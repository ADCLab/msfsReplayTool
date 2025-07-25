﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.FlightSimulator.SimConnect; // msfs yess
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates; // for SimConnect API

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

        // AddToDataDefinition method takes in enum as parameter, defined here
        // enums start with zero and increase by one, so directly declaring Var as 0 isn't necessary
        // 0 is the ID for user plane in msfs
       
        enum DefineID
        {
            Var
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
                MessageBox.Show("SimConnect connection failed: " + ex.Message, "there's been an error"); // make sure msfs is running before starting as this can appear as a result.
            }
        }

        private void descriptionText_Click(object sender, EventArgs e)
        {

        }

        private void Longitude_Click(object sender, EventArgs e)
        {

        }

        private void Latitude_Click(object sender, EventArgs e)
        {

        }

        private void labelAltitude_Click(object sender, EventArgs e)
        {

        }



        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            
            try
            {
                // convert input from textboxes to doubles 
                // consider using switch-cases for cleanup?
               
                double lat = double.Parse(textBox1.Text);
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please enter a valid latitude.");
                }

                double lon = double.Parse(textBox2.Text);
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Please enter a valid longitude.");
                }

                double alt = double.Parse(textBox3.Text);

                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    alt = 1500; // Default altitude is 1500
                }

                // initialize aircraftPosition struct and give values
                aircraftPosition position;
                position.latitude = lat;
                position.longitude = lon;
                position.altitude = alt;

                

                // basically interprets data from the struct and sends it to MSFS
                simconnect.AddToDataDefinition(DefineID.Var, "PLANE LATITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DefineID.Var, "PLANE LONGITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DefineID.Var, "PLANE ALTITUDE", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.RegisterDataDefineStruct<aircraftPosition>(DefineID.Var); // register the struct with SimConnect

                simconnect.SetDataOnSimObject(DefineID.Var, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_DATA_SET_FLAG.DEFAULT, position); // send the data to MSFS

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }

    
}
