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

namespace WindowsFormsApp1.Forms
{
    public partial class GestionUsers : Form
    {
        public GestionUsers()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        void clear()
        {
            txt_user_name.Text = string.Empty;
            txt_user_lname.Text = string.Empty;
            txt_user_Email.Text = string.Empty;
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
            cb_gradation.SelectedIndex = -1;
        }
        void chargeCB()
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM GRADATION", Methode.ConnectSqlserver());
            dap.Fill(ds, "GRADATION");
            cb_gradation.DataSource = ds.Tables["GRADATION"];
            cb_gradation.DisplayMember = "NOM_GRADE";
            cb_gradation.ValueMember = "NOM_GRADE";
            cb_gradation.SelectedIndex = -1;
        }
        void DGVcharger()
        {
            ds.Tables.Clear();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM USERS where USERTYPE in ('modérateur','utilisateur')", Methode.ConnectSqlserver());
            dap.Fill(ds, "USERS");
            dgv_Users.DataSource = ds.Tables["USERS"];

        }
        void chercherDGV(int i)
        {
            txt_user_name.Text = dgv_Users.Rows[i].Cells[0].Value.ToString();
            txt_user_lname.Text = dgv_Users.Rows[i].Cells[1].Value.ToString();
            txt_user_Email.Text = dgv_Users.Rows[i].Cells[2].Value.ToString();
            txt_username.Text = dgv_Users.Rows[i].Cells[3].Value.ToString();
            txt_password.Text = dgv_Users.Rows[i].Cells[4].Value.ToString();
            cb_gradation.SelectedValue = dgv_Users.Rows[i].Cells[5].Value;
        }
        private void GestionUsers_Load(object sender, EventArgs e)
        {
            chargeCB();
            DGVcharger();
        }
        
        private void dgv_Users_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_user_name.Text         = dgv_Users.CurrentRow.Cells[0].Value.ToString();
            txt_user_lname.Text        = dgv_Users.CurrentRow.Cells[1].Value.ToString();
            txt_user_Email.Text        = dgv_Users.CurrentRow.Cells[2].Value.ToString();
            txt_username.Text          = dgv_Users.CurrentRow.Cells[3].Value.ToString();
            txt_password.Text          = dgv_Users.CurrentRow.Cells[4].Value.ToString();
            cb_gradation.SelectedValue = dgv_Users.CurrentRow.Cells[5].Value;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clear();
        }

      

        private void btn_show_chercher_Click(object sender, EventArgs e)
        {
            groupesearch.Visible = true;
        }

        private void btn_chercher_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_Users.Rows.Count; i++)
            {
                if (txt_cherch_user.Text == dgv_Users.Rows[i].Cells[3].Value.ToString())
                {
                    dgv_Users.ClearSelection();
                    dgv_Users.Rows[i].Selected = true;
                    chercherDGV(i);
                }
            }
            groupesearch.Visible = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_user_name.Text == string.Empty || txt_user_lname.Text == string.Empty || txt_user_Email.Text == string.Empty || txt_username.Text == string.Empty || txt_username.Text == string.Empty || txt_password.Text == string.Empty || cb_gradation.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez saisir tout les informations");
            }
            else
            {
                try
                {
                    string querry = string.Format("UPDATE USERS SET NOM = '{0}',PRENOM = '{1}',EMAIL = '{2}',USERNAME = '{3}',PSW = '{4}',USERTYPE = '{5}' where USERNAME = '{3}' and USERTYPE in ('modérateur','utilisateur')", txt_user_name.Text, txt_user_lname.Text, txt_user_Email.Text, txt_username.Text, txt_password.Text, cb_gradation.SelectedValue);
                    SqlCommand cmd = new SqlCommand(querry, Methode.ConnectSqlserver());
                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        MessageBox.Show("Utilisateur est Modifié avec succes");
                        clear();
                        DGVcharger();
                    }
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void btn_drope_Click(object sender, EventArgs e)
        {
            if (txt_user_name.Text == string.Empty || txt_user_lname.Text == string.Empty || txt_user_Email.Text == string.Empty || txt_username.Text == string.Empty || txt_username.Text == string.Empty || txt_password.Text == string.Empty || cb_gradation.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez saisir tout les informations");
            }
            else
            {
                try
                {
                    string querry = string.Format("DELETE FROM USERS where USERNAME = '{0}' and USERTYPE in ('modérateur','utilisateur')", txt_username.Text);
                    SqlCommand cmd = new SqlCommand(querry, Methode.ConnectSqlserver());
                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        MessageBox.Show("Utilisateur est Supprimer avec succes");
                        clear();
                        DGVcharger();
                    }
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }
    }
}
