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
    public partial class YENİDERSAÇ : Form
    {
        public YENİDERSAÇ()
        {
            InitializeComponent();
        }
        public void harfBÜYÜT(TextBox b)
        {
            b.Text = b.Text.ToUpper();
            b.SelectionStart = b.Text.Length;

        }


        public int ÖNCEKINO;
        public void DERSNOAL()
        {
            baglanti.Open();
            SqlCommand KOMUT = new SqlCommand("SELECT DERSNO FROM DERSLERBİLGİ", baglanti);
            SqlDataReader DR = KOMUT.ExecuteReader();
            while (DR.Read())
            {
                ÖNCEKINO = Convert.ToInt32(DR[0]) + 1;
                label4.Text = ÖNCEKINO.ToString();

            }

            baglanti.Close();
        }


        private void YENİDERSAÇ_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'bEYKENTÜNİVERSTESİ1DataSet10.BOLUMLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bOLUMLERTableAdapter.Fill(this.bEYKENTÜNİVERSTESİ1DataSet10.BOLUMLER);
            // TODO: Bu kod satırı 'bEYKENTÜNİVERSTESİ1DataSet9.DERSLERBİLGİ' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dERSLERBİLGİTableAdapter.Fill(this.bEYKENTÜNİVERSTESİ1DataSet9.DERSLERBİLGİ);
            DERSNOAL();

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)//DATA GRİDE VERİ EKLE
        {
           
        }
        public int bolumıdsi;
        public void bolumıdbul()
        {
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select BOLUMNO FROM BOLUMLER WHERE BOLUMAD=@P2",baglanti);
            komut5.Parameters.AddWithValue("@P2",comboBox1.Text);
            SqlDataReader DR = komut5.ExecuteReader();
            while (DR.Read())
            {
                bolumıdsi = Convert.ToInt32(DR[0]);
                labelaçılıcakdersinbolumıdsı.Text = bolumıdsi.ToString();
            }

            baglanti.Close();
        
        
        }
        public void EKLE()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into DERSLERBİLGİ (DERASAD,DERSNO,BOLUMID) VALUES(@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", textBox1.Text);
            komut.Parameters.AddWithValue("@P2", ÖNCEKINO);
            komut.Parameters.AddWithValue("@P3", labelaçılıcakdersinbolumıdsı.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Text = "";
            MessageBox.Show("DERS EKLENDİ!!");
            DERSNOAL();
        }
        private void button2_Click(object sender, EventArgs e)//EKLE BUTON
        {
            EKLE();
        }

        private void button3_Click(object sender, EventArgs e)//SİL BUTONU
        {
            if (MessageBox.Show("BU DERSİ SİLMEK İSTEDİĞİNİZE EMİNMİSİNİZ??","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut5 = new SqlCommand("delete  from DERSLERBİLGİ WHERE DERASAD=@P1", baglanti);
                komut5.Parameters.AddWithValue("@P1", textBox2.Text);
                komut5.ExecuteNonQuery();
                MessageBox.Show("KAYIT SİLİNDİ!!");
                textBox1.Text = "";
                baglanti.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
        public void ADKONTROL()
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select DERASAD FROM DERSLERBİLGİ", baglanti);
            SqlDataReader DR = komut3.ExecuteReader();
            while (DR.Read())
            {
                if (textBox1.Text == DR[0].ToString())
                {
                    MessageBox.Show("BU DERS ZATEN AKTİF!!");
                }
            }


            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            harfBÜYÜT(textBox1);
            

            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'bEYKENTÜNİVERSTESİ1DataSet9.DERSLERBİLGİ' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dERSLERBİLGİTableAdapter.Fill(this.bEYKENTÜNİVERSTESİ1DataSet9.DERSLERBİLGİ);
            DERSNOAL();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bolumıdbul();
        }
    }
}
