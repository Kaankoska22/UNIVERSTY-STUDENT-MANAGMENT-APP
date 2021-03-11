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
    public partial class akademisyenekranı : Form
    {
        public akademisyenekranı()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        public string akad;
        public string akşifre;
        public string aktc;
        public int dersıd;
        public string notnosuyaz;
        public void DERSIDÖĞREN()//COMBOXDAN SEÇİLEN DERS ID ÖĞRENME
        {
            AKBOLUMBUL();
            baglanti.Open();
            SqlCommand KOMUT5 = new SqlCommand("SELECT DERSNO FROM DERSLERBİLGİ WHERE BOLUMID=@P1 and DERASAD=@P2", baglanti);
            KOMUT5.Parameters.AddWithValue("@P1", bolumıd);
            KOMUT5.Parameters.AddWithValue("@P2", LBLAKAKTİFDERS.Text);
            SqlDataReader dr3 = KOMUT5.ExecuteReader();
            while (dr3.Read())
            {
                dersıd = Convert.ToInt32(dr3[0]);

            }
            baglanti.Close();

        }
       
        public void datagrideveriat()//DATA GRİDE ÖNCEDEN KAYDI AÇILMIŞ DERLERİ ATAR
        {
            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("select BOLUMAD,DERASAD,AD,SOYAD,EGITIMYIL,S1 AS SINAV1,S2  AS SINAV2,S3  AS SINAV3,ORTALAMA,DURUM,OKULNO FROM NOTBİLGİLERİ INNER JOIN BOLUMLER ON NOTBİLGİLERİ.BOLUMID=BOLUMLER.BOLUMNO INNER JOIN DERSLERBİLGİ ON DERSLERBİLGİ.DERSNO = NOTBİLGİLERİ.DERSID INNER JOIN OGRENCİBİLGİLERİ ON OGRENCİBİLGİLERİ.NO = NOTBİLGİLERİ.OGRID where DERASAD=@P1 and BOLUMNO=@P2 ", baglanti);
            komut6.Parameters.AddWithValue("@P1", LBLAKAKTİFDERS.Text);
            komut6.Parameters.AddWithValue("@P2", bolumıd);
            SqlDataAdapter da = new SqlDataAdapter(komut6);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;



            baglanti.Close();
        }
        public void DATAGRİDEBİLGİATMA()//DATA GRİDE O DERSİ ALAN ÖĞRENCİ BİLGİLERİNİ ATAR
        {
            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("select NO AS ID,OKULNO,AD,SOYAD,BOLUMAD,EGITIMYIL  FROM OGRENCİBİLGİLERİ INNER JOIN BOLUMLER ON OGRENCİBİLGİLERİ.BOLUM=BOLUMLER.BOLUMNO WHERE BOLUMNO=@P1  ", baglanti);
            komut6.Parameters.AddWithValue("@P1", bolumıd);
            SqlDataAdapter da = new SqlDataAdapter(komut6);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;



            baglanti.Close();


        }
       
        private void akademisyenekranı_Load(object sender, EventArgs e)//EKRAN YÜKLENİRKEN AKADEMİSYEN BİLGİLERİ DATA GRİD VE COMBOXLARIN DOLUMU
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBoxaçılıcaknots1.Text = "0";
            textBoxacılıcaknots2.Text = "0";
            textBoxaçılıcaknots3.Text = "0";
            ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI bn = new ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI();
            labelOGRID.Text ="0";
            OGRID = Convert.ToInt32(labelOGRID.Text);
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("select AD,SOYAD,DOGUM,TC,BOLUMAD,DERASAD from AKADEMİSYENBİLGİ INNER JOIN BOLUMLER ON BOLUMLER.BOLUMNO=AKADEMİSYENBİLGİ.BOLUM INNER JOIN DERSLERBİLGİ ON DERSLERBİLGİ.DERSNO=AKADEMİSYENBİLGİ.AKTİFDERS where AD=@p1 and ŞİFRE=@p2 ", baglanti);
            komut1.Parameters.AddWithValue("@p1", akad);
            komut1.Parameters.AddWithValue("@p2", akşifre);

            SqlDataReader dt = komut1.ExecuteReader();

            while (dt.Read())
            {
                lblAKad.Text = dt[0].ToString();
                lblAKsoyad.Text = dt[1].ToString();
                LBLAKAKTİFDERS.Text = dt[5].ToString();
                lblAKTc.Text = dt[3].ToString();
                lblAKdogum.Text = dt[2].ToString();
                labelAKBOLUM.Text = dt[4].ToString();
                textBoxNOTGİRİLECEKDERS.Text= dt[5].ToString();

            }

            baglanti.Close();
            AKBOLUMBUL();
            DATAGRİDEBİLGİATMA();
            

           
            DERSIDÖĞREN();
            datagrideveriat();
            bn.SONNOTNOSUBUL(textBox5);
            



        }
       
        public int bolumıd;
        public void AKBOLUMBUL()//AKADEMİSYEN BÖLÜM ADINDAN BOLMIDSİ BULMA
        {
            baglanti.Open();
            SqlCommand KOMUT5 = new SqlCommand("SELECT BOLUMNO FROM BOLUMLER WHERE BOLUMAD=@P1", baglanti);
            KOMUT5.Parameters.AddWithValue("@P1", labelAKBOLUM.Text);
            SqlDataReader dr3 = KOMUT5.ExecuteReader();
            while (dr3.Read())
            {
                bolumıd = Convert.ToInt32(dr3[0]);
                label21.Text = bolumıd.ToString();
            }
            baglanti.Close();

        


    }
        public string NOTNOSU;
        public string textbox1deg;
    private void button5_Click(object sender, EventArgs e)//BUTON SORGULA VE NOT BİLGİLERİ GETİR
        {
            ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI bn = new ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI();
            bn.ÖĞRENCİBİLGİGETİRME(maskedTextBoxGÜNCELLENİCEKDEGER ,labelADISONUÇ,labelSOYADISONUÇ);
            bn.OGRENCİNOTGETİRME(dersıd,maskedTextBoxGÜNCELLENİCEKDEGER,textBox1,textBox2,textBox3,textBox4,labelDURUM,label15);
        }

        private void button1_Click(object sender, EventArgs e)//GÜNCELLEME EKRANI AÇAR
        {
            güncellemeekranıakademisyen gn = new güncellemeekranıakademisyen();
            gn.aktc1 = lblAKTc.Text;
            gn.Show();
        }

        private void button2_Click(object sender, EventArgs e)//GÜNCELLEME EKRANI AÇAR
        {
            güncellemeekranıakademisyen gn = new güncellemeekranıakademisyen();
            gn.aktc1 = lblAKTc.Text;
            gn.Show();
        }

        private void button7_Click(object sender, EventArgs e)//GÜNCELLEME EKRANI AÇAR
        {
            güncellemeekranıakademisyen gn = new güncellemeekranıakademisyen();
            gn.aktc1 = lblAKTc.Text;
            gn.Show();
        }

        private void button4_Click(object sender, EventArgs e)//GÜNCELLEME EKRANI AÇAR
        {
            güncellemeekranıakademisyen gn = new güncellemeekranıakademisyen();
            gn.aktc1 = lblAKTc.Text;
            gn.Show();
        }

        private void button8_Click(object sender, EventArgs e)//GÜNCELLEME EKRANI AÇAR
        {
            güncellemeekranıakademisyen gn = new güncellemeekranıakademisyen();
            gn.aktc1 = lblAKTc.Text;
            gn.Show();
        }

        private void comboBoxAKaktifders_SelectedIndexChanged(object sender, EventArgs e)//AKTİF DERS İNDEX DEĞİŞTİĞİ ZAMAN MESAJ VERİR
        {
            MessageBox.Show("aktif olarak verdiğiniz dersi değiştirmek için sekreterlik ile görüşün!!!");
        }

        private void button3_Click(object sender, EventArgs e)//GERİ DÖN BUTONU
        {
            this.Hide();
            ANAGİRİŞ vb = new ANAGİRİŞ();
            vb.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//DATAGRİD CELL CLİCK İLE TEXTBOXLARA VERİ ATAR
        {
            ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI bn = new ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI();
            maskedTextBoxGÜNCELLENİCEKDEGER.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            bn.OGRENCİNOTGETİRME(dersıd, maskedTextBoxGÜNCELLENİCEKDEGER, textBox1, textBox2, textBox3, textBox4, labelDURUM, label15);
            bn.ÖĞRENCİBİLGİGETİRME(maskedTextBoxGÜNCELLENİCEKDEGER, labelADISONUÇ, labelSOYADISONUÇ);
            
        }
     
        private void labelDURUM_TextChanged(object sender, EventArgs e)//TEXT CHANGE OLUNCA RENK DEĞİŞTİRİR
        {
            if (labelDURUM.Text == "GEÇTİ")
            {
                labelDURUM.BackColor = Color.Green;
            }
            if (labelDURUM.Text == "KALDI")
            {
                labelDURUM.BackColor = Color.Red;
            }
        }
        public  Double ORT;
        public int S1;
        public int S2;
        public int S3;
        public void ORTHESAPLA(TextBox A, TextBox B, TextBox C,TextBox D,TextBox Z)//ORT HESAPLA FONKSİYONU
        {
            S1 =Convert.ToInt32(A.Text);
            S2 = Convert.ToInt32(B.Text);
            S3 = Convert.ToInt32(C.Text);
            if (B.Text != "0" && C.Text != "0")
            {
                ORT = (S1 + S2 + S3) / 3;
                D.Text = ORT.ToString();
                if (ORT > 50)
                {
                    Z.Text = "GEÇTİ";
                }
                else
                {
                    Z.Text = "KALDI";
                }
            }
            else
            {
                Z.Text = "EKSİK";
                ORT = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)//NOT GÜNCELLEME BUTONU
        {
            if (maskedTextBoxGÜNCELLENİCEKDEGER.Text!=""&& labelADISONUÇ.Text!=""&&label15.Text!="")
            {
                ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI bn = new ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI();
                baglanti.Open();
                SqlCommand komut5 = new SqlCommand("update NOTBİLGİLERİ SET S1=@P1,S2=@P2,S3=@P3,ORTALAMA=@P4,DURUM=@P5 WHERE NOTNO=@P6", baglanti);
                komut5.Parameters.AddWithValue("@P6", label15.Text);
                komut5.Parameters.AddWithValue("@P1", textBox1.Text);
                komut5.Parameters.AddWithValue("@P5", labelDURUM.Text);
                komut5.Parameters.AddWithValue("@P2", textBox2.Text);
                komut5.Parameters.AddWithValue("@P3", textBox3.Text);
                komut5.Parameters.AddWithValue("@P4", textBox4.Text);
                komut5.ExecuteNonQuery();
                MessageBox.Show("NOTLAR GÜNCELLENDİ!!!");

                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                labelDURUM.Text = "";
                textBox4.Text = "";
                labelSOYADISONUÇ.Text = "";
                labelADISONUÇ.Text = "";
                maskedTextBoxGÜNCELLENİCEKDEGER.Text = "";
                baglanti.Close();
                bn.OGRENCİNOTGETİRME(dersıd, maskedTextBoxGÜNCELLENİCEKDEGER, textBox1, textBox2, textBox3, textBox4, labelDURUM, label15);
            }
            else
            {
                MessageBox.Show("BOŞ KAYIT OLUŞTURULAMAZ");
            }
           
            
            datagrideveriat();
        }

        private void textBox1_Leave(object sender, EventArgs e)//LEAVE OLDUĞU ZAMAN ORT HESAPLA
        {
            ORTHESAPLA(textBox1, textBox2, textBox3, textBox4, labelDURUM);
        }

        private void textBox2_Leave(object sender, EventArgs e)//LEAVE OLDUĞU ZAMAN ORT HESAPLA
        {
            ORTHESAPLA(textBox1, textBox2, textBox3, textBox4, labelDURUM);
        }

        private void textBox3_Leave(object sender, EventArgs e)//LEAVE OLDUĞU ZAMAN ORT HESAPLA
        {
            ORTHESAPLA(textBox1, textBox2, textBox3, textBox4, labelDURUM);
        }

        private void maskedTextBoxGÜNCELLENİCEKDEGER_TextChanged(object sender, EventArgs e)//ÖĞRENCİ IDSİ DEĞİŞİNCE BİLGİLERİ GETİR
        {
            ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI bn = new ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI();
            bn.ÖĞRENCİBİLGİGETİRME(maskedTextBoxGÜNCELLENİCEKDEGER, labelADISONUÇ, labelSOYADISONUÇ);
            bn.OGRENCİNOTGETİRME(dersıd,maskedTextBoxGÜNCELLENİCEKDEGER, textBox1, textBox2, textBox3, textBox4, labelDURUM, label15);
        }
       
        private void dataGridView3_CellClick_1(object sender, DataGridViewCellEventArgs e)//CELL CLİCK OLUNCA BİLGİLERİ TEXTBOXLARA AKTAR
        {
            LABELÖGRAD.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            LABELOGRSOYAD.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            LABELOGRNO.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            labelOGRID.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            LABELOGRBOLUM.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            LABELOGRSINIFYILI.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            labelaçılıcaknotdurum.Text = null;
            textBoxaçılıcaknots1.Text = "0";
            textBoxacılıcaknots2.Text = "0";
            labelöncekinotnoları.Text = "0";
            textBoxaçılıcaknots3.Text = "0";
            textBoxaçılıcaknotort.Text = "0";
            OGRENCİNOSAYISIOĞRENME();
        }
        public int OGRID;
        public string ogrıd;
        public string A;
        private void labelOGRID_TextChanged(object sender, EventArgs e)//ID DEĞİŞİNCE O İD Yİ VERİ TABANINDA SORGULA VE EĞER DAHA ÖNCE KAYITLI NOT VARSA GÜNCELLEME ALANINA GÖNDER
        {
            OGRENCİNOSAYISIOĞRENME();
            ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI nh = new ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI();
            ogrıd = labelOGRID.Text;
           
            nh.NOTKONTROL(ogrıd, dersıd);
            ogrıd = nh.ogrenciıdsı.ToString();
            if (ogrıd=="22222")
            {
                labelOGRID.Text = "0";
                if (labelOGRID.Text == "0")
                {
                    LABELOGRBOLUM.Text = "";
                    LABELOGRNO.Text = "";
                    LABELOGRSINIFYILI.Text = "";
                    LABELOGRSOYAD.Text = "";
                    LABELÖGRAD.Text = "";
                }
                
               
            }
           
        }
        public int SONNOTNO;
        public int sonnotsayısı;
        
        public void OGRENCİNOSAYISIOĞRENME()//ÖNCEDEN VERİ TABANINA KAYITLI FARKLI DERSLERİ ÖĞRENME
        {
            baglanti.Open();
            SqlCommand KOMUT = new SqlCommand("SELECT OGRENCİNOTSAYISI FROM NOTBİLGİLERİ WHERE  OGRENCİNO=@P4", baglanti);
            KOMUT.Parameters.AddWithValue("@P4",LABELOGRNO.Text);
            SqlDataReader dr = KOMUT.ExecuteReader();
            while (dr.Read())
            {

                sonnotsayısı = Convert.ToInt32(dr[0]);
                if (labelöncekinotnoları.Text == "0")
                {
                    
                   
                    labelöncekinotnoları.Text = "1";
                }
                else
                {
                    sonnotsayısı = Convert.ToInt32(dr[0])+1;
                    labelöncekinotnoları.Text = sonnotsayısı.ToString();
                }
                
            }
            baglanti.Close();
        }
        



      
        private void button5_Click_1(object sender, EventArgs e)//not bölümü aç girişyap
        {
            if (LABELÖGRAD.Text!="NULL" && labelOGRID.Text!="NULL"&&textBoxaçılıcaknotort.Text!=""&&labelaçılıcaknotdurum.Text!="")
            {
                ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI bn = new ÖĞRENCİNOTKAYITAÇMAFONKSİYONLARI();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into NOTBİLGİLERİ (DERSID,BOLUMID,S1,S2,S3,DURUM,ORTALAMA,OGRID,NOTNO,OGRENCİNO,OGRENCİNOTSAYISI) VALUES(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11)", baglanti);
                komut.Parameters.AddWithValue("@P1", dersıd);
                komut.Parameters.AddWithValue("@P2", bolumıd);
                komut.Parameters.AddWithValue("@P3", textBoxaçılıcaknots1.Text);
                komut.Parameters.AddWithValue("@P4", textBoxacılıcaknots2.Text);
                komut.Parameters.AddWithValue("@P5", textBoxaçılıcaknots3.Text);
                komut.Parameters.AddWithValue("@P6", labelaçılıcaknotdurum.Text);
                komut.Parameters.AddWithValue("@P7", textBoxaçılıcaknotort.Text);
                komut.Parameters.AddWithValue("@P8", ogrıd);
                komut.Parameters.AddWithValue("@P9", textBox5.Text);
                komut.Parameters.AddWithValue("@P10", LABELOGRNO.Text);
                komut.Parameters.AddWithValue("@P11", labelöncekinotnoları.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("not girişi yapıldı!!");
                labelaçılıcaknotdurum.Text = null;
                textBoxaçılıcaknots1.Text = "0";
                textBoxacılıcaknots2.Text = "0";
                labelöncekinotnoları.Text = "0";
                textBoxaçılıcaknots3.Text = "0";
                textBoxaçılıcaknotort.Text = "0";
                bn.SONNOTNOSUBUL(textBox5);

                baglanti.Close();
            }
            else
            {
                MessageBox.Show("BOŞ KAYIT OLUŞTURULAMAZ");
            }
           
            datagrideveriat();
            OGRENCİNOSAYISIOĞRENME();
        }

        private void textBoxaçılıcaknots1_Leave(object sender, EventArgs e)//ORTHESAPLA
        {
            ORTHESAPLA(textBoxaçılıcaknots1,textBoxacılıcaknots2, textBoxaçılıcaknots3, textBoxaçılıcaknotort, labelaçılıcaknotdurum);
        }

        private void textBoxacılıcaknots2_Leave(object sender, EventArgs e)//ORTHESAPLA
        {
            ORTHESAPLA(textBoxaçılıcaknots1, textBoxacılıcaknots2, textBoxaçılıcaknots3, textBoxaçılıcaknotort, labelaçılıcaknotdurum);
        }

        private void textBoxaçılıcaknots3_Leave(object sender, EventArgs e)//ORTHESAPLA
        {
            ORTHESAPLA(textBoxaçılıcaknots1, textBoxacılıcaknots2, textBoxaçılıcaknots3, textBoxaçılıcaknotort, labelaçılıcaknotdurum);
        }

        private void labelaçılıcaknotdurum_TextChanged(object sender, EventArgs e)//DURUMA GÖRE RENK DEĞİŞ
        {
            if (labelaçılıcaknotdurum.Text == "GEÇTİ")
            {
                labelaçılıcaknotdurum.BackColor = Color.Green;
            }
            if (labelaçılıcaknotdurum.Text == "KALDI")
            {
                labelaçılıcaknotdurum.BackColor = Color.Red;
            }
        }

    }

}
