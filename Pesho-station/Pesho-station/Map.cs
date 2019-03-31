using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;


namespace Pesho_station
{
    public partial class Map : Form
    {
        public string GetParameters(string docFile,string text)
        {
            var lines = File.ReadAllLines(docFile);

            var firstFound = false;
            for (int index = 0; index < lines.Count(); index++)
            {
                if (!firstFound && lines[index].Contains(text))
                {
                    firstFound = true;
                }
                if (firstFound && lines[index].Contains(text))
                {
                    //do, what you want, and exit the loop
                    return lines[index];
                }
            }
            return "";
        }

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
                MessageBox.Show(GetParameters(docFile,"waypoint0"), GetParameters(docFile, "waypoint1"));
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

