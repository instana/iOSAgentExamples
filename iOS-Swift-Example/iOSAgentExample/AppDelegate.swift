//
//  AppDelegate.swift
//  iOSAgentExample
//
//  Created by Christian Menschel on 22.11.19.
//  Copyright © 2019 Instana Inc. All rights reserved.
//

import UIKit
import InstanaAgent

@UIApplicationMain
class AppDelegate: UIResponder, UIApplicationDelegate {

    func application(_ application: UIApplication, didFinishLaunchingWithOptions launchOptions: [UIApplication.LaunchOptionsKey: Any]?) -> Bool {
        if !isRunningTests {
            Instana.setup(key: InstanaKey, reportingURL: InstanaURL)
        }
        return true
    }

    // MARK: UISceneSession Lifecycle

    func application(_ application: UIApplication, configurationForConnecting connectingSceneSession: UISceneSession, options: UIScene.ConnectionOptions) -> UISceneConfiguration {
        // Called when a new scene session is being created.
        // Use this method to select a configuration to create the new scene with.
        return UISceneConfiguration(name: "Default Configuration", sessionRole: connectingSceneSession.role)
    }

    func application(_ application: UIApplication, didDiscardSceneSessions sceneSessions: Set<UISceneSession>) {
        // Called when the user discards a scene session.
        // If any sessions were discarded while the application was not running, this will be called shortly after application:didFinishLaunchingWithOptions.
        // Use this method to release any resources that were specific to the discarded scenes, as they will not return.
    }
}

var isRunningTests: Bool {
    return ProcessInfo.processInfo.environment["XCTestConfigurationFilePath"] != nil
}

var isRunningUITests: Bool {
    return ProcessInfo.processInfo.environment["UITestsActive"] == "true"
}

var InstanaKey: String {
    /// Will be added via a hidden (git ignored) environment variables - see build phase "Load Environment vars into info.plist"
    /// Make sure to have the .env-vars in your local Dev folder and ignore it in git
    /// Containing the two values like
    /// export INSTANA_REPORTING_URL=https://<YOUR URL>
    /// export INSTANA_REPORTING_KEY=<YOUR KEY>
    return Bundle.main.infoDictionary?["INSTANA_REPORTING_KEY"] as? String ?? ""
}

var InstanaURL: URL {
    let value = Bundle.main.infoDictionary?["INSTANA_REPORTING_URL"] as? String ?? ""
    return URL(string: value)!
}
