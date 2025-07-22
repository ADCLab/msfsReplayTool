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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.Label();
            this.labelAltitude = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Font = new System.Drawing.Font("Rockwell", 9F);
            this.labelLongitude.Location = new System.Drawing.Point(220, 270);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(95, 20);
            this.labelLongitude.TabIndex = 0;
            this.labelLongitude.Text = "Longtitude";
            this.labelLongitude.Click += new System.EventHandler(this.Longitude_Click);
            // 
            // labelLatitude
            // 
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Font = new System.Drawing.Font("Rockwell", 9F);
            this.labelLatitude.Location = new System.Drawing.Point(598, 269);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(74, 20);
            this.labelLatitude.TabIndex = 1;
            this.labelLatitude.Text = "Latitude";
            this.labelLatitude.Click += new System.EventHandler(this.Latitude_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(584, 319);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // descriptionText
            // 
            this.descriptionText.AutoSize = true;
            this.descriptionText.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.descriptionText.Location = new System.Drawing.Point(94, 60);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(720, 24);
            this.descriptionText.TabIndex = 5;
            this.descriptionText.Text = "Please input longitude and latitude coordinates to your desired location.";
            this.descriptionText.Click += new System.EventHandler(this.descriptionText_Click);
            // 
            // labelAltitude
            // 
            this.labelAltitude.AutoSize = true;
            this.labelAltitude.Font = new System.Drawing.Font("Rockwell", 9F);
            this.labelAltitude.Location = new System.Drawing.Point(412, 270);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.Size = new System.Drawing.Size(73, 20);
            this.labelAltitude.TabIndex = 6;
            this.labelAltitude.Text = "Altitude";
            this.labelAltitude.Click += new System.EventHandler(this.labelAltitude_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(398, 319);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(393, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelAltitude);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label descriptionText;
        private System.Windows.Forms.Label labelAltitude;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}

