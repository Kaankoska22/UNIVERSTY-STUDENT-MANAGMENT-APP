using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Runtime.Remoting.Activation;
using System.Drawing;

namespace WindowsFormsApp1
{
    class ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI 
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        akademisyenekranı bg = new akademisyenekranı();
        public int ogrenciıdsı;
        public int sontotıdsi;
        //public string notnosu;

        public void OGRENCİNOTGETİRME(int derıd,MaskedTextBox maskedTextBoxGÜNCELLENİCEKDEGER, TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox labelDURUM, TextBox label15)
        {

            baglanti.Open();
           
            SqlCommand KOMUT5 = new SqlCommand("SELECT S1,S2,S3,ORTALAMA,DURUM,NOTNO FROM NOTBİLGİLERİ WHERE OGRENCİNO=@P1 AND DERSID=@P2  ", baglanti);
            KOMUT5.Parameters.AddWithValue("@P1", maskedTextBoxGÜNCELLENİCEKDEGER.Text);
            KOMUT5.Parameters.AddWithValue("@P2",derıd);
            KOMUT5.ExecuteNonQuery();
            SqlDataReader DR = KOMUT5.ExecuteReader();
            while (DR.Read())
            {
                bg.NOTNOSU = DR[5].ToString();        
                textBox1.Text = DR[0].ToString();
                textBox2.Text = DR[1].ToString();
                textBox3.Text = DR[2].ToString();
                textBox4.Text = DR[3].ToString();
                labelDURUM.Text = DR[4].ToString();
                label15.Text = bg.NOTNOSU;
            }
            
            baglanti.Close();
        }
        public void ÖĞRENCİBİLGİGETİRME(MaskedTextBox A,TextBox labelADISONUÇ,TextBox labelSOYADISONUÇ)
        {
            baglanti.Open();
            SqlCommand KOMUT5 = new SqlCommand("SELECT AD,SOYAD FROM OGRENCİBİLGİLERİ WHERE OKULNO=@P1  ", baglanti);
            KOMUT5.Parameters.AddWithValue("@P1", A.Text);
            KOMUT5.ExecuteNonQuery();
            SqlDataReader DR = KOMUT5.ExecuteReader();
            while (DR.Read())
            {
               
                labelADISONUÇ.Text = DR[0].ToString();
                labelSOYADISONUÇ.Text = DR[1].ToString();
            }
            baglanti.Close();
        }
        
        
        public void SONNOTNOSUBUL(TextBox a)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select NOTNO FROM NOTBİLGİLERİ", baglanti);
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                bg.SONNOTNO = Convert.ToInt32(DR[0]) + 1;
                sontotıdsi = bg.SONNOTNO;
                a.Text = sontotıdsi.ToString();
            }
            baglanti.Close();
        }
        public void NOTKONTROL(string LABELOGRID,int desıd)
        {
            baglanti.Open();
            ogrenciıdsı = Convert.ToInt32(LABELOGRID);

            SqlCommand komut = new SqlCommand("select OGRID FROM NOTBİLGİLERİ where DERSID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1",desıd);
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                if (ogrenciıdsı == Convert.ToInt32(DR[0]))
                {
                    MessageBox.Show("BU ÖĞRENCİNİN ZATEN NOT KAYDI VAR GÜNCELLEME BÖLÜMÜNDEN GÜNCELLİYEBİLİRSİNİZ");
                    ogrenciıdsı =22222;

                }
            }
            baglanti.Close();

        }










    }
}
