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
    public partial class bon_commande : Form
    {
        public bon_commande()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        string DATE_CMD;
        string NOM_VENDEUR;
        string DESCRIPTION_CMD;
        string COUNTRY;
        string VILLE;
        string ADRESSE;
        float charge;
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
            if (ds.Tables["BON_cmd"] != null)
            {
                ds.Tables["BON_cmd"].Clear();
            }
            string s = string.Format("SELECT PRODUIT.NOM_PRODUIT,DEVIS.* FROM DEVIS INNER JOIN PRODUIT ON PRODUIT.ID_PRODUIT = DEVIS.ID_PRODUIT WHERE ID_CLIENT = '{0}' AND DATE_DEVIS = '{1}'", int.Parse(cb_client_ID.SelectedValue.ToString()), dateTimePicker1.Value.ToShortDateString());
            string s1 = string.Format("SELECT TOP 1 NOM_BUYER FROM DEVIS WHERE ID_CLIENT = '{0}' AND DATE_DEVIS = '{1}' ", int.Parse(cb_client_ID.SelectedValue.ToString()), dateTimePicker1.Value.ToShortDateString());
            SqlCommand cmd = new SqlCommand(s1,Methode.ConnectSqlserver());
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                Methode.userNAME = rd[0].ToString();
            }
            SqlDataAdapter dap = new SqlDataAdapter(s, Methode.ConnectSqlserver()) ;
            dap.Fill(ds, "BON_cmd");
            dataGridView1.DataSource = ds.Tables["BON_cmd"];
            dataGridView1.Columns[0].FillWeight = 150;
            dataGridView1.Columns["ID_PRODUIT"].Visible = false;
            dataGridView1.Columns["ID_CLIENT"].Visible = false;
            dataGridView1.Columns["ID_DEVIS"].Visible = false;
            dataGridView1.Columns["DATE_DEVIS"].Visible = false;
            dataGridView1.Columns["NOM_BUYER"].Visible = false;
            float res = 0;
            float remise = 0;
            float montantSR = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                res = res + float.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                remise = remise + float.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                montantSR = montantSR + (float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()));
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
            SqlDataAdapter sda = new SqlDataAdapter("select ID_CLIENT ,concat(NOM_CLIENT,' ',PRN_CLIENT) as 'Fname' from CLIENT", Methode.ConnectSqlserver());
            sda.Fill(ds, "CLIENT_1");
            cb_client_ID.DataSource = ds.Tables["CLIENT_1"];
            cb_client_ID.DisplayMember = "Fname";
            cb_client_ID.ValueMember = "ID_CLIENT";
            cb_client_ID.SelectedIndex = -1;
        }
        private void bon_commande_Load(object sender, EventArgs e)
        {
            charger();
        }

        private void cb_client_ID_Click(object sender, EventArgs e)
        {
            //ds.Tables["BON_cmd"].Clear();
        }

        

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Le transport dédié")
            {
                if (checkBox1.Checked == true)
                {
                    MessageBox.Show("Le transport dédié, connu également sous le nom de transport urgent, transport express ou bien du taxi colis est le moyen de transport le plus convoité pour un transport de colis très urgent avec des délais de livraison courts et bien déterminés. \nComme son nom l’indique, le transport dédié vous permet de bénéficier d’un véhicule dédié (camion, TGV, avion…) uniquement à votre demande et une expédition acheminée directement dans la foulée d’un point A à un point B.\nVotre marchandise est alors remise en main propre à son destinataire.Perceval - Express est spécialisée dans ce type de livraison.Nous vous proposons un service de transport dédié extrêmement fiable avec un suivi constant de votre colis jusqu’à sa destination finale.");
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Le service coursier")
            {
                if (checkBox1.Checked == true)
                {
                    MessageBox.Show("Le service coursier concerne en général le transport dans les grandes villes et l’envoi de colis très urgent en très peu de temps.\n L’intérêt du service coursier est justement dans la rapidité de déplacement afin de permettre une livraison le jour même et en main propre.Même si le service coursier est essentiellement proposé en deux roues ou en véhicules légers, sachez que ce type de service existe également en camion, pour vous permettre un transport routier sur mesure de vos palettes et colis volumineux.");
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Le transport en messagerie")
            {
                if (checkBox1.Checked == true)
                {
                    MessageBox.Show("Contrairement au transport dédié où la marchandise est expédiée dans la foulée, le transport de messagerie nécessite un passage obligatoire à un centre de tri, vu que la messagerie concerne un transport de colis en lots.\n En effet, le transporteur devra effectuer au moins un arrêt à une plateforme afin que sa marchandise soit triée avant son expédition.Les délais de livraison en messagerie sont donc plus longs, parfois jusqu’à 72h et le tarif est naturellement plus attractif qu’un transport express.\nL’envoi par messagerie existe aussi bien au niveau national qu’international et le type de marchandise acceptée ainsi que ses dimensions et son volume varient d’une société de messagerie à une autre.");
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Le bagage accompagné")
            {
                if (checkBox1.Checked == true)
                {
                    MessageBox.Show("Le transport en bagage accompagné est souvent utilisé lors de transport de marchandise fragile ou confidentielle sur de long trajet.\nUn convoyeur spécial est alors mis en place afin de prendre en charge votre envoi important et l’acheminer à son destinataire finale.Cette solution de transport existe par rail ou par avion(le service OBC).Ce type de livraison nécessite une organisation sans failles, notamment une anticipation des formalités douanières pour un envoie hors Union Européennes.");
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Le groupage")
            {
                if (checkBox1.Checked == true)
                {
                    MessageBox.Show("Le groupage est souvent sollicité pour des transports sur des longues distances, car les coûts sont moindres.\n La marchandise provient dans ce cas de plusieurs expéditeurs afin d’être envoyée vers différents destinataires situés soit sur le même lieu de livraison ou bien sur le même trajet.\n Même si cette solution est moins onéreuse, elle comporte néanmoins des inconvénients liés surtout aux délais de livraison qui sont beaucoup plus importants qu’un transport direct.");
                }
            }
            else
            {
                charge = 0;
            }
        }

        private void cb_client_ID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chargerLBL();
            selection();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ds.Tables["BON_cmd"].Clear();
            selection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_client_ID.SelectedIndex != -1 && comboBox1.SelectedIndex != -1 && txt_value_liv_charge.Text != string.Empty)
            {


                charge = int.Parse(txt_value_liv_charge.Text);
                //string querry;
                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    querry = string.Format("UPDATE PRODUIT SET QTE_STOCK = QTE_STOCK - '{0}' WHERE ID_PRODUIT = '{1}'", int.Parse(ds.Tables["BON_cmd"].Rows[i]["Quantité"].ToString()), ds.Tables["BON_cmd"].Rows[i]["ID_PRODUIT"].ToString());
                //    Methode.Update(querry);
                //}
                //string querry1 = string.Format("DELETE FROM DEVIS WHERE ID_CLIENT = '{0}'", id);
                //int k = Methode.Update(querry1);
                //if (k != 0)
                //{

                //}
                int id = int.Parse(cb_client_ID.SelectedValue.ToString());
                string s = string.Format("SELECT COUNTRY,VILLE,ADRESSE FROM CLIENT WHERE ID_CLIENT = '{0}'", id);
                SqlCommand cmd = new SqlCommand(s,Methode.ConnectSqlserver());
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    DATE_CMD = dateTimePicker1.Value.ToShortDateString();
                    NOM_VENDEUR = Methode.userNAME;
                    DESCRIPTION_CMD = TXT_DES.Text;
                    COUNTRY = rd[0].ToString();
                    VILLE = rd[1].ToString();
                    ADRESSE = rd[2].ToString();
                }
                    
                
                

                string querr;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    querr = string.Format("INSERT INTO LIVRAISON VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", cb_client_ID.SelectedValue, Methode.userNAME, COUNTRY, VILLE, ADRESSE, comboBox1.SelectedItem.ToString(), charge,TXT_DES.Text);
                    SqlCommand cmd1 = new SqlCommand(querr, Methode.ConnectSqlserver());
                    int k1 = cmd1.ExecuteNonQuery();
                    if (k1 != 0)
                    {
                        MessageBox.Show("LIVRAISON BIEN AFFECTER");
                    }

                }

            }
            else
            {
                MessageBox.Show("Veuillez verifier vos information");
            }
        }
    }
}
