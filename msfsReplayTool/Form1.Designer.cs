using System.Drawing;

namespace msfsReplayTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelLongitude = new System.Windows.Forms.Label();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.labelAltitude = new System.Windows.Forms.Label();
            this.altitudeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSpawnAircraft = new System.Windows.Forms.Label();
            this.aircraftComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Font = new System.Drawing.Font("Rockwell", 9F);
            this.labelLongitude.Location = new System.Drawing.Point(35, 119);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(95, 20);
            this.labelLongitude.TabIndex = 0;
            this.labelLongitude.Text = "Longtitude";
            this.labelLongitude.Click += new System.EventHandler(this.labelLongitude_Click);
            // 
            // labelLatitude
            // 
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Font = new System.Drawing.Font("Rockwell", 9F);
            this.labelLatitude.Location = new System.Drawing.Point(45, 232);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(74, 20);
            this.labelLatitude.TabIndex = 1;
            this.labelLatitude.Text = "Latitude";
            this.labelLatitude.Click += new System.EventHandler(this.labelLatitude_Click);
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.Location = new System.Drawing.Point(164, 116);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(100, 26);
            this.longitudeTextBox.TabIndex = 2;
            this.longitudeTextBox.TextChanged += new System.EventHandler(this.longitudeTextBox_TextChanged);
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.Location = new System.Drawing.Point(164, 229);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(100, 26);
            this.latitudeTextBox.TabIndex = 3;
            this.latitudeTextBox.TextChanged += new System.EventHandler(this.latitudeTextBox_TextChanged);
            // 
            // labelAltitude
            // 
            this.labelAltitude.AutoSize = true;
            this.labelAltitude.Font = new System.Drawing.Font("Rockwell", 9F);
            this.labelAltitude.Location = new System.Drawing.Point(46, 173);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.Size = new System.Drawing.Size(73, 20);
            this.labelAltitude.TabIndex = 6;
            this.labelAltitude.Text = "Altitude";
            this.labelAltitude.Click += new System.EventHandler(this.labelAltitude_Click);
            // 
            // altitudeTextBox
            // 
            this.altitudeTextBox.Location = new System.Drawing.Point(164, 173);
            this.altitudeTextBox.Name = "altitudeTextBox";
            this.altitudeTextBox.Size = new System.Drawing.Size(100, 26);
            this.altitudeTextBox.TabIndex = 7;
            this.altitudeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.altitudeTextBox.TextChanged += new System.EventHandler(this.altitudeTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(97, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelSpawnAircraft
            // 
            this.labelSpawnAircraft.AutoSize = true;
            this.labelSpawnAircraft.Location = new System.Drawing.Point(561, 41);
            this.labelSpawnAircraft.Name = "labelSpawnAircraft";
            this.labelSpawnAircraft.Size = new System.Drawing.Size(113, 20);
            this.labelSpawnAircraft.TabIndex = 8;
            this.labelSpawnAircraft.Text = "Spawn Aircraft";
            this.labelSpawnAircraft.Click += new System.EventHandler(this.labelSpawnAircraft_Click);
            // 
            // aircraftComboBox
            // 
            this.aircraftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aircraftComboBox.FormattingEnabled = true;
            this.aircraftComboBox.Items.AddRange(new object[] {
            "AIRBUS A320 NEO ASOBO",
            "VL3 AVIATORS CLUB LIVERY",
            "PITTS ASOBO"});
            this.aircraftComboBox.Location = new System.Drawing.Point(553, 87);
            this.aircraftComboBox.Name = "aircraftComboBox";
            this.aircraftComboBox.Size = new System.Drawing.Size(121, 28);
            this.aircraftComboBox.TabIndex = 9;
            this.aircraftComboBox.SelectedIndexChanged += new System.EventHandler(this.aircraftComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.Controls.Add(this.aircraftComboBox);
            this.Controls.Add(this.labelSpawnAircraft);
            this.Controls.Add(this.altitudeTextBox);
            this.Controls.Add(this.labelAltitude);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.latitudeTextBox);
            this.Controls.Add(this.longitudeTextBox);
            this.Controls.Add(this.labelLatitude);
            this.Controls.Add(this.labelLongitude);
            this.Name = "Form1";
            this.Text = "Microsoft Flight Simulator Replay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.Label labelAltitude;
        private System.Windows.Forms.TextBox altitudeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelSpawnAircraft;
        private System.Windows.Forms.ComboBox aircraftComboBox;
    }
}

