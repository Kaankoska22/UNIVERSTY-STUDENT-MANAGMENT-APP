using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ANAGİRİŞ : Form
    {
        public ANAGİRİŞ()
        {
            InitializeComponent();
        }

        private void btnögrencigiriş_Click(object sender, EventArgs e)//GİRİŞLERE YÖNLENDİRME
        {
            ŞİFRE dr = new ŞİFRE();
            dr.Show();
            this.Hide();

        }
        private void BTNYÖNETİM_Click(object sender, EventArgs e)//GİRİŞLERE YÖNLENDİRME
        {

            şifreyönetim DR = new şifreyönetim();
            DR.Show();
            this.Hide();

        }

        private void BTNAKADEMİSYEN_Click(object sender, EventArgs e)//GİRİŞLERE YÖNLENDİRME
        {
            ŞİFREAKADEMİSYEN FE = new ŞİFREAKADEMİSYEN();
            FE.Show();
            this.Hide();

        }
    }
}
