using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using GMap.NET;
using GMap.NET.MapProviders;
using System.Globalization;

namespace weather
{
    public partial class Weather : Form
    {
        bool defaultMap = true;
        bool fullscreen = false;
        bool firsttime = true;
        public Weather()
        {
            //making app start in fullscreen mode
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Use the appliaction by selecting the city from the list");
            comboBox1.SelectedIndex = 0;
            displayCurrentTemperature(comboBox1.SelectedItem.ToString());
            firsttime = false;
        }

        //declaring my API Key and URLs that are needed to access the XML file

        private const string CurrentUrl =
            "http://api.apixu.com/v1/current.xml?key=ea0d12f7007c45c7874100917171606&q=@LOC@";

        private void displayCurrentTemperature(string url)
        {
            try {
                using (WebClient client = new WebClient())
                {
                    //downloading XML file from the server
                    string xml = client.DownloadString(url);
                    XmlDocument xml_document = new XmlDocument();
                    xml_document.LoadXml(xml);
                    //extracting and displaying infromation from the XML file : 
                    XmlNode latNode = xml_document.SelectSingleNode("root/location/lat");
                    double lat = Convert.ToDouble(latNode.InnerText, CultureInfo.InvariantCulture);

                    XmlNode lonNode = xml_document.SelectSingleNode("root/location/lon");
                    double lon = Convert.ToDouble(lonNode.InnerText, CultureInfo.InvariantCulture);

                    XmlNode countryNode = xml_document.SelectSingleNode("root/location/country");
                    string country = countryNode.InnerText;
                    countryText.Text = country;

                    XmlNode localtimeNode = xml_document.SelectSingleNode("root/location/localtime");
                    string localtime = localtimeNode.InnerText;
                    localTimeText.Text = "Local time : " + localtime;

                    XmlNode cityNode = xml_document.SelectSingleNode("root/location/name");
                    string city = cityNode.InnerText;
                    cityName.Text = city;

                    XmlNode tempNode = xml_document.SelectSingleNode("root/current/temp_c");
                    string temperature = tempNode.InnerText;
                    tempLabel.Text = temperature + " °C";

                    XmlNode lastUpdate = xml_document.SelectSingleNode("root/current/last_updated");
                    string last = lastUpdate.InnerText;
                    updated.Text ="Updated at: " +  last;

                    XmlNode conditionNode = xml_document.SelectSingleNode("root/current/condition/text");
                    string condition = conditionNode.InnerText;
                    conditionText.Text = condition;

                    XmlNode iconnode = xml_document.SelectSingleNode("root/current/condition/icon");
                    string urlIcon = "http:" + iconnode.InnerText;
                    pictureBox1.Load(urlIcon);

                    XmlNode windSpeed = xml_document.SelectSingleNode("root/current/wind_kph");
                    string wind = windSpeed.InnerText;
                    speedText.Text = wind + "km/h";

                    XmlNode humidityNode = xml_document.SelectSingleNode("root/current/humidity");
                    string humidity = humidityNode.InnerText;
                    humidityText.Text = humidity + " %";

                    XmlNode pressureNode = xml_document.SelectSingleNode("root/current/pressure_mb");
                    string pressure = pressureNode.InnerText;
                    pressureText.Text = pressure + " MBa";

                    //displaying map
                    if (defaultMap)
                    {
                        gMapControl1.MapProvider = GMapProviders.GoogleMap;
                        comboBox2.SelectedIndex = 0;
                    }
                    gMapControl1.DragButton = MouseButtons.Left;
                    gMapControl1.CanDragMap = true;
                    gMapControl1.Position = new PointLatLng(lat, lon);
                    gMapControl1.MinZoom = 0;
                    gMapControl1.MaxZoom = 25;
                    gMapControl1.Zoom = 12;
                    gMapControl1.AutoScroll = true;
                }
            }
            catch
            {
                if (firsttime)
                    MessageBox.Show("Welcome");
                else
                    MessageBox.Show("Could not find info on this city");
            }
       }


       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //calls the method to display the temperature and map
                string url = CurrentUrl.Replace("@LOC@", comboBox1.SelectedItem.ToString());
                displayCurrentTemperature(url);
           
         }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                MessageBox.Show("Invalid City");
            else
            {
                comboBox1.Items.Add(textBox1.Text);
                MessageBox.Show("The city has been added to the list");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            defaultMap = false;
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Google Maps":
                    gMapControl1.MapProvider = GMapProviders.GoogleMap;
                    break;
                case "Bing Maps":
                    gMapControl1.MapProvider = GMapProviders.BingMap;
                    break;
                case "Yandex Maps":
                    gMapControl1.MapProvider = GMapProviders.YandexMap;
                    break;
                case "Yandex Satellite":
                    gMapControl1.MapProvider = GMapProviders.YandexSatelliteMap;
                    break;
                case "Bing Satellite":
                    gMapControl1.MapProvider = GMapProviders.BingSatelliteMap;
                    break;
                case "Google Satellite":
                    gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
                    break;
                default:
                    gMapControl1.MapProvider = GMapProviders.GoogleMap;
                    break;
            }
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            //managing map fullscreen mode
            if (fullscreen == false)
            {
                button2.Hide();
                button3.BackgroundImage = Properties.Resources.minimize;
                groupBox1.Hide();
                gMapControl1.Width = 1370;
                gMapControl1.Height = 780;
                gMapControl1.Location = new Point(0, 0);
                button3.Location = new Point(0,0);
                
                fullscreen = true;
            }
            else
            {
                button2.Show();
                button3.BackgroundImage = Properties.Resources.full_screen_icon_png_0;
                groupBox1.Show();
                gMapControl1.Width = 645;
                gMapControl1.Height =731;
                gMapControl1.Location = new Point(713, -2);
                button3.Location = new Point(793, 0);

                fullscreen = false; 
            }
            
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            //managing map visibility
            if (button3.Visible)
            {
                button3.Hide();
            }
            else
            {
                button3.Show();
            }
            if (gMapControl1.Visible == false)
            {
                button2.Text = "HIDE";
                gMapControl1.Show();
            }
            else
            {
                button2.Text="SHOW";
                gMapControl1.Hide();
            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
    }
    }


