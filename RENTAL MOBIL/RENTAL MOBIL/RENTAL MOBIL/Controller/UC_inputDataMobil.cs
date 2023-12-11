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
            DataMobilListView();
            LoadDataMobil();
            Lvw_dataMobil.SelectedIndexChanged += Lvw_dataMobil_SelectedIndexChanged;

            btn_editDataMbl.Enabled = false;
            btn_DeleteMbl.Enabled = false;
            btn_saveData.Enabled = true;
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

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

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
            LoadDataMobil();

            btn_editDataMbl.Enabled = true;
            btn_DeleteMbl.Enabled = true;
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

        private void LoadDataMobil()
        {
            Lvw_dataMobil.Items.Clear();

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True"))
            {
                connection.Open();

                string query = @"SELECT Id_mobil, Plat_nomer,Merek,Harga_sewa,Warna from Tbl_mobil order by Id_mobil";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var noUrut = Lvw_dataMobil.Items.Count + 1;

                            var item = new ListViewItem(noUrut.ToString());
                            item.SubItems.Add(reader["Id_mobil"].ToString());
                            item.SubItems.Add(reader["Plat_nomer"].ToString());
                            item.SubItems.Add(reader["Merek"].ToString());
                            item.SubItems.Add(reader["Warna"].ToString());
                            item.SubItems.Add(reader["Harga_sewa"].ToString());

                            Lvw_dataMobil.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void DataMobilListView()
        {
            LoadDataMobil();
            Lvw_dataMobil.View = System.Windows.Forms.View.Details;
            Lvw_dataMobil.FullRowSelect = true;
            Lvw_dataMobil.GridLines = true;

            Lvw_dataMobil.Columns.Add("No", 30, HorizontalAlignment.Center);
            Lvw_dataMobil.Columns.Add("ID mobil", 80, HorizontalAlignment.Center);
            Lvw_dataMobil.Columns.Add("Plat Nomer", 100, HorizontalAlignment.Center);
            Lvw_dataMobil.Columns.Add("Merek", 80, HorizontalAlignment.Center);
            Lvw_dataMobil.Columns.Add("Warna", 120, HorizontalAlignment.Center);
            Lvw_dataMobil.Columns.Add("Harga Sewa (Rp)", 162, HorizontalAlignment.Center);
        }

        

        private void btn_DeleteMbl_Click(object sender, EventArgs e)
        {
            // Menampilkan konfirmasi kepada pengguna
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data pelanggan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Jika pengguna memilih 'Yes', maka lanjutkan dengan penghapusan
                var result = 0;

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

                conn.Open();

                string sql = @"DELETE from Tbl_mobil where Id_mobil =@Id_mobil";
                SqlCommand cmd = new SqlCommand(sql, conn);

                try
                {
                    cmd.Parameters.AddWithValue(@"Id_mobil", txt_IdMobil.Text);
                   
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
                    MessageBox.Show("Data mobil berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Membersihkan input setelah penghapusan
                    txt_IdMobil.Clear();
                    txt_PlatNomer.Clear();
                    txt_MerekMobil.Clear();
                    txt_Warna.Clear();
                    txt_HargaSewa.Clear();


                }
                else
                {
                    MessageBox.Show("Data mobil gagal dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                conn.Dispose();
            }
            else
            {
                // Jika pengguna memilih 'No', tidak melakukan apa-apa
            }
            LoadDataMobil();
            btn_DeleteMbl.Enabled = false;
            btn_editDataMbl.Enabled = false;
            btn_saveData.Enabled = true;
        }

        //agar tampil di form
        private void Lvw_dataMobil_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("ID mobil tidak Dapat di edit !", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (IsDataSelected)
            {
                ListViewItem selected = Lvw_dataMobil.SelectedItems[0];

                // Mengambil data dari item yang dipilih dan menampilkannya di TextBox dan ComboBox
                txt_IdMobil.Text = selected.SubItems[1].Text;
                txt_PlatNomer.Text = selected.SubItems[2].Text;
                txt_MerekMobil.Text = selected.SubItems[3].Text;
                txt_Warna.Text = selected.SubItems[4].Text;
                txt_HargaSewa.Text = selected.SubItems[5].Text;
                //int.Parse(txt_HargaSewa.Text))

                btn_editDataMbl.Enabled = true;
                btn_DeleteMbl.Enabled = true;
                btn_saveData.Enabled = false;
                
            } else
            {
                btn_editDataMbl.Enabled = false;
                btn_saveData.Enabled = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_saveData.Enabled = true;
            btn_DeleteMbl.Enabled = false;
            btn_editDataMbl.Enabled = false;
            txt_IdMobil.Clear();
            txt_PlatNomer.Clear();
            txt_MerekMobil.Clear();
            txt_Warna.Clear();
            txt_HargaSewa.Clear();
        }

        private void btn_editDataMbl_Click(object sender, EventArgs e)
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

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

            conn.Open();

            string sql = @"UPDATE Tbl_mobil set Merek = @Merek ,Plat_nomer = @Plat_nomer,Warna = @Warna ,Harga_sewa = @Harga_sewa where Id_mobil =@Id_mobil";

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
                MessageBox.Show("Data mobil berhasil di edit", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_IdMobil.Clear();
                txt_PlatNomer.Clear();
                txt_MerekMobil.Clear();
                txt_Warna.Clear();
                txt_HargaSewa.Clear();

            }
            else
            {
                MessageBox.Show("Data mobil tidak berhasil di edit", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conn.Dispose();
            LoadDataMobil();
            btn_editDataMbl.Enabled = false;
            btn_DeleteMbl.Enabled = false;
            btn_saveData.Enabled = true;
        }


        private bool IsDataSelected
        {
            get { return Lvw_dataMobil.SelectedItems.Count > 0; }
        }
    }
}
