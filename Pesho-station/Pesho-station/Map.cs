using System;
using System.ComponentModel;
using System.Device.Location;
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
        ChangeParametersInMap change = new ChangeParametersInMap();
        private string waypoint0Lat, waypoint0Long, waypoint1Lat, waypoint1Long;
        private string docFile = Path.Combine(Application.StartupPath, "..\\..\\map.html");
        public string[] GetParameters(string docFile, string text)
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
                    coordsLine = lines[index];
                    split = coordsLine.Split(new char[] { '\'', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    return split;
                }
            }

            return split;
        }

        public Map()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
          //  string dropOffPosition = "Pernik";
           // change.ChangeDestinationPins(docFile, "ADDRESS_KEYWORD", dropOffPosition);
            

            waypoint0Lat = GetParameters(docFile, "waypoint0")[1];
            waypoint0Long = GetParameters(docFile, "waypoint0")[2];
           // waypoint1Lat = GetParameters(docFile, "waypoint1")[1];
            //waypoint1Long = GetParameters(docFile, "waypoint1")[2];

            bool designTime = LicenseManager.UsageMode == LicenseUsageMode.Designtime;
            if (!designTime)
            {
                mapBrowser.ScriptErrorsSuppressed = false;
                string documentText = File.ReadAllText(docFile);
                mapBrowser.DocumentText = documentText;
            }
            FixBrowserEmulation();
            //change.ChangeDestinationPins(docFile, dropOffPosition, "ADDRESS_KEYWORD");
        }

        private static void FixBrowserEmulation()
        {
            var appName = Process.GetCurrentProcess().ProcessName + ".exe";
        }

        private void mapBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();//starting watcher 
            watcher.PositionChanged += watcher_PositionChanged;
            watcher.Start();
        }
        private void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            if (Double.Parse(waypoint0Lat) != e.Position.Location.Latitude 
                ||
                Double.Parse(waypoint0Long) != e.Position.Location.Longitude)
            {
                //coordinates of person's location
                change.ChangeDestinationPins(docFile, waypoint0Lat, e.Position.Location.Latitude.ToString());
                change.ChangeDestinationPins(docFile, waypoint0Long, e.Position.Location.Longitude.ToString());
                
            }    

        }
    }
}

