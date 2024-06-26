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
    public partial class GESTCategorie : Form
    {
        SqlConnection cn = Methode.ConnectSqlserver();
        DataSet ds = new DataSet();
        public GESTCategorie()
        {
            InitializeComponent();
        }
        void clear()
        {
            txt_CAT_ID.Text  = string.Empty;
            txt_nom_cat.Text = string.Empty;
            txt_des_CAT.Text = string.Empty;
        }
        bool ExistClient(string x)
        {
            bool a = false;
            try
            {
                cn = Methode.ConnectSqlserver();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORIE WHERE ID_CAT ='" + x + "'", cn);
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
        void DGVcharger()
        {
            ds.Tables.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("select * from CATEGORIE", cn);
            sda.Fill(ds, "CATEGORIE");
            DGV_Cate.DataSource = ds.Tables["CATEGORIE"];
            cn.Close();
        }
        void chercher(int i)
        {
            for (i = 0; i < DGV_Cate.Rows.Count; i++)
            {
                if (DGV_Cate.Rows[i].Cells[0].Value.ToString() == txt_CAT_ID.Text)
                {
                    DGV_Cate.ClearSelection();
                    DGV_Cate.Rows[i].Selected = true;
                    clear();
                    txt_CAT_ID.Text = DGV_Cate.Rows[i].Cells[0].Value.ToString();
                    txt_nom_cat.Text = DGV_Cate.Rows[i].Cells[1].Value.ToString();
                    txt_des_CAT.Text = DGV_Cate.Rows[i].Cells[2].Value.ToString();
                }
            }
        }
        
        private void GESTCategorie_Load(object sender, EventArgs e)
        {
            DGVcharger();
        }

        private void btn_CAT_add_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string querry = string.Format("insert into CATEGORIE values('{0}','{1}')", txt_nom_cat.Text, txt_des_CAT.Text);
                SqlCommand cmd = new SqlCommand(querry, cn);
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    MessageBox.Show("Ajouté");
                    DGVcharger();
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            cn.Close();
        }

        private void btn_CAT_edit_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                string querry = string.Format("update CATEGORIE set NOM_CAT = '{0}',DES_CAT = '{1}' where ID_CAT = '{2}'", txt_nom_cat.Text, txt_des_CAT.Text, txt_CAT_ID.Text);
                SqlCommand cmd = new SqlCommand(querry, cn);
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    MessageBox.Show("Edité");
                    DGVcharger();
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            cn.Close();
        }

        private void btn_CAT_delete_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                string querry = string.Format("delete from CATEGORIE where ID_CAT = '{0}'",txt_CAT_ID.Text);
                SqlCommand cmd = new SqlCommand(querry, cn);
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    MessageBox.Show("Supprimé");
                    DGVcharger();
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            cn.Close();
        }

        private void btn_CAT_searsh_Click(object sender, EventArgs e)
        {
            //if (ExistClient(txt_CAT_ID.Text) == false)
            //{
            //    MessageBox.Show("Not exists");
            //}
            //else
            //{
            //    chercher(int.Parse(txt_CAT_ID.Text));
            //}
            for (int i = 0; i < DGV_Cate.Rows.Count; i++)
            {
                if (txt_nom_cat.Text.ToLower() == DGV_Cate.Rows[i].Cells[1].Value.ToString().ToLower())
                {
                    DGV_Cate.ClearSelection();
                    DGV_Cate.Rows[i].Selected = true;
                    txt_CAT_ID.Text  = DGV_Cate.Rows[i].Cells[0].Value.ToString();
                    txt_nom_cat.Text = DGV_Cate.Rows[i].Cells[1].Value.ToString();
                    txt_des_CAT.Text = DGV_Cate.Rows[i].Cells[2].Value.ToString();
                }
            }
        }

        private void DGV_Cate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_CAT_ID.Text = DGV_Cate.CurrentRow.Cells[0].Value.ToString();
            txt_nom_cat.Text = DGV_Cate.CurrentRow.Cells[1].Value.ToString();
            txt_des_CAT.Text = DGV_Cate.CurrentRow.Cells[2].Value.ToString();
        }

        
    }
}
