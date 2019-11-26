import UIKit
import Flutter
import Instana

@UIApplicationMain
@objc class AppDelegate: FlutterAppDelegate {
  override func application(
    _ application: UIApplication,
    didFinishLaunchingWithOptions launchOptions: [UIApplication.LaunchOptionsKey: Any]?
  ) -> Bool {
    GeneratedPluginRegistrant.register(with: self)
    Instana.setup(key: "<YOUR KEY>", reportingURL: URL(string: "<YOUR INSTANA URL>")!)

    return super.application(application, didFinishLaunchingWithOptions: launchOptions)
  }
}
