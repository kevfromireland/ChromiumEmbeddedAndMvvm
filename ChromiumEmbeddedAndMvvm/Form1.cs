using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using ChromiumEmbeddedAndMvvm.Models;

namespace ChromiumEmbeddedAndMvvm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var webView = new WebView(Path.Combine(GetViewDirectory(), "MainPage.html"), new BrowserSettings())
            {
                Dock = DockStyle.Fill
            };

            webView.RegisterJsObject("AppServices", new AppModelAndServices());

            Controls.Add(webView);
        }

        private string GetViewDirectory()
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase), "View");
        }
    }


}
