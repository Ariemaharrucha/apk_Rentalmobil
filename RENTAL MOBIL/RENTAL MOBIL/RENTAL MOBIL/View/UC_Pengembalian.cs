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
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iText.Layout.Element;
//using iText.Layout;

namespace RENTAL_MOBIL.Controller
{
    public partial class UC_Pengembalian : UserControl
    {
        public UC_Pengembalian()
        {
            InitializeComponent();
            DataPelangganListView();
            LoadDataPengembalian();

            txt_PlatNomer.Enabled = false;
            txt_NikKtp.Enabled = true;
            txt_NamaPelanggan.Enabled = false;
            txt_Total.Enabled = false;
            txt_peminjaman.Enabled = false;

            Lvw_dataPengembalian.SelectedIndexChanged += Lvw_dataPengembalian_SelectedIndexChanged;
        }

        private void btn_simpanPngmblian_Click(object sender, EventArgs e)
        {
            var result = 0;

            if (String.IsNullOrEmpty(txt_NikKtp.Text) && String.IsNullOrEmpty(cmb_StatusPengembalian.Text))
            {
                MessageBox.Show("harus diisi dahulu  !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_NikKtp.Focus();
                return;
            }

            


            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

            conn.Open();

            string sql = @"insert into Tbl_Pengembalian ( Id_penyewaan , Status_pengembalian) VALUES (@Id_penyewaan,@Status_pengembalian)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
               //cmd.Parameters.AddWithValue(@"Id_pengembalian", Id_pengembalian.Text);
               cmd.Parameters.AddWithValue(@"Id_penyewaan", txt_peminjaman.Text);
               cmd.Parameters.AddWithValue(@"Status_pengembalian", cmb_StatusPengembalian.Text);


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
                MessageBox.Show("Data pengembalian berhasil di simpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_NikKtp.Clear();
               
                cmb_StatusPengembalian.Text = " ";

            }
            else
            {
                MessageBox.Show("Data pengembalian tidak tersimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                conn.Dispose();
            LoadDataPengembalian();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_simpanPngmblian.Enabled = true;
            txt_NikKtp.Clear();

            txt_NamaPelanggan.Clear();
            txt_peminjaman.Clear();
            txt_PlatNomer.Clear();
            txt_Total.Clear();
            cmb_StatusPengembalian.Text = " ";
        }

        private void btn_hapusDataPelanggan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data pelanggan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Jika pengguna memilih 'Yes', maka lanjutkan dengan penghapusan
                var result = 0;

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

                conn.Open();

                string sql = @"DELETE from Tbl_Pengembalian where Id_penyewaan = @Id_penyewaan";
                SqlCommand cmd = new SqlCommand(sql, conn);

                try
                {
                    cmd.Parameters.AddWithValue(@"Id_penyewaan", txt_peminjaman.Text);

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
                    btn_simpanPngmblian.Enabled = true;
                    txt_NikKtp.Clear();

                    txt_NamaPelanggan.Clear();
                    txt_peminjaman.Clear();
                    txt_PlatNomer.Clear();
                    txt_Total.Clear();
                    cmb_StatusPengembalian.Text = " ";

                    //btn_DeletePenyewa.Enabled = false;
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
            LoadDataPengembalian();
        }

        //PDf
        private void btn_printData_Click(object sender, EventArgs e)
        {

            if (Lvw_dataPengembalian.Items.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                            PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
                            document.Open();

                            PdfPTable pdfTable = new PdfPTable(Lvw_dataPengembalian.Columns.Count);
                            pdfTable.SetWidths(new float[] { 1, 4, 4, 4, 3, 4 });

                            //iText.Layout.Style fontStyle = new iText.Layout.Style().SetFontSize(16);

                            // Add table headers
                            for (int i = 0; i < Lvw_dataPengembalian.Columns.Count; i++)
                            {

                                PdfPCell cell = new PdfPCell(new Phrase(Lvw_dataPengembalian.Columns[i].Text));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                pdfTable.AddCell(cell);
                            }


                            foreach (ListViewItem item in Lvw_dataPengembalian.Items)
                            {
                                for (int i = 0; i < item.SubItems.Count; i++)
                                {

                                    PdfPCell cell = new PdfPCell(new Phrase(item.SubItems[i].Text));
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    pdfTable.AddCell(cell);
                                }
                            }

                            document.Add(pdfTable);
                            document.Close();
                            writer.Close();
                            fileStream.Close();

                            MessageBox.Show("Data successfully printed to PDF.", "Info");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No record found to print.", "Info");
            }
        }

        ////////

        private void DataPelangganListView()
        {
            LoadDataPengembalian();
            Lvw_dataPengembalian.View = System.Windows.Forms.View.Details;
            Lvw_dataPengembalian.FullRowSelect = true;
            Lvw_dataPengembalian.GridLines = true;

            Lvw_dataPengembalian.Columns.Add("No", 30, HorizontalAlignment.Center);
            //Lvw_dataPengembalian.Columns.Add("ID Pengembalian", 100, HorizontalAlignment.Center);
            //Lvw_dataPengembalian.Columns.Add("ID penyewaan", 100, HorizontalAlignment.Center);
            Lvw_dataPengembalian.Columns.Add("Nik Ktp", 120, HorizontalAlignment.Center);
            Lvw_dataPengembalian.Columns.Add("Nama pelanggan", 100, HorizontalAlignment.Center);
            Lvw_dataPengembalian.Columns.Add("Plat nomer", 100, HorizontalAlignment.Center);
            Lvw_dataPengembalian.Columns.Add("Total biaya", 120, HorizontalAlignment.Center);
            Lvw_dataPengembalian.Columns.Add("Status", 120, HorizontalAlignment.Center);
        }

        private void txt_NikKtp_TextChanged(object sender, EventArgs e)
        {
            showDataPengembalian(txt_NikKtp.Text);
        }

        private void showDataPengembalian(string nik)
        {

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True"))
            {
                connection.Open();
                string querry = @"SELECT P.Id_penyewaan, Pl.Nama_pelanggan, M.Plat_nomer, Total_biaya
                        FROM Tbl_Penyewaan P
                        JOIN Tbl_Pelanggan Pl ON P.Id_pelanggan = Pl.Id_pelanggan
                        JOIN Tbl_Mobil M ON P.Id_mobil = M.Id_mobil
                        WHERE Pl.Nik_ktp = @Nik_ktp";

                using (SqlCommand command = new SqlCommand(querry, connection))
                {
                    command.Parameters.AddWithValue("@Nik_ktp", nik);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_peminjaman.Text = reader["Id_penyewaan"].ToString();
                            txt_NamaPelanggan.Text = reader["Nama_pelanggan"].ToString();
                            txt_PlatNomer.Text = reader["Plat_nomer"].ToString();
                            txt_Total.Text = reader["Total_biaya"].ToString();
                        }
                        else
                        {

                            txt_peminjaman.Text = string.Empty;
                            txt_NamaPelanggan.Text = string.Empty;
                            txt_PlatNomer.Text = string.Empty;
                            txt_Total.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void Lvw_dataPengembalian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsDataSelected)
            {
                //btn_simpan.Enabled = false;
              
                ListViewItem selected = Lvw_dataPengembalian.SelectedItems[0];

                //txt_peminjaman.Text = selected.SubItems[2].Text;
                txt_NikKtp.Text = selected.SubItems[1].Text;
                
                txt_NamaPelanggan.Text = selected.SubItems[2].Text;
                txt_PlatNomer.Text = selected.SubItems[3].Text;
                txt_Total.Text = selected.SubItems[4].Text;
                cmb_StatusPengembalian.Text = selected.SubItems[5].Text;


            }
            else
            {
                btn_simpanPngmblian.Enabled = false;
            }
        }

        private bool IsDataSelected
        {
            get { return Lvw_dataPengembalian.SelectedItems.Count > 0; }
        }

        private void LoadDataPengembalian()
        {
            Lvw_dataPengembalian.Items.Clear();

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True"))
            {
                connection.Open();
    
                string query = @"SELECT  P.Id_penyewaan, PE.Status_pengembalian, 
                        Pl.Nama_pelanggan,Pl.Nik_ktp ,M.Plat_nomer, P.Total_biaya
                FROM Tbl_Pengembalian PE
                JOIN Tbl_Penyewaan P ON PE.Id_penyewaan = P.Id_penyewaan
                JOIN Tbl_Pelanggan Pl ON P.Id_pelanggan = Pl.Id_pelanggan
                JOIN Tbl_Mobil M ON P.Id_mobil = M.Id_mobil              
                            ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var noUrut = Lvw_dataPengembalian.Items.Count + 1;

                            var item = new ListViewItem(noUrut.ToString());
                            //item.SubItems.Add(reader["Id_pengembalian"].ToString());
                            //item.SubItems.Add(reader["Id_penyewaan"].ToString());
                            item.SubItems.Add(reader["Nik_ktp"].ToString());                        
                            item.SubItems.Add(reader["Nama_pelanggan"].ToString());
                            item.SubItems.Add(reader["Plat_nomer"].ToString());
                            item.SubItems.Add(reader["Total_biaya"].ToString());
                            item.SubItems.Add(reader["Status_pengembalian"].ToString());

                            Lvw_dataPengembalian.Items.Add(item);
                        }
                    }
                }
            }
        }

    }
}