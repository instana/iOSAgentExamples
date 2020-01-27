#!/bin/bash
set -e
# Any subsequent(*) commands which fail will cause the shell script to exit immediately
FAT_BUILD_PATH="build"
FRAMEWORK_NAME="InstanaAgent"
FRAMEWORK_SRC=${FRAMEWORK_NAME}-src
FRAMEWORKS=(${FRAMEWORK_NAME} "Gzip" "system_zlib")
# Remove old stuff first
rm -rf ${FRAMEWORK_NAME}-src
rm -rf ${FAT_BUILD_PATH}

echo "Clone iOS Agent"
git clone https://github.com/instana/iOSAgent ${FRAMEWORK_SRC}
cd ${FRAMEWORK_SRC}

### Check versions
if [ -z "$1" ]
then
    LATEST_TAG=$(git describe --tags)
else
    LATEST_TAG=$1
fi
echo "Use latest tag ${LATEST_TAG}"
git checkout ${LATEST_TAG}

echo "Building package now"

swift package generate-xcodeproj

############### build fat framework #######################

# Step 1. Build Device and Simulator versions
echo "Build iphoneos"
xcodebuild -project ${FRAMEWORK_NAME}.xcodeproj -scheme ${FRAMEWORK_NAME}-Package -configuration Release -sdk iphoneos CONFIGURATION_BUILD_DIR=build/iphoneos clean build ENABLE_BITCODE=NO
echo "Build simulator"
xcodebuild -project ${FRAMEWORK_NAME}.xcodeproj -scheme ${FRAMEWORK_NAME}-Package -configuration Release -sdk iphonesimulator CONFIGURATION_BUILD_DIR=build/simulator clean build ENABLE_BITCODE=NO

echo "Generating all fat frameworks now"
cd ..
mkdir ${FAT_BUILD_PATH}
for name in "${FRAMEWORKS[@]}"
do
 	echo "Generate fat framework for ${name}"
	# Step 2. Copy the framework structure (from iphoneos build) to the universal folder
	cp -R "${FRAMEWORK_SRC}/build/iphoneos/${name}.framework" ${FAT_BUILD_PATH}

	# Step 3. Copy Swift modules from iphonesimulator build (if it exists) to the copied framework directory
	SIMULATOR_SWIFT_MODULES_DIR="${FRAMEWORK_SRC}/build/simulator/${name}.framework/Modules/${name}.swiftmodule/"
	if [ -d "${SIMULATOR_SWIFT_MODULES_DIR}" ]; then
    		cp -R "${SIMULATOR_SWIFT_MODULES_DIR}" "${FAT_BUILD_PATH}/${name}.framework/Modules/${name}.swiftmodule"
	fi

	# Step 4. Create universal binary file using lipo and place the combined executable in the copied framework directory
	lipo -create -output "${FAT_BUILD_PATH}/${name}.framework/${name}" "${FRAMEWORK_SRC}/build/simulator/${name}.framework/${name}" "${FRAMEWORK_SRC}/build/iphoneos/${name}.framework/${name}"
done
echo "Done with fat framework"

############### End building fat framework #######################

SDK=`sharpie xcode -sdks | grep -o '\.*iphoneos\S*'`
sharpie bind -sdk ${SDK} ${FAT_BUILD_PATH}/${FRAMEWORK_NAME}.framework/Headers/${FRAMEWORK_NAME}-Swift.h
mv ApiDefinitions.cs InstanaXamarinBinding/ApiDefinitions.cs
mv StructsAndEnums.cs InstanaXamarinBinding/Structs.cs

echo "Completed"
