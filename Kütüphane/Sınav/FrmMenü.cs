using Fatura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sınav
{
    public partial class FrmMenü : Form
    {
        public FrmMenü()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmKitapEkle();
            frm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new FrmKitapSil();
            frm.ShowDialog(this);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new FrmKitapSorgula();
            frm.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
