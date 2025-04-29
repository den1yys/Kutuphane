using Fatura;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sınav
{
    public partial class FrmKitapSil : Form
    {
        private const string connectionString = "Data Source=.;Initial Catalog=Stok;Integrated Security=True";
        private const string query = "SELECT Ad, Yazar, SayfaSayi FROM KitapDetay WHERE Barkod = @Barkod";
        public FrmKitapSil()
        {
            InitializeComponent();
        }
        
        private void FrmKitapSil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] param = { "@Ad", comboBox1.Text,
                               "@Yazar", comboBox2.Text,
                               "@SayfaSayi", comboBox3.Text,

           };

            DBHelper.ExecuteNonQuery("DELETE FROM KitapDetay WHERE Ad=@Ad AND Yazar=@Yazar AND SayfaSayi=@SayfaSayi;", param);


            MessageBox.Show("Kitap, Silinmiştir");

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Barkod", textBox1.Text);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Ad"].ToString());
                        comboBox2.Items.Add(reader["Yazar"].ToString());
                        comboBox3.Items.Add(reader["SayfaSayi"].ToString());

                    }
                    else
                    {
                        MessageBox.Show("Kitap bulunamadı!");
                    }
                }
            }
        }

        private void FrmKitapSil_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
