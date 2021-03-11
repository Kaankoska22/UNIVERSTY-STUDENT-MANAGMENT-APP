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
    public partial class YÖNETİMBOLUMAÇ : Form
    {
        public YÖNETİMBOLUMAÇ()
        {
            InitializeComponent();
        }
        public string adı;
        public string şifre;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        public void harfbüyüt(TextBox a)
        {


            a.Text = a.Text.ToUpper();
            a.SelectionStart = a.Text.Length;



        }


        private void button1_Click(object sender, EventArgs e)
        {
           
          
               
                this.Hide();
           

           
        }
        public void LEAVEOLDUĞUZAMANBOLUMIDBULMA()
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select BOLUMNO FROM BOLUMLER where BOLUMAD=@P2", baglanti);
            komut2.Parameters.AddWithValue("@P2", textBoxAD.Text);
            komut2.ExecuteNonQuery();
            SqlDataReader DR = komut2.ExecuteReader();
            while (DR.Read())
            {
                labelBOLUMID.Text = DR[0].ToString();
            }
            baglanti.Close();




        }

        public void COMBODOLDUR(ComboBox A)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select DERASAD FROM DERSLERBİLGİ where BOLUMID=@P2",baglanti);
            komut2.Parameters.AddWithValue("@P2",labelBOLUMID.Text);
            komut2.ExecuteNonQuery();
            SqlDataReader DR = komut2.ExecuteReader();
            while (DR.Read())
            {
                A.Items.Add(DR[0]);
            }
            baglanti.Close();
        
        
        
        }
        public string EKLENİCEKBÖLÜMAD;
        private void YÖNETİMBOLUMAÇ_Load(object sender, EventArgs e)
        {
            textBoxAD.Text = EKLENİCEKBÖLÜMAD;
            COMBODOLDUR(comboBoxders1);
            COMBODOLDUR(comboBoxders2);
            COMBODOLDUR(comboBoxders3);
            COMBODOLDUR(comboBoxders4);
            COMBODOLDUR(comboBoxders5);
            COMBODOLDUR(comboBoxders6);
            COMBODOLDUR(comboBoxders7);
            COMBODOLDUR(comboBoxders8);
            DERSNOAL();
            sonsayıöğren();
            textBoxAD.Focus();
        }

        private void textBoxAD_TextChanged(object sender, EventArgs e)
        {
            SORGULA();
            harfbüyüt(textBoxAD);
           
        }



       

       
        public int bolumıd;
     
      
        public String ÖNCEKİDERSNO;
        public int EKLENİCEKDERSNO;
        public void DERSNOAL()
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select DERSNO FROM DERSLERBİLGİ ", baglanti);
            komut4.ExecuteNonQuery();
            SqlDataReader DR = komut4.ExecuteReader();

            while (DR.Read())
            {

                ÖNCEKİDERSNO = DR[0].ToString();
                
                EKLENİCEKDERSNO = Convert.ToInt32(ÖNCEKİDERSNO) + 1;
                label18.Text = EKLENİCEKDERSNO.ToString();


            }
            baglanti.Close();



        }
      
        public void harfküçült(TextBox b)
        {
            b.Text = b.Text.ToLower();
            b.SelectionStart = b.Text.Length;

        }
       

        
    

      

        public string SONSAYI;
        public int eklenicek;
        public void sonsayıöğren()
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select BOLUMNO FROM BOLUMLER ",baglanti);
            komut4.ExecuteNonQuery();
            SqlDataReader DR = komut4.ExecuteReader();

            while (DR.Read())
            {
               
                    SONSAYI = DR[0].ToString();
                    label16.Text = SONSAYI.ToString();
                    eklenicek = Convert.ToInt32(SONSAYI)+1;
                    label17.Text = eklenicek.ToString();


            }
            baglanti.Close();
        
        
        }




       
        private void buttonEKLE_Click(object sender, EventArgs e)
        {

            bolumgetirfonksiyom bh = new bolumgetirfonksiyom();
            bh.ÖYLEBÖLÜMVARMI(textBoxAD);


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into BOLUMLER (BOLUMAD,BOLUMDERS1,BOLUMDERS2,BOLUMDERS3,BOLUMDERS4,BOLUMDERS5,BOLUMDERS6,BOLUMDERS7,BOLUMDERS8,BOLUMÇEŞİT,SINIFYILI,BOLUMNO) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@P9,@P10,@P11,@P12) ", baglanti);
            komut2.Parameters.AddWithValue("@p1", textBoxAD.Text);
            komut2.Parameters.AddWithValue("@p2", comboBoxders1.Text);
            komut2.Parameters.AddWithValue("@p3", comboBoxders2.Text);
            komut2.Parameters.AddWithValue("@p4", comboBoxders3.Text);
            komut2.Parameters.AddWithValue("@p5", comboBoxders4.Text);
            komut2.Parameters.AddWithValue("@p6", comboBoxders5.Text);
            komut2.Parameters.AddWithValue("@p7", comboBoxders6.Text);
            komut2.Parameters.AddWithValue("@p8", comboBoxders7.Text);
            komut2.Parameters.AddWithValue("@p9", comboBoxders8.Text);
            komut2.Parameters.AddWithValue("@P10", comboBoxBOLUMÇEŞİDİ.Text);
            komut2.Parameters.AddWithValue("@P11", comboBox1.Text);
            komut2.Parameters.AddWithValue("@P12", eklenicek);
            komut2.ExecuteNonQuery();
            MessageBox.Show("BÖLÜM AÇILDI DERSLER EKLENDİ");
            
            comboBoxBOLUMÇEŞİDİ.Text = "";
            comboBox1.Text = "";
            baglanti.Close();

           
         
        }

        private void textBoxAD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                comboBoxBOLUMÇEŞİDİ.Focus();
            }
        }

        public void SORGULA()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from BOLUMLER where BOLUMAD=@P1 ", baglanti);
            komut.Parameters.AddWithValue("@P1", textBoxAD.Text);
            komut.ExecuteNonQuery();
            SqlDataReader dr5 = komut.ExecuteReader();
            while (dr5.Read())
            {
                textBoxAD.Text = dr5[1].ToString();
                comboBoxBOLUMÇEŞİDİ.Text = dr5[10].ToString();
                comboBox1.Text = dr5[11].ToString();
                comboBoxders1.Text = dr5[2].ToString();
                comboBoxders2.Text = dr5[3].ToString();
                comboBoxders3.Text = dr5[4].ToString();
                comboBoxders4.Text = dr5[5].ToString();
                comboBoxders5.Text = dr5[6].ToString();
                comboBoxders6.Text = dr5[7].ToString();
                comboBoxders7.Text = dr5[8].ToString();
                comboBoxders8.Text = dr5[9].ToString();

            }

            baglanti.Close();
        }



        private void button3_Click(object sender, EventArgs e)//btn bölüm sorgula
        {
            COMBODOLDUR(comboBoxders1);
            COMBODOLDUR(comboBoxders2);
            COMBODOLDUR(comboBoxders3);
            COMBODOLDUR(comboBoxders4);
            COMBODOLDUR(comboBoxders5);
            COMBODOLDUR(comboBoxders6);
            COMBODOLDUR(comboBoxders7);
            COMBODOLDUR(comboBoxders8);
            SORGULA();


        }

        public void GÜN()
        {
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("update BOLUMLER set BOLUMAD=@P1,BOLUMDERS1=@P2,BOLUMDERS2=@P3,BOLUMDERS3=@P4,BOLUMDERS4=@P5,BOLUMDERS5=@P6,BOLUMDERS6=@P7,BOLUMDERS7=@P8,BOLUMDERS8=@P9,BOLUMÇEŞİT=@P10,SINIFYILI=@P11 WHERE BOLUMAD=@P111", baglanti);
            komut6.Parameters.AddWithValue("@P111", textBoxAD.Text);
            komut6.Parameters.AddWithValue("@P1", textBoxAD.Text);
            komut6.Parameters.AddWithValue("@P10", comboBoxBOLUMÇEŞİDİ.Text);
            komut6.Parameters.AddWithValue("@P11", comboBox1.Text);
            komut6.Parameters.AddWithValue("@P2", comboBoxders1.Text);
            komut6.Parameters.AddWithValue("@P3", comboBoxders2.Text);
            komut6.Parameters.AddWithValue("@P4", comboBoxders3.Text);
            komut6.Parameters.AddWithValue("@P5", comboBoxders4.Text);
            komut6.Parameters.AddWithValue("@P6", comboBoxders5.Text);
            komut6.Parameters.AddWithValue("@P7", comboBoxders6.Text);
            komut6.Parameters.AddWithValue("@P8", comboBoxders7.Text);
            komut6.Parameters.AddWithValue("@P9", comboBoxders8.Text);
            komut6.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("BÖLÜM GNCELLENDİ!!!");
            comboBoxBOLUMÇEŞİDİ.Text = "";
            comboBox1.Text = "";
            comboBoxders1.Text = "";
            comboBoxders2.Text = "";
            comboBoxders3.Text = "";
            comboBoxders4.Text = "";
            comboBoxders5.Text = "";
            comboBoxders6.Text = "";
            comboBoxders7.Text = "";
            comboBoxders8.Text = "";
            textBoxAD.Text = "";
        }
        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            GÜN();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GÜN();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GÜN();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GÜN();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GÜN();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GÜN();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GÜN();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GÜN();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GÜN();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GÜN();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GÜN();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VAROLANBÖLÜMLER NB = new VAROLANBÖLÜMLER();
            NB.Show();

        }

        private void button14_Click(object sender, EventArgs e)//BÖLÜMÜ SİL
        {
            if (MessageBox.Show("BU BÖLÜMÜ SİLMEK İSTEDİĞİNİZE EMİNMİSİNİZ???", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut4 = new SqlCommand("delete from BOLUMLER WHERE BOLUMAD=@P1", baglanti);
                komut4.Parameters.AddWithValue("@P1", textBoxAD.Text);
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("BÖLÜM SİLİNDİ");
                comboBoxBOLUMÇEŞİDİ.Text = "";
                comboBoxders1.Items.Clear();
                comboBoxders2.Items.Clear();
                comboBoxders3.Items.Clear();
                comboBoxders4.Items.Clear();
                comboBoxders5.Items.Clear();
                comboBoxders6.Items.Clear();
                comboBoxders7.Items.Clear();
                comboBoxders8.Items.Clear();
                comboBoxBOLUMÇEŞİDİ.Text = "";
                comboBox1.Text = "";
               
               
               


            }
           
           
        }

        private void comboBoxBOLUMÇEŞİDİ_MouseDown(object sender, MouseEventArgs e)
        {
              
            bolumgetirfonksiyom bh = new bolumgetirfonksiyom();
           
            bh.ÖYLEBÖLÜMVARMI(textBoxAD);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AKTİFOLANDERSLER VC = new AKTİFOLANDERSLER();
            VC.Show();
        }

        private void comboBoxBOLUMÇEŞİDİ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            YENİDERSAÇ NB = new YENİDERSAÇ();
            NB.Show();
            
        }

        private void comboBoxders1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxAD_Leave(object sender, EventArgs e)
        {
            LEAVEOLDUĞUZAMANBOLUMIDBULMA();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            comboBoxders1.Items.Clear();
            comboBoxders2.Items.Clear();
            comboBoxders3.Items.Clear();
            comboBoxders4.Items.Clear();
            comboBoxders5.Items.Clear();
            comboBoxders6.Items.Clear();
            comboBoxders7.Items.Clear();
            comboBoxders8.Items.Clear();
            COMBODOLDUR(comboBoxders1);
            COMBODOLDUR(comboBoxders2);
            COMBODOLDUR(comboBoxders3);
            COMBODOLDUR(comboBoxders4);
            COMBODOLDUR(comboBoxders5);
            COMBODOLDUR(comboBoxders6);
            COMBODOLDUR(comboBoxders7);
            COMBODOLDUR(comboBoxders8);
            DERSNOAL();
            sonsayıöğren();
        }
    }


    
}
