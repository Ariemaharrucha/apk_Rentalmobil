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

        /*private void IDKaryawan()
        {
            string connectionString = @"Data Source=DESKTOP-D1LC3JE\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"SELECT Id FROM Tbl_LoginKaryawan WHERE username = @username";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Gantilah 'usernameValue' dengan nilai username yang sesuai.
                    cmd.Parameters.AddWithValue("@username", usernameValue);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Jika ID ditemukan, tetapkan nilainya ke dalam variabel lbl_IdKaryawan.Text.
                        lbl_IdKaryawan.Text = result.ToString();
                    }
                    else
                    {
                        // Jika ID tidak ditemukan, atur nilai lbl_IdKaryawan.Text sesuai kebutuhan.
                        lbl_IdKaryawan.Text = "ID not found";
                    }
                }
            }
        } */


    }
}
