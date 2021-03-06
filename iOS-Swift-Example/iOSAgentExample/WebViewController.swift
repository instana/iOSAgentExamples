//
//  WebViewController.swift
//  iOSAgentExample
//
//  Created by Christian Menschel on 10.12.19.
//  Copyright © 2019 Instana Inc. All rights reserved.
//

import UIKit
import WebKit
import InstanaAgent

class WebViewController: UIViewController {

    @IBOutlet var searchTextField: UITextField!
    @IBOutlet var webView: WKWebView!

    override func viewDidLoad() {
        super.viewDidLoad()
        webView.navigationDelegate = self
        load(url: URL(string: "https://www.instana.com")!)
    }

    func load(url: URL) {
        webView.load(URLRequest(url: url))
        searchTextField.resignFirstResponder()
    }

    override func viewDidAppear(_ animated: Bool) {
        super.viewDidAppear(animated)
        Instana.setView(name: "WebView")
    }

    @IBAction func enteredURL() {
        guard let value = searchTextField.text, let url = URL(string: value) else { return }
        load(url: url)
        Instana.reportEvent(name: "WebView Load", meta: ["URL": url.absoluteString], viewName: "WebView")
    }
}

extension WebViewController: WKNavigationDelegate {
    func webView(_ webView: WKWebView, didCommit navigation: WKNavigation!) {
        searchTextField.text = webView.url?.absoluteString
    }
}

extension WebViewController: UITextFieldDelegate {
    func textFieldShouldReturn(_ textField: UITextField) -> Bool {
        guard let value = textField.text else { return true }
        load(url: URL(string: value)!)
        return true
    }
}
