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
    public partial class yönetimakademisyensilme : Form
    {
        public yönetimakademisyensilme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSORGULA_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand(" select * from AKADEMİSYENBİLGİ where TC=@p1",baglanti);
            komut4.Parameters.AddWithValue("@p1",maskedTextBoxakARA.Text);
            komut4.ExecuteNonQuery();
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                labelAKAD.Text = dr4[1].ToString();
                labelAKSOYAD.Text = dr4[2].ToString();
                labelAKDOGUM.Text = dr4[5].ToString();
                labelAKTC.Text = dr4[3].ToString();
                labelAKBOLUM.Text = dr4[4].ToString();
                labelAKAKTİFDERS.Text = dr4[7].ToString();
            }
            if (dr4.Read()==false)
            {
                MessageBox.Show("böyle bi kayıt yok!!!");
            }

            baglanti.Close();

        }

        private void buttonSİL_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("uyarı","bu akademisyen kaydını silmek istediğinize emin misiniz ??",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {

                baglanti.Open();
                SqlCommand komut6 = new SqlCommand("delete from AKADEMİSYENBİLGİ where TC=@p1", baglanti);
                komut6.Parameters.AddWithValue("@p1", maskedTextBoxakARA.Text);
                komut6.ExecuteNonQuery();
                MessageBox.Show("kayıt silindi");
                labelAKAD.Text = "";
                labelAKSOYAD.Text = "";
                labelAKDOGUM.Text = "";
                labelAKTC.Text = "";
                labelAKBOLUM.Text = "";
                labelAKAKTİFDERS.Text = "";

                baglanti.Close();
            }
            else
            {

            }





        }

        private void buttonakgörüntüle_Click(object sender, EventArgs e)
        {
            KAYITLIAKADEMİSYENLER nm = new KAYITLIAKADEMİSYENLER();
            nm.Show();
        }
    }
}
