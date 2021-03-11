namespace WindowsFormsApp1
{
    partial class AKTİFOLANDERSLER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AKTİFOLANDERSLER));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bEYKENTÜNİVERSTESİ1DataSet2 = new WindowsFormsApp1.BEYKENTÜNİVERSTESİ1DataSet2();
            this.dERSLERBİLGİBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dERSLERBİLGİTableAdapter = new WindowsFormsApp1.BEYKENTÜNİVERSTESİ1DataSet2TableAdapters.DERSLERBİLGİTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dERASADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOLUMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dERSNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEYKENTÜNİVERSTESİ1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERSLERBİLGİBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(790, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(169, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(594, 55);
            this.label7.TabIndex = 28;
            this.label7.Text = "BEYKENT ÜNİVERSİTESİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(289, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 36);
            this.label1.TabIndex = 31;
            this.label1.Text = "AKTİF OLAN DERSLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.dERASADDataGridViewTextBoxColumn,
            this.bOLUMIDDataGridViewTextBoxColumn,
            this.dERSNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dERSLERBİLGİBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 262);
            this.dataGridView1.TabIndex = 32;
            // 
            // bEYKENTÜNİVERSTESİ1DataSet2
            // 
            this.bEYKENTÜNİVERSTESİ1DataSet2.DataSetName = "BEYKENTÜNİVERSTESİ1DataSet2";
            this.bEYKENTÜNİVERSTESİ1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dERSLERBİLGİBindingSource
            // 
            this.dERSLERBİLGİBindingSource.DataMember = "DERSLERBİLGİ";
            this.dERSLERBİLGİBindingSource.DataSource = this.bEYKENTÜNİVERSTESİ1DataSet2;
            // 
            // dERSLERBİLGİTableAdapter
            // 
            this.dERSLERBİLGİTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "ıd";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "ıd";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dERASADDataGridViewTextBoxColumn
            // 
            this.dERASADDataGridViewTextBoxColumn.DataPropertyName = "DERASAD";
            this.dERASADDataGridViewTextBoxColumn.HeaderText = "DERASAD";
            this.dERASADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dERASADDataGridViewTextBoxColumn.Name = "dERASADDataGridViewTextBoxColumn";
            // 
            // bOLUMIDDataGridViewTextBoxColumn
            // 
            this.bOLUMIDDataGridViewTextBoxColumn.DataPropertyName = "BOLUMID";
            this.bOLUMIDDataGridViewTextBoxColumn.HeaderText = "BOLUMID";
            this.bOLUMIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bOLUMIDDataGridViewTextBoxColumn.Name = "bOLUMIDDataGridViewTextBoxColumn";
            // 
            // dERSNODataGridViewTextBoxColumn
            // 
            this.dERSNODataGridViewTextBoxColumn.DataPropertyName = "DERSNO";
            this.dERSNODataGridViewTextBoxColumn.HeaderText = "DERSNO";
            this.dERSNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dERSNODataGridViewTextBoxColumn.Name = "dERSNODataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(755, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 47);
            this.button1.TabIndex = 33;
            this.button1.Text = "GERİ DÖN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AKTİFOLANDERSLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(922, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Name = "AKTİFOLANDERSLER";
            this.Text = "AKTİFOLANDERSLER";
            this.Load += new System.EventHandler(this.AKTİFOLANDERSLER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEYKENTÜNİVERSTESİ1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERSLERBİLGİBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BEYKENTÜNİVERSTESİ1DataSet2 bEYKENTÜNİVERSTESİ1DataSet2;
        private System.Windows.Forms.BindingSource dERSLERBİLGİBindingSource;
        private BEYKENTÜNİVERSTESİ1DataSet2TableAdapters.DERSLERBİLGİTableAdapter dERSLERBİLGİTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dERASADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOLUMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dERSNODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}