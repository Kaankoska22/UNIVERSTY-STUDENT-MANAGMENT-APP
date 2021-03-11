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
    public partial class yöneticigüncelleme : Form
    {
        public yöneticigüncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        public void güncelle()
        {
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("update YÖNETİCİBİLGİ set AD=@p1,SOYAD=@p2,DOGUMYIL=@p3,TC=@p4,ŞİFRE=@p5 where TC=@p4",baglanti);
            
            komut0.Parameters.AddWithValue("@p1", textBoxYNAD.Text);
            komut0.Parameters.AddWithValue("@p2", textBoxYNSOYAD.Text);
            komut0.Parameters.AddWithValue("@p3", maskedTextBoxYNDOGUM.Text);
            komut0.Parameters.AddWithValue("@p4", textBoxYNtc.Text);
            komut0.Parameters.AddWithValue("@p5", textBoxYNŞİFRE.Text);
            komut0.ExecuteNonQuery();
            MessageBox.Show("değişiklik yapıldı!!!");
            baglanti.Close();
        }





       
        private void BTNGERİGEL_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public string tc;
        private void yöneticigüncelleme_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from YÖNETİCİBİLGİ where TC=@p1",baglanti);
            komut9.Parameters.AddWithValue("@p1",tc);
            komut9.ExecuteNonQuery();
            SqlDataReader dr = komut9.ExecuteReader();
            while (dr.Read())
            {
                textBoxYNAD.Text = dr[1].ToString();
                textBoxYNSOYAD.Text = dr[2].ToString();
                textBoxYNtc.Text = dr[3].ToString();
                textBoxYNŞİFRE.Text = dr[4].ToString();
                maskedTextBoxYNDOGUM.Text = dr[5].ToString();

            }



            baglanti.Close();

        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            güncelle();
        }

        private void BTNGÜNCELLE2_Click(object sender, EventArgs e)
        {
            güncelle();
        }

        private void BTNGÜNCELLE3_Click(object sender, EventArgs e)
        {
            güncelle();
        }

        private void BTNGÜNCELLE6_Click(object sender, EventArgs e)
        {
            güncelle();
        }

        private void BTNGÜNCELLE4_Click(object sender, EventArgs e)
        {
            güncelle();
        }
        public void harfbüyüt(TextBox a)
        {


            a.Text = a.Text.ToUpper();
            a.SelectionStart = a.Text.Length;



        }

        private void textBoxYNAD_TextChanged(object sender, EventArgs e)
        {
            harfbüyüt(textBoxYNAD);
        }

        private void textBoxYNSOYAD_TextChanged(object sender, EventArgs e)
        {
            harfbüyüt(textBoxYNSOYAD);
        }
    }
}
