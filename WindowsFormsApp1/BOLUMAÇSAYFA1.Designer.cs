namespace WindowsFormsApp1
{
    partial class BOLUMAÇSAYFA1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOLUMAÇSAYFA1));
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxBOLUMÇEŞİDİ = new System.Windows.Forms.ComboBox();
            this.textBoxAD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEKLE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 75;
            this.label12.Text = "BÖLÜM ÇEŞİDİ :";
            // 
            // comboBoxBOLUMÇEŞİDİ
            // 
            this.comboBoxBOLUMÇEŞİDİ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBOLUMÇEŞİDİ.FormattingEnabled = true;
            this.comboBoxBOLUMÇEŞİDİ.Items.AddRange(new object[] {
            "LİSANS",
            "ÖNLİSANS",
            "AÇIK ÖĞRETİM"});
            this.comboBoxBOLUMÇEŞİDİ.Location = new System.Drawing.Point(368, 218);
            this.comboBoxBOLUMÇEŞİDİ.Name = "comboBoxBOLUMÇEŞİDİ";
            this.comboBoxBOLUMÇEŞİDİ.Size = new System.Drawing.Size(197, 24);
            this.comboBoxBOLUMÇEŞİDİ.TabIndex = 74;
            // 
            // textBoxAD
            // 
            this.textBoxAD.Location = new System.Drawing.Point(368, 190);
            this.textBoxAD.Name = "textBoxAD";
            this.textBoxAD.Size = new System.Drawing.Size(197, 22);
            this.textBoxAD.TabIndex = 73;
            this.textBoxAD.TextChanged += new System.EventHandler(this.textBoxAD_TextChanged);
            this.textBoxAD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAD_KeyDown);
            this.textBoxAD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAD_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "BOLUM ADI :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(156, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(594, 55);
            this.label7.TabIndex = 70;
            this.label7.Text = "BEYKENT ÜNİVERSİTESİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(770, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEKLE
            // 
            this.buttonEKLE.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonEKLE.Location = new System.Drawing.Point(438, 262);
            this.buttonEKLE.Name = "buttonEKLE";
            this.buttonEKLE.Size = new System.Drawing.Size(127, 44);
            this.buttonEKLE.TabIndex = 79;
            this.buttonEKLE.Text = "EKLE";
            this.buttonEKLE.UseVisualStyleBackColor = false;
            this.buttonEKLE.Click += new System.EventHandler(this.buttonEKLE_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Location = new System.Drawing.Point(684, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 44);
            this.button1.TabIndex = 80;
            this.button1.Text = "GERİ DÖN ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(786, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "BOLUM ADI :";
            // 
            // BOLUMAÇSAYFA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(900, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEKLE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxBOLUMÇEŞİDİ);
            this.Controls.Add(this.textBoxAD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BOLUMAÇSAYFA1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEYKENT ÜNİVERSTESİ";
            this.Load += new System.EventHandler(this.BOLUMAÇSAYFA1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxBOLUMÇEŞİDİ;
        private System.Windows.Forms.TextBox textBoxAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEKLE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}