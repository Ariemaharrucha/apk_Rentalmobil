namespace RENTAL_MOBIL.Controller
{
    partial class UC_inputPelanggan
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
            this.lvwDataPelanggan = new System.Windows.Forms.ListView();
            this.btn_LoadDtPelanggan = new System.Windows.Forms.Button();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.btn_saveData = new System.Windows.Forms.Button();
            this.btn_editData = new System.Windows.Forms.Button();
            this.txt_NamaPelanggan = new System.Windows.Forms.TextBox();
            this.txt_nikKtp = new System.Windows.Forms.TextBox();
            this.txt_Alamat = new System.Windows.Forms.TextBox();
            this.txt_IdPelanggan = new System.Windows.Forms.TextBox();
            this.lbl_fotoKtp = new System.Windows.Forms.Label();
            this.lbl_alamat = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_idPelanggan = new System.Windows.Forms.Label();
            this.lbl_namaPelanggan = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_DeletePelanggan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_DeletePelanggan);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.lvwDataPelanggan);
            this.panel1.Controls.Add(this.btn_LoadDtPelanggan);
            this.panel1.Controls.Add(this.comboBox_Gender);
            this.panel1.Controls.Add(this.btn_saveData);
            this.panel1.Controls.Add(this.btn_editData);
            this.panel1.Controls.Add(this.txt_NamaPelanggan);
            this.panel1.Controls.Add(this.txt_nikKtp);
            this.panel1.Controls.Add(this.txt_Alamat);
            this.panel1.Controls.Add(this.txt_IdPelanggan);
            this.panel1.Controls.Add(this.lbl_fotoKtp);
            this.panel1.Controls.Add(this.lbl_alamat);
            this.panel1.Controls.Add(this.lbl_gender);
            this.panel1.Controls.Add(this.lbl_idPelanggan);
            this.panel1.Controls.Add(this.lbl_namaPelanggan);
            this.panel1.Location = new System.Drawing.Point(33, 17);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(627, 627);
            this.panel1.TabIndex = 0;
            // 
            // lvwDataPelanggan
            // 
            this.lvwDataPelanggan.HideSelection = false;
            this.lvwDataPelanggan.Location = new System.Drawing.Point(24, 353);
            this.lvwDataPelanggan.Name = "lvwDataPelanggan";
            this.lvwDataPelanggan.Size = new System.Drawing.Size(576, 258);
            this.lvwDataPelanggan.TabIndex = 16;
            this.lvwDataPelanggan.UseCompatibleStateImageBehavior = false;
            this.lvwDataPelanggan.SelectedIndexChanged += new System.EventHandler(this.lvwDataPelanggan_SelectedIndexChanged);
            // 
            // btn_LoadDtPelanggan
            // 
            this.btn_LoadDtPelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_LoadDtPelanggan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadDtPelanggan.FlatAppearance.BorderSize = 0;
            this.btn_LoadDtPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadDtPelanggan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadDtPelanggan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_LoadDtPelanggan.Location = new System.Drawing.Point(24, 293);
            this.btn_LoadDtPelanggan.Name = "btn_LoadDtPelanggan";
            this.btn_LoadDtPelanggan.Size = new System.Drawing.Size(99, 42);
            this.btn_LoadDtPelanggan.TabIndex = 14;
            this.btn_LoadDtPelanggan.Text = "Load Data";
            this.btn_LoadDtPelanggan.UseVisualStyleBackColor = false;
            this.btn_LoadDtPelanggan.Click += new System.EventHandler(this.btn_LoadDtPelanggan_Click);
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Laki laki",
            "Perempuan"});
            this.comboBox_Gender.Location = new System.Drawing.Point(186, 135);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Gender.TabIndex = 15;
            // 
            // btn_saveData
            // 
            this.btn_saveData.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_saveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveData.FlatAppearance.BorderSize = 0;
            this.btn_saveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveData.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_saveData.Location = new System.Drawing.Point(499, 293);
            this.btn_saveData.Name = "btn_saveData";
            this.btn_saveData.Size = new System.Drawing.Size(101, 42);
            this.btn_saveData.TabIndex = 14;
            this.btn_saveData.Text = "save data";
            this.btn_saveData.UseVisualStyleBackColor = false;
            this.btn_saveData.Click += new System.EventHandler(this.btn_saveData_Click);
            // 
            // btn_editData
            // 
            this.btn_editData.BackColor = System.Drawing.Color.Yellow;
            this.btn_editData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editData.FlatAppearance.BorderSize = 0;
            this.btn_editData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editData.ForeColor = System.Drawing.Color.White;
            this.btn_editData.Location = new System.Drawing.Point(373, 293);
            this.btn_editData.Name = "btn_editData";
            this.btn_editData.Size = new System.Drawing.Size(106, 42);
            this.btn_editData.TabIndex = 13;
            this.btn_editData.Text = "Edit Data";
            this.btn_editData.UseVisualStyleBackColor = false;
            this.btn_editData.Click += new System.EventHandler(this.btn_editData_Click);
            // 
            // txt_NamaPelanggan
            // 
            this.txt_NamaPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NamaPelanggan.Location = new System.Drawing.Point(186, 30);
            this.txt_NamaPelanggan.Multiline = true;
            this.txt_NamaPelanggan.Name = "txt_NamaPelanggan";
            this.txt_NamaPelanggan.Size = new System.Drawing.Size(385, 27);
            this.txt_NamaPelanggan.TabIndex = 11;
            // 
            // txt_nikKtp
            // 
            this.txt_nikKtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nikKtp.Location = new System.Drawing.Point(186, 234);
            this.txt_nikKtp.Multiline = true;
            this.txt_nikKtp.Name = "txt_nikKtp";
            this.txt_nikKtp.Size = new System.Drawing.Size(385, 27);
            this.txt_nikKtp.TabIndex = 10;
            // 
            // txt_Alamat
            // 
            this.txt_Alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Alamat.Location = new System.Drawing.Point(186, 179);
            this.txt_Alamat.Multiline = true;
            this.txt_Alamat.Name = "txt_Alamat";
            this.txt_Alamat.Size = new System.Drawing.Size(385, 27);
            this.txt_Alamat.TabIndex = 9;
            // 
            // txt_IdPelanggan
            // 
            this.txt_IdPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdPelanggan.Location = new System.Drawing.Point(186, 80);
            this.txt_IdPelanggan.Multiline = true;
            this.txt_IdPelanggan.Name = "txt_IdPelanggan";
            this.txt_IdPelanggan.Size = new System.Drawing.Size(385, 27);
            this.txt_IdPelanggan.TabIndex = 7;
            this.txt_IdPelanggan.Click += new System.EventHandler(this.txt_IdPelanggan_Click);
            // 
            // lbl_fotoKtp
            // 
            this.lbl_fotoKtp.AutoSize = true;
            this.lbl_fotoKtp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fotoKtp.Location = new System.Drawing.Point(23, 236);
            this.lbl_fotoKtp.Name = "lbl_fotoKtp";
            this.lbl_fotoKtp.Size = new System.Drawing.Size(67, 21);
            this.lbl_fotoKtp.TabIndex = 5;
            this.lbl_fotoKtp.Text = "NIK Ktp";
            // 
            // lbl_alamat
            // 
            this.lbl_alamat.AutoSize = true;
            this.lbl_alamat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alamat.Location = new System.Drawing.Point(23, 185);
            this.lbl_alamat.Name = "lbl_alamat";
            this.lbl_alamat.Size = new System.Drawing.Size(61, 21);
            this.lbl_alamat.TabIndex = 4;
            this.lbl_alamat.Text = "Alamat";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(23, 135);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(64, 21);
            this.lbl_gender.TabIndex = 3;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_idPelanggan
            // 
            this.lbl_idPelanggan.AutoSize = true;
            this.lbl_idPelanggan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idPelanggan.Location = new System.Drawing.Point(20, 82);
            this.lbl_idPelanggan.Name = "lbl_idPelanggan";
            this.lbl_idPelanggan.Size = new System.Drawing.Size(106, 21);
            this.lbl_idPelanggan.TabIndex = 2;
            this.lbl_idPelanggan.Text = "Id pelanggan";
            // 
            // lbl_namaPelanggan
            // 
            this.lbl_namaPelanggan.AutoSize = true;
            this.lbl_namaPelanggan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namaPelanggan.Location = new System.Drawing.Point(20, 33);
            this.lbl_namaPelanggan.Name = "lbl_namaPelanggan";
            this.lbl_namaPelanggan.Size = new System.Drawing.Size(131, 21);
            this.lbl_namaPelanggan.TabIndex = 0;
            this.lbl_namaPelanggan.Text = "Nama Pelanggan";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Silver;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(141, 293);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(93, 42);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_DeletePelanggan
            // 
            this.btn_DeletePelanggan.BackColor = System.Drawing.Color.Red;
            this.btn_DeletePelanggan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeletePelanggan.FlatAppearance.BorderSize = 0;
            this.btn_DeletePelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeletePelanggan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeletePelanggan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DeletePelanggan.Location = new System.Drawing.Point(253, 293);
            this.btn_DeletePelanggan.Name = "btn_DeletePelanggan";
            this.btn_DeletePelanggan.Size = new System.Drawing.Size(97, 42);
            this.btn_DeletePelanggan.TabIndex = 18;
            this.btn_DeletePelanggan.Text = "Delete";
            this.btn_DeletePelanggan.UseVisualStyleBackColor = false;
            this.btn_DeletePelanggan.Click += new System.EventHandler(this.btn_DeletePelanggan_Click);
            // 
            // UC_inputPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 672);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Name = "UC_inputPelanggan";
            this.Size = new System.Drawing.Size(659, 612);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_fotoKtp;
        private System.Windows.Forms.Label lbl_alamat;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_idPelanggan;
        private System.Windows.Forms.Label lbl_namaPelanggan;
        private System.Windows.Forms.TextBox txt_nikKtp;
        private System.Windows.Forms.TextBox txt_Alamat;
        private System.Windows.Forms.TextBox txt_IdPelanggan;
        private System.Windows.Forms.TextBox txt_NamaPelanggan;
        private System.Windows.Forms.Button btn_saveData;
        private System.Windows.Forms.Button btn_editData;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.ListView lvwDataPelanggan;
        private System.Windows.Forms.Button btn_LoadDtPelanggan;
        private System.Windows.Forms.Button btn_DeletePelanggan;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
