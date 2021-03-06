//
//  JSONViewController.swift
//  iOSAgentExample
//
//  Created by Christian Menschel on 08.01.20.
//  Copyright © 2020 Instana Inc. All rights reserved.
//

import UIKit
import Combine
import InstanaAgent

class JSONViewController: UIViewController {

    @IBOutlet var searchTextField: UITextField!
    @IBOutlet var textView: UITextView!
    private var publisher: AnyCancellable?
    lazy var session = { URLSession(configuration: URLSessionConfiguration.default) }()

    override func viewDidAppear(_ animated: Bool) {
        super.viewDidAppear(animated)
        Instana.setView(name: "JSONView")
    }

    @IBAction func loadJSON() {
        searchTextField.resignFirstResponder()
        guard let url = URL(string: searchTextField.text ?? "") else {
            showAlert(message: "URL is invalid")
            return
        }
        publisher = session.dataTaskPublisher(for: url)
            .receive(on: RunLoop.main)
            .map { String(data: $0.data, encoding: .ascii) }
            .sink(receiveCompletion: { complete in
                if let errorMessage = complete.localizedError {
                    self.showAlert(message: errorMessage)
                }
            }, receiveValue: {[weak self] result in
                self?.textView.text = result
            })
    }

    func showAlert(message: String) {
        let alert = UIAlertController(title: "Error", message: message, preferredStyle: .alert)
        alert.addAction(UIAlertAction(title: "OK", style: .cancel, handler: nil))
        present(alert, animated: true, completion: nil)
        let error = NSError(domain: "JSONErrorDomain", code: -1, userInfo: nil)
        Instana.reportEvent(name: "JSON URL invalid",
                            timestamp: Date().millisecondsSince1970,
                            duration: 12,
                            backendTracingID: "MockBackendTraceID",
                            error: error,
                            meta: ["message": message],
                            viewName: "JSONView")
    }
}

extension JSONViewController: UITextFieldDelegate {
    func textFieldShouldReturn(_ textField: UITextField) -> Bool {
        loadJSON()
        return true
    }
}

extension Subscribers.Completion {
    var error: Error? {
        switch self {
        case .failure(let error):
            return error
        default:
            return nil
        }
    }

    var localizedError: String? {
        error?.localizedDescription
    }

    var hasError: Bool { error != nil }
}
