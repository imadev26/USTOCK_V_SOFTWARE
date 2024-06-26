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
    public partial class Add_product : Form
    {
        public Add_product()
        {
            InitializeComponent();
        }
        SqlConnection cn = Methode.ConnectSqlserver();
        DataSet ds = new DataSet();

        void clear()
        {
            txt_nom_prod.Text = string.Empty;
            txt_num_qte.Value = 0;
            txt_prix_prod.Text = string.Empty;
            cb_CAT_Prod.SelectedIndex = -1;
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
        void DGVcharger()
        {
            ds.Tables.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("select * from PRODUIT", cn);
            sda.Fill(ds, "PRODUIT");
            DGV_addPROD1.DataSource = ds.Tables["PRODUIT"];
            cn.Close();
        }

       

        

        private void Add_product_Load(object sender, EventArgs e)
        {
            cbCharger();
            DGVcharger();
        }

        private void btn_prod_add_Click(object sender, EventArgs e)
        {
            if (txt_nom_prod.Text.Equals(string.Empty) || txt_num_qte.Value.Equals(0) || txt_prix_prod.Text.Equals(string.Empty) || cb_CAT_Prod.SelectedIndex.Equals(-1) || pictureBox1.ImageLocation == null)
            {
                MessageBox.Show("Veuillez verifier vos information");
            }
            else
            {
                try
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        cn.Close();
                    }
                    cn.Open();
                    string querry = string.Format("insert into PRODUIT values ('{0}','{1}','{2}','{3}','{4}','{5}')", cb_CAT_Prod.SelectedValue, txt_nom_prod.Text, txt_num_qte.Text, txt_prix_prod.Text,TXT_FOUR.Text,Path.GetFileName(pictureBox1.ImageLocation));
                    SqlCommand cmd = new SqlCommand(querry, cn);
                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        MessageBox.Show("Ajouter avec succes");
                        file = new FileInfo(@"C:\Picture\" + Path.GetFileName(pictureBox1.ImageLocation));
                        if (file.Exists)
                        {


                            pictureBox1.Image = null;

                        }
                        else
                        {
                            File.Copy(dialog.FileName, @"C:\Picture\" + Path.GetFileName(pictureBox1.ImageLocation));
                        }
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

        private void btn_reset_product_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_prix_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }
        public OpenFileDialog dialog;
        public string imgpath;
        FileInfo file;
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
