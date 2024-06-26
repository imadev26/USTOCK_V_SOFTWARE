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
using System.IO;

namespace WindowsFormsApp1.Forms
{
    public partial class GestionDesProduits : Form
    {
        public GestionDesProduits()
        {
            InitializeComponent();
        }

        SqlConnection cn = Methode.ConnectSqlserver();
        DataSet ds = new DataSet();
        void clear()
        {
            CB_ID_Prod.Text             = string.Empty;
            cb_CAT_Prod.SelectedIndex   = -1;
            CB_NOM_Prod.Text            = string.Empty;
            txt_num_qte.Value           = 0;
            TXT_FOUR.Text               = string.Empty;
            txt_prix_prod.Text          = string.Empty;
        }
        void chercher(int i)
        {

            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (CB_ID_Prod.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;
                    cb_CAT_Prod.SelectedValue = dataGridView1.Rows[i].Cells[1].Value;
                    CB_NOM_Prod.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    txt_num_qte.Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    txt_prix_prod.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    pictureBox1.Image = Image.FromFile(@"C:\Picture\" + dataGridView1.Rows[i].Cells[6].Value.ToString());
                    Methode.img = dataGridView1.Rows[i].Cells[6].Value.ToString();
                }
            }
            
        }
        void DGVcharger()
        {
            ds.Tables.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("select * from PRODUIT", cn);
            sda.Fill(ds, "PRODUIT");
            dataGridView1.DataSource = ds.Tables["PRODUIT"];
            cn.Close();
        }
        void cbCharger()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select ID_CAT ,NOM_CAT from CATEGORIE", cn);
            sda.Fill(ds, "CATEGORIE");
            cb_CAT_Prod.DataSource = ds.Tables["CATEGORIE"];
            cb_CAT_Prod.DisplayMember = "NOM_CAT";
            cb_CAT_Prod.ValueMember = "ID_CAT";
            cb_CAT_Prod.SelectedIndex = -1;
            cn.Close();
        }

        private void GestionDesProduits_Load(object sender, EventArgs e)
        {
            cbCharger();
            DGVcharger();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (CB_ID_Prod.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    chercher(i);
                }
            }
        }
        public OpenFileDialog dialog;

        
        FileInfo file;
        private void button1_Click(object sender, EventArgs e)
        {
            if (CB_ID_Prod.Text.Equals(string.Empty))
            {
                MessageBox.Show("Veuillez Saisir ID de Produit pour Modifie");
                CB_ID_Prod.Focus();
            }
            else
            {
                try
                {
                    cn.Open();
                    Methode.img = pictureBox1.ImageLocation;
                    string querry = string.Format("update PRODUIT set ID_CAT = '{0}',NOM_PRODUIT = '{1}',QTE_STOCK = '{2}',PRIX = '{3}',FOUR ='{4}',img_prod = '{5}'  where ID_PRODUIT = '{6}'", cb_CAT_Prod.SelectedValue, CB_NOM_Prod.Text, txt_num_qte.Value, txt_prix_prod.Text, TXT_FOUR.Text,Path.GetFileName(pictureBox1.ImageLocation),CB_ID_Prod.Text);
                    SqlCommand cmd = new SqlCommand(querry, cn);
                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        MessageBox.Show("Mise a joure avec succes");
                        file = new FileInfo(@"C:\Picture\" + Path.GetFileName(Methode.img));
                        if (file.Exists)
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            File.Copy(dialog.FileName, @"C:\Picture\" + Path.GetFileName(Methode.img));
                        }
                        DGVcharger();
                        chercher(int.Parse(CB_ID_Prod.Text));
                        clear();
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
                cn.Close();
            }

        }

        private void btn_prod_add_Click(object sender, EventArgs e)
        {
            if (CB_ID_Prod.Text.Equals(string.Empty))
            {
                MessageBox.Show("Veuillez Saisir ID de Produit pour Supprimer");
                CB_ID_Prod.Focus();
            }
            else
            {
                try
                {
                    cn.Open();
                    string querry = string.Format("Delete from PRODUIT  where ID_PRODUIT = '{0}'", CB_ID_Prod.Text);
                    SqlCommand cmd = new SqlCommand(querry, cn);
                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        MessageBox.Show("Suppression avec succes");
                        DGVcharger();
                        clear();
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
                cn.Close();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //file = new FileInfo(@"C:\Picture\" + dataGridView1.CurrentRow.Cells[5].Value.ToString(););
            CB_ID_Prod.Text           = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cb_CAT_Prod.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            CB_NOM_Prod.Text          = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_num_qte.Value         = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);
            txt_prix_prod.Text        = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TXT_FOUR.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            pictureBox1.Image         = Image.FromFile(@"C:\Picture\" + dataGridView1.CurrentRow.Cells[6].Value.ToString());
        }

        private void btn_prod_reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.jpg)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(dialog.FileName);
                pictureBox1.ImageLocation = dialog.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
