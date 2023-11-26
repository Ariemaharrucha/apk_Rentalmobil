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

namespace RENTAL_MOBIL.Controller
{
    public partial class UC_dataSewa : UserControl
    {
        private string userId;


        public UC_dataSewa(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            lbl_IdKaryawan.Text = userId;
            
        }

        private void btn_Hitung_Click(object sender, EventArgs e)
        {
            DateTime tanggalMulai = dateTime_MulaiSewa.Value.Date;
            DateTime tanggalSelesai = dateTime_SelesaiSewa.Value.Date;

            if (tanggalSelesai < tanggalMulai)
            {
                MessageBox.Show("Tanggal selesai tidak boleh kurang dari tanggal mulai.");
                return;
            }

            int jumlahHari = (int)(tanggalSelesai - tanggalMulai).TotalDays + 1; 

            int biayaPerHari = 20000;
            int totalBiaya = jumlahHari * biayaPerHari;

            txt_TotalSewa.Text = totalBiaya.ToString();
        }

        private void txt_IdTransaksi_Click(object sender, EventArgs e)
        {
            string randomID = GenerateRandomID();
            txt_IdTransaksi.Text = randomID;
        }

        private string GenerateRandomID()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            string randomID = "RTL" + random.Next(100, 999).ToString();

            return randomID;
        }

        private void txt_IdPelanggan_TextChanged(object sender, EventArgs e)
        {
            showDataPelanggan(txt_IdPelanggan.Text);
        }

        private void showDataPelanggan (string id)
        {

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-D1LC3JE\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True"))
            {
                connection.Open();
                string querry = @"SELECT * from Tbl_pelanggan WHERE Id_pelanggan = @Id_pelanggan";

                using (SqlCommand command = new SqlCommand(querry, connection))
                {
                    command.Parameters.AddWithValue("@Id_pelanggan", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {                       
                            txtNamaPelanggan.Text = reader["Nama_pelanggan"].ToString();
                            txt_Notlpn.Text = reader["No_telepon"].ToString();
                            txt_NikKtp.Text = reader["Nik_ktp"].ToString();
                        }
                        else
                        {
                            txtNamaPelanggan.Text = string.Empty;
                            txt_Notlpn.Text = string.Empty;
                            txt_NikKtp.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void txt_IdMobil_TextChanged(object sender, EventArgs e)
        {
            showDataMobil(txt_IdMobil.Text);
        }

        private void showDataMobil(string id)
        {

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-D1LC3JE\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True"))
            {
                connection.Open();
                string querry = @"SELECT * from Tbl_Mobil WHERE Id_mobil = @Id_mobil";

                using (SqlCommand command = new SqlCommand(querry, connection))
                {
                    command.Parameters.AddWithValue("@Id_mobil", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_Merek.Text = reader["Merek"].ToString();
                            txt_PlatNo.Text = reader["Plat_nomer"].ToString();
                            txt_Harga.Text = reader["Harga_sewa"].ToString();
                        }
                        else
                        {
                            txt_Merek.Text = string.Empty;
                            txt_PlatNo.Text = string.Empty;
                            txt_Harga.Text = string.Empty;
                        }
                    }
                }
            }
        }
    }
}
