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
            DataPenyewaListView();
            LoadDataPenyewa();
            this.userId = userId;
            lbl_IdKaryawan.Text = userId;
            Lvw_dataPenyewa.SelectedIndexChanged += Lvw_dataPenyewa_SelectedIndexChanged;


            txtNamaPelanggan.Enabled = false;
            txt_Notlpn.Enabled = false;
            txt_IdPelanggan.Enabled = false;
            //txt_NikKtp.Enabled = false;
            txt_Harga.Enabled = false;
            txt_Merek.Enabled = false;
            //txt_PlatNo.Enabled = false; 
            txt_IdMobil.Enabled = false;
            
            btn_DeletePenyewa.Enabled = false;
            btn_EditPenyewa.Enabled = false;
            btn_simpan.Enabled = true;
        }

        private void DataPenyewaListView()
        {
            LoadDataPenyewa();
            Lvw_dataPenyewa.View = System.Windows.Forms.View.Details;
            Lvw_dataPenyewa.FullRowSelect = true;
            Lvw_dataPenyewa.GridLines = true;

            Lvw_dataPenyewa.Columns.Add("No", 30, HorizontalAlignment.Center);
            Lvw_dataPenyewa.Columns.Add("ID sewa", 80, HorizontalAlignment.Center);
            Lvw_dataPenyewa.Columns.Add("ID pelanggan", 80, HorizontalAlignment.Center);
            Lvw_dataPenyewa.Columns.Add("Nama Pelanggan", 80, HorizontalAlignment.Center);
            Lvw_dataPenyewa.Columns.Add("ID mobil", 80, HorizontalAlignment.Center);
            Lvw_dataPenyewa.Columns.Add("Plat Nomer", 120, HorizontalAlignment.Center);
            Lvw_dataPenyewa.Columns.Add("Tgl mulai sewa", 120, HorizontalAlignment.Center);
            Lvw_dataPenyewa.Columns.Add("Tgl Selesai sewa", 120, HorizontalAlignment.Center);
            Lvw_dataPenyewa.Columns.Add("Biaya", 120, HorizontalAlignment.Center);
            Lvw_dataPenyewa.Columns.Add("Id karyawan", 80, HorizontalAlignment.Center);
        }


        private void btn_simpan_Click(object sender, EventArgs e)
        {

            var result = 0;

            if (String.IsNullOrEmpty(txt_IdPenyewaan.Text))
            {
                MessageBox.Show("Id penyewaan harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_IdPenyewaan.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_IdMobil.Text))
            {
                MessageBox.Show("Id mobil harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_IdMobil.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_IdPelanggan.Text))
            {
                MessageBox.Show("Id pelanggan harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_IdPelanggan.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_TotalSewa.Text))
            {
                MessageBox.Show("Total sewa harus ter isi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_TotalSewa.Focus();
                return;
            }


            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

            conn.Open();

            string sql = @"insert into Tbl_Penyewaan (Id_penyewaan,Id,Id_pelanggan,Id_mobil,Tgl_mulaiSewa,Tgl_selesaiSewa,Total_biaya) VALUES (@Id_penyewaan,@Id,@Id_pelanggan,@Id_mobil,@Tgl_mulaiSewa,@Tgl_selesaiSewa,@Total_biaya)";

            SqlCommand cmd = new SqlCommand(sql, conn);


            try
            {
                cmd.Parameters.AddWithValue(@"Id_penyewaan", txt_IdPenyewaan.Text);
                cmd.Parameters.AddWithValue(@"Id", lbl_IdKaryawan.Text);
                cmd.Parameters.AddWithValue(@"Id_pelanggan", txt_IdPelanggan.Text);
                cmd.Parameters.AddWithValue(@"Id_mobil", txt_IdMobil.Text);
                cmd.Parameters.Add(new SqlParameter(@"Tgl_mulaiSewa", SqlDbType.Date)).Value = dateTime_MulaiSewa.Value.Date;
                cmd.Parameters.Add(new SqlParameter(@"Tgl_selesaiSewa", SqlDbType.Date)).Value = dateTime_SelesaiSewa.Value.Date;
                //cmd.Parameters.AddWithValue(@"Tgl_mulaiSewa", dateTime_MulaiSewa.Text);
                //cmd.Parameters.AddWithValue(@"Tgl_selesaiSewa", dateTime_SelesaiSewa.Text);
                cmd.Parameters.AddWithValue(@"Total_biaya", Int64.Parse(txt_TotalSewa.Text));

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
                MessageBox.Show("Data Penyewa berhasil di simpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNamaPelanggan.Clear();
                txt_Notlpn.Clear();
                txt_NikKtp.Clear();
                txt_IdPelanggan.Clear();

                txt_Merek.Clear();
                txt_PlatNo.Clear();
                txt_Harga.Clear();
                txt_IdMobil.Clear();

                txt_IdPenyewaan.Clear();
                txt_TotalSewa.Clear();
                dateTime_MulaiSewa.Value = DateTime.Now;
                dateTime_SelesaiSewa.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Data penyewa tidak tersimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conn.Dispose();
            LoadDataPenyewa();

        }

        private void btn_EditPenyewa_Click(object sender, EventArgs e)
        {
            var result = 0;

            if (String.IsNullOrEmpty(txt_IdPenyewaan.Text))
            {
                MessageBox.Show("Id penyewaan harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_IdPenyewaan.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_IdMobil.Text))
            {
                MessageBox.Show("Id mobil harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_IdMobil.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_IdPelanggan.Text))
            {
                MessageBox.Show("Id pelanggan harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_IdPelanggan.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_TotalSewa.Text))
            {
                MessageBox.Show("Total sewa harus ter isi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_TotalSewa.Focus();
                return;
            }


            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

            conn.Open();

            // yang bisa di edit kecuali id 
            string sql = @"UPDATE Tbl_Penyewaan SET Tgl_mulaiSewa = @Tgl_mulaiSewa,Tgl_selesaiSewa = @Tgl_selesaiSewa, Total_biaya = @Total_biaya, Id_mobil = @Id_mobil where Id_penyewaan = @Id_penyewaan ";

            SqlCommand cmd = new SqlCommand(sql, conn);


            try
            {
                cmd.Parameters.AddWithValue(@"Id_penyewaan", txt_IdPenyewaan.Text);
                cmd.Parameters.AddWithValue(@"Id", lbl_IdKaryawan.Text);
                cmd.Parameters.AddWithValue(@"Id_pelanggan", txt_IdPelanggan.Text);
                cmd.Parameters.AddWithValue(@"Id_mobil", txt_IdMobil.Text);
                cmd.Parameters.Add(new SqlParameter(@"Tgl_mulaiSewa", SqlDbType.Date)).Value = dateTime_MulaiSewa.Value.Date;
                cmd.Parameters.Add(new SqlParameter(@"Tgl_selesaiSewa", SqlDbType.Date)).Value = dateTime_SelesaiSewa.Value.Date;
                //cmd.Parameters.AddWithValue(@"Tgl_mulaiSewa", dateTime_MulaiSewa.Text);
                //cmd.Parameters.AddWithValue(@"Tgl_selesaiSewa", dateTime_SelesaiSewa.Text);
                cmd.Parameters.AddWithValue(@"Total_biaya", Int64.Parse(txt_TotalSewa.Text));

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
                MessageBox.Show("Data Penyewa berhasil di edit", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNamaPelanggan.Clear();
                txt_Notlpn.Clear();
                txt_NikKtp.Clear();
                txt_IdPelanggan.Clear();

                txt_Merek.Clear();
                txt_PlatNo.Clear();
                txt_Harga.Clear();
                txt_IdMobil.Clear();

                txt_IdPenyewaan.Clear();
                txt_TotalSewa.Clear();
                dateTime_MulaiSewa.Value = DateTime.Now;
                dateTime_SelesaiSewa.Value = DateTime.Now;

            }
            else
            {
                MessageBox.Show("Data penyewa tidak tersimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conn.Dispose();
            LoadDataPenyewa();
            txt_IdPenyewaan.Enabled = true;

            btn_simpan.Enabled = true;
            btn_DeletePenyewa.Enabled = false;
            btn_EditPenyewa.Enabled = false;
        }

        private void btn_DeletePenyewa_Click(object sender, EventArgs e)
        {
            // Menampilkan konfirmasi kepada pengguna
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data pelanggan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Jika pengguna memilih 'Yes', maka lanjutkan dengan penghapusan
                var result = 0;

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

                conn.Open();

                string sql = @"DELETE from Tbl_Penyewaan where Id_penyewaan = @Id_penyewaan";
                SqlCommand cmd = new SqlCommand(sql, conn);

                try
                {
                    cmd.Parameters.AddWithValue(@"Id_penyewaan", txt_IdPenyewaan.Text);

                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cmd.Dispose();
                }

                if (result > 0)
                {
                    MessageBox.Show("Data  berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Membersihkan input setelah penghapusan
                    txtNamaPelanggan.Clear();
                    txt_Notlpn.Clear();
                    txt_NikKtp.Clear();
                    txt_IdPelanggan.Clear();

                    txt_Merek.Clear();
                    txt_PlatNo.Clear();
                    txt_Harga.Clear();
                    txt_IdMobil.Clear();

                    txt_IdPenyewaan.Clear();
                    txt_TotalSewa.Clear();
                    dateTime_MulaiSewa.Value = DateTime.Now;
                    dateTime_SelesaiSewa.Value = DateTime.Now;


                }
                else
                {
                    MessageBox.Show("Data  gagal dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                conn.Dispose();
            }
            else
            {
                // Jika pengguna memilih 'No', tidak melakukan apa-apa
            }
            LoadDataPenyewa();
            btn_DeletePenyewa.Enabled = false;
            btn_EditPenyewa.Enabled = false;
            btn_simpan.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            txtNamaPelanggan.Clear();
            txt_Notlpn.Clear();
            txt_NikKtp.Clear();
            txt_IdPelanggan.Clear();

            txt_Merek.Clear();
            txt_PlatNo.Clear();
            txt_Harga.Clear();
            txt_IdMobil.Clear();

            txt_IdPenyewaan.Clear();
            txt_TotalSewa.Clear();
            dateTime_MulaiSewa.Value = DateTime.Now;
            dateTime_SelesaiSewa.Value = DateTime.Now;

            txt_IdPenyewaan.Enabled = true;
            btn_simpan.Enabled = true;
            btn_EditPenyewa.Enabled = false;
            btn_DeletePenyewa.Enabled = false;
        }

        private void btn_Hitung_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_Harga.Text))
            {
                MessageBox.Show("Harga belum terisi isi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_IdMobil.Focus();
                return;
            } else
            {
                DateTime tanggalMulai = dateTime_MulaiSewa.Value.Date;
                DateTime tanggalSelesai = dateTime_SelesaiSewa.Value.Date;

                if (tanggalSelesai < tanggalMulai)
                {
                    MessageBox.Show("Tanggal selesai tidak boleh kurang dari tanggal mulai.");
                    return;
                }

                int jumlahHari = (int)(tanggalSelesai - tanggalMulai).TotalDays + 1;

                //int biayaPerHari = 20000;
                int Harga = int.Parse(txt_Harga.Text);
                int totalBiaya = jumlahHari * Harga;

                txt_TotalSewa.Text = totalBiaya.ToString();
            }
           
        }



        private void txt_IdPenyewaan_Click(object sender, EventArgs e)
        {
            string randomID = GenerateRandomID();
            txt_IdPenyewaan.Text = randomID;
        }

        private string GenerateRandomID()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            string randomID = "RTL" + random.Next(100, 999).ToString();

            return randomID;
        }


        ////////
        private void txt_NikKtp_TextChanged(object sender, EventArgs e)
        {
            showDataPelanggan(txt_NikKtp.Text);
        }

        private void txt_PlatNo_TextChanged(object sender, EventArgs e)
        {
            showDataMobil(txt_PlatNo.Text);
        }

        private void showDataPelanggan (string nik)
        {

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True"))
            {
                connection.Open();
                string querry = @"SELECT * from Tbl_pelanggan WHERE Nik_ktp = @Nik_ktp";

                using (SqlCommand command = new SqlCommand(querry, connection))
                {
                    command.Parameters.AddWithValue("@Nik_ktp", nik);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_IdPelanggan.Text = reader["Id_pelanggan"].ToString();
                            txtNamaPelanggan.Text = reader["Nama_pelanggan"].ToString();
                            txt_Notlpn.Text = reader["No_telepon"].ToString();
                            
                        }
                        else
                        {
                            txtNamaPelanggan.Text = string.Empty;
                            txt_Notlpn.Text = string.Empty;
                            txt_IdPelanggan.Text = string.Empty;

                        }
                    }
                }
            }
        }


        private void showDataMobil(string plat)
        {

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True"))
            {
                connection.Open();
                string querry = @"SELECT * from Tbl_Mobil WHERE Plat_nomer = @Plat_nomer";

                using (SqlCommand command = new SqlCommand(querry, connection))
                {
                    command.Parameters.AddWithValue("@Plat_nomer", plat);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_Merek.Text = reader["Merek"].ToString();
                            //txt_PlatNo.Text = reader["Plat_nomer"].ToString();
                            txt_Harga.Text = reader["Harga_sewa"].ToString();
                            txt_IdMobil.Text = reader["Id_mobil"].ToString();
                        }
                        else
                        {
                            txt_Merek.Text = string.Empty;
                            //txt_PlatNo.Text = string.Empty;
                            txt_Harga.Text = string.Empty;
                            txt_IdMobil.Text = string.Empty;
                        }
                    }
                }
            }
        }

        

        private void Lvw_dataPenyewa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsDataSelected)
            {
                btn_simpan.Enabled = false;
                btn_EditPenyewa.Enabled = true;
                btn_DeletePenyewa.Enabled = true;
                txt_IdPenyewaan.Enabled = false;
                ListViewItem selected = Lvw_dataPenyewa.SelectedItems[0];

                // Mengambil data dari item yang dipilih dan menampilkannya di TextBox dan ComboBox
                txt_IdPenyewaan.Text = selected.SubItems[1].Text;
                txt_NikKtp.Text = selected.SubItems[2].Text;
                txt_PlatNo.Text = selected.SubItems[5].Text;
                txt_NikKtp.Text = selected.SubItems[10].Text;

                //txt_Warna.Text = selected.SubItems[4].Text;
                //txt_HargaSewa.Text = selected.SubItems[5].Text;
                //int.Parse(txt_HargaSewa.Text))

                btn_EditPenyewa.Enabled = true;
                btn_DeletePenyewa.Enabled = true;

            }
            else
            {
                btn_EditPenyewa.Enabled = false;
            }
        }

        private void LoadDataPenyewa()
        {
            Lvw_dataPenyewa.Items.Clear();

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True"))
            {
                connection.Open();

                string query = @"SELECT P.Id_penyewaan, P.Id_pelanggan, P.Id_mobil, CONVERT(VARCHAR(10), P.Tgl_mulaiSewa, 120) AS Tgl_mulaiSewa,
                   CONVERT(VARCHAR(10), P.Tgl_selesaiSewa, 120) AS Tgl_selesaiSewa, P.Total_biaya, P.Id, Pl.Nama_pelanggan, M.Plat_nomer, Pl.Nik_ktp
                   FROM Tbl_Penyewaan P
                   JOIN Tbl_Pelanggan Pl ON P.Id_pelanggan = Pl.Id_pelanggan
                   JOIN Tbl_Mobil M ON P.Id_mobil = M.Id_mobil
                   ORDER BY P.Id_penyewaan ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var noUrut = Lvw_dataPenyewa.Items.Count + 1;

                            var item = new ListViewItem(noUrut.ToString());
                            item.SubItems.Add(reader["Id_penyewaan"].ToString());
                            item.SubItems.Add(reader["Id_pelanggan"].ToString());
                            item.SubItems.Add(reader["Nama_pelanggan"].ToString());
                            item.SubItems.Add(reader["Id_mobil"].ToString());
                            item.SubItems.Add(reader["Plat_nomer"].ToString());
                            item.SubItems.Add(reader["Tgl_mulaiSewa"].ToString());
                            item.SubItems.Add(reader["Tgl_selesaiSewa"].ToString());
                            item.SubItems.Add(reader["Total_biaya"].ToString());
                            item.SubItems.Add(reader["Id"].ToString());
                            item.SubItems.Add(reader["Nik_ktp"].ToString());

                            Lvw_dataPenyewa.Items.Add(item);
                        }
                    }
                }
            }
        }
        private bool IsDataSelected
        {
            get { return Lvw_dataPenyewa.SelectedItems.Count > 0; }
        }

        
    }
}
