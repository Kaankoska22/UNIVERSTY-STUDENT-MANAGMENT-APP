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
    public partial class yöneticiöğrencisilme : Form
    {
        public yöneticiöğrencisilme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        private void bul()
        { baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from OGRENCİBİLGİLERİ where OKULNO=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",maskedTextBoxOGRARA.Text );
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                labelOGRAD.Text = dr[1].ToString();
                labelOGRSOYAD.Text = dr[2].ToString();
                labelOGRNO.Text = dr[3].ToString();
                labelOGRTC.Text = dr[4].ToString();
                labelOGRYIL.Text = dr[6].ToString();
                labelOGRDOGUM.Text = dr[5].ToString();
                labelOGRBOLUM.Text = dr[8].ToString();
            }
            else
            {
                MessageBox.Show("böyle bir öğrenci yok!!!");
            }
            baglanti.Close();
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bul();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (MessageBox.Show("UYARI","BU ÖĞRENCİ KAYDINI SİLMEK İSTEDİĞİNİZE EMİNMİSİNİZ ???",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut5 = new SqlCommand("delete  from OGRENCİBİLGİLERİ where OKULNO=@p1",baglanti);
                komut5.Parameters.AddWithValue("@p1",maskedTextBoxOGRARA.Text);
                komut5.ExecuteNonQuery();
                labelOGRAD.Text = "";
                labelOGRSOYAD.Text = "";
                labelOGRNO.Text = "";
                labelOGRTC.Text = "";
                labelOGRYIL.Text = "";
                labelOGRDOGUM.Text = "";
                labelOGRBOLUM.Text = "";
                maskedTextBoxOGRARA.Text ="";
                MessageBox.Show("kayıt silindi!!!");

            }






            baglanti.Close();
        }

        private void buttonakgörüntüle_Click(object sender, EventArgs e)
        {
            kayıtlıöğrencilerigörüntüle ÖÇ = new kayıtlıöğrencilerigörüntüle();
            ÖÇ.Show();
        }
    }
}
