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
    public partial class şifreyönetim : Form
    {
        public şifreyönetim()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");

        public string yönad1;
        public string yönşifre1;

        private void button1_Click(object sender, EventArgs e)
        {
           
            yönad1 = txtYÖNETİCİAD.Text;
            yönşifre1 = txtYÖNETİCİŞİFRE.Text;

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from YÖNETİCİBİLGİ where AD=@p1 and ŞİFRE=@p2 ", baglanti);
            komut1.Parameters.AddWithValue("p1", yönad1);
            komut1.Parameters.AddWithValue("p2", yönşifre1);

            SqlDataReader dt = komut1.ExecuteReader();
            if (dt.Read())
            {
                YÖNETİM TY = new YÖNETİM();
                TY.yönad = txtYÖNETİCİAD.Text;
                TY.yönşifre = txtYÖNETİCİŞİFRE.Text;
                TY.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("şifre yada kullanıcı adı yanlış");
            }

            baglanti.Close();
        }

        private void şifreyönetim_Load(object sender, EventArgs e)
        {
            txtYÖNETİCİAD.Focus();
        }

        private void txtYÖNETİCİŞİFRE_TextChanged(object sender, EventArgs e)
        {
            txtYÖNETİCİŞİFRE.PasswordChar = '*';
            if (txtYÖNETİCİŞİFRE.Text.Length>11)
            {
                MessageBox.Show("şifreniz 11 haneden fazla olamaz!!!");
                txtYÖNETİCİŞİFRE.Text="";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ANAGİRİŞ bh = new ANAGİRİŞ();
            bh.Show();
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

        private void txtYÖNETİCİAD_TextChanged(object sender, EventArgs e)
        {
            harfbüyüt(txtYÖNETİCİAD);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtYÖNETİCİŞİFRE.PasswordChar = '\0';
            }
            else
            {
               txtYÖNETİCİŞİFRE.PasswordChar = '*';
            }
        }

        private void txtYÖNETİCİAD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtYÖNETİCİŞİFRE.Focus();
            }
        }
    }
}
