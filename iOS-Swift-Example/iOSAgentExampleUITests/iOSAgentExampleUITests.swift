//
//  iOSAgentExampleUITests.swift
//  iOSAgentExampleUITests
//
//  Created by Christian Menschel on 28.01.20.
//  Copyright © 2020 Instana Inc. All rights reserved.
//

import XCTest

class iOSAgentExampleUITests: XCTestCase {

    var app: XCUIApplication!

    override func setUp() {
        continueAfterFailure = false

        app = XCUIApplication()
        app.launch()
   }

    override func tearDown() {
        app = nil
    }

    func test_Launch_and_enter_url() {
        app.tabBars.buttons["JSON"].tap()
        let urlTextField = app.textFields["URL"]
        urlTextField.tap()
        urlTextField.typeText("https://api.mygigs.tapwork.de")
        app.buttons["     GO     "].tap()

        let expected = app.textViews.staticTexts["{\"message\":\"api.mygigs.tapwork.de\"}"]
        verify(expected)
    }
}

func verify(_ element: XCUIElement, file: StaticString = #file, line: UInt = #line) {
    if !element.waitForExistence(timeout: 5) {
        XCTFail("Could not find element \(element)", file: file, line: line)
    }
}
