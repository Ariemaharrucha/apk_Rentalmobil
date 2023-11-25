using RENTAL_MOBIL.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RENTAL_MOBIL.View
{
    public partial class Frm_menu : Form
    {
        private string userId;
        //Controller.UC_inputPelanggan ucPelanggan = new Controller.UC_inputPelanggan();
        //Controller.UC_dataMobil ucDatamobil = new Controller.UC_dataMobil();
        //Controller.UC_dataSewa ucDatasewa = new Controller.UC_dataSewa();
        // Controller.UC_dataPelanggan ucDatapelanggan = new Controller.UC_dataPelanggan();
        //Controller.UC_inputDataMobil uc_InputDataMobil = new Controller.UC_inputDataMobil();

        Controller.UC_inputPelanggan ucPelanggan;
        Controller.UC_dataSewa ucDatasewa;
        Controller.UC_dataPelanggan ucDatapelanggan;
        Controller.UC_inputDataMobil uc_InputDataMobil;

        public Frm_menu(string userId)
        {
            InitializeComponent();
            this.userId = userId;

            ucPelanggan = new Controller.UC_inputPelanggan();
            ucDatasewa = new Controller.UC_dataSewa(userId);
            ucDatapelanggan = new Controller.UC_dataPelanggan();
            uc_InputDataMobil = new Controller.UC_inputDataMobil();

            lbl_judul.Text = "Iput Pelanggan";
            panel3.Controls.Clear();
            panel3.Controls.Add(ucPelanggan);
            ucPelanggan.Dock = DockStyle.Fill;
            //uC_DataMobil1.Visible = false;
            //uC_InputPelanggan1.Visible = false;
        }

        /*private void addController (Controller controller)
        {
            panel3.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(controller);
        }*/

        

        private void btn_inputPelanggan_Click(object sender, EventArgs e)
        {
            lbl_judul.Text = "Iput Pelanggan";
            panel3.Controls.Clear();
            panel3.Controls.Add(ucPelanggan);
            ucPelanggan.Dock = DockStyle.Fill;
        }

       /* private void btn_dataMobil_Click(object sender, EventArgs e)
        {
            lbl_judul.Text = "data mobil";
            panel3.Controls.Clear();
            panel3.Controls.Add(ucDatamobil);
            ucDatamobil.Dock = DockStyle.Fill;
        }*/

        private void btnSewa_Click(object sender, EventArgs e)
        {
            lbl_judul.Text = "Data Sewa";
            panel3.Controls.Clear();
            panel3.Controls.Add(ucDatasewa);
            ucDatasewa.Dock = DockStyle.Fill;
        }

        private void btnDatapelanggan_Click(object sender, EventArgs e)
        {
            lbl_judul.Text = "Data Pelanggan";
            panel3.Controls.Clear();
            panel3.Controls.Add(ucDatapelanggan);
            ucDatapelanggan.Dock = DockStyle.Fill;
        }

        private void btn_InputDataMbl_Click(object sender, EventArgs e)
        {
            lbl_judul.Text = "iput Data mobil";
            panel3.Controls.Clear();
            panel3.Controls.Add(uc_InputDataMobil);
            uc_InputDataMobil.Dock = DockStyle.Fill;
        }
    }
}
