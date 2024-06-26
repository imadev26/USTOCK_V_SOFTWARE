using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1.Forms
{
    public partial class Add_New_Sell : Form
    {

        SqlConnection cn = Methode.ConnectSqlserver();
        public static DataSet ds1 = new DataSet();
        public DataSet ds = new DataSet();
        List<PRODUIT> listFAC = new List<PRODUIT>(); 
        string fullname;
        public Add_New_Sell(string x)
        {
            fullname = x;
            InitializeComponent();
            
        }
        
        void RemplireCATEGORE()
        {
            string s = "SELECT * FROM CATEGORIE";
            cn = Methode.ConnectSqlserver();
            SqlDataAdapter dap = new SqlDataAdapter(s, cn);
            if (ds.Tables["CATEGORIE"] != null)
            {
                ds.Tables["CATEGORIE"].Clear();
            }
            dap.Fill(ds, "CATEGORIE");
            CB_CAT.DataSource = ds.Tables["CATEGORIE"];
            CB_CAT.DisplayMember = "NOM_CAT";
            CB_CAT.ValueMember = "ID_CAT";
            CB_CAT.SelectedIndex = -1;
        }
        void chargerCB()
        {
            string s = string.Format("select ID_PRODUIT,NOM_PRODUIT from PRODUIT where ID_CAT = '{0}'", CB_CAT.SelectedValue);
            cn = Methode.ConnectSqlserver();
            SqlDataAdapter dap = new SqlDataAdapter(s, cn);
            if (ds.Tables["PRODUIT"] != null)
            {
                ds.Tables["PRODUIT"].Clear();
            }
            dap.Fill(ds, "PRODUIT");
            CB_PRODUIT.DataSource = ds.Tables["PRODUIT"];
            CB_PRODUIT.DisplayMember = "NOM_PRODUIT";
            CB_PRODUIT.ValueMember = "ID_PRODUIT";
            CB_PRODUIT.SelectedIndex = -1;
        }
        void clearINSERT()
        {
            txt_prod_montant.Text    = string.Empty;
            CB_PRODUIT.SelectedIndex = -1;
            txt_prod_total.Text      = string.Empty;
            txt_discount.Text        = string.Empty;
            txt_qte_prod.Text        = string.Empty;
            txt_prix_prod.Text       = string.Empty;
            txt_nom_prod.Text        = string.Empty;
            txt_ID_prod.Text         = string.Empty;
        }
        void Clear()
        {
            cb_client_ID.SelectedIndex = -1;
            dateTimePicker1.ResetText();
            //txt_des_Fac.Text = string.Empty;
            txt_nomvendeur.Text = string.Empty;
            txt_ID_prod.Text = string.Empty;
            txt_nom_prod.Text = string.Empty;
            txt_prix_prod.Text = string.Empty;
            txt_qte_prod.Text = string.Empty;
            txt_prod_montant.Text = string.Empty;
            txt_prod_total.Text = string.Empty;
            txt_user_name.Text = string.Empty;
            txt_user_lname.Text = string.Empty;
            txt_user_num.Text = string.Empty;
            txt_user_Email.Text = string.Empty;
            txt_user_ville.Text = string.Empty;
            txt_user_ville.Text = string.Empty;
            txt_discount.Text = string.Empty;
            autoSETID(1);
        }
        DataTable data = new DataTable();
        void chargerDGV()
        {
                data.Columns.Add("ID PROD");
                data.Columns.Add("NOM PROD");
                data.Columns.Add("PRIX");
                data.Columns.Add("QTE");
                data.Columns.Add("MONTANT");
                data.Columns.Add("REMISE");
                data.Columns.Add("TOTAL");
            //    ds.Tables.Clear();
            //    SqlDataAdapter dap = new SqlDataAdapter("select * from DETAIL_CMD", cn);
            //    dap.Fill(ds, "DETAIL_CMD");
            //    DGV_addVENT.DataSource = ds.Tables["DETAIL_CMD"];
        }
        void autoSETID(int i)
        {
            int x = 0;
            cn = Methode.ConnectSqlserver();
            SqlCommand cmd = new SqlCommand("select top 1 ID_CMD from DETAIL_CMD order by ID_CMD desc", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                x = int.Parse(dr[0].ToString());
            }
            cn.Close();
            txt_N_facteure.Text = (x + i).ToString();
        }
        void CalculeTotalMontant()
        {
            if (txt_discount.Text != string.Empty && txt_prod_montant.Text != string.Empty)
            {
                double discount = Convert.ToDouble(txt_discount.Text);
                double montant = Convert.ToDouble(txt_prod_montant.Text);
                double total = montant - (montant * (discount / 100));
                txt_prod_total.Text = total.ToString();
            }

        }
        void CalculMontant()
        {
            if (txt_prix_prod.Text != string.Empty && txt_qte_prod.Text != string.Empty)
            {
                double montant = Convert.ToDouble(txt_prix_prod.Text) * Convert.ToInt32(txt_qte_prod.Text);
                txt_prod_montant.Text = montant.ToString();
            }

        }

        void cbClient()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select ID_CLIENT ,concat(NOM_CLIENT,' ',PRN_CLIENT) as 'Fname' from CLIENT", cn);
            sda.Fill(ds, "CLIENT");
            cb_client_ID.DataSource = ds.Tables["CLIENT"];
            cb_client_ID.DisplayMember = "Fname";
            cb_client_ID.ValueMember = "ID_CLIENT";
            cb_client_ID.SelectedIndex = -1;
        }

        private void btn_prod_add_Click(object sender, EventArgs e)
        {
            //if (cb_client_ID.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Veuiller saisir le client") ;
            //}
            if (txt_prix_prod.Text == string.Empty && txt_nom_prod.Text == string.Empty && txt_ID_prod.Text == string.Empty)
            {
                MessageBox.Show("Veuillez selectionné un produit !!");
            }
            else if (txt_discount.Text == string.Empty && txt_qte_prod.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir la quantié de produit est la remise !!");
            }
            else if (txt_qte_prod.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir la Quantite !!");
                txt_qte_prod.Focus();
            }
            else if (txt_discount.Text == string.Empty)
            {
                MessageBox.Show("Veuillez donner une remise");
                txt_discount.Focus();
            }
            else if (int.Parse(txt_qte_prod.Text) > Methode.quantité)
            {
                MessageBox.Show("La quantité en stock n'est pas suffisante!");
                return;
            }
            else
            {
                //DATE_CMD,PRICE,QUANTITE,AMOUNT,DISCOUNT,TOTAL_AMOUNT for facturation
                Methode.fullname = cb_client_ID.Text;
                Methode.userNAME = txt_nomvendeur.Text;
                Methode.CLTnumber = txt_user_num.Text;
                Methode.CLTemail = txt_user_Email.Text;
                DataRow dr = ds1.Tables["FAC"].NewRow();
                dr[0] = txt_nom_prod.Text;
                dr[1] = txt_qte_prod.Text;
                dr[2] = txt_prix_prod.Text;
                dr[3] = txt_discount.Text ;
                dr[4] = txt_prod_total.Text;
                dr[5] = int.Parse(cb_client_ID.SelectedValue.ToString());
                dr[6] = txt_ID_prod.Text;
                dr[7] = txt_nomvendeur.Text;
                bool res = false;
                for (int i = 0; i < ds1.Tables["FAC"].Rows.Count; i++)
                {
                    if (CB_PRODUIT.Text == ds1.Tables["FAC"].Rows[i][0].ToString())
                    {
                        ds1.Tables["FAC"].Rows[i][1] = float.Parse(ds1.Tables["FAC"].Rows[i][1].ToString()) + float.Parse(txt_qte_prod.Text);
                        ds1.Tables["FAC"].Rows[i][4] = float.Parse(ds1.Tables["FAC"].Rows[i][4].ToString()) + float.Parse(txt_prod_total.Text);
                        ds1.Tables["FAC"].Rows[i][3] = ((float.Parse(ds1.Tables["FAC"].Rows[i][3].ToString()) + float.Parse(txt_discount.Text)) / 2).ToString();
                        ds1.Tables["FAC"].Rows.Add(dr); 

                        for (int i1 = 0; i1 < ds1.Tables["FAC"].Rows.Count; i1++)
                        {
                            if (int.Parse(ds1.Tables["FAC"].Rows[i][1].ToString()) > int.Parse(ds1.Tables["FAC"].Rows[i1][1].ToString()) && ds1.Tables["FAC"].Rows[i][0].ToString() == ds1.Tables["FAC"].Rows[i1][0].ToString())
                            {
                                ds1.Tables["FAC"].Rows[i1].Delete();
                                res = true;
                            }
                        }

                    }
                }
                if (res == false)
                {
                    ds1.Tables["FAC"].Rows.Add(dr);
                }

                MessageBox.Show("bien ajouter");
                //ds.Tables["DETAIL_CMD"].Rows.Add(txt_nom_prod.Text,txt_N_facteure.Text, dateTimePicker1.Value.ToShortDateString().ToString(), txt_nomvendeur.Text, txt_des_Fac.Text, txt_ID_prod.Text, cb_client_ID.SelectedValue, txt_qte_prod.Text, txt_prix_prod.Text, txt_discount.Text, txt_prod_montant.Text, txt_prod_total.Text);
                //Only datagridview


                //ds.Tables["DETAIL_CMD"].Rows.Add(txt_nom_prod.Text, dateTimePicker1.Value.ToShortDateString().ToString(), txt_prix_prod.Text, txt_qte_prod.Text, txt_prod_montant.Text, txt_discount.Text, txt_prod_total.Text);
                //DGV_addVENT.DataSource = ds.Tables["DETAIL_CMD"];
                DGV_addVENT.DataSource = ds1.Tables["FAC"];
                




                clearINSERT();
               //listFAC.Add(new PRODUIT() {id_Client = cb_client_ID.SelectedValue.ToString(), id_produit = txt_ID_prod.Text, NOM_PRODDUIT = txt_nom_prod.Text, PRIX_PRODUIT = txt_prix_prod.Text, QTE = txt_qte_prod.Text, MONTANT = txt_prod_montant.Text, REMISE = txt_discount.Text + " %" });
               // DGV_addVENT.DataSource = null;
               // DGV_addVENT.DataSource = listFAC;
            } 
             
        }

        private void Add_New_Sell_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT DATE_CMD,PRICE,QUANTITE,AMOUNT,DISCOUNT,TOTAL_AMOUNT FROM DETAIL_CMD", Methode.ConnectSqlserver());
            ds.Tables.Add("DETAIL_CMD");
            ds.Tables["DETAIL_CMD"].Columns.Add("NOM_PROD");
            dap.Fill(ds, "DETAIL_CMD");
            ds.Tables["DETAIL_CMD"].Clear();
            if (ds1.Tables["FAC"] == null)
            {
                ds1.Tables.Add("FAC");
                ds1.Tables["FAC"].Columns.Add("Produit");
                ds1.Tables["FAC"].Columns.Add("Quantité");
                ds1.Tables["FAC"].Columns.Add("Prix");
                ds1.Tables["FAC"].Columns.Add("Remise");
                ds1.Tables["FAC"].Columns.Add("Montant total");
                ds1.Tables["FAC"].Columns.Add("ID CLIENT");
                ds1.Tables["FAC"].Columns.Add("ID PRODUIT");
                ds1.Tables["FAC"].Columns.Add("NOM_BUYER");
            }

            DGV_addVENT.DataSource = ds1.Tables["FAC"];
            DGV_addVENT.Columns["ID CLIENT"].Visible = false;
            DGV_addVENT.Columns["ID PRODUIT"].Visible = false;
            DGV_addVENT.Columns["NOM_BUYER"].Visible = false;


            //ds.Tables["DETAIL_CMD"].Clear();
            //chargerCB();
            cbClient();
            //chargerDGV();
            autoSETID(1);
            txt_nomvendeur.Text = fullname;
        }

        

        private void btn_prod_Reset_Click(object sender, EventArgs e)
        {
            Clear();
            
        }

        private void txt_discount_KeyUp(object sender, KeyEventArgs e)
        {

            if (txt_discount.Text != string.Empty)
            {
                CalculeTotalMontant();
            }
            else
            {
                txt_prod_total.Text = string.Empty;
            }
        }

        private void txt_qte_prod_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_qte_prod.Text != string.Empty)
            {
                CalculMontant();
            }
            else
            {
                txt_prod_total.Text = string.Empty;
            }
        }
        void dgvBILL() {
            if (ds1.Tables["FAC"] != null)
            {
                ds1.Tables["FAC"].Clear();
            }
            DGV_addVENT.Columns["ID CLIENT"].Visible = false;
            DGV_addVENT.Columns["ID PRODUIT"].Visible = false;
            string querry1 = string.Format("select P.NOM_PRODUIT,D.Quantité,D.PRIX,D.DISCOUNT,D.MONTANT_TOTAL,D.ID_CLIENT,D.ID_PRODUIT FROM PRODUIT P INNER JOIN DEVIS D ON P.ID_PRODUIT = D.ID_PRODUIT where ID_CLIENT = '{0}' AND D.DATE_DEVIS = '{1}'", cb_client_ID.SelectedValue, dateTimePicker1.Value.ToShortDateString());
            SqlCommand cmd1 = new SqlCommand(querry1, Methode.ConnectSqlserver());
            SqlDataReader rd1 = cmd1.ExecuteReader();
            while (rd1.Read())
            {
                ds1.Tables["FAC"].Rows.Add(rd1[0].ToString(), rd1[1].ToString(), rd1[2].ToString(), rd1[3].ToString(), rd1[4].ToString(), rd1[5].ToString(), rd1[6].ToString());
            }
            DGV_addVENT.DataSource = ds1.Tables["FAC"];
            cn.Close();
            rd1.Close();
            

        }

        private void cb_client_ID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string querry = string.Format("select * from CLIENT where ID_CLIENT = '{0}'", cb_client_ID.SelectedValue);
                SqlCommand cmd = new SqlCommand(querry,Methode.ConnectSqlserver());
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txt_user_name.Text  = rd[1].ToString();
                    txt_user_lname.Text = rd[2].ToString();
                    txt_user_num.Text   = rd[3].ToString();
                    txt_user_Email.Text = rd[4].ToString();
                    txt_user_ville.Text = rd[6].ToString();
                    cn.Close();
                    rd.Close();
                    dgvBILL();
                }
                
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void txt_N_facteure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void txt_qte_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void CB_PRODUIT_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cn = Methode.ConnectSqlserver();
            string s = string.Format("SELECT * FROM PRODUIT WHERE ID_PRODUIT = '{0}'", CB_PRODUIT.SelectedValue);
            SqlCommand cmd = new SqlCommand(s, cn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txt_ID_prod.Text = rd[0].ToString();
                txt_nom_prod.Text = rd[2].ToString();
                txt_prix_prod.Text = rd[4].ToString();
                txt_qte_prod.Focus();
            }
        }

        private void CB_CAT_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CB_CAT.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir la catégorie","Obligation",MessageBoxButtons.OK);
            }
            else
            {
                chargerCB();
            }
        }

        private void CB_CAT_Enter(object sender, EventArgs e)
        {
            RemplireCATEGORE();
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (DGV_addVENT.Rows.Count != 0)
            {
                Methode.fullname = cb_client_ID.Text;
                Methode.userNAME = txt_nomvendeur.Text;
                Methode.CLTnumber = txt_user_num.Text;
                Methode.CLTemail = txt_user_Email.Text;
                if (cb_client_ID.SelectedIndex == -1)
                {
                    MessageBox.Show("Veuiller Seceltioner un client");
                }
                else
                {
                    Methode.ID = int.Parse(cb_client_ID.SelectedValue.ToString());
                    Methode.date = dateTimePicker1.Value.ToShortDateString();
                    PrintingDEVait printing = new PrintingDEVait();
                    printing.ShowDialog();
                }
            }
        }

        

        

        private void cb_client_ID_TextUpdate(object sender, EventArgs e)
        {
            btn_prod_Reset_Click(sender, e);
        }

        private void cb_client_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ds.Tables["FAC"] != null)
            {
                ds.Tables["FAC"].Clear();
            }
        }

        private void txt_qte_prod_TextChanged(object sender, EventArgs e)
        {
            if (txt_qte_prod.Text != "" && txt_discount.Text != "")
            {
                CalculMontant();
                CalculeTotalMontant();
            }
            else
            {
                CalculMontant();
            }
            if (txt_qte_prod.Text == string.Empty)
            {
                return;
            }
            if (txt_qte_prod.Text != "")
            {
                bool istrue = Methode.Search("select QTE_STOCK from PRODUIT where ID_PRODUIT = " + int.Parse(CB_PRODUIT.SelectedValue.ToString()) + "");
                if (int.Parse(txt_qte_prod.Text) < Methode.quantité)
                {
                    if (Methode.quantité - int.Parse(txt_qte_prod.Text) < 3)
                    {
                        lbl_war.ForeColor = Color.Red;
                        lbl_war.Text = "Faites attention que vous avez moins de trois produits dans " + CB_PRODUIT.Text;
                    }
                    else
                    {

                        lbl_war.ForeColor = Color.White;
                        int q = Methode.quantité - int.Parse(txt_qte_prod.Text);
                        lbl_war.Text = "rest in stock :" + q;
                    }
                }
                else
                {
                    if (int.Parse(txt_qte_prod.Text) >= Methode.quantité)
                    {
                        lbl_war.ForeColor = Color.Red;
                        lbl_war.Text = "La quantité en stock n'est pas suffisante!";
                    }


                }
            }
            else
            {

                lbl_war.ForeColor = Color.White;
                txt_qte_prod.Text = "rest stock :";

            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_qte_prod.Text != "" && txt_discount.Text != "")
            {
                CalculMontant();
                CalculeTotalMontant();
            }
            else
            {
                CalculMontant();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (cb_client_ID.SelectedIndex == -1)
            {
                MessageBox.Show("Veuiller selectionner un client");
            }
            else
            {
                dgvBILL();
            }
        }
    }
}
