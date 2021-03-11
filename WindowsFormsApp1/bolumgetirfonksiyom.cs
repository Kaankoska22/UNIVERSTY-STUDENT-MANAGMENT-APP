using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class bolumgetirfonksiyom 
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        public void ÖYLEBÖLÜMVARMI(TextBox N)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select BOLUMAD FROM BOLUMLER", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                if (N.Text == DR[0].ToString())
                {
                    MessageBox.Show("BU BÖLÜM ZATEN VAR!!!");
                    N.Text = "";
                }
                else
                {

                }
            }

            baglanti.Close(); ;


        }



        public void AKBOLUMEKLE(ComboBox A)
        {
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select BOLUMAD from BOLUMLER ", baglanti);
            komut9.ExecuteNonQuery();
            SqlDataReader dr3 = komut9.ExecuteReader();
            while (dr3.Read())
            {

                A.Items.Add(dr3[0]);
            }
            baglanti.Close();
        }



        public void comboyadersekle(ComboBox a, ComboBox b)
        {
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from BOLUMLER where BOLUMAD=@P1", baglanti);
            komut6.Parameters.AddWithValue("@P1", a.Text);
            komut6.ExecuteNonQuery();
            SqlDataReader dr1 = komut6.ExecuteReader();
            if (dr1.Read())
            {
                b.Items.Clear();
                for (int i = 1; i < 8; i++)
                {
                    b.Items.Add(dr1["BOLUMDERS" + i].ToString());
                }

            }
            else
            {

            }
            baglanti.Close();
        }




    }
}
