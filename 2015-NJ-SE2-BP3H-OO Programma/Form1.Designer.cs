namespace _2015_NJ_SE2_BP3H_OO_Programma
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
            this.lbGemeenten = new System.Windows.Forms.ListBox();
            this.lbProvincies = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.nudAantalKinderen = new System.Windows.Forms.NumericUpDown();
            this.cbProvincie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.tbGemeente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAfstand = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMaakPosse = new System.Windows.Forms.Button();
            this.lbPosse = new System.Windows.Forms.ListBox();
            this.chkGedicht = new System.Windows.Forms.CheckBox();
            this.chkEducatief = new System.Windows.Forms.CheckBox();
            this.chkDigitaal = new System.Windows.Forms.CheckBox();
            this.chkSpeelgoed = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalKinderen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGemeenten
            // 
            this.lbGemeenten.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGemeenten.FormattingEnabled = true;
            this.lbGemeenten.ItemHeight = 15;
            this.lbGemeenten.Location = new System.Drawing.Point(279, 178);
            this.lbGemeenten.Name = "lbGemeenten";
            this.lbGemeenten.Size = new System.Drawing.Size(482, 184);
            this.lbGemeenten.TabIndex = 0;
            // 
            // lbProvincies
            // 
            this.lbProvincies.FormattingEnabled = true;
            this.lbProvincies.Location = new System.Drawing.Point(12, 12);
            this.lbProvincies.Name = "lbProvincies";
            this.lbProvincies.Size = new System.Drawing.Size(260, 160);
            this.lbProvincies.TabIndex = 1;
            this.lbProvincies.SelectedIndexChanged += new System.EventHandler(this.lbProvincies_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnToevoegen);
            this.groupBox1.Controls.Add(this.nudAantalKinderen);
            this.groupBox1.Controls.Add(this.cbProvincie);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudY);
            this.groupBox1.Controls.Add(this.nudX);
            this.groupBox1.Controls.Add(this.tbGemeente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(278, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toevoegen";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.Location = new System.Drawing.Point(102, 124);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(152, 23);
            this.btnToevoegen.TabIndex = 9;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // nudAantalKinderen
            // 
            this.nudAantalKinderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAantalKinderen.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAantalKinderen.Location = new System.Drawing.Point(102, 98);
            this.nudAantalKinderen.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAantalKinderen.Name = "nudAantalKinderen";
            this.nudAantalKinderen.Size = new System.Drawing.Size(152, 20);
            this.nudAantalKinderen.TabIndex = 8;
            this.nudAantalKinderen.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // cbProvincie
            // 
            this.cbProvincie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvincie.FormattingEnabled = true;
            this.cbProvincie.Items.AddRange(new object[] {
            "Drenthe",
            "Flevoland",
            "Friesland",
            "Gelderland",
            "Groningen",
            "Limburg",
            "Noord-Brabant",
            "Noord-Holland",
            "Overijssel",
            "Utrecht",
            "Zeeland",
            "Zuid-Holland"});
            this.cbProvincie.Location = new System.Drawing.Point(102, 45);
            this.cbProvincie.Name = "cbProvincie";
            this.cbProvincie.Size = new System.Drawing.Size(152, 21);
            this.cbProvincie.TabIndex = 3;
            this.cbProvincie.SelectedIndexChanged += new System.EventHandler(this.cbProvincie_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aantal kinderen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Coordinaten:";
            // 
            // nudY
            // 
            this.nudY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudY.Location = new System.Drawing.Point(181, 72);
            this.nudY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(73, 20);
            this.nudY.TabIndex = 5;
            this.nudY.Value = new decimal(new int[] {
            390,
            0,
            0,
            0});
            // 
            // nudX
            // 
            this.nudX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudX.Location = new System.Drawing.Point(102, 72);
            this.nudX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(73, 20);
            this.nudX.TabIndex = 4;
            this.nudX.Value = new decimal(new int[] {
            5761,
            0,
            0,
            0});
            // 
            // tbGemeente
            // 
            this.tbGemeente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGemeente.Location = new System.Drawing.Point(102, 19);
            this.tbGemeente.Name = "tbGemeente";
            this.tbGemeente.Size = new System.Drawing.Size(152, 20);
            this.tbGemeente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provincie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gemeente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Afstand:";
            // 
            // lblAfstand
            // 
            this.lblAfstand.AutoSize = true;
            this.lblAfstand.Location = new System.Drawing.Point(88, 381);
            this.lblAfstand.Name = "lblAfstand";
            this.lblAfstand.Size = new System.Drawing.Size(27, 13);
            this.lblAfstand.TabIndex = 5;
            this.lblAfstand.Text = "0km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cadeautypes:";
            // 
            // btnMaakPosse
            // 
            this.btnMaakPosse.Location = new System.Drawing.Point(91, 491);
            this.btnMaakPosse.Name = "btnMaakPosse";
            this.btnMaakPosse.Size = new System.Drawing.Size(182, 23);
            this.btnMaakPosse.TabIndex = 8;
            this.btnMaakPosse.Text = "Stel posse samen";
            this.btnMaakPosse.UseVisualStyleBackColor = true;
            // 
            // lbPosse
            // 
            this.lbPosse.FormattingEnabled = true;
            this.lbPosse.Location = new System.Drawing.Point(279, 380);
            this.lbPosse.Name = "lbPosse";
            this.lbPosse.Size = new System.Drawing.Size(482, 134);
            this.lbPosse.TabIndex = 9;
            // 
            // chkGedicht
            // 
            this.chkGedicht.AutoSize = true;
            this.chkGedicht.Location = new System.Drawing.Point(91, 399);
            this.chkGedicht.Name = "chkGedicht";
            this.chkGedicht.Size = new System.Drawing.Size(99, 17);
            this.chkGedicht.TabIndex = 10;
            this.chkGedicht.Text = "Gedicht (rijmen)";
            this.chkGedicht.UseVisualStyleBackColor = true;
            // 
            // chkEducatief
            // 
            this.chkEducatief.AutoSize = true;
            this.chkEducatief.Location = new System.Drawing.Point(91, 422);
            this.chkEducatief.Name = "chkEducatief";
            this.chkEducatief.Size = new System.Drawing.Size(170, 17);
            this.chkEducatief.TabIndex = 11;
            this.chkEducatief.Text = "Educatief (creatief, computers)";
            this.chkEducatief.UseVisualStyleBackColor = true;
            // 
            // chkDigitaal
            // 
            this.chkDigitaal.AutoSize = true;
            this.chkDigitaal.Location = new System.Drawing.Point(91, 445);
            this.chkDigitaal.Name = "chkDigitaal";
            this.chkDigitaal.Size = new System.Drawing.Size(119, 17);
            this.chkDigitaal.TabIndex = 12;
            this.chkDigitaal.Text = "Digitaal (computers)";
            this.chkDigitaal.UseVisualStyleBackColor = true;
            // 
            // chkSpeelgoed
            // 
            this.chkSpeelgoed.AutoSize = true;
            this.chkSpeelgoed.Location = new System.Drawing.Point(91, 468);
            this.chkSpeelgoed.Name = "chkSpeelgoed";
            this.chkSpeelgoed.Size = new System.Drawing.Size(121, 17);
            this.chkSpeelgoed.TabIndex = 13;
            this.chkSpeelgoed.Text = "Speelgoed (creatief)";
            this.chkSpeelgoed.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 3);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(579, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(772, 528);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkSpeelgoed);
            this.Controls.Add(this.chkDigitaal);
            this.Controls.Add(this.chkEducatief);
            this.Controls.Add(this.chkGedicht);
            this.Controls.Add(this.lbPosse);
            this.Controls.Add(this.btnMaakPosse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAfstand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbProvincies);
            this.Controls.Add(this.lbGemeenten);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PietenPlanner 3000 SwagDeLuxe - Powered by Tim Goes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalKinderen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGemeenten;
        private System.Windows.Forms.ListBox lbProvincies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.TextBox tbGemeente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAantalKinderen;
        private System.Windows.Forms.ComboBox cbProvincie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAfstand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMaakPosse;
        private System.Windows.Forms.ListBox lbPosse;
        private System.Windows.Forms.CheckBox chkGedicht;
        private System.Windows.Forms.CheckBox chkEducatief;
        private System.Windows.Forms.CheckBox chkDigitaal;
        private System.Windows.Forms.CheckBox chkSpeelgoed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

