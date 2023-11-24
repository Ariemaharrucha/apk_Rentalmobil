namespace RENTAL_MOBIL.Controller
{
    partial class UC_dataSewa
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
            this.txtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Hitung = new System.Windows.Forms.Button();
            this.lbl_Hari = new System.Windows.Forms.Label();
            this.txt_LamaHari = new System.Windows.Forms.TextBox();
            this.dateTime_MulaiSewa = new System.Windows.Forms.DateTimePicker();
            this.txt_IdTransaksi = new System.Windows.Forms.TextBox();
            this.lbl_LamaSewa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_IdKaryawan = new System.Windows.Forms.Label();
            this.lblTransaksi = new System.Windows.Forms.Label();
            this.txt_IdKaryawan = new System.Windows.Forms.TextBox();
            this.lblDataMobil = new System.Windows.Forms.Label();
            this.lblDataPelanggan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.Lvw_ricianSewa = new System.Windows.Forms.ListView();
            this.lbl_Rincian = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_NikKtp = new System.Windows.Forms.TextBox();
            this.txt_Notlpn = new System.Windows.Forms.TextBox();
            this.txt_IdPelanggan = new System.Windows.Forms.TextBox();
            this.lblNik = new System.Windows.Forms.Label();
            this.lblNoTlpn = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Harga = new System.Windows.Forms.TextBox();
            this.txt_PlatNo = new System.Windows.Forms.TextBox();
            this.txt_Merek = new System.Windows.Forms.TextBox();
            this.txt_IdMobil = new System.Windows.Forms.TextBox();
            this.lblWarna = new System.Windows.Forms.Label();
            this.lblPlatNo = new System.Windows.Forms.Label();
            this.lblMerek = new System.Windows.Forms.Label();
            this.lbl_IdMobil = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNamaPelanggan
            // 
            this.txtNamaPelanggan.Location = new System.Drawing.Point(117, 57);
            this.txtNamaPelanggan.Multiline = true;
            this.txtNamaPelanggan.Name = "txtNamaPelanggan";
            this.txtNamaPelanggan.Size = new System.Drawing.Size(155, 25);
            this.txtNamaPelanggan.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblDataMobil);
            this.panel1.Controls.Add(this.lblDataPelanggan);
            this.panel1.Controls.Add(this.btn_simpan);
            this.panel1.Controls.Add(this.Lvw_ricianSewa);
            this.panel1.Controls.Add(this.lbl_Rincian);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(26, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 642);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Penyewaan";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_Hitung);
            this.panel4.Controls.Add(this.lbl_Hari);
            this.panel4.Controls.Add(this.txt_LamaHari);
            this.panel4.Controls.Add(this.dateTime_MulaiSewa);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txt_IdTransaksi);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.lbl_LamaSewa);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lbl_IdKaryawan);
            this.panel4.Controls.Add(this.lblTransaksi);
            this.panel4.Controls.Add(this.txt_IdKaryawan);
            this.panel4.Location = new System.Drawing.Point(18, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(404, 247);
            this.panel4.TabIndex = 29;
            // 
            // btn_Hitung
            // 
            this.btn_Hitung.BackColor = System.Drawing.Color.Silver;
            this.btn_Hitung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hitung.FlatAppearance.BorderSize = 0;
            this.btn_Hitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hitung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hitung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Hitung.Location = new System.Drawing.Point(11, 190);
            this.btn_Hitung.Name = "btn_Hitung";
            this.btn_Hitung.Size = new System.Drawing.Size(93, 34);
            this.btn_Hitung.TabIndex = 30;
            this.btn_Hitung.Text = "Hitung";
            this.btn_Hitung.UseVisualStyleBackColor = false;
            // 
            // lbl_Hari
            // 
            this.lbl_Hari.AutoSize = true;
            this.lbl_Hari.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hari.Location = new System.Drawing.Point(218, 146);
            this.lbl_Hari.Name = "lbl_Hari";
            this.lbl_Hari.Size = new System.Drawing.Size(33, 17);
            this.lbl_Hari.TabIndex = 32;
            this.lbl_Hari.Text = "Hari";
            // 
            // txt_LamaHari
            // 
            this.txt_LamaHari.Location = new System.Drawing.Point(169, 139);
            this.txt_LamaHari.Multiline = true;
            this.txt_LamaHari.Name = "txt_LamaHari";
            this.txt_LamaHari.Size = new System.Drawing.Size(43, 25);
            this.txt_LamaHari.TabIndex = 31;
            // 
            // dateTime_MulaiSewa
            // 
            this.dateTime_MulaiSewa.Location = new System.Drawing.Point(169, 99);
            this.dateTime_MulaiSewa.Name = "dateTime_MulaiSewa";
            this.dateTime_MulaiSewa.Size = new System.Drawing.Size(131, 20);
            this.dateTime_MulaiSewa.TabIndex = 30;
            // 
            // txt_IdTransaksi
            // 
            this.txt_IdTransaksi.Location = new System.Drawing.Point(169, 20);
            this.txt_IdTransaksi.Multiline = true;
            this.txt_IdTransaksi.Name = "txt_IdTransaksi";
            this.txt_IdTransaksi.Size = new System.Drawing.Size(155, 25);
            this.txt_IdTransaksi.TabIndex = 29;
            // 
            // lbl_LamaSewa
            // 
            this.lbl_LamaSewa.AutoSize = true;
            this.lbl_LamaSewa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_LamaSewa.Location = new System.Drawing.Point(9, 142);
            this.lbl_LamaSewa.Name = "lbl_LamaSewa";
            this.lbl_LamaSewa.Size = new System.Drawing.Size(133, 20);
            this.lbl_LamaSewa.TabIndex = 28;
            this.lbl_LamaSewa.Text = "Lama Peminjaman";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tanggal Mulai Sewa";
            // 
            // lbl_IdKaryawan
            // 
            this.lbl_IdKaryawan.AutoSize = true;
            this.lbl_IdKaryawan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_IdKaryawan.Location = new System.Drawing.Point(7, 60);
            this.lbl_IdKaryawan.Name = "lbl_IdKaryawan";
            this.lbl_IdKaryawan.Size = new System.Drawing.Size(96, 20);
            this.lbl_IdKaryawan.TabIndex = 26;
            this.lbl_IdKaryawan.Text = "Id_Karyawan";
            // 
            // lblTransaksi
            // 
            this.lblTransaksi.AutoSize = true;
            this.lblTransaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTransaksi.Location = new System.Drawing.Point(8, 23);
            this.lblTransaksi.Name = "lblTransaksi";
            this.lblTransaksi.Size = new System.Drawing.Size(100, 20);
            this.lblTransaksi.TabIndex = 25;
            this.lblTransaksi.Text = "ID Pelanggan";
            // 
            // txt_IdKaryawan
            // 
            this.txt_IdKaryawan.Location = new System.Drawing.Point(169, 57);
            this.txt_IdKaryawan.Multiline = true;
            this.txt_IdKaryawan.Name = "txt_IdKaryawan";
            this.txt_IdKaryawan.Size = new System.Drawing.Size(155, 25);
            this.txt_IdKaryawan.TabIndex = 12;
            // 
            // lblDataMobil
            // 
            this.lblDataMobil.AutoSize = true;
            this.lblDataMobil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataMobil.Location = new System.Drawing.Point(362, 15);
            this.lblDataMobil.Name = "lblDataMobil";
            this.lblDataMobil.Size = new System.Drawing.Size(90, 21);
            this.lblDataMobil.TabIndex = 25;
            this.lblDataMobil.Text = "Data Mobil";
            // 
            // lblDataPelanggan
            // 
            this.lblDataPelanggan.AutoSize = true;
            this.lblDataPelanggan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPelanggan.Location = new System.Drawing.Point(40, 13);
            this.lblDataPelanggan.Name = "lblDataPelanggan";
            this.lblDataPelanggan.Size = new System.Drawing.Size(122, 21);
            this.lblDataPelanggan.TabIndex = 24;
            this.lblDataPelanggan.Text = "Data Pelanggan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Rp . ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(256, 192);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(116, 36);
            this.textBox6.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total ";
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_simpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_simpan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_simpan.Location = new System.Drawing.Point(449, 451);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(105, 42);
            this.btn_simpan.TabIndex = 19;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            // 
            // Lvw_ricianSewa
            // 
            this.Lvw_ricianSewa.HideSelection = false;
            this.Lvw_ricianSewa.Location = new System.Drawing.Point(18, 520);
            this.Lvw_ricianSewa.Name = "Lvw_ricianSewa";
            this.Lvw_ricianSewa.Size = new System.Drawing.Size(576, 75);
            this.Lvw_ricianSewa.TabIndex = 18;
            this.Lvw_ricianSewa.UseCompatibleStateImageBehavior = false;
            this.Lvw_ricianSewa.SelectedIndexChanged += new System.EventHandler(this.Lvw_ricianSewa_SelectedIndexChanged);
            // 
            // lbl_Rincian
            // 
            this.lbl_Rincian.AutoSize = true;
            this.lbl_Rincian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rincian.Location = new System.Drawing.Point(482, 341);
            this.lbl_Rincian.Name = "lbl_Rincian";
            this.lbl_Rincian.Size = new System.Drawing.Size(104, 21);
            this.lbl_Rincian.TabIndex = 8;
            this.lbl_Rincian.Text = "Rincian Sewa";
            this.lbl_Rincian.Click += new System.EventHandler(this.lbl_Rincian_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_NikKtp);
            this.panel2.Controls.Add(this.txt_Notlpn);
            this.panel2.Controls.Add(this.txt_IdPelanggan);
            this.panel2.Controls.Add(this.lblNik);
            this.panel2.Controls.Add(this.lblNoTlpn);
            this.panel2.Controls.Add(this.lblNama);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNamaPelanggan);
            this.panel2.Location = new System.Drawing.Point(14, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 177);
            this.panel2.TabIndex = 26;
            // 
            // txt_NikKtp
            // 
            this.txt_NikKtp.Location = new System.Drawing.Point(117, 133);
            this.txt_NikKtp.Multiline = true;
            this.txt_NikKtp.Name = "txt_NikKtp";
            this.txt_NikKtp.Size = new System.Drawing.Size(155, 25);
            this.txt_NikKtp.TabIndex = 31;
            // 
            // txt_Notlpn
            // 
            this.txt_Notlpn.Location = new System.Drawing.Point(117, 96);
            this.txt_Notlpn.Multiline = true;
            this.txt_Notlpn.Name = "txt_Notlpn";
            this.txt_Notlpn.Size = new System.Drawing.Size(155, 25);
            this.txt_Notlpn.TabIndex = 30;
            // 
            // txt_IdPelanggan
            // 
            this.txt_IdPelanggan.Location = new System.Drawing.Point(118, 20);
            this.txt_IdPelanggan.Multiline = true;
            this.txt_IdPelanggan.Name = "txt_IdPelanggan";
            this.txt_IdPelanggan.Size = new System.Drawing.Size(155, 25);
            this.txt_IdPelanggan.TabIndex = 29;
            // 
            // lblNik
            // 
            this.lblNik.AutoSize = true;
            this.lblNik.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNik.Location = new System.Drawing.Point(9, 135);
            this.lblNik.Name = "lblNik";
            this.lblNik.Size = new System.Drawing.Size(55, 17);
            this.lblNik.TabIndex = 28;
            this.lblNik.Text = "Nik KTP";
            // 
            // lblNoTlpn
            // 
            this.lblNoTlpn.AutoSize = true;
            this.lblNoTlpn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTlpn.Location = new System.Drawing.Point(9, 97);
            this.lblNoTlpn.Name = "lblNoTlpn";
            this.lblNoTlpn.Size = new System.Drawing.Size(77, 17);
            this.lblNoTlpn.TabIndex = 27;
            this.lblNoTlpn.Text = "No Telepon";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(9, 57);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(44, 17);
            this.lblNama.TabIndex = 26;
            this.lblNama.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID Pelanggan";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_Harga);
            this.panel3.Controls.Add(this.txt_PlatNo);
            this.panel3.Controls.Add(this.txt_Merek);
            this.panel3.Controls.Add(this.txt_IdMobil);
            this.panel3.Controls.Add(this.lblWarna);
            this.panel3.Controls.Add(this.lblPlatNo);
            this.panel3.Controls.Add(this.lblMerek);
            this.panel3.Controls.Add(this.lbl_IdMobil);
            this.panel3.Location = new System.Drawing.Point(335, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 177);
            this.panel3.TabIndex = 27;
            // 
            // txt_Harga
            // 
            this.txt_Harga.Location = new System.Drawing.Point(126, 134);
            this.txt_Harga.Multiline = true;
            this.txt_Harga.Name = "txt_Harga";
            this.txt_Harga.Size = new System.Drawing.Size(155, 25);
            this.txt_Harga.TabIndex = 33;
            // 
            // txt_PlatNo
            // 
            this.txt_PlatNo.Location = new System.Drawing.Point(126, 97);
            this.txt_PlatNo.Multiline = true;
            this.txt_PlatNo.Name = "txt_PlatNo";
            this.txt_PlatNo.Size = new System.Drawing.Size(155, 25);
            this.txt_PlatNo.TabIndex = 32;
            // 
            // txt_Merek
            // 
            this.txt_Merek.Location = new System.Drawing.Point(126, 57);
            this.txt_Merek.Multiline = true;
            this.txt_Merek.Name = "txt_Merek";
            this.txt_Merek.Size = new System.Drawing.Size(155, 25);
            this.txt_Merek.TabIndex = 31;
            // 
            // txt_IdMobil
            // 
            this.txt_IdMobil.Location = new System.Drawing.Point(126, 22);
            this.txt_IdMobil.Multiline = true;
            this.txt_IdMobil.Name = "txt_IdMobil";
            this.txt_IdMobil.Size = new System.Drawing.Size(155, 25);
            this.txt_IdMobil.TabIndex = 30;
            // 
            // lblWarna
            // 
            this.lblWarna.AutoSize = true;
            this.lblWarna.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarna.Location = new System.Drawing.Point(18, 134);
            this.lblWarna.Name = "lblWarna";
            this.lblWarna.Size = new System.Drawing.Size(51, 20);
            this.lblWarna.TabIndex = 3;
            this.lblWarna.Text = "Harga";
            // 
            // lblPlatNo
            // 
            this.lblPlatNo.AutoSize = true;
            this.lblPlatNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatNo.Location = new System.Drawing.Point(17, 99);
            this.lblPlatNo.Name = "lblPlatNo";
            this.lblPlatNo.Size = new System.Drawing.Size(87, 20);
            this.lblPlatNo.TabIndex = 2;
            this.lblPlatNo.Text = "Plat Nomer";
            // 
            // lblMerek
            // 
            this.lblMerek.AutoSize = true;
            this.lblMerek.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerek.Location = new System.Drawing.Point(18, 60);
            this.lblMerek.Name = "lblMerek";
            this.lblMerek.Size = new System.Drawing.Size(53, 20);
            this.lblMerek.TabIndex = 1;
            this.lblMerek.Text = "Merek";
            // 
            // lbl_IdMobil
            // 
            this.lbl_IdMobil.AutoSize = true;
            this.lbl_IdMobil.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdMobil.Location = new System.Drawing.Point(18, 22);
            this.lbl_IdMobil.Name = "lbl_IdMobil";
            this.lbl_IdMobil.Size = new System.Drawing.Size(68, 20);
            this.lbl_IdMobil.TabIndex = 0;
            this.lbl_IdMobil.Text = "ID Mobil";
            // 
            // UC_dataSewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 672);
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "UC_dataSewa";
            this.Size = new System.Drawing.Size(699, 658);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNamaPelanggan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Rincian;
        private System.Windows.Forms.ListView Lvw_ricianSewa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblDataPelanggan;
        private System.Windows.Forms.Label lblDataMobil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNoTlpn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPlatNo;
        private System.Windows.Forms.Label lblMerek;
        private System.Windows.Forms.Label lbl_IdMobil;
        private System.Windows.Forms.Label lblWarna;
        private System.Windows.Forms.TextBox txt_NikKtp;
        private System.Windows.Forms.TextBox txt_Notlpn;
        private System.Windows.Forms.TextBox txt_IdPelanggan;
        private System.Windows.Forms.Label lblNik;
        private System.Windows.Forms.TextBox txt_Harga;
        private System.Windows.Forms.TextBox txt_PlatNo;
        private System.Windows.Forms.TextBox txt_Merek;
        private System.Windows.Forms.TextBox txt_IdMobil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_IdTransaksi;
        private System.Windows.Forms.Label lbl_LamaSewa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_IdKaryawan;
        private System.Windows.Forms.Label lblTransaksi;
        private System.Windows.Forms.TextBox txt_IdKaryawan;
        private System.Windows.Forms.DateTimePicker dateTime_MulaiSewa;
        private System.Windows.Forms.TextBox txt_LamaHari;
        private System.Windows.Forms.Label lbl_Hari;
        private System.Windows.Forms.Button btn_Hitung;
    }
}
