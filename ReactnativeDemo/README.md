# Try the ReactNative Example
If you are new to ReactNative, you should go to this [article](https://facebook.github.io/react-native/docs/getting-started) and read the *React Native CLI Quickstart*.

### Get the code
```
git clone https://github.com/instana/iOSAgentExamples.git
cd iOSAgentExamples/ReactnativeDemo
npm install
```

### Setup demo
Please enter the provided key and reporting URL in the proper setup method. You don't have a key yet? Just use a free  [Instana trial version](https://www.instana.com/trial/) and get a key & url.

#### iOS
Instana is installed via `CocoaPods`
Just run pod install via 
```
cd ios
pod install
cd ..
```

You will find the setup in the `ReactnativeDemo/ios/ReactnativeDemo/AppDelegate.m`

```
@import InstanaAgent;

@implementation AppDelegate

- (BOOL)application:(UIApplication *)application didFinishLaunchingWithOptions:(NSDictionary *)launchOptions
{
  [Instana setupWithKey:@"<Your Key>" reportingURL:[NSURL URLWithString:@"<YOUR INSTANA URL>"]];
}
```

#### Android
.....

### Start demo
#### iOS
```
npx react-native run-ios
```
#### Android
```
npx react-native run-android
```

