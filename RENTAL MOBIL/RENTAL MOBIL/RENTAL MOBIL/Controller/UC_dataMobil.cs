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
    public partial class UC_dataMobil : UserControl
    {
        public UC_dataMobil()
        {
            InitializeComponent();
            DataMobilListView();
        }

        

        

        private void UC_dataMobil_Load(object sender, EventArgs e)
        {

        }

        private void btn_LoadDtPelanggan_Click(object sender, EventArgs e)
        {
            Lvw_dataMobil.Items.Clear();

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1LC3JE\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

            conn.Open();


            string sql = @"SELECT Id_mobil, Plat_nomer,Merek,Harga_sewa,Warna from Tbl_mobil order by Id_mobil";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dtr = cmd.ExecuteReader();

            while (dtr.Read())
            {
                var noUrut = Lvw_dataMobil.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(dtr["Id_mobil"].ToString());
                item.SubItems.Add(dtr["Plat_nomer"].ToString());
                item.SubItems.Add(dtr["Merek"].ToString());
                item.SubItems.Add(dtr["Warna"].ToString());
                item.SubItems.Add(dtr["Harga_sewa"].ToString());

                Lvw_dataMobil.Items.Add(item);
                //lvwDataPelanggan.Items.Insert(0, item);
            }

            dtr.Dispose();
            cmd.Dispose();
            conn.Dispose();
        }

        private void DataMobilListView()
        {
            Lvw_dataMobil.View = System.Windows.Forms.View.Details;
            Lvw_dataMobil.FullRowSelect = true;
            Lvw_dataMobil.GridLines = true;

            Lvw_dataMobil.Columns.Add("No", 30, HorizontalAlignment.Center);
            Lvw_dataMobil.Columns.Add("ID mobil", 80, HorizontalAlignment.Center);
            Lvw_dataMobil.Columns.Add("Plat Nomer", 100, HorizontalAlignment.Center);
            Lvw_dataMobil.Columns.Add("Merek", 80, HorizontalAlignment.Center);
            Lvw_dataMobil.Columns.Add("Warna", 120, HorizontalAlignment.Center);
            Lvw_dataMobil.Columns.Add("Harga Sewa", 160, HorizontalAlignment.Center);
        }
    }
}
