# React Native Instana How-To

## Install
1. Add `Instana` to your `Podfile` like
```
pod 'Instana', :git => 'git@github.com:instana/iOSAgent', :branch => 'master'
```
2. Run `pod install`
3. Import Instana in your React Native iOS Project in the `ios/ReactnativeDemo/AppDelegate.m`
```
@import Instana;

@implementation AppDelegate

- (BOOL)application:(UIApplication *)application didFinishLaunchingWithOptions:(NSDictionary *)launchOptions {
  [Instana setupWithKey:@"<YOUR KEY>" reportingURL:[NSURL URLWithString:@"<YOUR INSTANA URL>"]];
  
   ...
}
```

