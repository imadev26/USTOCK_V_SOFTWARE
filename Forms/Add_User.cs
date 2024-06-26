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
    public partial class Add_User : Form
    {
        DataSet ds = new DataSet();
        public Add_User()
        {
            InitializeComponent();
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
            dgv_users.DataSource = ds.Tables["USERS"];

        }

        void clear()
        {
            txt_user_name.Text = string.Empty;
            txt_user_lname.Text = string.Empty;
            txt_user_Email.Text = string.Empty;
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
            cb_gradation.SelectedIndex = -1;
        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            chargeCB();
            DGVcharger();
        }

        private void btn_User_add_Click(object sender, EventArgs e)
        {
            try
            {
                string querry = string.Format("INSERT INTO USERS VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", txt_user_name.Text, txt_user_lname.Text, txt_user_Email.Text, txt_username.Text, txt_password.Text,cb_gradation.SelectedValue);
                SqlCommand cmd = new SqlCommand(querry, Methode.ConnectSqlserver());
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    MessageBox.Show("Nouvel utilisateur est ajouté");
                    DGVcharger();
                    clear();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void btn_prod_Reset_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
