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
    public partial class SINIFAKTİFDERLERİGÖRÜNTÜLE : Form
    {
        public SINIFAKTİFDERLERİGÖRÜNTÜLE()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public String BOLUM;
        public int sayısıders;
        public int SINIFYIL;
        public void DERSGETİR(Label C,int v)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select BOLUMDERS1, BOLUMDERS2, BOLUMDERS3, BOLUMDERS4, BOLUMDERS5, BOLUMDERS6, BOLUMDERS7, BOLUMDERS8 FROM BOLUMLER WHERE BOLUMAD=@P1 and SINIFYILI=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1",BOLUM);
            komut.Parameters.AddWithValue("@P2",SINIFYIL);
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                C.Text = dr[v].ToString();
            }
            sayısıders = Convert.ToInt32(dr.FieldCount);
            labelTOPLAMDERSAYI.Text = sayısıders.ToString();
            baglanti.Close();



        }



        private void SINIFAKTİFDERLERİGÖRÜNTÜLE_Load(object sender, EventArgs e)
        {
            DERSGETİR(label3,0);
            DERSGETİR(label4,1);
            DERSGETİR(label5,2);
            DERSGETİR(label6,3);
            DERSGETİR(label8,4);
            DERSGETİR(label10,5);
            DERSGETİR(label12,6);
            DERSGETİR(label9,7);
           
           





        }
    }
}
