namespace RENTAL_MOBIL.Controller
{
    partial class UC_inputDataMobil
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
            this.Lvw_dataMobil = new System.Windows.Forms.ListView();
            this.btn_LoadDtmobil = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_editDataMbl = new System.Windows.Forms.Button();
            this.btn_DeleteMbl = new System.Windows.Forms.Button();
            this.lbl_PerHari = new System.Windows.Forms.Label();
            this.txt_MerekMobil = new System.Windows.Forms.TextBox();
            this.btn_saveData = new System.Windows.Forms.Button();
            this.txt_IdMobil = new System.Windows.Forms.TextBox();
            this.txt_HargaSewa = new System.Windows.Forms.TextBox();
            this.txt_Warna = new System.Windows.Forms.TextBox();
            this.txt_PlatNomer = new System.Windows.Forms.TextBox();
            this.lbl_hargaSewa = new System.Windows.Forms.Label();
            this.lbl_warna = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_platNomer = new System.Windows.Forms.Label();
            this.lbl_idMobil = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Lvw_dataMobil);
            this.panel1.Controls.Add(this.btn_LoadDtmobil);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_editDataMbl);
            this.panel1.Controls.Add(this.btn_DeleteMbl);
            this.panel1.Controls.Add(this.lbl_PerHari);
            this.panel1.Controls.Add(this.txt_MerekMobil);
            this.panel1.Controls.Add(this.btn_saveData);
            this.panel1.Controls.Add(this.txt_IdMobil);
            this.panel1.Controls.Add(this.txt_HargaSewa);
            this.panel1.Controls.Add(this.txt_Warna);
            this.panel1.Controls.Add(this.txt_PlatNomer);
            this.panel1.Controls.Add(this.lbl_hargaSewa);
            this.panel1.Controls.Add(this.lbl_warna);
            this.panel1.Controls.Add(this.lbl_gender);
            this.panel1.Controls.Add(this.lbl_platNomer);
            this.panel1.Controls.Add(this.lbl_idMobil);
            this.panel1.Location = new System.Drawing.Point(22, 21);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(637, 648);
            this.panel1.TabIndex = 1;
            // 
            // Lvw_dataMobil
            // 
            this.Lvw_dataMobil.HideSelection = false;
            this.Lvw_dataMobil.Location = new System.Drawing.Point(24, 355);
            this.Lvw_dataMobil.Name = "Lvw_dataMobil";
            this.Lvw_dataMobil.Size = new System.Drawing.Size(593, 275);
            this.Lvw_dataMobil.TabIndex = 25;
            this.Lvw_dataMobil.UseCompatibleStateImageBehavior = false;
            this.Lvw_dataMobil.SelectedIndexChanged += new System.EventHandler(this.Lvw_dataMobil_SelectedIndexChanged);
            // 
            // btn_LoadDtmobil
            // 
            this.btn_LoadDtmobil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_LoadDtmobil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadDtmobil.FlatAppearance.BorderSize = 0;
            this.btn_LoadDtmobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadDtmobil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadDtmobil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_LoadDtmobil.Location = new System.Drawing.Point(27, 293);
            this.btn_LoadDtmobil.Name = "btn_LoadDtmobil";
            this.btn_LoadDtmobil.Size = new System.Drawing.Size(97, 42);
            this.btn_LoadDtmobil.TabIndex = 24;
            this.btn_LoadDtmobil.Text = "Load Data";
            this.btn_LoadDtmobil.UseVisualStyleBackColor = false;
            this.btn_LoadDtmobil.Click += new System.EventHandler(this.btn_LoadDtmobil_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Silver;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(148, 293);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(93, 42);
            this.btn_Cancel.TabIndex = 23;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_editDataMbl
            // 
            this.btn_editDataMbl.BackColor = System.Drawing.Color.Yellow;
            this.btn_editDataMbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editDataMbl.FlatAppearance.BorderSize = 0;
            this.btn_editDataMbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editDataMbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editDataMbl.ForeColor = System.Drawing.Color.White;
            this.btn_editDataMbl.Location = new System.Drawing.Point(388, 293);
            this.btn_editDataMbl.Name = "btn_editDataMbl";
            this.btn_editDataMbl.Size = new System.Drawing.Size(93, 42);
            this.btn_editDataMbl.TabIndex = 22;
            this.btn_editDataMbl.Text = "Edit Data";
            this.btn_editDataMbl.UseVisualStyleBackColor = false;
            this.btn_editDataMbl.Click += new System.EventHandler(this.btn_editDataMbl_Click);
            // 
            // btn_DeleteMbl
            // 
            this.btn_DeleteMbl.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteMbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteMbl.FlatAppearance.BorderSize = 0;
            this.btn_DeleteMbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteMbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteMbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DeleteMbl.Location = new System.Drawing.Point(271, 293);
            this.btn_DeleteMbl.Name = "btn_DeleteMbl";
            this.btn_DeleteMbl.Size = new System.Drawing.Size(97, 42);
            this.btn_DeleteMbl.TabIndex = 20;
            this.btn_DeleteMbl.Text = "Delete";
            this.btn_DeleteMbl.UseVisualStyleBackColor = false;
            this.btn_DeleteMbl.Click += new System.EventHandler(this.btn_DeleteMbl_Click);
            // 
            // lbl_PerHari
            // 
            this.lbl_PerHari.AutoSize = true;
            this.lbl_PerHari.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PerHari.Location = new System.Drawing.Point(337, 237);
            this.lbl_PerHari.Name = "lbl_PerHari";
            this.lbl_PerHari.Size = new System.Drawing.Size(51, 21);
            this.lbl_PerHari.TabIndex = 16;
            this.lbl_PerHari.Text = "/ Hari";
            // 
            // txt_MerekMobil
            // 
            this.txt_MerekMobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MerekMobil.Location = new System.Drawing.Point(186, 129);
            this.txt_MerekMobil.Multiline = true;
            this.txt_MerekMobil.Name = "txt_MerekMobil";
            this.txt_MerekMobil.Size = new System.Drawing.Size(171, 27);
            this.txt_MerekMobil.TabIndex = 15;
            // 
            // btn_saveData
            // 
            this.btn_saveData.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_saveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveData.FlatAppearance.BorderSize = 0;
            this.btn_saveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveData.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_saveData.Location = new System.Drawing.Point(504, 293);
            this.btn_saveData.Name = "btn_saveData";
            this.btn_saveData.Size = new System.Drawing.Size(101, 42);
            this.btn_saveData.TabIndex = 14;
            this.btn_saveData.Text = "save data";
            this.btn_saveData.UseVisualStyleBackColor = false;
            this.btn_saveData.Click += new System.EventHandler(this.btn_saveData_Click);
            // 
            // txt_IdMobil
            // 
            this.txt_IdMobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdMobil.Location = new System.Drawing.Point(186, 30);
            this.txt_IdMobil.Multiline = true;
            this.txt_IdMobil.Name = "txt_IdMobil";
            this.txt_IdMobil.Size = new System.Drawing.Size(385, 27);
            this.txt_IdMobil.TabIndex = 11;
            this.txt_IdMobil.Click += new System.EventHandler(this.txt_IdMobil_Click);
            // 
            // txt_HargaSewa
            // 
            this.txt_HargaSewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HargaSewa.Location = new System.Drawing.Point(186, 234);
            this.txt_HargaSewa.Multiline = true;
            this.txt_HargaSewa.Name = "txt_HargaSewa";
            this.txt_HargaSewa.Size = new System.Drawing.Size(210, 27);
            this.txt_HargaSewa.TabIndex = 10;
            // 
            // txt_Warna
            // 
            this.txt_Warna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Warna.Location = new System.Drawing.Point(186, 179);
            this.txt_Warna.Multiline = true;
            this.txt_Warna.Name = "txt_Warna";
            this.txt_Warna.Size = new System.Drawing.Size(385, 27);
            this.txt_Warna.TabIndex = 9;
            // 
            // txt_PlatNomer
            // 
            this.txt_PlatNomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PlatNomer.Location = new System.Drawing.Point(186, 80);
            this.txt_PlatNomer.Multiline = true;
            this.txt_PlatNomer.Name = "txt_PlatNomer";
            this.txt_PlatNomer.Size = new System.Drawing.Size(385, 27);
            this.txt_PlatNomer.TabIndex = 7;
            // 
            // lbl_hargaSewa
            // 
            this.lbl_hargaSewa.AutoSize = true;
            this.lbl_hargaSewa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hargaSewa.Location = new System.Drawing.Point(23, 236);
            this.lbl_hargaSewa.Name = "lbl_hargaSewa";
            this.lbl_hargaSewa.Size = new System.Drawing.Size(96, 21);
            this.lbl_hargaSewa.TabIndex = 5;
            this.lbl_hargaSewa.Text = "Harga Sewa";
            // 
            // lbl_warna
            // 
            this.lbl_warna.AutoSize = true;
            this.lbl_warna.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warna.Location = new System.Drawing.Point(23, 185);
            this.lbl_warna.Name = "lbl_warna";
            this.lbl_warna.Size = new System.Drawing.Size(55, 21);
            this.lbl_warna.TabIndex = 4;
            this.lbl_warna.Text = "Warna";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(23, 135);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(57, 21);
            this.lbl_gender.TabIndex = 3;
            this.lbl_gender.Text = "Merek";
            // 
            // lbl_platNomer
            // 
            this.lbl_platNomer.AutoSize = true;
            this.lbl_platNomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_platNomer.Location = new System.Drawing.Point(20, 82);
            this.lbl_platNomer.Name = "lbl_platNomer";
            this.lbl_platNomer.Size = new System.Drawing.Size(92, 21);
            this.lbl_platNomer.TabIndex = 2;
            this.lbl_platNomer.Text = "Plat Nomer";
            // 
            // lbl_idMobil
            // 
            this.lbl_idMobil.AutoSize = true;
            this.lbl_idMobil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idMobil.Location = new System.Drawing.Point(20, 33);
            this.lbl_idMobil.Name = "lbl_idMobil";
            this.lbl_idMobil.Size = new System.Drawing.Size(73, 21);
            this.lbl_idMobil.TabIndex = 0;
            this.lbl_idMobil.Text = "ID Mobil";
            // 
            // UC_inputDataMobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 672);
            this.Controls.Add(this.panel1);
            this.Name = "UC_inputDataMobil";
            this.Size = new System.Drawing.Size(625, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_saveData;
        private System.Windows.Forms.TextBox txt_IdMobil;
        private System.Windows.Forms.TextBox txt_HargaSewa;
        private System.Windows.Forms.TextBox txt_Warna;
        private System.Windows.Forms.TextBox txt_PlatNomer;
        private System.Windows.Forms.Label lbl_hargaSewa;
        private System.Windows.Forms.Label lbl_warna;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_platNomer;
        private System.Windows.Forms.Label lbl_idMobil;
        private System.Windows.Forms.TextBox txt_MerekMobil;
        private System.Windows.Forms.Label lbl_PerHari;
        private System.Windows.Forms.Button btn_DeleteMbl;
        private System.Windows.Forms.Button btn_editDataMbl;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_LoadDtmobil;
        private System.Windows.Forms.ListView Lvw_dataMobil;
    }
}
