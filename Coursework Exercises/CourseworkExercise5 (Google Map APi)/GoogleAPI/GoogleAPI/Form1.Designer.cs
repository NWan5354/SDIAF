namespace GoogleAPI
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRoadMap = new System.Windows.Forms.RadioButton();
            this.rbHybrid = new System.Windows.Forms.RadioButton();
            this.rbSatellite = new System.Windows.Forms.RadioButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHouseNo = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(187, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 28);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Find Postcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(225, 689);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zoom Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "15";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRoadMap);
            this.groupBox2.Controls.Add(this.rbHybrid);
            this.groupBox2.Controls.Add(this.rbSatellite);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 689);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 139);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pick a view";
            // 
            // rbRoadMap
            // 
            this.rbRoadMap.AutoSize = true;
            this.rbRoadMap.Location = new System.Drawing.Point(7, 96);
            this.rbRoadMap.Name = "rbRoadMap";
            this.rbRoadMap.Size = new System.Drawing.Size(113, 28);
            this.rbRoadMap.TabIndex = 2;
            this.rbRoadMap.TabStop = true;
            this.rbRoadMap.Text = "Roadmap";
            this.rbRoadMap.UseVisualStyleBackColor = true;
            // 
            // rbHybrid
            // 
            this.rbHybrid.AutoSize = true;
            this.rbHybrid.Location = new System.Drawing.Point(7, 62);
            this.rbHybrid.Name = "rbHybrid";
            this.rbHybrid.Size = new System.Drawing.Size(86, 28);
            this.rbHybrid.TabIndex = 1;
            this.rbHybrid.TabStop = true;
            this.rbHybrid.Text = "Hybrid";
            this.rbHybrid.UseVisualStyleBackColor = true;
            // 
            // rbSatellite
            // 
            this.rbSatellite.AutoSize = true;
            this.rbSatellite.Location = new System.Drawing.Point(7, 28);
            this.rbSatellite.Name = "rbSatellite";
            this.rbSatellite.Size = new System.Drawing.Size(95, 28);
            this.rbSatellite.TabIndex = 0;
            this.rbSatellite.TabStop = true;
            this.rbSatellite.Text = "Satellite";
            this.rbSatellite.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(609, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(905, 816);
            this.webBrowser1.TabIndex = 6;
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouseNo.Location = new System.Drawing.Point(127, 234);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(115, 28);
            this.txtHouseNo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "House No: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address Line 1: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address Line 2: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "City:";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1.Location = new System.Drawing.Point(183, 74);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(152, 24);
            this.lblAddressLine1.TabIndex = 12;
            this.lblAddressLine1.Text = "No Match Found";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(183, 107);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(152, 24);
            this.lblTown.TabIndex = 13;
            this.lblTown.Text = "No Match Found";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(183, 141);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(152, 24);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "No Match Found";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Postcode: ";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(127, 267);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(115, 28);
            this.txtPostcode.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "House No:";
            // 
            // lblHouseNo
            // 
            this.lblHouseNo.AutoSize = true;
            this.lblHouseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNo.Location = new System.Drawing.Point(183, 41);
            this.lblHouseNo.Name = "lblHouseNo";
            this.lblHouseNo.Size = new System.Drawing.Size(152, 24);
            this.lblHouseNo.TabIndex = 18;
            this.lblHouseNo.Text = "No Match Found";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(248, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 61);
            this.button4.TabIndex = 19;
            this.button4.Text = "Auto Complete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Postcode:";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCode.Location = new System.Drawing.Point(183, 175);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(152, 24);
            this.lblPostCode.TabIndex = 21;
            this.lblPostCode.Text = "No Match Found";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Country: ";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(183, 210);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(152, 24);
            this.lblCountry.TabIndex = 23;
            this.lblCountry.Text = "No Match Found";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "Enter Postcode: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(282, 39);
            this.label12.TabIndex = 25;
            this.label12.Text = "Google Maps APi";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 34);
            this.button5.TabIndex = 26;
            this.button5.Text = "Locate on Map";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblCountry);
            this.groupBox3.Controls.Add(this.lblAddressLine1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblTown);
            this.groupBox3.Controls.Add(this.lblPostCode);
            this.groupBox3.Controls.Add(this.lblCity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblHouseNo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 329);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delivery Form";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblLongitude);
            this.groupBox4.Controls.Add(this.lblLatitude);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(366, 341);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 199);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Latitude + Logitude";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(6, 141);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(158, 24);
            this.lblLongitude.TabIndex = 30;
            this.lblLongitude.Text = "No Data Available";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(6, 74);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(158, 24);
            this.lblLatitude.TabIndex = 29;
            this.lblLatitude.Text = "No Data Available";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 24);
            this.label14.TabIndex = 28;
            this.label14.Text = "Longitude:  ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 24);
            this.label13.TabIndex = 27;
            this.label13.Text = "Latitude: ";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(382, 70);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(87, 17);
            this.lblLat.TabIndex = 29;
            this.lblLat.Text = "lblLatHidden";
            this.lblLat.Visible = false;
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Location = new System.Drawing.Point(382, 101);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(99, 17);
            this.lblLong.TabIndex = 30;
            this.lblLong.Text = "lblLongHidden";
            this.lblLong.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 843);
            this.Controls.Add(this.lblLong);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHouseNo);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Google Map API";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbHybrid;
        private System.Windows.Forms.RadioButton rbSatellite;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RadioButton rbRoadMap;
        private System.Windows.Forms.TextBox txtHouseNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHouseNo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLong;
    }
}

