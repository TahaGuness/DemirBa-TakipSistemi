using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemırbasUygl
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            {
                string connectionString = "Server=localhost;Database=demırbasuygl;Uid=root;";

                string query = "INSERT INTO odev3 (marka, model, aciklama, Verilme_tarihi) VALUES (@marka, @model, @aciklama, @Verilme_tarihi)";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@marka", marka.Text);
                        command.Parameters.AddWithValue("@model", model.Text);
                        command.Parameters.AddWithValue("@aciklama", aciklama.Text);
                        command.Parameters.AddWithValue("@Verilme_tarihi", Verilme_tarihi.Text);

                        try
                        {
                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Kayıt başarıyla eklendi!");
                            }
                            else
                            {
                                MessageBox.Show("Kayıt eklenemedi.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bir hata oluştu: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();  
        }

        private void model_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form3 = new Form1();
            form3.Show();
            this.Hide();
        }
    }
}