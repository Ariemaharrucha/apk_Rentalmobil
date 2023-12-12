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

        UC_inputPelanggan ucPelanggan;
        UC_dataSewa ucDatasewa;      
        UC_inputDataMobil uc_InputDataMobil;
        UC_Pengembalian uCPengembalian;

        public Frm_menu(string userId)
        {
            InitializeComponent();
            this.userId = userId;

            ucPelanggan = new UC_inputPelanggan();
            ucDatasewa = new UC_dataSewa(userId);
            
            uc_InputDataMobil = new UC_inputDataMobil();
            uCPengembalian = new UC_Pengembalian();

            lbl_judul.Text = "Iput Pelanggan";
            panel3.Controls.Clear();
            panel3.Controls.Add(ucPelanggan);
            ucPelanggan.Dock = DockStyle.Fill;
            //uC_DataMobil1.Visible = false;
            //uC_InputPelanggan1.Visible = false;
        }
        
        private void btn_inputPelanggan_Click(object sender, EventArgs e)
        {
            lbl_judul.Text = "Iput Pelanggan";
            panel3.Controls.Clear();
            panel3.Controls.Add(ucPelanggan);
            ucPelanggan.Dock = DockStyle.Fill;
        }

        private void btnSewa_Click(object sender, EventArgs e)
        {
            lbl_judul.Text = "Data Sewa";
            panel3.Controls.Clear();
            panel3.Controls.Add(ucDatasewa);
            ucDatasewa.Dock = DockStyle.Fill;
        }

       

        private void btn_InputDataMbl_Click(object sender, EventArgs e)
        {
            lbl_judul.Text = "iput Data mobil";
            panel3.Controls.Clear();
            panel3.Controls.Add(uc_InputDataMobil);
            uc_InputDataMobil.Dock = DockStyle.Fill;
        }

        private void btn_pengembalian_Click(object sender, EventArgs e)
        {
            lbl_judul.Text = "Pengembalian mobil";
            panel3.Controls.Clear();
            panel3.Controls.Add(uCPengembalian);
            uCPengembalian.Dock = DockStyle.Fill;
        }
    }
}
