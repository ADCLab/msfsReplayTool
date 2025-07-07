using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.FlightSimulator.SimConnect; // msfs yess
using System.Runtime.InteropServices; // for SimConnect API

namespace msfsReplayTool
{
    

    public partial class Form1 : Form
    {

        SimConnect simconnect = null;
        const int WM_USER_SIMCONNECT = 0x0402; // windows message for SimConnect

       /* This is an actual struct from the api, but just to keep things simple
        * im going to create my own just to get lat, lon, and alt.
        struct SIMCONNECT_DATA_INITPOSITION
        {
            public double latitude; // Degrees
            public double longitude; // Degrees
            public double altitude; // Feet
            public double pitch; // Degrees
            public double bank; // Degrees
            public double heading; // Degrees
            public float airspeed; // Knots
            public float verticalSpeed; // Feet per minute
        }
       */

        struct aircraftPosition
        {
            public double latitude; // degrees
            public double longitude; // degrees
            public double altitude; // feet
        }
        public Form1()
        {
            InitializeComponent();

            try
            {
                simconnect = new SimConnect("connection", this.Handle, WM_USER_SIMCONNECT, null, 0); // establish connection to MSFS
            }
            catch (COMException ex)
            {
                MessageBox.Show("SimConnect connection failed: " + ex.Message, "there's been an error");
            }
        }

        private void Longitude_Click(object sender, EventArgs e)
        {

        }

        private void Latitude_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // convert input from textboxes to doubles 
                double lat = double.Parse(labelLatitude.Text);
                double lon = double.Parse(labelLongitude.Text);
                double alt = 1500.0; // default altitude for now

                // initialize aircraftPosition struct and give values
                aircraftPosition position;
                position.latitude = lat;
                position.longitude = lon;
                position.altitude = alt;

                // AddToDataDefinition doesn't accept integer values
                // this doesnt work fix tomorrow
                Enum DefineID
                {
                    aircraftPosition = 0
                }

                // basically interprets data from the struct and sends it to MSFS
                simconnect.AddToDataDefinition(DefineID.aircraftPosition, "PLANE LATITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DefineID.aircraftPosition, "PLANE LONGITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DefineID.aircraftPosition, "PLANE ALTITUDE", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.RegisterDataDefineStruct<aircraftPosition>(DefineID.aircraftPosition); // register the struct with SimConnect

                simconnect.SetDataOnSimObject(DefineID.aircraftPosition, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_DATA_SET_FLAG.DEFAULT, position); // send the data to MSFS

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    
}
