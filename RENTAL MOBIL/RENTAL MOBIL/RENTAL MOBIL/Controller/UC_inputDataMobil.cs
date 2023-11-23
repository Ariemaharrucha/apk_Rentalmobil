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
    public partial class UC_inputDataMobil : UserControl
    {
        public UC_inputDataMobil()
        {
            InitializeComponent();
        }

        private void btn_saveData_Click(object sender, EventArgs e)
        {
            var result = 0;

            if (String.IsNullOrEmpty(txt_IdMobil.Text))
            {
                MessageBox.Show("Id Mobil harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_IdMobil.Focus();
                return;
            }


            if (String.IsNullOrEmpty(txt_PlatNomer.Text))
            {
                MessageBox.Show("Plat Nomer harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_PlatNomer.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_MerekMobil.Text))
            {
                MessageBox.Show("Merek harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_MerekMobil.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_Warna.Text))
            {
                MessageBox.Show("Warna diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Warna.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_HargaSewa.Text))
            {
                MessageBox.Show("Harga sewa harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_HargaSewa.Focus();
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1LC3JE\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

            conn.Open();

            string sql = @"insert into Tbl_mobil (Id_mobil,Plat_nomer,Merek,Harga_sewa,Warna) VALUES (@Id_mobil,@Plat_nomer,@Merek,@Harga_sewa,@Warna)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                cmd.Parameters.AddWithValue(@"Id_mobil", txt_IdMobil.Text);
                cmd.Parameters.AddWithValue(@"Plat_nomer", txt_PlatNomer.Text);
                cmd.Parameters.AddWithValue(@"Merek", txt_MerekMobil.Text);
                cmd.Parameters.AddWithValue(@"Warna", txt_Warna.Text);
                cmd.Parameters.AddWithValue(@"Harga_sewa", int.Parse(txt_HargaSewa.Text));

                result = cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cmd.Dispose();
            }

            if (result > 0)
            {
                MessageBox.Show("Data mobil berhasil di simpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_IdMobil.Clear();
                txt_PlatNomer.Clear();
                txt_MerekMobil.Clear();
                txt_Warna.Clear();
                txt_HargaSewa.Clear();
            }
            else
            {
                MessageBox.Show("Data mobil tidak tersimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conn.Dispose();
        }

        private void txt_IdMobil_Click(object sender, EventArgs e)
        {
            string randomID = GenerateRandomID();

            txt_IdMobil.Text = randomID;
        }

        private string GenerateRandomID()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            string randomID = "MBL" + random.Next(100, 999).ToString();

            return randomID;
        }
    }
}
