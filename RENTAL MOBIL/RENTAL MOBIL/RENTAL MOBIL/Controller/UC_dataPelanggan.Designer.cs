namespace RENTAL_MOBIL.Controller
{
    partial class UC_dataPelanggan
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
            this.btn_hapusDataPelanggan = new System.Windows.Forms.Button();
            this.Lvw_dataPelanggan = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_hapusDataPelanggan);
            this.panel1.Controls.Add(this.Lvw_dataPelanggan);
            this.panel1.Location = new System.Drawing.Point(32, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 477);
            this.panel1.TabIndex = 3;
            // 
            // btn_hapusDataPelanggan
            // 
            this.btn_hapusDataPelanggan.BackColor = System.Drawing.Color.Red;
            this.btn_hapusDataPelanggan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hapusDataPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapusDataPelanggan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_hapusDataPelanggan.Location = new System.Drawing.Point(461, 396);
            this.btn_hapusDataPelanggan.Name = "btn_hapusDataPelanggan";
            this.btn_hapusDataPelanggan.Size = new System.Drawing.Size(144, 42);
            this.btn_hapusDataPelanggan.TabIndex = 2;
            this.btn_hapusDataPelanggan.Text = "Hapus Data pelanggan";
            this.btn_hapusDataPelanggan.UseVisualStyleBackColor = false;
            // 
            // Lvw_dataPelanggan
            // 
            this.Lvw_dataPelanggan.HideSelection = false;
            this.Lvw_dataPelanggan.Location = new System.Drawing.Point(17, 12);
            this.Lvw_dataPelanggan.Name = "Lvw_dataPelanggan";
            this.Lvw_dataPelanggan.Size = new System.Drawing.Size(588, 356);
            this.Lvw_dataPelanggan.TabIndex = 1;
            this.Lvw_dataPelanggan.UseCompatibleStateImageBehavior = false;
            // 
            // UC_dataPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UC_dataPelanggan";
            this.Size = new System.Drawing.Size(693, 560);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView Lvw_dataPelanggan;
        private System.Windows.Forms.Button btn_hapusDataPelanggan;
    }
}
