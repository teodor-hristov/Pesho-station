using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;


namespace Pesho_station
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;

            FixBrowserEmulation();

            bool designTime = LicenseManager.UsageMode == LicenseUsageMode.Designtime;
            if (!designTime)
            {
                mapBrowser.ScriptErrorsSuppressed = false;

                string docFile = Path.Combine(Application.StartupPath, "D:\\Git\\Pesho-station\\Pesho-station\\Pesho-station\\map.html");
                string documentText = File.ReadAllText(docFile);
                mapBrowser.DocumentText = documentText;
            }
        }

        // see: 
        // https://stackoverflow.com/questions/17922308/use-latest-version-of-internet-explorer-in-the-webbrowser-control
        // https://blog.malwarebytes.com/101/2016/01/a-brief-guide-to-feature_browser_emulation/
        private static void FixBrowserEmulation()
        {
            var appName = Process.GetCurrentProcess().ProcessName + ".exe";

            // 11000 (0x2AF8) - Internet Explorer 11. Webpages containing standards-based !DOCTYPE directives are displayed 
            // in IE11 edge mode. Default value for IE11.
            int? mode = 0x2AF8;

            
        }
    }
}

