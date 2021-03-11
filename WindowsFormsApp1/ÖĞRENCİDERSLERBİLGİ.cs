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


    public partial class ÖĞRENCİDERSLERBİLGİ : Form
    {
        public ÖĞRENCİDERSLERBİLGİ()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        public int ogrencino;
        public string ogrencişifre;
        public void harfbüyüt(TextBox a)
        {
            a.Text.ToUpper();
            
        }
        public int ID;
        public void aç(Label a)
        {
            öğrencinotlardetay bv = new öğrencinotlardetay();
            bv.soyad = LBLSOYAD.Text;
            bv.BOLUMID =Convert.ToInt32(labelBOLUMNO.Text);
            bv.OGRID =Convert.ToInt32( labelOGRID.Text);
            bv.ad = lblad1.Text;
            bv.derasd =a.Text;
            bv.Show();

        
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu değeri güncelliyemezsiniz!!!");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
        public void BOLUMGETİR()
        {
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select BOLUMÇEŞİT,SINIFYILI,BOLUMNO from BOLUMLER WHERE BOLUMAD=@P1 ", baglanti);
            komut9.Parameters.AddWithValue("@P1",lblogrbolum.Text);
            komut9.ExecuteNonQuery();
            SqlDataReader DR = komut9.ExecuteReader();
            while (DR.Read())
            {
                labelBOLUMÇEŞİDİ.Text = DR[0].ToString();
                labelSINIFYIL.Text = DR[1].ToString();
                labelBOLUMNO.Text = DR[2].ToString();

            }


            baglanti.Close();
        }



        public int bol;
        public void NOTLARIGETİR(Label DERSAD,Label ORTALAMA,Label DURUM,int OGRENCİNOTSAYI)
        {
            baglanti.Open();
            SqlCommand KOMUT4 = new SqlCommand("SELECT DERASAD,ORTALAMA,DURUM FROM NOTBİLGİLERİ INNER JOIN OGRENCİBİLGİLERİ ON OGRENCİBİLGİLERİ.NO=NOTBİLGİLERİ.OGRID INNER JOIN DERSLERBİLGİ ON DERSLERBİLGİ.DERSNO=NOTBİLGİLERİ.DERSID WHERE OGRID=@P1 AND OGRENCİNOTSAYISI=@P2 ", baglanti);
            KOMUT4.Parameters.AddWithValue("@P1",OGRID.Text);
            KOMUT4.Parameters.AddWithValue("@P2",OGRENCİNOTSAYI);
            SqlDataReader DR4 = KOMUT4.ExecuteReader();
            while (DR4.Read())
            {
                DERSAD.Text = DR4[0].ToString();
                ORTALAMA.Text = DR4[1].ToString();
                DURUM.Text = DR4[2].ToString();
            }
            baglanti.Close();

        
        
        
        
        
        }
        public void BOLUMIDNUL()
        { 
        
        
        }


        public int OGRID1;
        private void ÖĞRENCİDERSLERBİLGİ_Load(object sender, EventArgs e)
        {


            labelOGRID.Text = OGRID1.ToString();
            lblöğrencino.Text = ogrencino.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT AD,OKULNO,SOYAD,TC,DOGUMYIL,CİNSİYET,ŞİFRE,BOLUMAD,EGITIMYIL,NO from OGRENCİBİLGİLERİ INNER JOIN BOLUMLER ON OGRENCİBİLGİLERİ.BOLUM=BOLUMLER.BOLUMNO WHERE BOLUM=@p1 AND OKULNO=@P3", baglanti);
            komut.Parameters.AddWithValue("@p1",bol);
            komut.Parameters.AddWithValue("@P3", ogrencino);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {                
                LBLAD.Text = dr[0].ToString();
                lblad1.Text = dr[0].ToString();
                lblsoyad1.Text = dr[2].ToString();
                LBLSOYAD.Text = dr[2].ToString();
                lbldogum.Text = dr[4].ToString();
                lblogrencitc.Text = dr[3].ToString();
                lblöğrencino.Text = dr[1].ToString();
                lblogrenciyıl.Text = dr[8].ToString();
                lblogrbolum.Text = dr[7].ToString();
                maskedTextBoxogrşifre.Text = dr[6].ToString();
                OGRID.Text = dr[9].ToString();

            }
            baglanti.Close();
            
           
            BOLUMGETİR();
            maskedTextBoxogrşifre.PasswordChar = '*';
            NOTLARIGETİR(lblders, labelORT1,  labelDURUM1,0);
            NOTLARIGETİR(lblders2, labelORT2, labelDURUM2,1);
            NOTLARIGETİR(lblders3, labelORT3, labelDURUM3,2);
            NOTLARIGETİR(lblders4, labelORT4, labelDURUM4,3);
            NOTLARIGETİR(lblders5, labelORT5, labelDURUM5,4);
            NOTLARIGETİR(lblders6, labelORT6, labelDURUM6,5);
            NOTLARIGETİR(lblders7, labelORT7, labelDURUM7,6);
            NOTLARIGETİR(lblders8, labelORT8, labelDURUM8,7);
        }


        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ANAGİRİŞ nb = new ANAGİRİŞ();
            nb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            aç(lblders6);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            aç(lblders);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu değeri güncelliyemezsiniz!!!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu değeri güncelliyemezsiniz!!!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu değeri güncelliyemezsiniz!!!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu değeri güncelliyemezsiniz!!!");
        }

        private void maskedTextBoxogrşifre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxogrşifre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            öğrencigüncelle bg = new öğrencigüncelle();
            bg.tc = lblogrencitc.Text;
            bg.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            aç(lblders2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            aç(lblders3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            aç(lblders4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            aç(lblders5);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            aç(lblders8);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            aç(lblders7);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
               maskedTextBoxogrşifre.PasswordChar = '\0';
            }
            else
            {
                maskedTextBoxogrşifre.PasswordChar = '*';
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SINIFAKTİFDERLERİGÖRÜNTÜLE BG = new SINIFAKTİFDERLERİGÖRÜNTÜLE();
            BG.BOLUM = lblogrbolum.Text;
            BG.SINIFYIL = Convert.ToInt32(labelSINIFYIL.Text);
            BG.Show();
        }
    }
}
