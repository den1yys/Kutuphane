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

namespace Sınav
{
    public partial class FrmKitapSorgula : Form
    {
        private const string connectionString = "Data Source=.;Initial Catalog=Stok;Integrated Security=True";
        private const string query = "SELECT Barkod, Yazar, SayfaSayi FROM KitapDetay WHERE Ad = @Ad";
        public FrmKitapSorgula()
        {
            InitializeComponent();
        }

        private void FrmKitapSorgula_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ad", textBox1.Text);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBox2.Text=(reader["Barkod"].ToString());
                        textBox3.Text = (reader["Yazar"].ToString());
                        textBox4.Text = (reader["SayfaSayi"].ToString());

                    }
                    else
                    {
                        MessageBox.Show("Kitap bulunamadı!");
                    }
                }
            }

        }
    }
}
