using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Maps.Geocoding;
using Google.Maps.StaticMaps;
using Google.Maps;

namespace GoogleAPI
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var request = new GeocodingRequest();
            request.Address = textBox1.Text;
            request.Sensor = false;
            var response = new GeocodingService().GetResponse(request);
            var result = response.Results.First();

            label1.Text = "Full Address: " + result.FormattedAddress;

            var map = new StaticMapRequest();

            string selectedType = Convert.ToString(Google.Maps.MapTypes.Roadmap);

            if (rbSatellite.Checked)
            {
                selectedType = Convert.ToString(rbSatellite.Text);
            }
            if (rbRoadMap.Checked)
            {
                selectedType = Convert.ToString(rbRoadMap.Text);
            }
            if (rbHybrid.Checked)
            {
                selectedType = Convert.ToString(rbHybrid.Text);
            }

            lblLat.Text = Convert.ToString(result.Geometry.Location.Latitude);
            lblLong.Text = Convert.ToString(result.Geometry.Location.Longitude);

            string lat = lblLat.Text;
            string lng = lblLong.Text;

            map.Markers.Add(lat + "," + lng);


            Google.Maps.MapTypes valueType;

            Enum.TryParse(selectedType, out valueType);

            map.MapType = valueType;

            map.Center = new Location(textBox1.Text);
            map.Size = new System.Drawing.Size(webBrowser1.Width, webBrowser1.Height);
            map.Zoom = Convert.ToInt32(label2.Text);
            map.Sensor = false;

            //var latlng = new Google.Maps.LatLng(result.Geometry.Location.Latitude, result.Geometry.Location.Longitude);

            //var marker = new Google.Maps.MapMarkers(
            //    locations: latlng
            //);

            webBrowser1.Navigate(map.ToUri().ToString());
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "1")
            {

            }
            else
            {
                int currentZoom = Convert.ToInt32(label2.Text);
                int value = currentZoom - 1;

                label2.Text = Convert.ToString(value);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int currentZoom1 = Convert.ToInt32(label2.Text);
            int value = currentZoom1 + 1;

            label2.Text = Convert.ToString(value);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            var map = new StaticMapRequest();
            map.Center = new Location(textBox1.Text);
            map.Size = new System.Drawing.Size(webBrowser1.Width, webBrowser1.Height);
            map.Zoom = Convert.ToInt32(label2.Text);
            map.Sensor = false;

            webBrowser1.Navigate(map.ToUri().ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            try
            {
                var request = new GeocodingRequest();
                request.Address = txtPostcode.Text;
                request.Sensor = false;
                var response = new GeocodingService().GetResponse(request);

                var result = response.Results.First();

                lblHouseNo.Text = "" + txtHouseNo.Text;
                lblAddressLine1.Text = "" + result.AddressComponents[1].LongName;
                lblTown.Text = "" + result.AddressComponents[2].LongName;
                //lblCounty.Text = "" + result.AddressComponents[4].LongName;
                lblCity.Text = "" + result.AddressComponents[3].LongName;
                lblPostCode.Text = "" + result.AddressComponents[0].LongName;
                lblCountry.Text = "" + result.AddressComponents[5].LongName;

                

                lblLatitude.Text = Convert.ToString(result.Geometry.Location.Latitude);
                lblLongitude.Text = Convert.ToString(result.Geometry.Location.Longitude);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid postcode entered", "Please enter a valid postcode", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtHouseNo.Text = string.Empty;
                txtPostcode.Text = string.Empty;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var map = new StaticMapRequest();

            string selectedType = Convert.ToString(Google.Maps.MapTypes.Roadmap);

            if (rbSatellite.Checked)
            {
                selectedType = Convert.ToString(rbSatellite.Text);
            }
            if (rbRoadMap.Checked)
            {
                selectedType = Convert.ToString(rbRoadMap.Text);
            }
            if (rbHybrid.Checked)
            {
                selectedType = Convert.ToString(rbHybrid.Text);
            }


            Google.Maps.MapTypes valueType;

            Enum.TryParse(selectedType, out valueType);

            map.MapType = valueType;
            map.Center = new Location(lblPostCode.Text);
            map.Size = new System.Drawing.Size(webBrowser1.Width, webBrowser1.Height);
            map.Zoom = Convert.ToInt32(label2.Text);
            map.Sensor = false;

            //map.Markers.Add("52.6689153,-0.1692544");

            string latitude = lblLatitude.Text;
            string longitude = lblLongitude.Text;

            map.Markers.Add(latitude + "," + longitude);


            webBrowser1.Navigate(map.ToUri().ToString());
        }
    }
}
