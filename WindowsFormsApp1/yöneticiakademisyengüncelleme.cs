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
    public partial class yöneticiakademisyengüncelleme : Form
    {
        public yöneticiakademisyengüncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");

        public void akgetir()
        {
            baglanti.Open();
           
            
            SqlCommand komut5 = new SqlCommand("select BOLUM,AKTİFDERS from AKADEMİSYENBİLGİ INNER JOIN BOLUMLER ON AKADEMİSYENBİLGİ.BOLUM=BOLUMLER.ID WHERE TC=@P1", baglanti);
            komut5.Parameters.AddWithValue("@P1",maskedTextBox1.Text);
            komut5.ExecuteNonQuery();
            SqlDataReader DR4 = komut5.ExecuteReader();

            while (DR4.Read())
            {
                comboBoxAKaktifders.Text = DR4[7].ToString();
                comboBoxAKBOLUM.Text = DR4[6].ToString();


            }
           
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)//btn sorgulama
        {
           
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select AD,SOYAD,DOGUM,TC,ŞİFRE,BOLUMAD,DERASAD from AKADEMİSYENBİLGİ INNER JOIN BOLUMLER ON AKADEMİSYENBİLGİ.BOLUM=BOLUMLER.BOLUMNO  INNER JOIN DERSLERBİLGİ  ON  AKADEMİSYENBİLGİ.AKTİFDERS=DERSLERBİLGİ.DERSNO WHERE AKNO=@P1", baglanti);
            komut5.Parameters.AddWithValue("@p1",maskedTextBox1.Text);
            komut5.ExecuteNonQuery();
            SqlDataReader DR4 = komut5.ExecuteReader();

            while (DR4.Read())
            {
             textBoxAKAD.Text= DR4[0].ToString();
             textBoxAKSOYAD.Text = DR4[1].ToString();
             maskedTextBoxAKDOGUM.Text = DR4[2].ToString();
             textBoxŞİFRE.Text = DR4[4].ToString();
             textBoxAKTC.Text = DR4[3].ToString();
             labelAKBOLUM.Text = DR4[5].ToString();
             labelAKAKDERS.Text = DR4[6].ToString();


            }

            baglanti.Close();
            yuklrders();
        }

        private void buttonakgörüntüle_Click(object sender, EventArgs e)
        {
            KAYITLIAKADEMİSYENLER VB = new KAYITLIAKADEMİSYENLER();
            VB.Show();
        }
        public void harfbüyüt(TextBox a)
        {


            a.Text = a.Text.ToUpper();
            a.SelectionStart = a.Text.Length;



        }
        private void textBoxAKAD_TextChanged(object sender, EventArgs e)
        {
            harfbüyüt(textBoxAKAD);
        }

        private void textBoxAKSOYAD_TextChanged(object sender, EventArgs e)
        {
            harfbüyüt(textBoxAKSOYAD);
        }

        private void BTNGERİGEL_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            SORULUGÜNCELLE();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public void yuklrders()
        {
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from BOLUMLER where BOLUMAD=@P1", baglanti);
            komut6.Parameters.AddWithValue("@P1", labelAKBOLUM.Text);
            komut6.ExecuteNonQuery();
            SqlDataReader dr1 = komut6.ExecuteReader();
            if (dr1.Read())
            {
                comboBoxAKaktifders.Items.Clear();
                for (int i = 1; i < 8; i++)
                {
                    comboBoxAKaktifders.Items.Add(dr1["BOLUMDERS" + i].ToString());
                }

            }
            baglanti.Close();


        }
        public int DERSNOSU;
        public void dersnoalekle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select DERSNO FROM DERSLERBİLGİ WHERE DERASAD=@P1",baglanti);
            komut.Parameters.AddWithValue("@P1",comboBoxAKaktifders.Text);
            komut.ExecuteNonQuery();
            SqlDataReader DR3 = komut.ExecuteReader();
            if (DR3.Read())
            {
                DERSNOSU = Convert.ToInt32(DR3[0]);
                label11.Text = DERSNOSU.ToString();
            }
          


            baglanti.Close();
        
        }


        

        private void yöneticiakademisyengüncelleme_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select BOLUMAD FROM BOLUMLER",baglanti);
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                comboBoxAKBOLUM.Items.Add(DR[0]);


            }

            baglanti.Close();

            







        }
        public int bolumno;
        
        private void comboBoxAKBOLUM_SelectedIndexChanged(object sender, EventArgs e)
        {

            bolumno =Convert.ToInt32(comboBoxAKBOLUM.SelectedIndex)+1;
            label12.Text = bolumno.ToString();
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from BOLUMLER where BOLUMAD=@P1", baglanti);
            komut6.Parameters.AddWithValue("@P1", comboBoxAKBOLUM.Text);
            komut6.ExecuteNonQuery();
            SqlDataReader dr1 = komut6.ExecuteReader();
            if (dr1.Read())
            {
                comboBoxAKaktifders.Items.Clear();
                for (int i = 1; i < 8; i++)
                {
                    comboBoxAKaktifders.Items.Add(dr1["BOLUMDERS" + i].ToString());
                }

            }
            baglanti.Close();
        }

        public void güncelle()
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("update AKADEMİSYENBİLGİ set AD=@P1,SOYAD=@P2,DOGUM=@P3,TC=@P4,ŞİFRE=@P5,BOLUM=@P6,AKTİFDERS=@P7  WHERE TC=@P8", baglanti);
            komut1.Parameters.AddWithValue("@P8", maskedTextBox1.Text);
            komut1.Parameters.AddWithValue("@P1", textBoxAKAD.Text);
            komut1.Parameters.AddWithValue("@P2", textBoxAKSOYAD.Text);
            komut1.Parameters.AddWithValue("@P3", maskedTextBoxAKDOGUM.Text);
            komut1.Parameters.AddWithValue("@P4", textBoxAKTC.Text);
            komut1.Parameters.AddWithValue("@P5", textBoxŞİFRE.Text);
            komut1.Parameters.AddWithValue("@P6", bolumno);
            komut1.Parameters.AddWithValue("@P7", DERSNOSU);
            komut1.ExecuteNonQuery();

            textBoxAKAD.Text = "";
            textBoxAKSOYAD.Text = "";
            comboBoxAKaktifders.Text = "";
            comboBoxAKBOLUM.Text = "";
            textBoxAKTC.Text = "";
            textBoxŞİFRE.Text = "";
            maskedTextBoxAKDOGUM.Text = "";
            maskedTextBox1.Text = "";
            baglanti.Close();
        }
        public void SORULUGÜNCELLE()
        {
            if (MessageBox.Show("bu değeri güncellemek istediğinize eminmisiniz!!", "", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                güncelle();
                MessageBox.Show("değer güncellendi!!!");
            }
        
        
        }





        private void BTNGÜNCELLE8_Click(object sender, EventArgs e)
        {
            SORULUGÜNCELLE();
        }

        private void BTNGÜNCELLE2_Click(object sender, EventArgs e)
        {
            SORULUGÜNCELLE();
        }

        private void BTNGÜNCELLE4_Click(object sender, EventArgs e)
        {
            SORULUGÜNCELLE();
        }

        private void BTNGÜNCELLE3_Click(object sender, EventArgs e)
        {
            SORULUGÜNCELLE();
        }

        private void BTNGÜNCELLE6_Click(object sender, EventArgs e)
        {
            SORULUGÜNCELLE();
        }

        private void BTNGÜNCELLE7_Click(object sender, EventArgs e)
        {
            SORULUGÜNCELLE();
        }

        private void comboBoxAKaktifders_SelectedIndexChanged(object sender, EventArgs e)
        {
            dersnoalekle();
        }
    }
}
