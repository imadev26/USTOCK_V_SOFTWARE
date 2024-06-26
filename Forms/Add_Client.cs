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
    public partial class Add_Client : Form
    {
        SqlConnection cn;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public Add_Client()
        {
            InitializeComponent();
        }
        void load()
        {
            ds.Tables.Clear();
            cn = Methode.ConnectSqlserver();
            SqlDataAdapter sda = new SqlDataAdapter("select * from CLIENT", cn);
            sda.Fill(ds, "CLIENT");
            DGV_ADDCLT.DataSource = ds.Tables["CLIENT"];
            cn.Close();
        }
        //methodes
        void clear()
        {
            txt_user_name.Text   = string.Empty;
            txt_user_lname.Text  = string.Empty;
            txt_user_num.Text    = string.Empty;
            txt_user_Email.Text  = string.Empty;
            txt_user_Pays.Text   = string.Empty;
            txt_user_ville.Text  = string.Empty;
        }

        private void btn_Client_ADD_Click(object sender, EventArgs e)
        {
            if (txt_user_name.Text.Equals(string.Empty) || txt_user_num.Text.Equals(string.Empty) || txt_user_Email.Text.Equals(string.Empty) || txt_user_Pays.Text.Equals(string.Empty) || txt_user_ville.Text.Equals(string.Empty))
            {
                MessageBox.Show("vous devez saisir tout les informations pour ajouter un client");
            }
            else
            {
                cn = Methode.ConnectSqlserver();
                string querry = string.Format("insert into CLIENT values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", txt_user_name.Text, txt_user_lname.Text, txt_user_num.Text, txt_user_Email.Text, txt_user_Pays.Text, txt_user_ville.Text,TXT_ADRESSE.Text);
                SqlCommand cmd = new SqlCommand(querry, cn);
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    MessageBox.Show("Added");
                    load();
                    clear();
                }
                cn.Close();
            }
        }

        private void btn_Client_Reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            load();
        }

        private void Add_Client_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txt_user_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }
    }
}
