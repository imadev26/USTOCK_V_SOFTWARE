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
    public partial class Devis : Form
    {
        public Devis()
        {
            InitializeComponent();
        }
        SqlConnection cn = Methode.ConnectSqlserver();
        public static DataSet ds = new DataSet();
        List<int> ID = new List<int>();


        void chargerLBL()
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT concat(NOM_CLIENT,' ',PRN_CLIENT) as 'Fname',TEL_CLIENT,EMAIL from CLIENT WHERE ID_CLIENT = "+cb_client_ID.SelectedValue+"",Methode.ConnectSqlserver());
            dap.Fill(ds,"CLT_FAC");
            if (ds.Tables["CLT_FAC"] != null)
            {
                lbl_nomCLT.Text = ds.Tables["CLT_FAC"].Rows[0][0].ToString();
                lbl_CLTnum.Text = ds.Tables["CLT_FAC"].Rows[0][1].ToString();
                lbl_CLTemail.Text = ds.Tables["CLT_FAC"].Rows[0][2].ToString();
                ds.Tables["CLT_FAC"].Clear();
            }
        }
        void selection()
        {
            
            string s = string.Format("SELECT PRODUIT.NOM_PRODUIT,DEVIS.* FROM DEVIS INNER JOIN PRODUIT ON PRODUIT.ID_PRODUIT = DEVIS.ID_PRODUIT WHERE ID_CLIENT = '{0}' AND DATE_DEVIS = '{1}'", int.Parse(cb_client_ID.SelectedValue.ToString()), dateTimePicker1.Value.ToShortDateString());
            SqlDataAdapter dap = new SqlDataAdapter(s, cn);
            dap.Fill(ds, "DEVIS");          
            dataGridView1.DataSource = ds.Tables["DEVIS"];
            dataGridView1.Columns[0].FillWeight = 150;
            dataGridView1.Columns["ID_PRODUIT"].Visible = false;
            dataGridView1.Columns["ID_CLIENT"].Visible = false;
            dataGridView1.Columns["ID_DEVIS"].Visible = false;
            dataGridView1.Columns["DATE_DEVIS"].Visible = false;
            dataGridView1.Columns["NOM_BUYER"].Visible = false;


            float res = 0;
            float remise = 0;
            float montantSR = 0;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                res = res + float.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                remise = remise + float.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                montantSR = montantSR + (float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) * float.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()));
            }
            if (dataGridView1.Rows.Count != 0)
            {
                lbl_montantSR.Text = montantSR.ToString();
                lbl_remise.Text = (remise / dataGridView1.Rows.Count).ToString() + " %";
                lbl_montant_payer.Text = res.ToString();
            }
            else
            {
                lbl_montantSR.Text = "";
                lbl_remise.Text = "";
                lbl_montant_payer.Text = "";
            }
        }
        void charger()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select ID_CLIENT ,concat(NOM_CLIENT,' ',PRN_CLIENT) as 'Fname' from CLIENT", cn);
            if (ds.Tables["CLIENT_1"] != null)
            {
                ds.Tables["CLIENT_1"].Clear();
            }
            sda.Fill(ds, "CLIENT_1");
            cb_client_ID.DataSource = ds.Tables["CLIENT_1"];
            cb_client_ID.DisplayMember = "Fname";
            cb_client_ID.ValueMember = "ID_CLIENT";
            cb_client_ID.SelectedIndex = -1;
        }
        private void Devis_Load(object sender, EventArgs e)
        {
            charger();
        }



        private void cb_client_ID_Click(object sender, EventArgs e)
        {
            ds.Tables["DEVIS"].Clear();

        }
        float res;
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            Methode.dt = (DataTable)dataGridView1.DataSource;
        }

        private void BTN_SYNC_Click(object sender, EventArgs e)
        {



            string s1;
            if (dataGridView1.Rows.Count < ds.Tables["DEVIS"].Rows.Count)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    s1 = string.Format("INSERT INTO DEVIS VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", cb_client_ID.SelectedValue, dateTimePicker1.Value.ToString(), dataGridView1.Rows[i].Cells["ID_PRODUIT"].Value.ToString(), dataGridView1.Rows[i].Cells["Quantité"].Value.ToString(), dataGridView1.Rows[i].Cells["PRIX"].Value.ToString(), dataGridView1.Rows[i].Cells["DISCOUNT"].Value.ToString(), dataGridView1.Rows[i].Cells["MONTANT_TOTAL"].Value.ToString());
                    SqlDataAdapter dap = new SqlDataAdapter(s1, Methode.ConnectSqlserver());
                    ds.Tables["DEVIS"].Clear();
                    dap.Fill(ds, "DEVIS");
                    dataGridView1.DataSource = ds.Tables["DEVIS"];
                }
            }
            string s;
            for (int i = 0; i < ID.Count; i++)
            {
                s = string.Format("DELETE FROM DEVIS WHERE ID_CLIENT = '{0}' and ID_PRODUIT = '{1}'", cb_client_ID.SelectedValue, ID[i]);
                SqlCommand cmd = new SqlCommand(s, Methode.ConnectSqlserver());
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    MessageBox.Show("Sync Affected");
                }
            }

            //string s1;

            //foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            //{
            //    ID.Add(int.Parse(dataGridView1.Rows[item.Index].Cells["ID_PRODUIT"].Value.ToString()));

            //    s1 = string.Format("INSERT INTO DEVIS VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", cb_client_ID.SelectedValue, dateTimePicker1.Value.ToString(), dataGridView1.Rows[item.Index].Cells["ID_PRODUIT"].Value.ToString(), dataGridView1.Rows[item.Index].Cells["Quantité"].Value.ToString(), dataGridView1.Rows[item.Index].Cells["PRIX"].Value.ToString(), dataGridView1.Rows[item.Index].Cells["DISCOUNT"].Value.ToString(), dataGridView1.Rows[item.Index].Cells["MONTANT_TOTAL"].Value.ToString());
            //    SqlDataAdapter dap = new SqlDataAdapter(s1, Methode.ConnectSqlserver());
            //    ds.Tables["DEVIS"].Clear();
            //    dap.Fill(ds, "DEVIS");
            //    dataGridView1.DataSource = ds.Tables["DEVIS"];
            //    //dataGridView1.Rows.RemoveAt(item.Index);
            //}




        }

        private void cb_client_ID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cb_client_ID.Text != "" || ds.Tables["DEVIS"] != null)
            {
                ds.Tables["DEVIS"].Clear();
            }
            chargerLBL();
            selection();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (cb_client_ID.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez saisir un client");
                return;
            }
            if (ds.Tables["DEVIS"] != null)
            {
                ds.Tables["DEVIS"].Clear();
            }
            selection();
        }

        private void btn_liv_print_Click(object sender, EventArgs e)
        {

        }
        String Q;
        private void BTN_REMOVE_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                Q = string.Format("DELETE FROM DEVIS WHERE ID_PRODUIT = '{0}'", dataGridView1.Rows[item.Index].Cells["ID_PRODUIT"].Value.ToString());
                int k = Methode.Update(Q);
                if (k != 0)
                {
                    MessageBox.Show("Supprimé");
                }
            }
        }
    }
}
