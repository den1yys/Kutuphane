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
    public partial class FrmKitapEkle : Form
    {
        public FrmKitapEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] param = { "@Ad", textBox1.Text,
                               "@Yazar", textBox2.Text,
                               "@SayfaSayi", textBox3.Text,
                               "@Barkod", textBox4.Text

           };

            DBHelper.ExecuteNonQuery("INSERT INTO KitapDetay(Ad,Yazar,SayfaSayi,Barkod) VALUES(@Ad,@Yazar,@SayfaSayi,@Barkod)", param);

            MessageBox.Show("Kitap, Kitaplığa Eklenmiştir");

            this.Close();
        }
    }
}
