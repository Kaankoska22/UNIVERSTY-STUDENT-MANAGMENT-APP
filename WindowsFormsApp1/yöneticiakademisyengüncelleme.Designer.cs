namespace WindowsFormsApp1
{
    partial class yöneticiakademisyengüncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yöneticiakademisyengüncelleme));
            this.maskedTextBoxAKDOGUM = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxAKaktifders = new System.Windows.Forms.ComboBox();
            this.comboBoxAKBOLUM = new System.Windows.Forms.ComboBox();
            this.BTNGERİGEL = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE6 = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE7 = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE8 = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE3 = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE4 = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE2 = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE = new System.Windows.Forms.Button();
            this.textBoxŞİFRE = new System.Windows.Forms.TextBox();
            this.textBoxAKTC = new System.Windows.Forms.TextBox();
            this.textBoxAKSOYAD = new System.Windows.Forms.TextBox();
            this.textBoxAKAD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonakgörüntüle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelAKBOLUM = new System.Windows.Forms.Label();
            this.labelAKAKDERS = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxAKDOGUM
            // 
            this.maskedTextBoxAKDOGUM.Location = new System.Drawing.Point(439, 434);
            this.maskedTextBoxAKDOGUM.Mask = "00/00/0000";
            this.maskedTextBoxAKDOGUM.Name = "maskedTextBoxAKDOGUM";
            this.maskedTextBoxAKDOGUM.Size = new System.Drawing.Size(235, 22);
            this.maskedTextBoxAKDOGUM.TabIndex = 79;
            this.maskedTextBoxAKDOGUM.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxAKaktifders
            // 
            this.comboBoxAKaktifders.DisplayMember = "dersadı";
            this.comboBoxAKaktifders.FormattingEnabled = true;
            this.comboBoxAKaktifders.Location = new System.Drawing.Point(736, 305);
            this.comboBoxAKaktifders.Name = "comboBoxAKaktifders";
            this.comboBoxAKaktifders.Size = new System.Drawing.Size(231, 24);
            this.comboBoxAKaktifders.TabIndex = 78;
            this.comboBoxAKaktifders.ValueMember = "dersadı";
            this.comboBoxAKaktifders.SelectedIndexChanged += new System.EventHandler(this.comboBoxAKaktifders_SelectedIndexChanged);
            // 
            // comboBoxAKBOLUM
            // 
            this.comboBoxAKBOLUM.DisplayMember = "bolumadı";
            this.comboBoxAKBOLUM.FormattingEnabled = true;
            this.comboBoxAKBOLUM.Location = new System.Drawing.Point(736, 237);
            this.comboBoxAKBOLUM.Name = "comboBoxAKBOLUM";
            this.comboBoxAKBOLUM.Size = new System.Drawing.Size(231, 24);
            this.comboBoxAKBOLUM.TabIndex = 77;
            this.comboBoxAKBOLUM.ValueMember = "bolumadı";
            this.comboBoxAKBOLUM.SelectedIndexChanged += new System.EventHandler(this.comboBoxAKBOLUM_SelectedIndexChanged);
            // 
            // BTNGERİGEL
            // 
            this.BTNGERİGEL.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGERİGEL.Location = new System.Drawing.Point(954, 474);
            this.BTNGERİGEL.Name = "BTNGERİGEL";
            this.BTNGERİGEL.Size = new System.Drawing.Size(172, 53);
            this.BTNGERİGEL.TabIndex = 76;
            this.BTNGERİGEL.Text = "geri dön";
            this.BTNGERİGEL.UseVisualStyleBackColor = false;
            this.BTNGERİGEL.Click += new System.EventHandler(this.BTNGERİGEL_Click);
            // 
            // BTNGÜNCELLE6
            // 
            this.BTNGÜNCELLE6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE6.Location = new System.Drawing.Point(984, 371);
            this.BTNGÜNCELLE6.Name = "BTNGÜNCELLE6";
            this.BTNGÜNCELLE6.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE6.TabIndex = 75;
            this.BTNGÜNCELLE6.Text = "güncelle";
            this.BTNGÜNCELLE6.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE6.Click += new System.EventHandler(this.BTNGÜNCELLE6_Click);
            // 
            // BTNGÜNCELLE7
            // 
            this.BTNGÜNCELLE7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE7.Location = new System.Drawing.Point(984, 305);
            this.BTNGÜNCELLE7.Name = "BTNGÜNCELLE7";
            this.BTNGÜNCELLE7.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE7.TabIndex = 74;
            this.BTNGÜNCELLE7.Text = "güncelle";
            this.BTNGÜNCELLE7.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE7.Click += new System.EventHandler(this.BTNGÜNCELLE7_Click);
            // 
            // BTNGÜNCELLE8
            // 
            this.BTNGÜNCELLE8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE8.Location = new System.Drawing.Point(984, 234);
            this.BTNGÜNCELLE8.Name = "BTNGÜNCELLE8";
            this.BTNGÜNCELLE8.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE8.TabIndex = 73;
            this.BTNGÜNCELLE8.Text = "güncelle";
            this.BTNGÜNCELLE8.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE8.Click += new System.EventHandler(this.BTNGÜNCELLE8_Click);
            // 
            // BTNGÜNCELLE3
            // 
            this.BTNGÜNCELLE3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE3.Location = new System.Drawing.Point(721, 434);
            this.BTNGÜNCELLE3.Name = "BTNGÜNCELLE3";
            this.BTNGÜNCELLE3.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE3.TabIndex = 72;
            this.BTNGÜNCELLE3.Text = "güncelle";
            this.BTNGÜNCELLE3.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE3.Click += new System.EventHandler(this.BTNGÜNCELLE3_Click);
            // 
            // BTNGÜNCELLE4
            // 
            this.BTNGÜNCELLE4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE4.Location = new System.Drawing.Point(465, 371);
            this.BTNGÜNCELLE4.Name = "BTNGÜNCELLE4";
            this.BTNGÜNCELLE4.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE4.TabIndex = 71;
            this.BTNGÜNCELLE4.Text = "güncelle";
            this.BTNGÜNCELLE4.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE4.Click += new System.EventHandler(this.BTNGÜNCELLE4_Click);
            // 
            // BTNGÜNCELLE2
            // 
            this.BTNGÜNCELLE2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE2.Location = new System.Drawing.Point(465, 287);
            this.BTNGÜNCELLE2.Name = "BTNGÜNCELLE2";
            this.BTNGÜNCELLE2.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE2.TabIndex = 70;
            this.BTNGÜNCELLE2.Text = "güncelle";
            this.BTNGÜNCELLE2.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE2.Click += new System.EventHandler(this.BTNGÜNCELLE2_Click);
            // 
            // BTNGÜNCELLE
            // 
            this.BTNGÜNCELLE.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGÜNCELLE.Location = new System.Drawing.Point(465, 226);
            this.BTNGÜNCELLE.Name = "BTNGÜNCELLE";
            this.BTNGÜNCELLE.Size = new System.Drawing.Size(97, 27);
            this.BTNGÜNCELLE.TabIndex = 69;
            this.BTNGÜNCELLE.Text = "güncelle";
            this.BTNGÜNCELLE.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE.Click += new System.EventHandler(this.BTNGÜNCELLE_Click);
            // 
            // textBoxŞİFRE
            // 
            this.textBoxŞİFRE.Location = new System.Drawing.Point(736, 371);
            this.textBoxŞİFRE.Name = "textBoxŞİFRE";
            this.textBoxŞİFRE.Size = new System.Drawing.Size(231, 22);
            this.textBoxŞİFRE.TabIndex = 68;
            // 
            // textBoxAKTC
            // 
            this.textBoxAKTC.Location = new System.Drawing.Point(206, 373);
            this.textBoxAKTC.Name = "textBoxAKTC";
            this.textBoxAKTC.Size = new System.Drawing.Size(231, 22);
            this.textBoxAKTC.TabIndex = 67;
            // 
            // textBoxAKSOYAD
            // 
            this.textBoxAKSOYAD.Location = new System.Drawing.Point(206, 290);
            this.textBoxAKSOYAD.Name = "textBoxAKSOYAD";
            this.textBoxAKSOYAD.Size = new System.Drawing.Size(231, 22);
            this.textBoxAKSOYAD.TabIndex = 66;
            this.textBoxAKSOYAD.TextChanged += new System.EventHandler(this.textBoxAKSOYAD_TextChanged);
            // 
            // textBoxAKAD
            // 
            this.textBoxAKAD.Location = new System.Drawing.Point(206, 227);
            this.textBoxAKAD.Name = "textBoxAKAD";
            this.textBoxAKAD.Size = new System.Drawing.Size(231, 22);
            this.textBoxAKAD.TabIndex = 65;
            this.textBoxAKAD.TextChanged += new System.EventHandler(this.textBoxAKAD_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(307, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 64;
            this.label5.Text = "DOĞUM YILI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(91, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 63;
            this.label6.Text = "TC :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(51, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 62;
            this.label8.Text = "SOYAD :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(90, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 24);
            this.label9.TabIndex = 61;
            this.label9.Text = "AD :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(653, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 60;
            this.label4.Text = "ŞİFRE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(598, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 59;
            this.label2.Text = "AKTİF DERS :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(641, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "BÖLÜM :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(994, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(223, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(743, 69);
            this.label7.TabIndex = 55;
            this.label7.Text = "BEYKENT ÜNİVERSİTESİ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(636, 161);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(72, 22);
            this.maskedTextBox1.TabIndex = 80;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(258, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 24);
            this.label3.TabIndex = 81;
            this.label3.Text = "GÜNCELLENİCEK AKADEMİSYEN NO :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Location = new System.Drawing.Point(721, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 82;
            this.button1.Text = "SORGULA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonakgörüntüle
            // 
            this.buttonakgörüntüle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonakgörüntüle.Location = new System.Drawing.Point(496, 474);
            this.buttonakgörüntüle.Name = "buttonakgörüntüle";
            this.buttonakgörüntüle.Size = new System.Drawing.Size(122, 53);
            this.buttonakgörüntüle.TabIndex = 83;
            this.buttonakgörüntüle.Text = "görüntüle";
            this.buttonakgörüntüle.UseVisualStyleBackColor = false;
            this.buttonakgörüntüle.Click += new System.EventHandler(this.buttonakgörüntüle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(48, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(389, 24);
            this.label10.TabIndex = 84;
            this.label10.Text = "KAYITLI AKADEMİSYENLERİ GÖRÜNTÜLE :";
            // 
            // labelAKBOLUM
            // 
            this.labelAKBOLUM.AutoSize = true;
            this.labelAKBOLUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAKBOLUM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelAKBOLUM.Location = new System.Drawing.Point(733, 217);
            this.labelAKBOLUM.Name = "labelAKBOLUM";
            this.labelAKBOLUM.Size = new System.Drawing.Size(72, 17);
            this.labelAKBOLUM.TabIndex = 85;
            this.labelAKBOLUM.Text = "BÖLÜM :";
            // 
            // labelAKAKDERS
            // 
            this.labelAKAKDERS.AutoSize = true;
            this.labelAKAKDERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAKAKDERS.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelAKAKDERS.Location = new System.Drawing.Point(733, 285);
            this.labelAKAKDERS.Name = "labelAKAKDERS";
            this.labelAKAKDERS.Size = new System.Drawing.Size(72, 17);
            this.labelAKAKDERS.TabIndex = 86;
            this.labelAKAKDERS.Text = "BÖLÜM :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(990, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 24);
            this.label11.TabIndex = 87;
            this.label11.Text = "BÖLÜM :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(990, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 24);
            this.label12.TabIndex = 88;
            this.label12.Text = "BÖLÜM :";
            // 
            // yöneticiakademisyengüncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1138, 539);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelAKAKDERS);
            this.Controls.Add(this.labelAKBOLUM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonakgörüntüle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox1);
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
            this.MinimizeBox = false;
            this.Name = "yöneticiakademisyengüncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEYKENT ÜNİVERSİTESİ";
            this.Load += new System.EventHandler(this.yöneticiakademisyengüncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxAKDOGUM;
        private System.Windows.Forms.ComboBox comboBoxAKaktifders;
        private System.Windows.Forms.ComboBox comboBoxAKBOLUM;
        private System.Windows.Forms.Button BTNGERİGEL;
        private System.Windows.Forms.Button BTNGÜNCELLE6;
        private System.Windows.Forms.Button BTNGÜNCELLE7;
        private System.Windows.Forms.Button BTNGÜNCELLE8;
        private System.Windows.Forms.Button BTNGÜNCELLE3;
        private System.Windows.Forms.Button BTNGÜNCELLE4;
        private System.Windows.Forms.Button BTNGÜNCELLE2;
        private System.Windows.Forms.Button BTNGÜNCELLE;
        private System.Windows.Forms.TextBox textBoxŞİFRE;
        private System.Windows.Forms.TextBox textBoxAKTC;
        private System.Windows.Forms.TextBox textBoxAKSOYAD;
        private System.Windows.Forms.TextBox textBoxAKAD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonakgörüntüle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelAKBOLUM;
        private System.Windows.Forms.Label labelAKAKDERS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}