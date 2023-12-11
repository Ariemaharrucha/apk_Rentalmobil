using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RENTAL_MOBIL.View;

namespace RENTAL_MOBIL
{
    public partial class Frm_login : Form
    {

        public Frm_login()
        {
             InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MG9E6H7\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }
 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txtNama.Text;
            user_password = txtPassword.Text;

            try
            {
                string query = "SELECT Id  FROM Tbl_LoginKaryawan WHERE username = @username AND password = @password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtNama.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    string userId = Convert.ToString(dtable.Rows[0]["Id"]); 

                    MessageBox.Show("Berhasil login", "Succes" , MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Frm_menu fMenu = new Frm_menu(userId);
                    fMenu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNama.Clear();
                    txtPassword.Clear();
                    txtNama.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNama.Clear();
            txtPassword.Clear();
            txtNama.Focus();    
        }

       
    }
}
