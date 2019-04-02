using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;


namespace Pesho_station
{
    public partial class Map : Form
    {
        private string docFile;
        public string[] GetParameters(string docFile,string text)
        {
            string[] lines = File.ReadAllLines(docFile);
            string coordsLine;
            string[] split = new string[4];
            bool firstFound = false;
            for (int index = 0; index < lines.Count(); index++)
            {
                if (!firstFound && lines[index].Contains(text))
                {
                    firstFound = true;
                }
                if (firstFound && lines[index].Contains(text))
                {
                    coordsLine =  lines[index];
                    split = coordsLine.Split(new char[] { '\'', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    return split;
                }
            }
            
            return split;
        }
        static public void ChangeDestinationPins(string filePath, string searchText, string replaceText)
        {
            StreamReader reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, searchText, replaceText);

            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(content);
            writer.Close();
        }
        public Map()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            FixBrowserEmulation();

            string waypoint0Lat = GetParameters(docFile, "waypoint0")[1];//dumata e waypoint0/1 zashtoto tova hvashta reda v koito e samata duma
            string waypoint0Long = GetParameters(docFile, "waypoint0")[2];
            string waypoint1Lat = GetParameters(docFile, "waypoint1")[1];
            string waypoint1Long = GetParameters(docFile, "waypoint1")[2];

            bool designTime = LicenseManager.UsageMode == LicenseUsageMode.Designtime;
            if (!designTime)
            {
                mapBrowser.ScriptErrorsSuppressed = false;

                docFile = Path.Combine(Application.StartupPath, "..\\..\\map.html");
                ChangeDestinationPins(docFile,waypoint0Lat, "43.13333");//zamestvate "43.13333" za novata tochka koqto iskate da slojite
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
        }
    }
}

