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
    public partial class öğrencinotlardetay : Form
    {

        public öğrencinotlardetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public string derasd;
        public string ad;
        public string soyad;
        public int OGRID;
        public int BOLUMID;
        public int DERSID;
        public void GELENDERSIDSİBUL()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select DERSNO FROM DERSLERBİLGİ WHERE DERASAD=@P1 AND BOLUMID=@P2",baglanti);
            komut.Parameters.AddWithValue("@P1",labelDERSADI.Text);
            komut.Parameters.AddWithValue("@P2",BOLUMID);
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                DERSID = Convert.ToInt32(DR[0]);
            }
            baglanti.Close();
        }


        public void DERSAYRINTIGETİR()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select S1,S2,S3,ORTALAMA,DURUM FROM NOTBİLGİLERİ WHERE DERSID=@P1 and OGRID=@P2",baglanti);
            komut.Parameters.AddWithValue("@P1",DERSID);
            komut.Parameters.AddWithValue("@P2",labelOGRID.Text);
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                LBLSINAV1.Text = DR[0].ToString();
                LBLSINAV2.Text = DR[1].ToString();
                LBLSINAV3.Text = DR[2].ToString();
                LBLORTALAMA.Text = DR[3].ToString();
                LBLDURUM.Text = DR[4].ToString();
            }
            baglanti.Close();
        }

        private void öğrencinotlardetay_Load(object sender, EventArgs e)
        {
            labelDERSADI.Text = derasd;
            LBLAD.Text = ad;
            LBLSOYAD.Text = soyad;
            labelOGRID.Text = OGRID.ToString() ;
            GELENDERSIDSİBUL();
            DERSAYRINTIGETİR();




        }
    }
}
