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
    public partial class KAYITLIAKADEMİSYENLER : Form
    {
        public KAYITLIAKADEMİSYENLER()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD5P9VL;Initial Catalog=BEYKENTÜNİVERSTESİ1;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void datagrideveriat()//DATA GRİDE VERİ ATAR
        {
            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("select AD,SOYAD,DOGUM,BOLUMAD,DERASAD,AKNO FROM AKADEMİSYENBİLGİ INNER JOIN DERSLERBİLGİ ON DERSLERBİLGİ.DERSNO=AKADEMİSYENBİLGİ.AKTİFDERS INNER JOIN BOLUMLER ON BOLUMLER.BOLUMNO=AKADEMİSYENBİLGİ.BOLUM  ", baglanti);
           
            SqlDataAdapter da = new SqlDataAdapter(komut6);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;



            baglanti.Close();
        }

        private void KAYITLIAKADEMİSYENLER_Load(object sender, EventArgs e)
        {
            datagrideveriat();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
