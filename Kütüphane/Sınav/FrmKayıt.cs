﻿using Fatura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav
{
    public partial class FrmKayıt : Form
    {
        public FrmKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] param = { "@KullaniciAdi", textBox1.Text,
                               "@Sifre", textBox2.Text,
                               "@Ad", textBox5.Text,
                               "@Soyad", textBox4.Text

           };

            DBHelper.ExecuteNonQuery("INSERT INTO PersonelDetay(KullaniciAdi,Sifre,Ad,Soyad) VALUES(@KullaniciAdi,@Sifre,@Ad,@Soyad)", param);

            MessageBox.Show("Kaydınız Eklenmiştir");

            this.Close();
        }
    }
}
