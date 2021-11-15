using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();

        public static string place = "Stratford, CA";

     


        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast()
        {
            string forcastUrl = "http://api.openweathermap.org/data/2.5/forecast/daily?q=" + place + "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";

            XmlReader reader = XmlReader.Create(forcastUrl);
            
            while (reader.Read())
            {
                //TODO: create a day object
                Day newDay = new Day();

                //TODO: fill day object with required data
                reader.ReadToFollowing("time");
                newDay.date = newDay.condition = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                newDay.condition = reader.GetAttribute("number");

                reader.ReadToFollowing("precipitation");
                newDay.precipitation = reader.GetAttribute("mode");

                reader.ReadToFollowing("windDirection");
                newDay.windDirection = reader.GetAttribute("name");

                reader.ReadToFollowing("windSpeed");
                newDay.windSpeed = reader.GetAttribute("value");

                reader.ReadToFollowing("temperature");
                newDay.currentTemp = Convert.ToDouble(reader.GetAttribute("value")).ToString("0");
                newDay.tempLow = Convert.ToDouble(reader.GetAttribute("min")).ToString("0");
                newDay.tempHigh = Convert.ToDouble(reader.GetAttribute("max")).ToString("0");

                //TODO: if day object not null add to the days list
                if (newDay.date != null)
                {
                    days.Add(newDay);
                }
            }
        }

        public static void ExtractCurrent()
        {
            string currentUrl = "http://api.openweathermap.org/data/2.5/weather?q=" + place + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create(currentUrl);

            ////TODO: find the city and current temperature and add to appropriate item in days list

            reader.ReadToFollowing("city");
            //days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = Convert.ToDouble(reader.GetAttribute("value")).ToString("0");

            reader.ReadToFollowing("clouds");
            days[0].condition = reader.GetAttribute("value");

        }
    }
}
