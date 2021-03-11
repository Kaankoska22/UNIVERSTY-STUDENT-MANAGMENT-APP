using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class BOLUMAÇSAYFA1 : Form
    {
        public BOLUMAÇSAYFA1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");

        public string SONSAYI;
        public int eklenicek;
        public void sonsayıöğren()
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select BOLUMNO FROM BOLUMLER ", baglanti);
            komut4.ExecuteNonQuery();
            SqlDataReader DR = komut4.ExecuteReader();

            while (DR.Read())
            {

                SONSAYI = DR[0].ToString();
                label2.Text = SONSAYI.ToString();
                eklenicek = Convert.ToInt32(SONSAYI) + 1;
                label2.Text = eklenicek.ToString();


            }
            baglanti.Close();


        }

        
        private void buttonEKLE_Click(object sender, EventArgs e)
        {
           

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into BOLUMLER (BOLUMAD,BOLUMÇEŞİT,BOLUMNO) values(@P1,@P10,@P12) ", baglanti);
            komut2.Parameters.AddWithValue("@P1", textBoxAD.Text);
            //komut2.Parameters.AddWithValue("@p2", null);
            //komut2.Parameters.AddWithValue("@p3", null);
            //komut2.Parameters.AddWithValue("@p4", null);
            //komut2.Parameters.AddWithValue("@p5", null);
            //komut2.Parameters.AddWithValue("@p6", null);
            //komut2.Parameters.AddWithValue("@p7", null);
            //komut2.Parameters.AddWithValue("@p8", null);
            //komut2.Parameters.AddWithValue("@p9", null);
            komut2.Parameters.AddWithValue("@P10", comboBoxBOLUMÇEŞİDİ.Text);
            //komut2.Parameters.AddWithValue("@P11", null);
            komut2.Parameters.AddWithValue("@P12", eklenicek);
            komut2.ExecuteNonQuery();
            if (MessageBox.Show("BÖLÜM AÇILDI BÖLÜME DERS EKLEMELİSİNİZ!!","",MessageBoxButtons.OK,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                YÖNETİMBOLUMAÇ MN = new YÖNETİMBOLUMAÇ();
                MN.EKLENİCEKBÖLÜMAD = textBoxAD.Text;
                MN.Show();
                this.Hide();
            }

            baglanti.Close();

        }
        public void harfBÜYÜT(TextBox b)
        {
            b.Text = b.Text.ToUpper();
            b.SelectionStart = b.Text.Length;

        }
        private void textBoxAD_KeyDown(object sender, KeyEventArgs e)
        {
            harfBÜYÜT(textBoxAD);
        }

        private void textBoxAD_TextChanged(object sender, EventArgs e)
        {
            bolumgetirfonksiyom bh = new bolumgetirfonksiyom();

            bh.ÖYLEBÖLÜMVARMI(textBoxAD);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BOLUMAÇSAYFA1_Load(object sender, EventArgs e)
        {
            sonsayıöğren();
        }

        private void textBoxAD_KeyUp(object sender, KeyEventArgs e)
        {
            harfBÜYÜT(textBoxAD);
        }
    }
}
