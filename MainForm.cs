using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        //DECLARATION
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public static string username;
        public string Gradation;
        public MainForm(string G,string x)
        {
            Gradation = G;
            username = x;
            InitializeComponent();
            random = new Random();
            button1.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        ////GUI
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Methodes
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender!= null)
            {
                DisableButton();
                if (currentButton != (Button)btnSender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    button1.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(64, 64, 64);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        //Methode Open form child

        private void OpenChildForm(Form childForm,Object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnsender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_Title.Text = currentButton.Text;

        }

        private void btn_ANC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Add_Client(), sender);
        }

        private void btn_GCLIENT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GestionDesClient(), sender);
        }

        private void btn_ANP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Add_product(), sender);
        }

        private void btn_GPROD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GestionDesProduits(), sender);
        }

        private void btn_GCAT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GESTCategorie(), sender);
        }

        public void btn_ANV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Add_New_Sell(username), sender);
        }


        private void btn_ANU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Add_User(), sender);
        }

        private void btn_GUSER_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GestionUsers(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lbl_Title.Text = "Page D'Accueil";
            panelTitleBar.BackColor = Color.FromArgb(26, 1, 155);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            button1.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous étes sure ??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login Log = new Login();
                this.Hide();
                Log.ShowDialog();
            }
        }

        private void BTN_REDUIRE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Resize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Facteur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Devis(), sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Gradation == "modérateur")
            {
                btn_ANU.Visible = false;
                btn_GUSER.Visible = false;
            }
            else if (Gradation == "utilisateur")
            {
                btn_ANU.Visible = false;
                btn_GUSER.Visible = false;
                btn_GCLIENT.Visible = false;
                btn_GPROD.Visible = false;
                btn_GCAT.Visible = false;
                //btn_GVENTE.Visible = false;
            }
        }

        private void btn_BONCMD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.bon_commande(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LivraisonFORM(), sender);
        }
    }
}
