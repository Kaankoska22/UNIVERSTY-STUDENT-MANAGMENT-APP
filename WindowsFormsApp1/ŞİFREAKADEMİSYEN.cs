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
    public partial class ŞİFREAKADEMİSYEN : Form
    {
        public ŞİFREAKADEMİSYEN()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        public string akad1;
        public string akşifre1;

        private void button1_Click(object sender, EventArgs e)
        {
            akad1 = txtakad.Text;
            akşifre1 = txtşifre.Text;

            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("select * from AKADEMİSYENBİLGİ where AD=@p1 and ŞİFRE=@p2 ", baglanti);
            komut1.Parameters.AddWithValue("p1", akad1);
            komut1.Parameters.AddWithValue("p2", akşifre1);

            SqlDataReader dt = komut1.ExecuteReader();
            if (dt.Read())
            {
                akademisyenekranı gt = new akademisyenekranı();
                gt.akad = txtakad.Text;
                gt.akşifre = txtşifre.Text;
                gt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("şifre ya da kullanıcı adı yanlış!!!");
            }


            baglanti.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ANAGİRİŞ vg = new ANAGİRİŞ();
            vg.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://obs.beykent.edu.tr/oibs/ogrenci/start.aspx?gkm=0429378053221038816322283770735545322103876035585322203223438928333483893633327214634388378053667236720");
        }
        public void harfbüyüt(TextBox a)
        {


            a.Text = a.Text.ToUpper();
            a.SelectionStart = a.Text.Length;



        }

        private void txtakad_TextChanged(object sender, EventArgs e)
        {
            harfbüyüt(txtakad);
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

        private void txtşifre_TextChanged(object sender, EventArgs e)
        {
            txtşifre.PasswordChar ='*';
        }

        private void txtakad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtşifre.Focus();
            }
        }

        private void ŞİFREAKADEMİSYEN_Load(object sender, EventArgs e)
        {
            txtakad.Focus();
        }
    }
}
