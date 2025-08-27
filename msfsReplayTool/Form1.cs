using Microsoft.FlightSimulator.SimConnect; // msfs 
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msfsReplayTool
{
    
    public partial class Form1 : Form
    {

        SimConnect simconnect = null;
        const int WM_USER_SIMCONNECT = 0x0402; // windows message for SimConnect

        // struct for AI Objects 
        struct SIMCONNECT_DATA_INITPOSITION
        {
            public double latitude; // Degrees
            public double longitude; // Degrees
            public double altitude; // Feet , default is 1500
            public double pitch; // Degrees
            public double bank; // Degrees
            public double heading; // Degrees
            public uint onGround; // 1 to place obj on ground, 0 if obj is airborn
            public uint airSpeed; // knots, or -1 for aircraft's design cruising speed, -2 to maintain current airspeed
           
        }
        
        // struct for user aircraft
        struct aircraftPosition
        {
            public double latitude; // degrees
            public double longitude; // degrees
            public double altitude; // feet
        }
        
        // AddToDataDefinition method takes in enum as parameter, defined here
        enum DefineID
        {
            userPlane, // id 0 
            pittsAsobo, // id 1
        }

        public Form1()
        {
            InitializeComponent();

            try
            {
                simconnect = new SimConnect("connection", this.Handle, WM_USER_SIMCONNECT, null, 0); // establish connection to MSFS

                if (simconnect != null)
                {
                    Console.WriteLine("SimConnect connection established");

                    // Defines data from struct
                    simconnect.AddToDataDefinition(DefineID.userPlane, "PLANE LATITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DefineID.userPlane, "PLANE LONGITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DefineID.userPlane, "PLANE ALTITUDE", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                    // Registers Data Definition based on specified struct
                    simconnect.RegisterDataDefineStruct<aircraftPosition>(DefineID.userPlane);


                }
            }
            catch (COMException ex)
            {
                MessageBox.Show("SimConnect connection failed: " + ex.Message); // make sure msfs is running before starting as this can appear as a result.
            }
        }

        private void labelLongitude_Click(object sender, EventArgs e)
        {

        }

        private void labelLatitude_Click(object sender, EventArgs e)
        {

        }

        private void labelAltitude_Click(object sender, EventArgs e)
        {

        }

        private void labelSpawnAircraft_Click(object sender, EventArgs e)
        {

        }

        private void longitudeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void latitudeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void altitudeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aircraftComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            
            try
            {
                // convert input from strings to doubles 
                // Long, Lat, Alt
                double lat = double.Parse(latitudeTextBox.Text);
                

                double lon = double.Parse(longitudeTextBox.Text);

                double alt = double.Parse(altitudeTextBox.Text);
                

                // Plane type
                string selectedAircraft = aircraftComboBox.SelectedItem.ToString();
                Console.WriteLine(selectedAircraft); // for debugging

                aircraftPosition position;
                position.latitude = lat;
                position.longitude = lon;
                position.altitude = alt;
             
                

                // Sends data to msfs based on data interpreted and registered from "AddDataToDefinition" and "RegisterDataDefineStruct"
                simconnect.SetDataOnSimObject(DefineID.userPlane, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_DATA_SET_FLAG.DEFAULT, position); 

                Console.WriteLine("Button clicked");

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                if (simconnect != null)
                    simconnect.ReceiveMessage();
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }  
        
    }
    
}
