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
    public partial class YNÖĞRENCİGÜNCELLE : Form
    {
        public YNÖĞRENCİGÜNCELLE()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");

       

        public int SEÇ;
        private void Gn()
        {

            SEÇ = Convert.ToInt32(comboBoxOGRBOLUM.SelectedIndex) + 1;
           
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("update OGRENCİBİLGİLERİ set AD=@p1,SOYAD=@p2,OKULNO=@p3,TC=@p4,DOGUMYIL=@p5,EGITIMYIL=@p6,ŞİFRE=@p7,BOLUM=@p8 where OKULNO=@p9",baglanti);
            komut4.Parameters.AddWithValue("@p1",textBoxOGRAD.Text);
            komut4.Parameters.AddWithValue("@p2", textBoxOGRSOYAD.Text);
            komut4.Parameters.AddWithValue("@p3", textBoxOGRNO.Text);
            komut4.Parameters.AddWithValue("@p4", textBoxogrtc1.Text);
            komut4.Parameters.AddWithValue("@p5", maskedTextBoxOGRDOGUM.Text);
            komut4.Parameters.AddWithValue("@p6", comboBoxOGREGITIMYIL.Text);
            komut4.Parameters.AddWithValue("@p7", textBoxOGRŞİFRE.Text);
            komut4.Parameters.AddWithValue("@p8",SEÇ );
            komut4.Parameters.AddWithValue("@p9", maskedTextBoxSORGULANICAKOGR.Text);
            komut4.ExecuteNonQuery();
            MessageBox.Show("kayıt güncellendi !!!");


            baglanti.Close();



        }


        private void BTNGERİGEL_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void BTNSORGULA_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("SELECT AD,SOYAD,OKULNO,TC,CİNSİYET,DOGUMYIL,EGITIMYIL,BOLUMAD,ŞİFRE from OGRENCİBİLGİLERİ INNER JOIN BOLUMLER ON OGRENCİBİLGİLERİ.BOLUM=BOLUMLER.BOLUMNO where OKULNO=@p1", baglanti);
            komut9.Parameters.AddWithValue("@p1",maskedTextBoxSORGULANICAKOGR.Text);
            komut9.ExecuteNonQuery();
            SqlDataReader dr5 = komut9.ExecuteReader();
            if (dr5.Read())
            {
                textBoxOGRAD.Text = dr5[0].ToString();
                textBoxOGRSOYAD.Text=dr5[1].ToString();
                textBoxogrtc1.Text = dr5[3].ToString();
                textBoxOGRŞİFRE.Text = dr5[8].ToString();
                label12.Text = dr5[7].ToString();
                comboBoxOGREGITIMYIL.Text = dr5[6].ToString();
                maskedTextBoxOGRDOGUM.Text = dr5[5].ToString();
                textBoxOGRNO.Text=dr5[2].ToString();

            }
            else
            {
                MessageBox.Show("böyle bir öğrenci yok!!!");
            }

            baglanti.Close();










        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            Gn();
        }

        private void BTNGÜNCELLE2_Click(object sender, EventArgs e)
        {
            Gn();
        }

        private void BTNGÜNCELLE4_Click(object sender, EventArgs e)
        {
            Gn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gn();
        }

        private void BTNGÜNCELLE3_Click(object sender, EventArgs e)
        {
            Gn();
        }

        private void BTNGÜNCELLE6_Click(object sender, EventArgs e)
        {
            Gn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gn();
        }

        private void YNÖĞRENCİGÜNCELLE_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select BOLUMAD from BOLUMLER ", baglanti); 
            SqlDataReader dr1 = komut6.ExecuteReader();
            while (dr1.Read())
            {
                
                comboBoxOGRBOLUM.Items.Add(dr1[0]);
                
                  
               

            }
            baglanti.Close();
           
            comboBoxOGRBOLUM.Text = "";

        }

        private void textBoxOGRNO_MouseDown(object sender, MouseEventArgs e)
        {
            

            if (MessageBox.Show("yeni öğrenci numarası almak istermisiniz ???", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Random rastgele = new Random();
                int sayi = rastgele.Next(1000, 9999);
                textBoxOGRNO.Text = sayi.ToString();
            }
            else
            {

            }
           
           



        }

        private void buttonakgörüntüle_Click(object sender, EventArgs e)
        {
            kayıtlıöğrencilerigörüntüle nm = new kayıtlıöğrencilerigörüntüle();
            nm.Show();
        }
        public void harfbüyüt(TextBox a)
        {


            a.Text = a.Text.ToUpper();
            a.SelectionStart = a.Text.Length;



        }

        private void textBoxOGRAD_TextChanged(object sender, EventArgs e)
        {
            harfbüyüt(textBoxOGRAD);
        }

        private void textBoxOGRSOYAD_TextChanged(object sender, EventArgs e)
        {
            harfbüyüt(textBoxOGRSOYAD);
        }

        private void comboBoxOGRBOLUM_SelectedIndexChanged(object sender, EventArgs e)
        {
            SEÇ = Convert.ToInt32(comboBoxOGRBOLUM.SelectedIndex) + 1;
            label13.Text = SEÇ.ToString();
        }

        private void comboBoxOGREGITIMYIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
