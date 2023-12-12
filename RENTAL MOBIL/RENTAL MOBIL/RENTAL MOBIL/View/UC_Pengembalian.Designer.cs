namespace RENTAL_MOBIL.Controller
{
    partial class UC_Pengembalian
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_printData = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_simpanPngmblian = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_peminjaman = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_StatusPengembalian = new System.Windows.Forms.ComboBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.txt_PlatNomer = new System.Windows.Forms.TextBox();
            this.txt_NamaPelanggan = new System.Windows.Forms.TextBox();
            this.txt_NikKtp = new System.Windows.Forms.TextBox();
            this.btn_hapusDataPelanggan = new System.Windows.Forms.Button();
            this.Lvw_dataPengembalian = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_printData);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_simpanPngmblian);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_peminjaman);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_StatusPengembalian);
            this.panel1.Controls.Add(this.txt_Total);
            this.panel1.Controls.Add(this.txt_PlatNomer);
            this.panel1.Controls.Add(this.txt_NamaPelanggan);
            this.panel1.Controls.Add(this.txt_NikKtp);
            this.panel1.Controls.Add(this.btn_hapusDataPelanggan);
            this.panel1.Controls.Add(this.Lvw_dataPengembalian);
            this.panel1.Location = new System.Drawing.Point(18, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 583);
            this.panel1.TabIndex = 4;
            // 
            // btn_printData
            // 
            this.btn_printData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_printData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_printData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_printData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_printData.Location = new System.Drawing.Point(458, 523);
            this.btn_printData.Name = "btn_printData";
            this.btn_printData.Size = new System.Drawing.Size(183, 42);
            this.btn_printData.TabIndex = 48;
            this.btn_printData.Text = "Print Data";
            this.btn_printData.UseVisualStyleBackColor = false;
            this.btn_printData.Click += new System.EventHandler(this.btn_printData_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancel.Location = new System.Drawing.Point(409, 219);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(101, 42);
            this.btn_cancel.TabIndex = 47;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_simpanPngmblian
            // 
            this.btn_simpanPngmblian.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_simpanPngmblian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simpanPngmblian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpanPngmblian.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_simpanPngmblian.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_simpanPngmblian.Location = new System.Drawing.Point(536, 218);
            this.btn_simpanPngmblian.Name = "btn_simpanPngmblian";
            this.btn_simpanPngmblian.Size = new System.Drawing.Size(101, 42);
            this.btn_simpanPngmblian.TabIndex = 46;
            this.btn_simpanPngmblian.Text = "Simpan";
            this.btn_simpanPngmblian.UseVisualStyleBackColor = false;
            this.btn_simpanPngmblian.Click += new System.EventHandler(this.btn_simpanPngmblian_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(362, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(362, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "PlatMobil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nik Ktp";
            // 
            // txt_peminjaman
            // 
            this.txt_peminjaman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_peminjaman.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_peminjaman.Location = new System.Drawing.Point(151, 74);
            this.txt_peminjaman.Multiline = true;
            this.txt_peminjaman.Name = "txt_peminjaman";
            this.txt_peminjaman.Size = new System.Drawing.Size(155, 25);
            this.txt_peminjaman.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID Penyewaan";
            // 
            // cmb_StatusPengembalian
            // 
            this.cmb_StatusPengembalian.FormattingEnabled = true;
            this.cmb_StatusPengembalian.Items.AddRange(new object[] {
            "Lunas ",
            "Belum Lunas"});
            this.cmb_StatusPengembalian.Location = new System.Drawing.Point(486, 123);
            this.cmb_StatusPengembalian.Name = "cmb_StatusPengembalian";
            this.cmb_StatusPengembalian.Size = new System.Drawing.Size(121, 21);
            this.cmb_StatusPengembalian.TabIndex = 37;
            // 
            // txt_Total
            // 
            this.txt_Total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Total.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Total.Location = new System.Drawing.Point(486, 74);
            this.txt_Total.Multiline = true;
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(155, 25);
            this.txt_Total.TabIndex = 36;
            // 
            // txt_PlatNomer
            // 
            this.txt_PlatNomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_PlatNomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_PlatNomer.Location = new System.Drawing.Point(151, 165);
            this.txt_PlatNomer.Multiline = true;
            this.txt_PlatNomer.Name = "txt_PlatNomer";
            this.txt_PlatNomer.Size = new System.Drawing.Size(155, 25);
            this.txt_PlatNomer.TabIndex = 34;
            // 
            // txt_NamaPelanggan
            // 
            this.txt_NamaPelanggan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NamaPelanggan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_NamaPelanggan.Location = new System.Drawing.Point(151, 123);
            this.txt_NamaPelanggan.Multiline = true;
            this.txt_NamaPelanggan.Name = "txt_NamaPelanggan";
            this.txt_NamaPelanggan.Size = new System.Drawing.Size(155, 25);
            this.txt_NamaPelanggan.TabIndex = 33;
            // 
            // txt_NikKtp
            // 
            this.txt_NikKtp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NikKtp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_NikKtp.Location = new System.Drawing.Point(151, 33);
            this.txt_NikKtp.Multiline = true;
            this.txt_NikKtp.Name = "txt_NikKtp";
            this.txt_NikKtp.Size = new System.Drawing.Size(155, 25);
            this.txt_NikKtp.TabIndex = 32;
            this.txt_NikKtp.TextChanged += new System.EventHandler(this.txt_NikKtp_TextChanged);
            // 
            // btn_hapusDataPelanggan
            // 
            this.btn_hapusDataPelanggan.BackColor = System.Drawing.Color.Red;
            this.btn_hapusDataPelanggan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hapusDataPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapusDataPelanggan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_hapusDataPelanggan.Location = new System.Drawing.Point(17, 220);
            this.btn_hapusDataPelanggan.Name = "btn_hapusDataPelanggan";
            this.btn_hapusDataPelanggan.Size = new System.Drawing.Size(101, 42);
            this.btn_hapusDataPelanggan.TabIndex = 2;
            this.btn_hapusDataPelanggan.Text = "Hapus Data pelanggan";
            this.btn_hapusDataPelanggan.UseVisualStyleBackColor = false;
            this.btn_hapusDataPelanggan.Click += new System.EventHandler(this.btn_hapusDataPelanggan_Click);
            // 
            // Lvw_dataPengembalian
            // 
            this.Lvw_dataPengembalian.HideSelection = false;
            this.Lvw_dataPengembalian.Location = new System.Drawing.Point(16, 275);
            this.Lvw_dataPengembalian.Name = "Lvw_dataPengembalian";
            this.Lvw_dataPengembalian.Size = new System.Drawing.Size(624, 238);
            this.Lvw_dataPengembalian.TabIndex = 1;
            this.Lvw_dataPengembalian.UseCompatibleStateImageBehavior = false;
            this.Lvw_dataPengembalian.SelectedIndexChanged += new System.EventHandler(this.Lvw_dataPengembalian_SelectedIndexChanged);
            // 
            // UC_Pengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 600);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Pengembalian";
            this.Size = new System.Drawing.Size(642, 509);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_hapusDataPelanggan;
        private System.Windows.Forms.ListView Lvw_dataPengembalian;
        private System.Windows.Forms.ComboBox cmb_StatusPengembalian;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.TextBox txt_PlatNomer;
        private System.Windows.Forms.TextBox txt_NamaPelanggan;
        private System.Windows.Forms.TextBox txt_NikKtp;
        private System.Windows.Forms.TextBox txt_peminjaman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_simpanPngmblian;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_printData;
    }
}
