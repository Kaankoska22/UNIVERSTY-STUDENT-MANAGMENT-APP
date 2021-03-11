namespace WindowsFormsApp1
{
    partial class şifreyönetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(şifreyönetim));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYÖNETİCİŞİFRE = new System.Windows.Forms.TextBox();
            this.txtYÖNETİCİAD = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BTNGİRİŞ = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bOLUMLERTableAdapter = new WindowsFormsApp1.dbnotkayıtDataSet9TableAdapters.BOLUMLERTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(230, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(230, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "YÖNETİCİ AD";
            // 
            // txtYÖNETİCİŞİFRE
            // 
            this.txtYÖNETİCİŞİFRE.Location = new System.Drawing.Point(230, 177);
            this.txtYÖNETİCİŞİFRE.Name = "txtYÖNETİCİŞİFRE";
            this.txtYÖNETİCİŞİFRE.Size = new System.Drawing.Size(294, 22);
            this.txtYÖNETİCİŞİFRE.TabIndex = 36;
            this.txtYÖNETİCİŞİFRE.TextChanged += new System.EventHandler(this.txtYÖNETİCİŞİFRE_TextChanged);
            // 
            // txtYÖNETİCİAD
            // 
            this.txtYÖNETİCİAD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtYÖNETİCİAD.Location = new System.Drawing.Point(230, 129);
            this.txtYÖNETİCİAD.Name = "txtYÖNETİCİAD";
            this.txtYÖNETİCİAD.Size = new System.Drawing.Size(294, 22);
            this.txtYÖNETİCİAD.TabIndex = 35;
            this.txtYÖNETİCİAD.TextChanged += new System.EventHandler(this.txtYÖNETİCİAD_TextChanged);
            this.txtYÖNETİCİAD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYÖNETİCİAD_KeyDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(230, 202);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 17);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ŞİFREMİ UNUTTUM";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BTNGİRİŞ
            // 
            this.BTNGİRİŞ.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGİRİŞ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNGİRİŞ.Location = new System.Drawing.Point(230, 236);
            this.BTNGİRİŞ.Name = "BTNGİRİŞ";
            this.BTNGİRİŞ.Size = new System.Drawing.Size(294, 47);
            this.BTNGİRİŞ.TabIndex = 33;
            this.BTNGİRİŞ.Text = "GİRİŞ YAP";
            this.BTNGİRİŞ.UseVisualStyleBackColor = false;
            this.BTNGİRİŞ.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(643, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(154, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(483, 46);
            this.label7.TabIndex = 30;
            this.label7.Text = "BEYKENT ÜNİVERSTESİ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(683, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 37);
            this.button2.TabIndex = 39;
            this.button2.Text = "geri dön";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bOLUMLERTableAdapter
            // 
            this.bOLUMLERTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(530, 179);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 21);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "ŞİFREYİ GÖSTER";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // şifreyönetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(771, 305);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYÖNETİCİŞİFRE);
            this.Controls.Add(this.txtYÖNETİCİAD);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BTNGİRİŞ);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "şifreyönetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEYKENT ÜNİVERSTESİ";
            this.Load += new System.EventHandler(this.şifreyönetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYÖNETİCİŞİFRE;
        private System.Windows.Forms.TextBox txtYÖNETİCİAD;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button BTNGİRİŞ;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private dbnotkayıtDataSet9TableAdapters.BOLUMLERTableAdapter bOLUMLERTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}