import UIKit
import WebKit
import InstanaAgent
import Combine

class WebViewController: UIViewController {

    lazy var webView: WKWebView = {
        let conf = WKWebViewConfiguration()
        let webview = WKWebView(frame: .zero, configuration: conf)
        return webview
    }()

    override func loadView() {
        view = webView
        webView.load(URLRequest(url: URL(string: "https://www.instana.com")!))
        loadSimpleRequest()
    }

    override func viewDidAppear(_ animated: Bool) {
        super.viewDidAppear(animated)
        if !isRunningTests {
            Instana.setView(name: "WebView: Instana.com")
        }
    }

    func loadSimpleRequest() {
        let conf = URLSessionConfiguration.default
        conf.protocolClasses?.insert(CustomProtocol.self, at: 0)
        let session = URLSession(configuration: conf)
        session.dataTask(with: URL(string: "https://www.spiegel.de")!) { (_, _, _ ) in
        }.resume()
    }
}
