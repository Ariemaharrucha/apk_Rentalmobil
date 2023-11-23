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

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1LC3JE\SQLEXPRESS;Initial Catalog=Rental_mobil;Integrated Security=True");

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
                string querry = "SELECT * FROM Tbl_LoginKaryawan WHERE username = '"+txtNama.Text+"' AND password = '"+txtPassword.Text+"'";
                //string querry = "SELECT * FROM Tbl_login WHERE username = @username AND password = CONVERT(@password AS varchar(50))";
                //SqlCommand cmd = new SqlCommand(querry,conn);

                //cmd.Parameters.AddWithValue("@username", txtNama.Text);
                //cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                //SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
             
                if (dtable.Rows.Count > 0)
                {
                    username = txtNama.Text;
                    user_password = txtPassword.Text;

                    MessageBox.Show("berhasil login","Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Frm_menu fMenu = new Frm_menu();
                    fMenu.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("user atau pass salah","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtNama.Clear();
                    txtPassword.Clear();

                    //to focus username
                    txtNama.Focus();
                }
            }
                 

            catch (Exception ex) 
            {
                MessageBox.Show("Error" + ex.Message);
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
