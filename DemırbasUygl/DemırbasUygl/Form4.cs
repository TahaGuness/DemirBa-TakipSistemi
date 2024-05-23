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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void kaydet_Click(object sender, EventArgs e)        
            {
                string connectionString = "Server=localhost;Database=demırbasuygl;Uid=root;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO kasa_bilgileri (kasa_demirbas_no, calisan_sicil_no, isletim_sistemi, islemci_marka_model, ram, sabit_disk_kapasitesi, ekran_karti, pc_model, islemci_hizi, cekirdek_sayisi, monitor_boyutu) " +
                                       "VALUES (@kasaDemirbasNo, @calisanSicilNo, @isletimSistemi, @islemciMarkaModel, @ram, @sabitDiskKapasitesi, @ekranKarti, @pcModel, @islemciHizi, @CekirdekSayisi, @monitorBoyutu)";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@kasaDemirbasNo", kasa_demirbas_no.Text);
                            command.Parameters.AddWithValue("@calisanSicilNo", calisan_sicil_no.Text);
                            command.Parameters.AddWithValue("@isletimSistemi", isletim_sistemi.Text);
                            command.Parameters.AddWithValue("@islemciMarkaModel", islemci_marka_model.Text);
                            command.Parameters.AddWithValue("@ram", ram.Text);
                            command.Parameters.AddWithValue("@sabitDiskKapasitesi", sabit_disk_kapasitesi.Text);
                            command.Parameters.AddWithValue("@ekranKarti", ekran_karti.Text);
                            command.Parameters.AddWithValue("@pcModel", pc_model.Text);
                            command.Parameters.AddWithValue("@islemciHizi", islemci_hizi.Text);
                            command.Parameters.AddWithValue("@monitorBoyutu", monitör_boyutu.Text);
                        command.Parameters.AddWithValue("@CekirdekSayisi", cekirdik_sayisi.Text);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Veri başarıyla kaydedildi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void islemci_hizi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form3 = new Form2();
            form3.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form4 = new Form1();
            form4.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

    
               
         
