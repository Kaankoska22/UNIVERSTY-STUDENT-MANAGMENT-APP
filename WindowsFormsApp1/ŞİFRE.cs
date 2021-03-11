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
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class ŞİFRE : Form
    {
        public ŞİFRE()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://obs.beykent.edu.tr/oibs/ogrenci/start.aspx?gkm=0429378053221038816322283770735545322103876035585322203223438928333483893633327214634388378053667236720");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from OGRENCİBİLGİLERİ where OKULNO=@p1 and ŞİFRE=@p2 ", baglanti);
            komut1.Parameters.AddWithValue("p1", maskedTextBox1.Text);
            komut1.Parameters.AddWithValue("p2", txtşifre.Text);

            SqlDataReader dt = komut1.ExecuteReader();
            if (dt.Read())
            {
                
                ÖĞRENCİDERSLERBİLGİ fr = new ÖĞRENCİDERSLERBİLGİ();
                fr.ID = Convert.ToInt32(dt[0]);
                fr.OGRID1 = Convert.ToInt32(dt[10]);
                fr.bol =Convert.ToInt32(dt[4]);
                fr.ogrencino = Convert.ToInt32(maskedTextBox1.Text);
                fr.ogrencişifre = txtşifre.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("şifre yada kullanıcı adı yanlış");
                maskedTextBox1.Text = "";
                txtşifre.Text = "";
            }

            baglanti.Close();




























            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ANAGİRİŞ bj = new ANAGİRİŞ();
            bj.Show();
        }

        private void txtşifre_TextChanged(object sender, EventArgs e)
        {

            txtşifre.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                txtşifre.PasswordChar = '\0';
            }
            else
            {
                txtşifre.PasswordChar = '*';
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtşifre.Focus();
            }
        }

        private void ŞİFRE_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Focus();
        }
    }
}
