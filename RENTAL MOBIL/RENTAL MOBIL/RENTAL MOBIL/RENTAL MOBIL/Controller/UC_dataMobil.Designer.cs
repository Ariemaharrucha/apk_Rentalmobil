﻿namespace RENTAL_MOBIL.Controller
{
    partial class UC_dataMobil
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
            this.lbl_merekMbl = new System.Windows.Forms.Label();
            this.lbl_jenisMbl = new System.Windows.Forms.Label();
            this.lbl_warna = new System.Windows.Forms.Label();
            this.Lvw_dataMobil = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LoadDtmobil = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_DeleteMbl = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_editDataMbl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_merekMbl
            // 
            this.lbl_merekMbl.AutoSize = true;
            this.lbl_merekMbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_merekMbl.Location = new System.Drawing.Point(21, 21);
            this.lbl_merekMbl.Name = "lbl_merekMbl";
            this.lbl_merekMbl.Size = new System.Drawing.Size(97, 20);
            this.lbl_merekMbl.TabIndex = 0;
            this.lbl_merekMbl.Text = "Merek mobil";
            // 
            // lbl_jenisMbl
            // 
            this.lbl_jenisMbl.AutoSize = true;
            this.lbl_jenisMbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jenisMbl.Location = new System.Drawing.Point(21, 53);
            this.lbl_jenisMbl.Name = "lbl_jenisMbl";
            this.lbl_jenisMbl.Size = new System.Drawing.Size(88, 20);
            this.lbl_jenisMbl.TabIndex = 1;
            this.lbl_jenisMbl.Text = "Jenis mobil";
            // 
            // lbl_warna
            // 
            this.lbl_warna.AutoSize = true;
            this.lbl_warna.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warna.Location = new System.Drawing.Point(21, 84);
            this.lbl_warna.Name = "lbl_warna";
            this.lbl_warna.Size = new System.Drawing.Size(54, 20);
            this.lbl_warna.TabIndex = 2;
            this.lbl_warna.Text = "Warna";
            // 
            // Lvw_dataMobil
            // 
            this.Lvw_dataMobil.HideSelection = false;
            this.Lvw_dataMobil.Location = new System.Drawing.Point(16, 168);
            this.Lvw_dataMobil.Name = "Lvw_dataMobil";
            this.Lvw_dataMobil.Size = new System.Drawing.Size(579, 275);
            this.Lvw_dataMobil.TabIndex = 3;
            this.Lvw_dataMobil.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_editDataMbl);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_DeleteMbl);
            this.panel1.Controls.Add(this.btn_LoadDtmobil);
            this.panel1.Controls.Add(this.Lvw_dataMobil);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lbl_merekMbl);
            this.panel1.Controls.Add(this.lbl_warna);
            this.panel1.Controls.Add(this.lbl_jenisMbl);
            this.panel1.Location = new System.Drawing.Point(42, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 463);
            this.panel1.TabIndex = 4;
            // 
            // btn_LoadDtmobil
            // 
            this.btn_LoadDtmobil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_LoadDtmobil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadDtmobil.FlatAppearance.BorderSize = 0;
            this.btn_LoadDtmobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadDtmobil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadDtmobil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_LoadDtmobil.Location = new System.Drawing.Point(501, 86);
            this.btn_LoadDtmobil.Name = "btn_LoadDtmobil";
            this.btn_LoadDtmobil.Size = new System.Drawing.Size(97, 42);
            this.btn_LoadDtmobil.TabIndex = 15;
            this.btn_LoadDtmobil.Text = "Load Data";
            this.btn_LoadDtmobil.UseVisualStyleBackColor = false;
            this.btn_LoadDtmobil.Click += new System.EventHandler(this.btn_LoadDtPelanggan_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(168, 86);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(168, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btn_DeleteMbl
            // 
            this.btn_DeleteMbl.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteMbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteMbl.FlatAppearance.BorderSize = 0;
            this.btn_DeleteMbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteMbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteMbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DeleteMbl.Location = new System.Drawing.Point(386, 86);
            this.btn_DeleteMbl.Name = "btn_DeleteMbl";
            this.btn_DeleteMbl.Size = new System.Drawing.Size(97, 42);
            this.btn_DeleteMbl.TabIndex = 19;
            this.btn_DeleteMbl.Text = "Delete";
            this.btn_DeleteMbl.UseVisualStyleBackColor = false;
            this.btn_DeleteMbl.Click += new System.EventHandler(this.btn_DeleteMbl_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Silver;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(386, 23);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(93, 42);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_editDataMbl
            // 
            this.btn_editDataMbl.BackColor = System.Drawing.Color.Yellow;
            this.btn_editDataMbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editDataMbl.FlatAppearance.BorderSize = 0;
            this.btn_editDataMbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editDataMbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editDataMbl.ForeColor = System.Drawing.Color.White;
            this.btn_editDataMbl.Location = new System.Drawing.Point(501, 23);
            this.btn_editDataMbl.Name = "btn_editDataMbl";
            this.btn_editDataMbl.Size = new System.Drawing.Size(93, 42);
            this.btn_editDataMbl.TabIndex = 21;
            this.btn_editDataMbl.Text = "Edit Data";
            this.btn_editDataMbl.UseVisualStyleBackColor = false;
            // 
            // UC_dataMobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UC_dataMobil";
            this.Size = new System.Drawing.Size(693, 560);
            this.Load += new System.EventHandler(this.UC_dataMobil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_merekMbl;
        private System.Windows.Forms.Label lbl_jenisMbl;
        private System.Windows.Forms.Label lbl_warna;
        private System.Windows.Forms.ListView Lvw_dataMobil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_LoadDtmobil;
        private System.Windows.Forms.Button btn_DeleteMbl;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_editDataMbl;
    }
}
