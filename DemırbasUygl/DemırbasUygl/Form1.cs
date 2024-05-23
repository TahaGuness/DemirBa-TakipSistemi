using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemırbasUygl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string connectionString = "Server=localhost;Database=demırbasuygl;User ID=root;";
                string query = "SELECT COUNT(1) FROM odev WHERE kullanici=@kullanici AND sifre=@sifre";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@kullanici", kullanıcı.Text);
                        cmd.Parameters.AddWithValue("@sifre", sıfre.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Giriş başarılı!");                 
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide(); 
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        private void sıfre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}