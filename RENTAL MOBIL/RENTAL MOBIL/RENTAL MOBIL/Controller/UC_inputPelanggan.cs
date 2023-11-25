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
    public partial class UC_inputPelanggan : UserControl
    {

        public UC_inputPelanggan()
        {
            InitializeComponent();
            DataPelangganListView();
            lvwDataPelanggan.SelectedIndexChanged += lvwDataPelanggan_SelectedIndexChanged;

            btn_editData.Enabled = false;
        }
      
        private void btn_saveData_Click(object sender, EventArgs e)
        {
            var result = 0;

            if (String.IsNullOrEmpty(txt_NamaPelanggan.Text))
            {
                MessageBox.Show("Nama pelanggan harus diisi !!!", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txt_NamaPelanggan.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_IdPelanggan.Text))
            {
                MessageBox.Show("id pelanggan harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_IdPelanggan.Focus();
                return;
            }


            if (String.IsNullOrEmpty(comboBox_Gender.Text))
            {
                MessageBox.Show("Gender harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox_Gender.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_Alamat.Text))
            {
                MessageBox.Show("ALAMAT harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Alamat.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_nikKtp.Text))
            {
                MessageBox.Show("NIK KTP harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nikKtp.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txt_NoTelepon.Text))
            {
                MessageBox.Show("Nama pelanggan harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_NoTelepon.Focus();
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1LC3JE\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

            conn.Open();

            string sql = @"insert into Tbl_Pelanggan (Id_pelanggan,Nama_pelanggan,Gender,Alamat,Nik_ktp,No_telepon) VALUES (@Id_pelanggan,@Nama_pelanggan,@Gender,@Alamat,@Nik_ktp,@No_telepon)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            

            try
            {
                cmd.Parameters.AddWithValue(@"Id_pelanggan", txt_IdPelanggan.Text);
                cmd.Parameters.AddWithValue(@"Nama_pelanggan", txt_NamaPelanggan.Text);
                cmd.Parameters.AddWithValue(@"Gender", comboBox_Gender.Text);
                cmd.Parameters.AddWithValue(@"Alamat", txt_Alamat.Text);
                cmd.Parameters.AddWithValue(@"Nik_ktp", txt_nikKtp.Text);
                cmd.Parameters.AddWithValue(@"No_telepon", Int64.Parse(txt_NoTelepon.Text));

                result = cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show( "Error"+ ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cmd.Dispose();
            }

            if (result > 0)
            {
                MessageBox.Show("Data pelanggan berhasil di simpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_NamaPelanggan.Clear();
                txt_IdPelanggan.Clear();
                comboBox_Gender.Text = "";
                txt_Alamat.Clear();
                txt_nikKtp.Clear();
                txt_NoTelepon.Clear();
            } else
            {
                MessageBox.Show("Data pelanggan tidak tersimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conn.Dispose();
        }

        private void txt_IdPelanggan_Click(object sender, EventArgs e)
        {
            string randomID = GenerateRandomID();

            txt_IdPelanggan.Text = randomID;
        }

        private string GenerateRandomID()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            string randomID = "PLG" + random.Next(100, 999).ToString();

            return randomID;
        }

        private void lvwDataPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsDataSelected)
            {
                ListViewItem selected = lvwDataPelanggan.SelectedItems[0];

                // Mengambil data dari item yang dipilih dan menampilkannya di TextBox dan ComboBox
                txt_IdPelanggan.Text = selected.SubItems[1].Text;
                txt_NamaPelanggan.Text = selected.SubItems[2].Text;
                comboBox_Gender.Text = selected.SubItems[3].Text;
                txt_Alamat.Text = selected.SubItems[4].Text;
                txt_nikKtp.Text = selected.SubItems[5].Text;
                txt_NoTelepon.Text = selected.SubItems[6].Text;
                btn_editData.Enabled = true;


            }
            else {
                btn_editData.Enabled = false;

            }
        }

        private void DataPelangganListView()
        {
            lvwDataPelanggan.View = System.Windows.Forms.View.Details;
            lvwDataPelanggan.FullRowSelect = true;
            lvwDataPelanggan.GridLines = true;

            lvwDataPelanggan.Columns.Add("No", 30, HorizontalAlignment.Center);
            lvwDataPelanggan.Columns.Add("ID", 80, HorizontalAlignment.Center);
            lvwDataPelanggan.Columns.Add("Nama", 160, HorizontalAlignment.Center);
            lvwDataPelanggan.Columns.Add("Gender", 80, HorizontalAlignment.Center);
            lvwDataPelanggan.Columns.Add("Alamat", 120, HorizontalAlignment.Center);
            lvwDataPelanggan.Columns.Add("NIK KTP", 120, HorizontalAlignment.Center);
            lvwDataPelanggan.Columns.Add("No Telepon", 120, HorizontalAlignment.Center);
        }

        private void btn_LoadDtPelanggan_Click(object sender, EventArgs e)
        {
            lvwDataPelanggan.Items.Clear();
            btn_editData.Enabled = false;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1LC3JE\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

            conn.Open();

            string sql = @"SELECT Id_pelanggan, Nama_pelanggan,Gender,Alamat,Nik_ktp,No_telepon from Tbl_pelanggan order by Nama_pelanggan ASC ";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dtr = cmd.ExecuteReader();

            while (dtr.Read())
            {
                var noUrut = lvwDataPelanggan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(dtr["Id_pelanggan"].ToString());
                item.SubItems.Add(dtr["Nama_pelanggan"].ToString());
                item.SubItems.Add(dtr["Gender"].ToString());
                item.SubItems.Add(dtr["Alamat"].ToString());
                item.SubItems.Add(dtr["Nik_ktp"].ToString());
                item.SubItems.Add(dtr["No_telepon"].ToString());

                lvwDataPelanggan.Items.Add(item);
                //lvwDataPelanggan.Items.Insert(0, item);
            }

            dtr.Dispose();
            cmd.Dispose();
            conn.Dispose();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_NamaPelanggan.Clear();
            txt_IdPelanggan.Clear();
            comboBox_Gender.Text = "";
            txt_Alamat.Clear();
            txt_nikKtp.Clear();
            txt_NoTelepon.Clear();
        }

        private void btn_editData_Click(object sender, EventArgs e)
        {
            var result = 0;

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1LC3JE\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

            conn.Open();

            string sql = @"UPDATE Tbl_Pelanggan set Nama_pelanggan = @Nama_pelanggan ,Gender = @Gender,Alamat = @Alamat ,Nik_ktp = @Nik_ktp,No_telepon = @No_telepon where Id_pelanggan =@Id_pelanggan";

            SqlCommand cmd = new SqlCommand(sql, conn);

            btn_editData.Enabled = false;


            try
            {
                
                cmd.Parameters.AddWithValue(@"Id_pelanggan", txt_IdPelanggan.Text);
                cmd.Parameters.AddWithValue(@"Nama_pelanggan", txt_NamaPelanggan.Text);
                cmd.Parameters.AddWithValue(@"Gender", comboBox_Gender.Text);
                cmd.Parameters.AddWithValue(@"Alamat", txt_Alamat.Text);
                cmd.Parameters.AddWithValue(@"Nik_ktp", txt_nikKtp.Text);
                cmd.Parameters.AddWithValue(@"No_telepon", Int64.Parse(txt_NoTelepon.Text));

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
            }

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil diupdate !", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                txt_NamaPelanggan.Clear();
                txt_IdPelanggan.Clear();
                comboBox_Gender.Text = "";
                txt_Alamat.Clear();
                txt_nikKtp.Clear(); 
                txt_NoTelepon.Clear();
            }
            else
                MessageBox.Show("Data mahasiswa gagal diupdate !!!", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            
            conn.Dispose();
        }

        private void btn_DeletePelanggan_Click(object sender, EventArgs e)
        {
                // Menampilkan konfirmasi kepada pengguna
                DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data pelanggan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Jika pengguna memilih 'Yes', maka lanjutkan dengan penghapusan
                    var result = 0;

                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1LC3JE\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

                    conn.Open();

                    string sql = @"DELETE from Tbl_Pelanggan where Id_pelanggan =@Id_pelanggan";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    try
                    {
                        cmd.Parameters.AddWithValue(@"Id_pelanggan", txt_IdPelanggan.Text);
                        cmd.Parameters.AddWithValue(@"Nama_pelanggan", txt_NamaPelanggan.Text);
                        cmd.Parameters.AddWithValue(@"Gender", comboBox_Gender.Text);
                        cmd.Parameters.AddWithValue(@"Alamat", txt_Alamat.Text);
                        cmd.Parameters.AddWithValue(@"Nik_ktp", txt_nikKtp.Text);
                        //cmd.Parameters.AddWithValue(@"Nik_ktp", int.Parse(txt_NoTelepon.Text));

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
                        MessageBox.Show("Data pelanggan berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Membersihkan input setelah penghapusan
                        txt_NamaPelanggan.Clear();
                        txt_IdPelanggan.Clear();
                        comboBox_Gender.Text = "";
                        txt_Alamat.Clear();
                        txt_nikKtp.Clear();
                        txt_NoTelepon.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Data pelanggan gagal dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    conn.Dispose();
                }
                else
                {
                    // Jika pengguna memilih 'No', tidak melakukan apa-apa
                }
        }

        //btn edit 
        private bool IsDataSelected
        {
            get { return lvwDataPelanggan.SelectedItems.Count > 0; }
        }

    }
}
