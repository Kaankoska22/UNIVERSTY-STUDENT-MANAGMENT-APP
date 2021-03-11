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
    public partial class AKTİFOLANDERSLER : Form
    {
        public AKTİFOLANDERSLER()
        {
            InitializeComponent();
        }

        private void AKTİFOLANDERSLER_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'bEYKENTÜNİVERSTESİ1DataSet2.DERSLERBİLGİ' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dERSLERBİLGİTableAdapter.Fill(this.bEYKENTÜNİVERSTESİ1DataSet2.DERSLERBİLGİ);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
