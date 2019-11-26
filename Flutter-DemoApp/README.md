# Flutter demo app

## Install
1. Add `Instana` to your `Podfile` like
```
pod 'Instana', :git => 'git@github.com:instana/iOSAgent', :branch => 'master'
```
2. Run `pod install`
3. Import Instana in your Flutter Project in the `ios/Runner/AppDelegate.swift`
```
import Instana
```
And make Instana the setup in your 
```
func application(_ application: UIApplication, didFinishLaunchingWithOptions launchOptions: [UIApplication.LaunchOptionsKey: Any]? {
	Instana.setup(key: "<YOUR KEY>", reportingURL: URL(string: "<YOUR INSTANA HOST>")!)
	...
}
```


After you run `pod install`
Add the following 
```
#include "Pods/Target Support Files/Pods-Runner/Pods-Runner.debug.xcconfig"
```
to ios/Flutter/Debug.xcconfig
and add
```
#include "Pods/Target Support Files/Pods-Runner/Pods-Runner.release.xcconfig"
#include "Pods/Target Support Files/Pods-Runner/Pods-Runner.profile.xcconfig"
```
to ios/Flutter/Release.xcconfig

Do a `pod install` again 
