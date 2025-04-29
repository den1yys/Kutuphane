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
    public partial class FrmGiriş : Form
    {
        public FrmGiriş()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] param = { "@KullaniciAdi", textBox1.Text,
                               "@Sifre", textBox3.Text,

           };

            int ıd = Convert.ToInt32(DBHelper.ExecuteScalar("select PersonelId from PersonelDetay where Sifre=@Sifre and KullaniciAdi=@KullaniciAdi",param));

            
            if (ıd>0)
            {
                var frm = new FrmMenü();
                frm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Yanlış Şifre!");
            }
        }
    }
    
}
