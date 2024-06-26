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
using System.Drawing.Printing;

namespace WindowsFormsApp1.Forms
{
    public partial class LivraisonFORM : Form
    {
        public LivraisonFORM()
        {
            InitializeComponent();
        }
        DataSet ds = Devis.ds;


        public Bitmap map;
        public void print(Panel pnl)
        {
            PrinterSettings pn = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            insertCMD();
            printPreviewDialog1.ShowDialog();
        }
        void insertCMD()
        {
            
            if (dataGridView1.Rows.Count > 0)
            {
                float res;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    res = float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) * float.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                    string querry = string.Format("insert into DETAIL_CMD values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", DateTime.Now.ToShortDateString(), label21.Text, label27.Text, int.Parse(dataGridView1.Rows[i].Cells["ID_PRODUIT"].Value.ToString()), int.Parse(dataGridView1.Rows[i].Cells["ID_CLIENT"].Value.ToString()), int.Parse(dataGridView1.Rows[i].Cells["Quantité"].Value.ToString()), int.Parse(dataGridView1.Rows[i].Cells["PRIX"].Value.ToString()), float.Parse(dataGridView1.Rows[i].Cells["DISCOUNT"].Value.ToString()), res.ToString(), float.Parse(dataGridView1.Rows[i].Cells["MONTANT_TOTAL"].Value.ToString()));
                    if (Methode.Update(querry) != 0)
                    {
                        if (Methode.Update("UPDATE PRODUIT SET QTE_STOCK = QTE_STOCK -" + int.Parse(dataGridView1.Rows[i].Cells["Quantité"].Value.ToString()) + " WHERE ID_PRODUIT = " + int.Parse(dataGridView1.Rows[i].Cells["ID_PRODUIT"].Value.ToString()) + "") != 0)
                        {
                            if (Methode.Update("DELETE FROM DEVIS WHERE ID_DEVIS = " + int.Parse(dataGridView1.Rows[i].Cells["ID_DEVIS"].Value.ToString())) != 0)
                            {
                                MessageBox.Show("Affected");
                            }
                        }
                    }
                }

            }
        }
        public void getprintarea(Panel pnl)
        {
            map = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(map, new Rectangle(0, 0, pnl.Width, pnl.Height));

        }
        void chargerLBL()
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT concat(NOM_CLIENT,' ',PRN_CLIENT) as 'Fname',TEL_CLIENT,EMAIL from CLIENT WHERE ID_CLIENT = " + cb_client_ID.SelectedValue + "", Methode.ConnectSqlserver());
            dap.Fill(ds, "CLT_FAC");
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
            if (cb_client_ID.SelectedIndex != -1)
            {
                

                string s = string.Format("SELECT PRODUIT.NOM_PRODUIT,DEVIS.* FROM DEVIS INNER JOIN PRODUIT ON PRODUIT.ID_PRODUIT = DEVIS.ID_PRODUIT WHERE ID_CLIENT = '{0}' AND DATE_DEVIS = '{1}'", int.Parse(cb_client_ID.SelectedValue.ToString()), dateTimePicker1.Value.ToShortDateString());
                SqlDataAdapter dap = new SqlDataAdapter(s, Methode.ConnectSqlserver());
                dap.Fill(ds, "DEVIS");
                dataGridView1.DataSource = ds.Tables["DEVIS"];
                dataGridView1.Columns[0].FillWeight = 150;
                dataGridView1.Columns["ID_PRODUIT"].Visible = false;
                dataGridView1.Columns["ID_CLIENT"].Visible = false;
                dataGridView1.Columns["ID_DEVIS"].Visible = false;
                dataGridView1.Columns["DATE_DEVIS"].Visible = false;
                dataGridView1.Columns["NOM_BUYER"].Visible = false;
                float fraiLIV = 0;
                float res = 0;
                float remise = 0;
                float montantSR = 0;
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    res = res + float.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                    remise = remise + float.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                    montantSR = montantSR + (float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()));
                }
                res = res + fraiLIV;
                if (dataGridView1.Rows.Count != 0)
                {
                    string s1 = string.Format("SELECT * FROM LIVRAISON WHERE ID_CLIENT = '{0}'", cb_client_ID.SelectedValue);
                    SqlCommand cmd = new SqlCommand(s1, Methode.ConnectSqlserver());
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    if (rd.HasRows)
                    {
                        label21.Text = rd[2].ToString();
                        label20.Text = rd[6].ToString();
                        label13.Text = rd[3].ToString();
                        label15.Text = rd[4].ToString();
                        label16.Text = rd[5].ToString();
                        label22.Text = rd[7].ToString();
                        label27.Text = rd[8].ToString();

                    }
                    else
                    {
                        return;
                    }
                    lbl_montantSR.Text = montantSR.ToString();
                    lbl_remise.Text = (remise / dataGridView1.Rows.Count).ToString() + " %";
                    label22.Text = (float.Parse(label22.Text)).ToString();
                    lbl_montant_payer.Text = (res + (float.Parse(label22.Text) - (float.Parse(label22.Text) / 10))).ToString();

                }
                else
                {
                    label22.Text = "";
                    label27.Text = "";
                    label21.Text = "";
                    label20.Text = "";
                    label16.Text = "";
                    label15.Text = "";
                    label13.Text = "";
                    lbl_CLTemail.Text = "";
                    lbl_CLTnum.Text = "";
                    lbl_nomCLT.Text = "";
                    lbl_montantSR.Text = "";
                    lbl_remise.Text = "";
                    lbl_montant_payer.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir un client");
            }
        }
        void charger()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select ID_CLIENT ,concat(NOM_CLIENT,' ',PRN_CLIENT) as 'Fname' from CLIENT", Methode.ConnectSqlserver());
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
        

        private void LivraisonFORM_Load(object sender, EventArgs e)
        {
            charger();
        }

        private void cb_client_ID_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (cb_client_ID.Text != "" || ds.Tables["DEVIS"] != null)
            {
                ds.Tables["DEVIS"].Clear();
            }
            selection();
            if (dataGridView1.Rows.Count != 0)
            {
                chargerLBL();
            }
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (ds.Tables["DEVIS"] != null)
            {
                ds.Tables["DEVIS"].Clear();
            }
            selection();
            if (cb_client_ID.SelectedIndex != -1 && dataGridView1.Rows.Count != 0)
            {
                chargerLBL();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle rec = e.PageBounds;
            e.Graphics.DrawImage(map, (rec.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        private void btn_liv_print_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                print(panel1);
            }
            else
            {
                MessageBox.Show("No data");
            }
        }
    }
}
