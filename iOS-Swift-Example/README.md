# Try the Native Swift Example

### Get the code
```
git clone https://github.com/instana/iOSAgentExamples.git
cd iOSAgentExamples/iOS-Swift-Example
```

### Setup demo
Please enter the provided key and reporting URL in the proper setup method. You don't have a key yet? Just use a free  [Instana trial version](https://www.instana.com/trial/) and get a key & url.

You will find the setup in the `iOS-Swift-Example/iOSSensor-Development/AppDelegate.swift`

```
import InstanaAgent

@UIApplicationMain
class AppDelegate: UIResponder, UIApplicationDelegate {

    func application(_ application: UIApplication, didFinishLaunchingWithOptions launchOptions: [UIApplication.LaunchOptionsKey: Any]?) -> Bool {
        if !isRunningTests {
            Instana.setup(key: "<YOUR KEY>", reportingURL: URL(string: "<YOUR INSTANA URL>")!)
        }
        return true
    }
}
```

### Run 
To start the demo, just open the `iOSSensor-Development.xcodeproj` file and hit `Cmd+R`
