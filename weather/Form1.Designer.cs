namespace weather
{
    partial class Weather
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cityName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.humidityText = new System.Windows.Forms.Label();
            this.speedText = new System.Windows.Forms.Label();
            this.conditionText = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.countryText = new System.Windows.Forms.Label();
            this.updated = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pressureText = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.localTimeText = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tbilisi",
            "Zugdidi",
            "New York",
            "Gori",
            "London",
            "Paris",
            "Berlin",
            "Moscow",
            "Sarpi",
            "Warsaw",
            "Bucharest",
            "Minsk",
            "Budapest",
            "Kiev",
            "Beijing",
            "Tokyo",
            "Aspindza",
            "Ottawa",
            "Sofia",
            "Monaco",
            "Sydney",
            "Bern",
            "Madrid",
            "Lissabon",
            "Dhaka"});
            this.comboBox1.Location = new System.Drawing.Point(8, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 26);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose a City";
            // 
            // cityName
            // 
            this.cityName.AutoSize = true;
            this.cityName.BackColor = System.Drawing.Color.Transparent;
            this.cityName.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityName.ForeColor = System.Drawing.Color.SandyBrown;
            this.cityName.Location = new System.Drawing.Point(74, 212);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(93, 40);
            this.cityName.TabIndex = 10;
            this.cityName.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(77, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Weather Condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(77, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wind Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(77, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Humidity";
            // 
            // humidityText
            // 
            this.humidityText.AutoSize = true;
            this.humidityText.BackColor = System.Drawing.Color.Transparent;
            this.humidityText.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityText.ForeColor = System.Drawing.Color.Lime;
            this.humidityText.Location = new System.Drawing.Point(330, 591);
            this.humidityText.Name = "humidityText";
            this.humidityText.Size = new System.Drawing.Size(0, 28);
            this.humidityText.TabIndex = 16;
            // 
            // speedText
            // 
            this.speedText.AutoSize = true;
            this.speedText.BackColor = System.Drawing.Color.Transparent;
            this.speedText.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedText.ForeColor = System.Drawing.Color.Lime;
            this.speedText.Location = new System.Drawing.Point(330, 551);
            this.speedText.Name = "speedText";
            this.speedText.Size = new System.Drawing.Size(0, 28);
            this.speedText.TabIndex = 15;
            // 
            // conditionText
            // 
            this.conditionText.AutoSize = true;
            this.conditionText.BackColor = System.Drawing.Color.Transparent;
            this.conditionText.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionText.ForeColor = System.Drawing.Color.Lime;
            this.conditionText.Location = new System.Drawing.Point(330, 511);
            this.conditionText.Name = "conditionText";
            this.conditionText.Size = new System.Drawing.Size(0, 28);
            this.conditionText.TabIndex = 14;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tempLabel.Location = new System.Drawing.Point(519, 235);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(0, 32);
            this.tempLabel.TabIndex = 17;
            // 
            // countryText
            // 
            this.countryText.AutoSize = true;
            this.countryText.BackColor = System.Drawing.Color.Transparent;
            this.countryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryText.ForeColor = System.Drawing.Color.SandyBrown;
            this.countryText.Location = new System.Drawing.Point(56, 264);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(80, 22);
            this.countryText.TabIndex = 18;
            this.countryText.Text = "Country";
            // 
            // updated
            // 
            this.updated.AutoSize = true;
            this.updated.BackColor = System.Drawing.Color.Transparent;
            this.updated.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updated.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updated.Location = new System.Drawing.Point(80, 483);
            this.updated.Name = "updated";
            this.updated.Size = new System.Drawing.Size(96, 19);
            this.updated.TabIndex = 19;
            this.updated.Text = "Updated At : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(77, 628);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Pressure";
            // 
            // pressureText
            // 
            this.pressureText.AutoSize = true;
            this.pressureText.BackColor = System.Drawing.Color.Transparent;
            this.pressureText.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureText.ForeColor = System.Drawing.Color.Lime;
            this.pressureText.Location = new System.Drawing.Point(330, 628);
            this.pressureText.Name = "pressureText";
            this.pressureText.Size = new System.Drawing.Size(0, 28);
            this.pressureText.TabIndex = 21;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(717, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(645, 741);
            this.gMapControl1.TabIndex = 22;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(227, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 32);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add City to the List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(228, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 24);
            this.textBox1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.LawnGreen;
            this.label6.Location = new System.Drawing.Point(224, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Or Add a City";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Google Maps",
            "Google Satellite",
            "Yandex Maps",
            "Yandex Satellite",
            "Bing Maps",
            "Bing Satellite"});
            this.comboBox2.Location = new System.Drawing.Point(440, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 26);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.ForeColor = System.Drawing.Color.LawnGreen;
            this.label7.Location = new System.Drawing.Point(440, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Choose A map";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(388, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // localTimeText
            // 
            this.localTimeText.AutoSize = true;
            this.localTimeText.BackColor = System.Drawing.Color.Transparent;
            this.localTimeText.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localTimeText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.localTimeText.Location = new System.Drawing.Point(78, 318);
            this.localTimeText.Name = "localTimeText";
            this.localTimeText.Size = new System.Drawing.Size(84, 19);
            this.localTimeText.TabIndex = 31;
            this.localTimeText.Text = "Local time :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::weather.Properties.Resources.full_screen_icon_png_0;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(793, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 39);
            this.button3.TabIndex = 32;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.localTimeText);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.updated);
            this.groupBox1.Controls.Add(this.pressureText);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.countryText);
            this.groupBox1.Controls.Add(this.tempLabel);
            this.groupBox1.Controls.Add(this.humidityText);
            this.groupBox1.Controls.Add(this.speedText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.conditionText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cityName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 741);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(717, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 39);
            this.button2.TabIndex = 34;
            this.button2.Text = "HIDE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::weather.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gMapControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Weather";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label humidityText;
        private System.Windows.Forms.Label speedText;
        private System.Windows.Forms.Label conditionText;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label countryText;
        private System.Windows.Forms.Label updated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pressureText;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label localTimeText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label1;
    }
}

