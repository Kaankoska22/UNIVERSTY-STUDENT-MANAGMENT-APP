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
    public partial class YÖNETİM : Form
    {
        public YÖNETİM()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        bolumgetirfonksiyom bh = new bolumgetirfonksiyom();
        ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI öğ = new ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI();


        public string yönad;
        public string yönşifre;
        private void YÖNETİM_Load(object sender, EventArgs e)//YÖNETİM SAYFASI YÜKLENMESİ  VE KİŞİSEL VERİLERİN AKTARIMI
        {
            //COMBOBOXLARIN TEXTLERİNİ SIFIRLAMA
            comboBoxAKaktifders.Text = "";
            comboBoxakbolum.Text = "";
            comboBoxogrbolum.Text = "";

            //BOLUMLERİN COMBOBOXA AKTARIMI
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("select BOLUMAD from BOLUMLER ", baglanti);
            komut0.ExecuteNonQuery();
            SqlDataReader dr4 = komut0.ExecuteReader();
            while (dr4.Read())
            {
                comboBoxogrbolum.Items.Add(dr4[0]);

            }
            baglanti.Close();



            
            // YÖNETİCİ BİLGİLERİNİN GETİRİLMESİ
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from YÖNETİCİBİLGİ where AD=@p1 and ŞİFRE=@p2 ", baglanti);
            komut1.Parameters.AddWithValue("@p1", yönad);
            komut1.Parameters.AddWithValue("@p2", yönşifre);

            SqlDataReader dt = komut1.ExecuteReader();

            while (dt.Read())
            {
                lblyönad.Text = dt[1].ToString();
                lblyönsoyad.Text = dt[2].ToString();
                lblyöndogum.Text = dt[5].ToString();
                lblyöntc.Text = dt[3].ToString();

            }
            //AKADEMİSYEN COMBOBOXA VERİ  AKTARIMI
            bh.AKBOLUMEKLE(comboBoxakbolum);
            baglanti.Close();
            //ÖNCEDEN KAYITLI SON ÖĞRENCİ NOSU ÖĞRENME
            OGRnobul();
            //ÖNCEDEN KAYITLI SON NOT NOSU ÖĞRENME
           
            //YÖN ŞİFRE DEĞİŞKENİ İLE VERİ TABANI SORGU
            labelşifre.Text = yönşifre;
            //SON KAYITLI AKADEMİSYEN NO BULMA
            AKnobul();
            //LOAD EKRANINDA FOCUSLAMA
            comboBoxCİNSİYET.Focus();

        } 
        public void harfbüyüt(TextBox a)//HARF BÜYÜTME FONKSİYONU
        {
            a.Text = a.Text.ToUpper();
            a.SelectionStart = a.Text.Length;
        }
        public void aç()//yöneticigüncelleme EKRANI GETİRME
        {
            yöneticigüncelleme yn = new yöneticigüncelleme();
            yn.tc = lblyöntc.Text;
            yn.Show();
        }
        private void button3_Click(object sender, EventArgs e)//ANA GİRİŞ EKRANI YENİDEN AÇMA
        {
            this.Hide();
            ANAGİRİŞ cv = new ANAGİRİŞ();
            cv.Show();
        }
        public int BOLUMNOBULMASAYISIİNT;
        public string BOLUMNOBULMASAYISI;

        public void bolumnobul()//SEÇİLEN BOLUMÜN NOSUNU BULMA
        {
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("select BOLUMNO from BOLUMLER where BOLUMAD=@p1 ", baglanti);
            komut0.Parameters.AddWithValue("@p1", comboBoxakbolum.Text);
            komut0.ExecuteNonQuery();
            SqlDataReader dr4 = komut0.ExecuteReader();
            while (dr4.Read())
            {
                BOLUMNOBULMASAYISI = dr4[0].ToString();
                BOLUMNOBULMASAYISIİNT = Convert.ToInt32(BOLUMNOBULMASAYISI);
                label28.Text = BOLUMNOBULMASAYISIİNT.ToString();
            }
            baglanti.Close();
        }
        public int AKADEMİSYENNOSUİNT;
        public String AKADEMİSYENNOSU;
        public void AKnobul()//AKADEMİSYEN NOSU BULMA
        {
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("select AKNO from AKADEMİSYENBİLGİ ", baglanti);
          
            komut0.ExecuteNonQuery();
            SqlDataReader dr4 = komut0.ExecuteReader();
            while (dr4.Read())
            {
                AKADEMİSYENNOSU = dr4[0].ToString();
                AKADEMİSYENNOSUİNT = Convert.ToInt32(AKADEMİSYENNOSU) + 1;
                label32.Text = AKADEMİSYENNOSUİNT.ToString();
            }
            baglanti.Close();
        }
        private void button5_Click(object sender, EventArgs e)//AKADEMİSYEN EKLE
        {
            if (textBoxAKAD.Text == "")
            {
                MessageBox.Show("ad boş bırakılamaz");
            }
            if (textBoxAKSOYAD.Text == "")
            {
                MessageBox.Show("soyad boş bırakılamaz");
            }
            if (textBoxAKTC.Text == "")
            {
                MessageBox.Show("tc boş bırakılamaz");
            }
            if (comboBoxAKaktifders.Text == "")
            {
                MessageBox.Show("aktif ders boş bırakılamaz");
            }
            if (comboBoxakbolum.Text == "")
            {
                MessageBox.Show("bölüm boş bırakılamaz");
            }
            if (textBoxakdogum.Text == "")
            {
                MessageBox.Show("doğum tarihi boş bırakılamaz");
            }
            if (textBoxAKŞİFRE.Text == "")
            {
                MessageBox.Show("şifre boş bırakılamaz");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into AKADEMİSYENBİLGİ (AD,SOYAD,DOGUM,TC,ŞİFRE,BOLUM,AKTİFDERS,AKNO) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@P8) ", baglanti);
                komut.Parameters.AddWithValue("@p1", textBoxAKAD.Text);
                komut.Parameters.AddWithValue("@p2", textBoxAKSOYAD.Text);
                komut.Parameters.AddWithValue("@p3", textBoxakdogum.Text);
                komut.Parameters.AddWithValue("@p4", textBoxAKTC.Text);
                komut.Parameters.AddWithValue("@p5", textBoxAKŞİFRE.Text);
                komut.Parameters.AddWithValue("@p6", BOLUMNOBULMASAYISIİNT);
                komut.Parameters.AddWithValue("@p7", AKAKTİFDERSNO);
                komut.Parameters.AddWithValue("@p8", label32.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("KAYIT YAPILDI");
                textBoxAKAD.Text = "";
                textBoxAKSOYAD.Text = "";
                textBoxAKTC.Text = "";
                textBoxAKŞİFRE.Text = "";
                comboBoxAKaktifders.Text = "";
                textBoxakdogum.Text = "";
                comboBoxakbolum.Text = "";
                baglanti.Close();
                AKnobul();
            }
        }
        public int OGNRNO;
        public void OGRnobul()//ÖĞRENCİ NOSU BUL +1 EKLE YENİ KAYIT YAP
        {
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("select NO from OGRENCİBİLGİLERİ ", baglanti);
            komut0.ExecuteNonQuery();
            SqlDataReader dr4 = komut0.ExecuteReader();
            while (dr4.Read())
            {
                OGNRNO = Convert.ToInt32(dr4[0])+1;
              

            }
            baglanti.Close();
        }
       
        public int ARANANBOLUMID;
        public void BOLUMIDBUL()//BOLUM ADINA GÖRE BOLUMNO BUL
        {
            baglanti.Open();
            SqlCommand KOMUT4 = new SqlCommand("SELECT BOLUMNO FROM BOLUMLER WHERE BOLUMAD=@P1", baglanti);
            KOMUT4.Parameters.AddWithValue("@P1",comboBoxogrbolum.Text);
            SqlDataReader DR = KOMUT4.ExecuteReader();
            while (DR.Read())
            {
                ARANANBOLUMID = Convert.ToInt32(DR[0]);
                
            }
            baglanti.Close();
        }


        public int BOLUMNOSU;
        public void BOLUMNUMARASIBUL()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select BOLUMNO FROM BOLUMLER WHERE BOLUMAD=@P1",baglanti);
            komut.Parameters.AddWithValue("@P1",comboBoxogrbolum.Text);
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                BOLUMNOSU = Convert.ToInt32(DR[0]);
                labelBOLUMNO.Text = BOLUMNOSU.ToString();
            }
            baglanti.Close();
        }


        private void comboBoxogrbolum_SelectedIndexChanged(object sender, EventArgs e)//bolum index değişimden sonra fonksiyonların çalışması ve yeni öğrenci için not alanı oluşturma için zemin hazırlanması
        {

            BOLUMNUMARASIBUL();
            

        }

        private void BTNÖĞRENCİEKLE_Click(object sender, EventArgs e)//öğrenci ekle
        {

            if (textBoxOGRAD.Text == "")
            {
                MessageBox.Show("ad alanı boş bırakılamaz!!");
            }
            if (textBoxOGRSOYAD.Text == "")
            {
                MessageBox.Show("soyad alanı boş bırakılamaz!!");
            }
            if (textBoxOGRDOGUMTARIHI.Text == "")
            {
                MessageBox.Show("dogum yılı alanı boş bırakılamaz!!");
            }
            if (textBoxOGRTC.Text == "")
            {
                MessageBox.Show("tc alanı boş bırakılamaz!!");
            }
            if (textBoxOGRNO.Text == "")
            {
                MessageBox.Show("öğrenci numara alanı boş bırakılamaz!!");
            }
            if (textBoxOGRSIFRE.Text == "")
            {
                MessageBox.Show("şifre alanı boş bırakılamaz!!");
            }
            if (comboBoxogryıl.Text == "")
            {
                MessageBox.Show("yıl bilgisi alanı boş bırakılamaz!!");
            }
            if (comboBoxogrbolum.Text == "")
            {
                MessageBox.Show("bolum alanı boş bırakılamaz!!");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into OGRENCİBİLGİLERİ (AD,SOYAD,OKULNO,TC,BOLUM,DOGUMYIL,EGITIMYIL,ŞİFRE,CİNSİYET,NO) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@P9,@p10) ", baglanti);
                komut.Parameters.AddWithValue("@p1", textBoxOGRAD.Text);
                komut.Parameters.AddWithValue("@p2", textBoxOGRSOYAD.Text);
                komut.Parameters.AddWithValue("@p3", textBoxOGRNO.Text);
                komut.Parameters.AddWithValue("@p4", textBoxOGRTC.Text);
                komut.Parameters.AddWithValue("@p5", labelBOLUMNO.Text);
                komut.Parameters.AddWithValue("@p6", textBoxOGRDOGUMTARIHI.Text);
                komut.Parameters.AddWithValue("@p7", comboBoxogryıl.Text);
                komut.Parameters.AddWithValue("@p8", textBoxOGRSIFRE.Text);
                komut.Parameters.AddWithValue("@p9", comboBoxCİNSİYET.Text);
                komut.Parameters.AddWithValue("@p10", OGNRNO);
                
                komut.ExecuteNonQuery();
                MessageBox.Show("KAYIT YAPILDI");
                textBoxOGRAD.Text = "";
                textBoxOGRSOYAD.Text = "";
                textBoxOGRNO.Text = "";
                textBoxOGRTC.Text = "";
                textBoxOGRDOGUMTARIHI.Text = "";
                comboBoxogryıl.Text = "";
                textBoxOGRSIFRE.Text = "";
                baglanti.Close();
                comboBoxCİNSİYET.Text = "";
                comboBoxogrbolum.Text = "";
                OGRnobul();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            aç();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aç();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            aç();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            aç();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            YNÖĞRENCİGÜNCELLE NM = new YNÖĞRENCİGÜNCELLE();
            NM.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            yöneticiöğrencisilme nm = new yöneticiöğrencisilme();
            nm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            yönetimakademisyensilme nm = new yönetimakademisyensilme();
            nm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            yöneticiakademisyengüncelleme bn = new yöneticiakademisyengüncelleme();
            bn.Show();
        }

        private void btnyeninoal_Click(object sender, EventArgs e)//yeni unique numara alımı
        {
            baglanti.Open();
            Random rastgele = new Random();
            int sayi = rastgele.Next(1000, 9999);
            textBoxOGRNO.Text = sayi.ToString();
            SqlCommand komut6 = new SqlCommand("select OKULNO from OGRENCİBİLGİLERİ ", baglanti);
            komut6.ExecuteNonQuery();
            SqlDataReader dr4 = komut6.ExecuteReader();
            while (dr4.Read())
            {
                if (textBoxOGRNO.Text == dr4[0].ToString())
                {

                    sayi = +1;
                    textBoxOGRNO.Text = sayi.ToString();

                    if (sayi > 9999)
                    {
                        sayi = -3;
                    }
                }
                else
                {

                }
            }
            baglanti.Close();
        }
        private void textBoxOGRTC_KeyUp(object sender, KeyEventArgs e)//tc keyup olduğunda şifre txt ye aktarma
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select TC from OGRENCİBİLGİLERİ", baglanti);
            komut3.ExecuteNonQuery();
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                if (textBoxOGRTC.Text == dr2[0].ToString())
                {
                    MessageBox.Show("bu tc daha önce kayıtlı bir öğrenciye ait !!!");
                    textBoxOGRTC.Text = "";
                }
            }
            baglanti.Close();
            textBoxOGRSIFRE.Text = textBoxOGRTC.Text;
        }

        private void textBoxAKTC_KeyUp(object sender, KeyEventArgs e)//akademisyen tc keyupı ve şifre aktarımı
        {
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select TC from AKADEMİSYENBİLGİ ", baglanti);
            komut9.ExecuteNonQuery();
            SqlDataReader dr3 = komut9.ExecuteReader();
            while (dr3.Read())
            {
                if (textBoxAKTC.Text == dr3[0].ToString())
                {
                    MessageBox.Show("bu tc ile kayıtlı bir akademisyen zaten var!!");
                    textBoxAKTC.Text = "";
                }
            }
            textBoxAKŞİFRE.Text = textBoxAKTC.Text;
            baglanti.Close();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            YÖNLENDİRİCİ gh = new YÖNLENDİRİCİ();

            gh.Show();
        }
        public void comboBoxakbolum_SelectedIndexChanged(object sender, EventArgs e)//seçilen index değişince bolum nosu bulma
        {
            bolumnobul();
        }
        public int akademisyenaktifders;
        public void SEÇİLENDERNOSUNUL()
        {
            baglanti.Open();
            SqlCommand KOMUT = new SqlCommand("select DERSNO FROM DERSLERBİLGİ WHERE DERASAD=@P1",baglanti);
            KOMUT.Parameters.AddWithValue("@P1",comboBoxAKaktifders.Text);
            SqlDataReader DR = KOMUT.ExecuteReader();

            while (DR.Read())
            {

                akademisyenaktifders = Convert.ToInt32(DR[0]);


            }
            baglanti.Close();
        }
        private void comboBoxAKaktifders_SelectedIndexChanged(object sender, EventArgs e)//seçilen index değişince aktifders nosu bulma
        {
            SEÇİLENDERNOSUNUL();
            
            label29.Text = akademisyenaktifders.ToString();
        }

        private void textBoxOGRAD_TextChanged(object sender, EventArgs e)
        {
            harfbüyüt(textBoxOGRAD);
        }

        private void textBoxOGRSOYAD_TextChanged(object sender, EventArgs e)
        {
            harfbüyüt(textBoxOGRSOYAD);
        }

        private void textBoxAKAD_TextChanged(object sender, EventArgs e)
        {
            harfbüyüt(textBoxAKAD);
        }

        private void textBoxAKSOYAD_TextChanged(object sender, EventArgs e)
        {
            harfbüyüt(textBoxAKSOYAD);
        }

        private void textBoxAKAD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxAKSOYAD.Focus();
            }
        }

        private void textBoxAKSOYAD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxAKTC.Focus();
            }
        }

        private void textBoxAKTC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxakdogum.Focus();
            }
        }
        private void textBoxOGRAD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxOGRSOYAD.Focus();
            }
        }

        private void textBoxOGRSOYAD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxOGRTC.Focus();
            }
        }

        private void textBoxOGRTC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxOGRDOGUMTARIHI.Focus();
            }
        }
        private void comboBoxCİNSİYET_TextChanged(object sender, EventArgs e)
        {
            textBoxOGRAD.Focus();
        }
        public int bolum;
        public void comboBoxakbolum_TextChanged(object sender, EventArgs e)
        {
            bolumgetirfonksiyom bn = new bolumgetirfonksiyom();
            bn.comboyadersekle(comboBoxakbolum, comboBoxAKaktifders);
            label28.Text = bolum.ToString();

        }
        private void label36_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxogrbolum_Leave(object sender, EventArgs e)
        {
            BOLUMNUMARASIBUL();
        }
        public int AKBOLLUMNOSU;
        public void BOLUMNUMARASIBULAK()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select BOLUMNO FROM BOLUMLER WHERE BOLUMAD=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBoxakbolum.Text);
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                AKBOLLUMNOSU = Convert.ToInt32(DR[0]);
                labelBOLUMNO.Text = AKBOLLUMNOSU.ToString();
            }
            baglanti.Close();
        }
        public int AKAKTİFDERSNO;
        public void akdersıdbul()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select DERSNO FROM DERSLERBİLGİ WHERE DERASAD=@P1 AND BOLUMID=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1",comboBoxAKaktifders.Text);
            komut.Parameters.AddWithValue("@P2",AKBOLLUMNOSU);
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                AKAKTİFDERSNO = Convert.ToInt32(DR[0]);
                labelAKAKTİFDERSNO.Text = AKAKTİFDERSNO.ToString();
            }
            baglanti.Close();
        }
        private void comboBoxAKaktifders_Leave(object sender, EventArgs e)
        {
            akdersıdbul();
        }

        private void comboBoxakbolum_Leave(object sender, EventArgs e)
        {
            BOLUMNUMARASIBULAK();
        }
    }
}
