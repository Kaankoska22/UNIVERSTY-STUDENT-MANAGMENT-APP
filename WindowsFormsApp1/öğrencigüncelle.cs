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
    public partial class öğrencigüncelle : Form
    {
        public öğrencigüncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        public string tc;
        public void gnc()
        {
            MessageBox.Show("bu alanı güncelleme yetkiniz yok lütfen öğrenci işleri ile görüşünüz!!!");
        
        }
        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            gnc();
        }
        
        private void öğrencigüncelle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand(" select * from OGRENCİBİLGİLERİ where TC=@p4 ",baglanti);
            komut1.Parameters.AddWithValue("@p4",tc);
            SqlDataReader dr5 = komut1.ExecuteReader();

            if (dr5.Read())
            {
                textBoxOGRAD.Text = dr5[1].ToString();
                textBoxOGRSOYAD.Text = dr5[2].ToString();
                textBoxŞİFRE.Text = dr5[9].ToString();
                textBoxogrtc.Text = dr5[3].ToString();
                maskedTextBoxAKDOGUM.Text = dr5[6].ToString();
                textBoxOGRNO.Text = dr5[11].ToString();
            }
            baglanti.Close();

        }

        private void BTNGÜNCELLE6_Click(object sender, EventArgs e)//şifre güncelle
        {
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("update OGRENCİBİLGİLERİ set ŞİFRE=@p1 where TC=@p2 ", baglanti);
            komut6.Parameters.AddWithValue("@p1", textBoxŞİFRE.Text);
            komut6.Parameters.AddWithValue("@p2", textBoxogrtc.Text);
            komut6.ExecuteNonQuery();
            MessageBox.Show("şifreniz değiştirildi!!!");
            baglanti.Close();
        }

        private void BTNGÜNCELLE2_Click(object sender, EventArgs e)
        {
            gnc();
        }

        private void BTNGÜNCELLE4_Click(object sender, EventArgs e)
        {
            gnc();
        }

        private void BTNGÜNCELLE3_Click(object sender, EventArgs e)
        {
            gnc();
        }

        private void BTNGÜNCELLE7_Click(object sender, EventArgs e)
        {
            gnc();
        }

        private void BTNGERİGEL_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
