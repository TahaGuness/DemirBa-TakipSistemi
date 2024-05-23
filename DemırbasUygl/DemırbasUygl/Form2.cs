using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DemırbasUygl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=demırbasuygl;User ID=root;";
            string query = "INSERT INTO odev2 (ad, soyad, dogum, ise_baslama, eposta, unvan, notlar) VALUES (@ad, @soyad, @dogum, @ise_baslama, @eposta, @unvan, @notlar)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ad", ad.Text);
                    cmd.Parameters.AddWithValue("@soyad", soyad.Text);
                    cmd.Parameters.AddWithValue("@dogum", dogum.Text);
                    cmd.Parameters.AddWithValue("@ise_baslama", ise_baslama.Text);
                    cmd.Parameters.AddWithValue("@eposta", eposta.Text);
                    cmd.Parameters.AddWithValue("@unvan", unvan.Text);
                    cmd.Parameters.AddWithValue("@notlar", notlar.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarılı!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void notlar_TextChanged(object sender, EventArgs e)
        {

        }

        private void eposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void soyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }
    }
}
