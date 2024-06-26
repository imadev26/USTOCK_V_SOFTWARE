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
    public partial class GestionDesClient : Form
    {
        SqlConnection cn;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        bool ExistClient(string x)
        {
            bool a = false;
            try
            {
                cn = Methode.ConnectSqlserver();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENT WHERE ID_Client ='" + x + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                a = dr.HasRows;
                dr.Close();
                cn.Close();
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.Message);
            }
            return a;
        }

        void cbLoad()
        {
            string querry = "select ID_CLIENT,concat(NOM_CLIENT ,' ',PRN_CLIENT) as 'Nom et prénom' from CLIENT";
            SqlDataAdapter sda = new SqlDataAdapter(querry, Methode.ConnectSqlserver());
            sda.Fill(ds, "cb_charger");
            cb_client_ID.DataSource = ds.Tables["cb_charger"];
            cb_client_ID.DisplayMember = "Nom et prénom";
            cb_client_ID.ValueMember = "ID_CLIENT";
        }
        void load()
        {
            cb_client_ID.SelectedIndex = -1;
            ds.Tables.Clear();
            cn = Methode.ConnectSqlserver();
            SqlDataAdapter sda = new SqlDataAdapter("select * from CLIENT", cn);
            sda.Fill(ds, "CLIENT");
            DGV_gestCLT.DataSource = ds.Tables["CLIENT"];
            cn.Close();
        }
        void chercher(int i)
        {
            for (i = 0; i < DGV_gestCLT.Rows.Count; i++)
            {
                if (DGV_gestCLT.Rows[i].Cells[0].Value == cb_client_ID.SelectedValue || DGV_gestCLT.Rows[i].Cells[0].Value.ToString() == txt_srch_ID.Text)
                {
                    DGV_gestCLT.ClearSelection();
                    DGV_gestCLT.Rows[i].Selected = true;
                    clear();
                    cb_client_ID.SelectedValue = DGV_gestCLT.Rows[i].Cells[0].Value.ToString();
                    txt_srch_ID.Text = DGV_gestCLT.Rows[i].Cells[0].Value.ToString();
                    txt_user_name.Text = DGV_gestCLT.Rows[i].Cells[1].Value.ToString();
                    txt_user_lname.Text = DGV_gestCLT.Rows[i].Cells[2].Value.ToString();
                    txt_user_num.Text = DGV_gestCLT.Rows[i].Cells[3].Value.ToString();
                    txt_user_Email.Text = DGV_gestCLT.Rows[i].Cells[4].Value.ToString();
                    txt_user_Pays.Text = DGV_gestCLT.Rows[i].Cells[5].Value.ToString();
                    txt_user_ville.Text = DGV_gestCLT.Rows[i].Cells[6].Value.ToString();
                }
            }
        }
        void clear()
        {
            txt_user_name.Text = string.Empty;
            txt_user_lname.Text = string.Empty;
            txt_user_num.Text = string.Empty;
            txt_user_Email.Text = string.Empty;
            txt_user_Pays.Text = string.Empty;
            txt_user_ville.Text = string.Empty;
            txt_srch_ID.Text = string.Empty;
            cb_client_ID.SelectedIndex = -1;
        }

        public GestionDesClient()
        {
            InitializeComponent();
        }

        private void GestionDesClient_Load(object sender, EventArgs e)
        {
            cbLoad();
            load();
        }

        private void btn_GEST_search_Click(object sender, EventArgs e)
        {
            if (cb_client_ID.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Not exists");
            }
            else
            {
                if (txt_srch_ID.Text == cb_client_ID.SelectedValue.ToString())
                {
                    for (int i = 0; i < DGV_gestCLT.Rows.Count; i++)
                    {
                        chercher(i);
                    }
                }
                else if (txt_srch_ID.Text != string.Empty && cb_client_ID.SelectedIndex == -1)
                {
                    for (int i = 0; i < DGV_gestCLT.Rows.Count; i++)
                    {
                        chercher(i);
                    }
                }
                else if (cb_client_ID.SelectedIndex != -1 && txt_srch_ID.Text == string.Empty)
                {
                    txt_srch_ID.Text = cb_client_ID.SelectedValue.ToString();
                    for (int i = 0; i < DGV_gestCLT.Rows.Count; i++)
                    {
                        chercher(i);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez Verifier vos donnée");
                }
            }
        }

        private void txt_srch_ID_TextChanged(object sender, EventArgs e)
        {
            if (txt_srch_ID.Text == string.Empty)
            {
                cb_client_ID.SelectedIndex = -1;
                return;
            }
            else
            {
                cb_client_ID.SelectedValue = txt_srch_ID.Text;
            }
        }

        private void btn_CLT_UPDATE_Click(object sender, EventArgs e)
        {
            if (cb_client_ID.SelectedIndex.Equals(-1)||txt_user_name.Text.Equals(string.Empty)|| txt_user_lname.Text.Equals(string.Empty)|| txt_user_num.Text.Equals(string.Empty)|| txt_user_Pays.Text.Equals(string.Empty)|| txt_user_ville.Text.Equals(string.Empty))
            {
                MessageBox.Show("Veuillez verifier les informations");
            }
            else
            {
                try
                {
                    cn = Methode.ConnectSqlserver();
                    string querry = string.Format("update CLIENT set NOM_CLIENT = '{1}',PRN_CLIENT = '{2}',TEL_CLIENT = '{3}',EMAIL = '{4}',COUNTRY = '{5}',VILLE = '{6}' where ID_CLIENT = '{0}'", cb_client_ID.SelectedValue, txt_user_name.Text, txt_user_lname.Text, txt_user_num.Text, txt_user_Email.Text, txt_user_Pays.Text, txt_user_ville.Text);
                    SqlCommand cmd = new SqlCommand(querry, cn);
                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        MessageBox.Show("Le client est modifié");
                        clear();
                        load();
                        chercher(Convert.ToInt32(cb_client_ID.SelectedValue));
                    }
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void btn_CLT_LOAD_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void DGV_gestCLT_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cb_client_ID.SelectedValue = DGV_gestCLT.CurrentRow.Cells[0].Value;
            txt_srch_ID.Text = DGV_gestCLT.CurrentRow.Cells[0].Value.ToString();
            txt_user_name.Text = DGV_gestCLT.CurrentRow.Cells[1].Value.ToString();
            txt_user_lname.Text = DGV_gestCLT.CurrentRow.Cells[2].Value.ToString();
            txt_user_num.Text = DGV_gestCLT.CurrentRow.Cells[3].Value.ToString();
            txt_user_Email.Text = DGV_gestCLT.CurrentRow.Cells[4].Value.ToString();
            txt_user_Pays.Text = DGV_gestCLT.CurrentRow.Cells[5].Value.ToString();
            txt_user_ville.Text = DGV_gestCLT.CurrentRow.Cells[6].Value.ToString();
        }

        private void txt_user_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_srch_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btn_prod_add_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_GEST_DROP_Click(object sender, EventArgs e)
        {
            try
            {
                cn = Methode.ConnectSqlserver();
                string querry = string.Format("delete CLIENT where ID_CLIENT = '{0}'", cb_client_ID.SelectedValue);
                SqlCommand cmd = new SqlCommand(querry, cn);
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    MessageBox.Show("Le client est supprimé");
                    clear();
                    load();
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void cb_client_ID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string s;
            s = cb_client_ID.SelectedValue.ToString();
            txt_srch_ID.Text = s;
            chercher(Convert.ToInt32(cb_client_ID.SelectedValue));
        }
    }
}
