namespace WindowsFormsApp1
{
    partial class güncellemeekranıakademisyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(güncellemeekranıakademisyen));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAKAD = new System.Windows.Forms.TextBox();
            this.textBoxAKSOYAD = new System.Windows.Forms.TextBox();
            this.textBoxAKTC = new System.Windows.Forms.TextBox();
            this.textBoxŞİFRE = new System.Windows.Forms.TextBox();
            this.BTNGÜNCELLE = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE2 = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE3 = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE4 = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE6 = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE7 = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE8 = new System.Windows.Forms.Button();
            this.BTNGERİGEL = new System.Windows.Forms.Button();
            this.comboBoxAKBOLUM = new System.Windows.Forms.ComboBox();
            this.bölümlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbnotkayıtDataSet3 = new WindowsFormsApp1.dbnotkayıtDataSet3();
            this.comboBoxAKaktifders = new System.Windows.Forms.ComboBox();
            this.derslerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbnotkayıtDataSet4 = new WindowsFormsApp1.dbnotkayıtDataSet4();
            this.maskedTextBoxAKDOGUM = new System.Windows.Forms.MaskedTextBox();
            this.bölümlerTableAdapter = new WindowsFormsApp1.dbnotkayıtDataSet3TableAdapters.bölümlerTableAdapter();
            this.derslerTableAdapter = new WindowsFormsApp1.dbnotkayıtDataSet4TableAdapters.derslerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bölümlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbnotkayıtDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbnotkayıtDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(988, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(217, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(743, 69);
            this.label7.TabIndex = 24;
            this.label7.Text = "BEYKENT ÜNİVERSİTESİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(597, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "BÖLÜM :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(597, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "AKTİF DERS :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(597, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "ŞİFRE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(298, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "DOĞUM YILI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "TC :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(39, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "SOYAD :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(39, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "AD :";
            // 
            // textBoxAKAD
            // 
            this.textBoxAKAD.Enabled = false;
            this.textBoxAKAD.Location = new System.Drawing.Point(194, 169);
            this.textBoxAKAD.Name = "textBoxAKAD";
            this.textBoxAKAD.Size = new System.Drawing.Size(231, 22);
            this.textBoxAKAD.TabIndex = 35;
            this.textBoxAKAD.TextChanged += new System.EventHandler(this.textBoxAKAD_TextChanged);
            // 
            // textBoxAKSOYAD
            // 
            this.textBoxAKSOYAD.Enabled = false;
            this.textBoxAKSOYAD.Location = new System.Drawing.Point(194, 223);
            this.textBoxAKSOYAD.Name = "textBoxAKSOYAD";
            this.textBoxAKSOYAD.Size = new System.Drawing.Size(231, 22);
            this.textBoxAKSOYAD.TabIndex = 36;
            this.textBoxAKSOYAD.TextChanged += new System.EventHandler(this.textBoxAKSOYAD_TextChanged);
            // 
            // textBoxAKTC
            // 
            this.textBoxAKTC.Enabled = false;
            this.textBoxAKTC.Location = new System.Drawing.Point(194, 275);
            this.textBoxAKTC.Name = "textBoxAKTC";
            this.textBoxAKTC.Size = new System.Drawing.Size(231, 22);
            this.textBoxAKTC.TabIndex = 37;
            // 
            // textBoxŞİFRE
            // 
            this.textBoxŞİFRE.Location = new System.Drawing.Point(727, 277);
            this.textBoxŞİFRE.Name = "textBoxŞİFRE";
            this.textBoxŞİFRE.Size = new System.Drawing.Size(231, 22);
            this.textBoxŞİFRE.TabIndex = 41;
            // 
            // BTNGÜNCELLE
            // 
            this.BTNGÜNCELLE.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE.Location = new System.Drawing.Point(453, 168);
            this.BTNGÜNCELLE.Name = "BTNGÜNCELLE";
            this.BTNGÜNCELLE.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE.TabIndex = 43;
            this.BTNGÜNCELLE.Text = "güncelle";
            this.BTNGÜNCELLE.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE.Click += new System.EventHandler(this.BTNGÜNCELLE_Click);
            // 
            // BTNGÜNCELLE2
            // 
            this.BTNGÜNCELLE2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE2.Location = new System.Drawing.Point(453, 220);
            this.BTNGÜNCELLE2.Name = "BTNGÜNCELLE2";
            this.BTNGÜNCELLE2.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE2.TabIndex = 44;
            this.BTNGÜNCELLE2.Text = "güncelle";
            this.BTNGÜNCELLE2.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE2.Click += new System.EventHandler(this.BTNGÜNCELLE2_Click);
            // 
            // BTNGÜNCELLE3
            // 
            this.BTNGÜNCELLE3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE3.Location = new System.Drawing.Point(712, 340);
            this.BTNGÜNCELLE3.Name = "BTNGÜNCELLE3";
            this.BTNGÜNCELLE3.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE3.TabIndex = 46;
            this.BTNGÜNCELLE3.Text = "güncelle";
            this.BTNGÜNCELLE3.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE3.Click += new System.EventHandler(this.BTNGÜNCELLE3_Click);
            // 
            // BTNGÜNCELLE4
            // 
            this.BTNGÜNCELLE4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE4.Location = new System.Drawing.Point(453, 277);
            this.BTNGÜNCELLE4.Name = "BTNGÜNCELLE4";
            this.BTNGÜNCELLE4.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE4.TabIndex = 45;
            this.BTNGÜNCELLE4.Text = "güncelle";
            this.BTNGÜNCELLE4.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE4.Click += new System.EventHandler(this.BTNGÜNCELLE4_Click);
            // 
            // BTNGÜNCELLE6
            // 
            this.BTNGÜNCELLE6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE6.Location = new System.Drawing.Point(991, 278);
            this.BTNGÜNCELLE6.Name = "BTNGÜNCELLE6";
            this.BTNGÜNCELLE6.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE6.TabIndex = 49;
            this.BTNGÜNCELLE6.Text = "güncelle";
            this.BTNGÜNCELLE6.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE6.Click += new System.EventHandler(this.BTNGÜNCELLE6_Click);
            // 
            // BTNGÜNCELLE7
            // 
            this.BTNGÜNCELLE7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE7.Location = new System.Drawing.Point(991, 221);
            this.BTNGÜNCELLE7.Name = "BTNGÜNCELLE7";
            this.BTNGÜNCELLE7.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE7.TabIndex = 48;
            this.BTNGÜNCELLE7.Text = "güncelle";
            this.BTNGÜNCELLE7.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE7.Click += new System.EventHandler(this.BTNGÜNCELLE7_Click);
            // 
            // BTNGÜNCELLE8
            // 
            this.BTNGÜNCELLE8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE8.Location = new System.Drawing.Point(991, 169);
            this.BTNGÜNCELLE8.Name = "BTNGÜNCELLE8";
            this.BTNGÜNCELLE8.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE8.TabIndex = 47;
            this.BTNGÜNCELLE8.Text = "güncelle";
            this.BTNGÜNCELLE8.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE8.Click += new System.EventHandler(this.BTNGÜNCELLE8_Click);
            // 
            // BTNGERİGEL
            // 
            this.BTNGERİGEL.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGERİGEL.Location = new System.Drawing.Point(944, 419);
            this.BTNGERİGEL.Name = "BTNGERİGEL";
            this.BTNGERİGEL.Size = new System.Drawing.Size(172, 53);
            this.BTNGERİGEL.TabIndex = 51;
            this.BTNGERİGEL.Text = "geri dön";
            this.BTNGERİGEL.UseVisualStyleBackColor = false;
            this.BTNGERİGEL.Click += new System.EventHandler(this.BTNGERİGEL_Click);
            // 
            // comboBoxAKBOLUM
            // 
            this.comboBoxAKBOLUM.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bölümlerBindingSource, "bolumadı", true));
            this.comboBoxAKBOLUM.DataSource = this.bölümlerBindingSource;
            this.comboBoxAKBOLUM.DisplayMember = "bolumadı";
            this.comboBoxAKBOLUM.Enabled = false;
            this.comboBoxAKBOLUM.FormattingEnabled = true;
            this.comboBoxAKBOLUM.Location = new System.Drawing.Point(727, 169);
            this.comboBoxAKBOLUM.Name = "comboBoxAKBOLUM";
            this.comboBoxAKBOLUM.Size = new System.Drawing.Size(231, 24);
            this.comboBoxAKBOLUM.TabIndex = 52;
            this.comboBoxAKBOLUM.ValueMember = "bolumadı";
            // 
            // bölümlerBindingSource
            // 
            this.bölümlerBindingSource.DataMember = "bölümler";
            this.bölümlerBindingSource.DataSource = this.dbnotkayıtDataSet3;
            // 
            // dbnotkayıtDataSet3
            // 
            this.dbnotkayıtDataSet3.DataSetName = "dbnotkayıtDataSet3";
            this.dbnotkayıtDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxAKaktifders
            // 
            this.comboBoxAKaktifders.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.derslerBindingSource, "dersadı", true));
            this.comboBoxAKaktifders.DataSource = this.derslerBindingSource;
            this.comboBoxAKaktifders.DisplayMember = "dersadı";
            this.comboBoxAKaktifders.Enabled = false;
            this.comboBoxAKaktifders.FormattingEnabled = true;
            this.comboBoxAKaktifders.Location = new System.Drawing.Point(727, 223);
            this.comboBoxAKaktifders.Name = "comboBoxAKaktifders";
            this.comboBoxAKaktifders.Size = new System.Drawing.Size(231, 24);
            this.comboBoxAKaktifders.TabIndex = 53;
            this.comboBoxAKaktifders.ValueMember = "dersadı";
            // 
            // derslerBindingSource
            // 
            this.derslerBindingSource.DataMember = "dersler";
            this.derslerBindingSource.DataSource = this.dbnotkayıtDataSet4;
            // 
            // dbnotkayıtDataSet4
            // 
            this.dbnotkayıtDataSet4.DataSetName = "dbnotkayıtDataSet4";
            this.dbnotkayıtDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBoxAKDOGUM
            // 
            this.maskedTextBoxAKDOGUM.Enabled = false;
            this.maskedTextBoxAKDOGUM.Location = new System.Drawing.Point(430, 340);
            this.maskedTextBoxAKDOGUM.Mask = "00/00/0000";
            this.maskedTextBoxAKDOGUM.Name = "maskedTextBoxAKDOGUM";
            this.maskedTextBoxAKDOGUM.Size = new System.Drawing.Size(235, 22);
            this.maskedTextBoxAKDOGUM.TabIndex = 54;
            this.maskedTextBoxAKDOGUM.ValidatingType = typeof(System.DateTime);
            // 
            // bölümlerTableAdapter
            // 
            this.bölümlerTableAdapter.ClearBeforeFill = true;
            // 
            // derslerTableAdapter
            // 
            this.derslerTableAdapter.ClearBeforeFill = true;
            // 
            // güncellemeekranıakademisyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1128, 489);
            this.Controls.Add(this.maskedTextBoxAKDOGUM);
            this.Controls.Add(this.comboBoxAKaktifders);
            this.Controls.Add(this.comboBoxAKBOLUM);
            this.Controls.Add(this.BTNGERİGEL);
            this.Controls.Add(this.BTNGÜNCELLE6);
            this.Controls.Add(this.BTNGÜNCELLE7);
            this.Controls.Add(this.BTNGÜNCELLE8);
            this.Controls.Add(this.BTNGÜNCELLE3);
            this.Controls.Add(this.BTNGÜNCELLE4);
            this.Controls.Add(this.BTNGÜNCELLE2);
            this.Controls.Add(this.BTNGÜNCELLE);
            this.Controls.Add(this.textBoxŞİFRE);
            this.Controls.Add(this.textBoxAKTC);
            this.Controls.Add(this.textBoxAKSOYAD);
            this.Controls.Add(this.textBoxAKAD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "güncellemeekranıakademisyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEYKENT ÜNİVERSİTESİ";
            this.Load += new System.EventHandler(this.güncellemeekranıakademisyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bölümlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbnotkayıtDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbnotkayıtDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAKAD;
        private System.Windows.Forms.TextBox textBoxAKSOYAD;
        private System.Windows.Forms.TextBox textBoxAKTC;
        private System.Windows.Forms.TextBox textBoxŞİFRE;
        private System.Windows.Forms.Button BTNGÜNCELLE;
        private System.Windows.Forms.Button BTNGÜNCELLE2;
        private System.Windows.Forms.Button BTNGÜNCELLE3;
        private System.Windows.Forms.Button BTNGÜNCELLE4;
        private System.Windows.Forms.Button BTNGÜNCELLE6;
        private System.Windows.Forms.Button BTNGÜNCELLE7;
        private System.Windows.Forms.Button BTNGÜNCELLE8;
        private System.Windows.Forms.Button BTNGERİGEL;
        private System.Windows.Forms.ComboBox comboBoxAKBOLUM;
        private System.Windows.Forms.ComboBox comboBoxAKaktifders;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAKDOGUM;
        private dbnotkayıtDataSet3 dbnotkayıtDataSet3;
        private System.Windows.Forms.BindingSource bölümlerBindingSource;
        private dbnotkayıtDataSet3TableAdapters.bölümlerTableAdapter bölümlerTableAdapter;
        private dbnotkayıtDataSet4 dbnotkayıtDataSet4;
        private System.Windows.Forms.BindingSource derslerBindingSource;
        private dbnotkayıtDataSet4TableAdapters.derslerTableAdapter derslerTableAdapter;
    }
}