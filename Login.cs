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


namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection cn;
        string x;
        public string name;
        public Login()
        {
            InitializeComponent();
        }

        private void button_login_login_Click(object sender, EventArgs e)
        {
            cn = Methode.ConnectSqlserver();
            if (textBox_login_username.Text == string.Empty || textBox_login_password.Text == string.Empty)
            {
                MessageBox.Show("Fields are empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    string h = string.Format("SELECT * FROM USERS WHERE USERNAME = '{0}' AND PSW = '{1}'", textBox_login_username.Text, textBox_login_password.Text);
                    SqlCommand cmd = new SqlCommand(h, cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows == true)
                    {
                        x = dr[5].ToString();
                        Methode.userNAME = dr[0].ToString() + " " + dr[1].ToString();
                        MainForm M = new MainForm(x, Methode.userNAME);
                        dr.Close();
                        this.Hide();
                        cn.Close();
                        M.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        cn.Close();
                        MessageBox.Show("Information Incorrect", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cn.Close();
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label_login_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_login_show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_login_show.Checked == true)
            {
                textBox_login_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_login_password.UseSystemPasswordChar = true;
            }
        }

        private void label_login_clear_Click(object sender, EventArgs e)
        {
            textBox_login_password.Text = string.Empty;
            textBox_login_username.Text = string.Empty;
        }
    }
}
