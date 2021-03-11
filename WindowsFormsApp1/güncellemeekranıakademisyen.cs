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
    public partial class güncellemeekranıakademisyen : Form
    {
        public güncellemeekranıakademisyen()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        public void açılamaz()
        {
            MessageBox.Show("bu alanı güncellemek için yönetim ile görüşünüz");
        
        
        
        }




        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }


        public void kayıtgüncelle()
        {
            if (SayiMi(textBoxAKAD.Text) == true)
            {
                MessageBox.Show("ad alanında sadece harf kullanılabilir");
            }
            else if (SayiMi(textBoxAKSOYAD.Text) == true)
            {
                MessageBox.Show("soyad alanında sadece harf kullanılabilir");
            }
            else if (SayiMi(textBoxAKTC.Text) == false)
            {
                MessageBox.Show("TC alanına sadece SAYI kullanılabilir");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut4 = new SqlCommand("update AKADEMİSYENBİLGİ set AD=@p1,SOYAD=@p2,DOGUM=@p3,TC=@p4,ŞİFRE=@P5,BOLUM=@p6,AKTİFDERS=@p7 where TC=@p8 ", baglanti);
                komut4.Parameters.AddWithValue("@p8", textBoxAKTC.Text);
                komut4.Parameters.AddWithValue("@p1", textBoxAKAD.Text);
                komut4.Parameters.AddWithValue("@p2", textBoxAKSOYAD.Text);
                komut4.Parameters.AddWithValue("@p4", textBoxAKTC.Text);
                komut4.Parameters.AddWithValue("@p6", comboBoxAKBOLUM.Text);
                komut4.Parameters.AddWithValue("@p3", maskedTextBoxAKDOGUM.Text);
                komut4.Parameters.AddWithValue("@p5", textBoxŞİFRE.Text);
                komut4.Parameters.AddWithValue("@p7", comboBoxAKaktifders.Text);
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("bilgileriniz güncellendi");
            }


            

        }





        
        akademisyenekranı gh = new akademisyenekranı();
        public string aktc1;
        private void BTNGERİGEL_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            açılamaz();

        }
       
        
        private void güncellemeekranıakademisyen_Load(object sender, EventArgs e)
        {
            textBoxAKTC.Text = aktc1;
           
            baglanti.Open();
           
            SqlCommand komut1 = new SqlCommand("select * from AKADEMİSYENBİLGİ where TC=@p1 ", baglanti);
            komut1.Parameters.AddWithValue("@p1",aktc1 );
           

            SqlDataReader dt = komut1.ExecuteReader();

            while (dt.Read())
            {
                textBoxAKAD.Text = dt[1].ToString();
                textBoxAKSOYAD.Text = dt[2].ToString();
                comboBoxAKBOLUM.Text = dt[6].ToString();
                textBoxAKTC.Text = dt[4].ToString();
                maskedTextBoxAKDOGUM.Text = dt[3].ToString();
                textBoxŞİFRE.Text= dt[5].ToString();
                comboBoxAKaktifders.Text= dt[7].ToString();
            }

            baglanti.Close();












        }

        private void BTNGÜNCELLE2_Click(object sender, EventArgs e)
        {
            açılamaz();

        }

        private void BTNGÜNCELLE4_Click(object sender, EventArgs e)
        {
            açılamaz();
        }

        private void BTNGÜNCELLE8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bölümünüzü değiştirmek için sekreterlik ile görüşün!!!");
        }

        private void BTNGÜNCELLE7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aktif olarak verdiğiniz dersi değiştirmek için sekreterlik ile görüşün!!!");
        }

        private void BTNGÜNCELLE6_Click(object sender, EventArgs e)
        {
            kayıtgüncelle();
        }

        private void BTNGÜNCELLE3_Click(object sender, EventArgs e)
        {
            açılamaz();
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
    }
}
