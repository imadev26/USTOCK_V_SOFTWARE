using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;



namespace WindowsFormsApp1.Forms
{
    public partial class PrintingDEVait : Form
    {
        public PrintingDEVait()
        {
            InitializeComponent();
        }
        public Bitmap map;
        //SqlDataAdapter dap = new SqlDataAdapter("SELECT ",Methode.ConnectSqlserver());
        public void print(Panel pnl)
        {
            PrinterSettings pn = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        public void getprintarea(Panel pnl)
        {
            map = new Bitmap(pnl.Width,pnl.Height);
            pnl.DrawToBitmap(map,new Rectangle(0,0,pnl.Width,pnl.Height));
            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle rec = e.PageBounds;
            e.Graphics.DrawImage(map, (rec.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
            
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            print(this.panel1);
        }
        

        private void PrintingDEVait_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    dataGridView1.Rows[i].Selected = true;
            //}
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent;
            dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle.Font = new System.Drawing.Font("Verdana", 14f, FontStyle.Regular);
            lbl_nomCLT.Text = Methode.fullname;
            lbl_CLTnum.Text = Methode.CLTnumber;
            lbl_CLTemail.Text = Methode.CLTemail;
            lbl_lieudate.Text = "Marrakech le : " + DateTime.Now.ToShortDateString().ToString();
            dataGridView1.DataSource = Add_New_Sell.ds1.Tables["FAC"];
            dataGridView1.Columns[0].FillWeight = 150;
            float res = 0;
            float remise = 0;
            float montantSR = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                res = res + float.Parse(dataGridView1.Rows[i].Cells["Montant total"].Value.ToString());
                remise = remise + float.Parse(dataGridView1.Rows[i].Cells["Remise"].Value.ToString());
                montantSR = montantSR + (float.Parse(dataGridView1.Rows[i].Cells["Prix"].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells["Quantité"].Value.ToString()));
            }
            lbl_montantSR.Text = montantSR.ToString();
            lbl_remise.Text = (remise / dataGridView1.Rows.Count).ToString() + " %";
            lbl_montant_payer.Text = res.ToString();
            //SqlConnection cn = Methode.ConnectSqlserver();
            //SqlCommand cmd = new SqlCommand("SELECT QUANTITE,PRICE,TOTAL_AMOUNT");

            dataGridView1.Columns["ID PRODUIT"].Visible = false;
            dataGridView1.Columns["ID CLIENT"].Visible = false;
            dataGridView1.Columns["NOM_BUYER"].Visible = false;




            if (dataGridView1.Rows.Count > 0)
            {
                string clear = string.Format("DELETE FROM DEVIS WHERE ID_CLIENT = '{0}' AND DATE_DEVIS = '{1}'", Methode.ID, Methode.date);
                Methode.Update(clear);
                
                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string querry = string.Format("insert into DEVIS values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", int.Parse(dataGridView1.Rows[i].Cells["ID CLIENT"].Value.ToString()), DateTime.Now.ToShortDateString(), int.Parse(dataGridView1.Rows[i].Cells["ID PRODUIT"].Value.ToString()), int.Parse(dataGridView1.Rows[i].Cells["Quantité"].Value.ToString()), float.Parse(dataGridView1.Rows[i].Cells["Prix"].Value.ToString()), float.Parse(dataGridView1.Rows[i].Cells["Remise"].Value.ToString()), float.Parse(dataGridView1.Rows[i].Cells["Montant total"].Value.ToString()), dataGridView1.Rows[i].Cells["NOM_BUYER"].Value.ToString());
                    if (Methode.Update(querry) != 0)
                    {

                    }
                }
                
            }
        }

        private void PrintingDEVait_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
