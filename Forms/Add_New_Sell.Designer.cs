
namespace WindowsFormsApp1.Forms
{
    partial class Add_New_Sell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Sell));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Print = new System.Windows.Forms.Button();
            this.CB_PRODUIT = new System.Windows.Forms.ComboBox();
            this.CB_CAT = new System.Windows.Forms.ComboBox();
            this.btn_prod_Reset = new System.Windows.Forms.Button();
            this.btn_prod_add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_war = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nomvendeur = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_N_facteure = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_client_ID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_user_ville = new System.Windows.Forms.TextBox();
            this.txt_user_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user_num = new System.Windows.Forms.TextBox();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_user_lname = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_prod_total = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_prod_montant = new System.Windows.Forms.TextBox();
            this.txt_qte_prod = new System.Windows.Forms.TextBox();
            this.txt_prix_prod = new System.Windows.Forms.TextBox();
            this.txt_nom_prod = new System.Windows.Forms.TextBox();
            this.txt_ID_prod = new System.Windows.Forms.TextBox();
            this.DGV_addVENT = new System.Windows.Forms.DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_addVENT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_war);
            this.panel1.Controls.Add(this.btn_Print);
            this.panel1.Controls.Add(this.CB_PRODUIT);
            this.panel1.Controls.Add(this.CB_CAT);
            this.panel1.Controls.Add(this.btn_prod_Reset);
            this.panel1.Controls.Add(this.btn_prod_add);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 390);
            this.panel1.TabIndex = 1;
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Print.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(400, 260);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(339, 65);
            this.btn_Print.TabIndex = 13;
            this.btn_Print.Text = "Devis";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // CB_PRODUIT
            // 
            this.CB_PRODUIT.BackColor = System.Drawing.SystemColors.Control;
            this.CB_PRODUIT.Dock = System.Windows.Forms.DockStyle.Top;
            this.CB_PRODUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_PRODUIT.FormattingEnabled = true;
            this.CB_PRODUIT.Location = new System.Drawing.Point(400, 104);
            this.CB_PRODUIT.Name = "CB_PRODUIT";
            this.CB_PRODUIT.Size = new System.Drawing.Size(339, 39);
            this.CB_PRODUIT.TabIndex = 11;
            this.CB_PRODUIT.SelectionChangeCommitted += new System.EventHandler(this.CB_PRODUIT_SelectionChangeCommitted);
            // 
            // CB_CAT
            // 
            this.CB_CAT.BackColor = System.Drawing.SystemColors.Control;
            this.CB_CAT.Dock = System.Windows.Forms.DockStyle.Top;
            this.CB_CAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_CAT.FormattingEnabled = true;
            this.CB_CAT.Location = new System.Drawing.Point(400, 65);
            this.CB_CAT.Name = "CB_CAT";
            this.CB_CAT.Size = new System.Drawing.Size(339, 39);
            this.CB_CAT.TabIndex = 12;
            this.CB_CAT.SelectionChangeCommitted += new System.EventHandler(this.CB_CAT_SelectionChangeCommitted);
            this.CB_CAT.Enter += new System.EventHandler(this.CB_CAT_Enter);
            // 
            // btn_prod_Reset
            // 
            this.btn_prod_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_prod_Reset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_prod_Reset.FlatAppearance.BorderSize = 0;
            this.btn_prod_Reset.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_prod_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_prod_Reset.Location = new System.Drawing.Point(400, 0);
            this.btn_prod_Reset.Name = "btn_prod_Reset";
            this.btn_prod_Reset.Size = new System.Drawing.Size(339, 65);
            this.btn_prod_Reset.TabIndex = 9;
            this.btn_prod_Reset.Text = "Réinitialiser";
            this.btn_prod_Reset.UseVisualStyleBackColor = false;
            this.btn_prod_Reset.Click += new System.EventHandler(this.btn_prod_Reset_Click);
            // 
            // btn_prod_add
            // 
            this.btn_prod_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_prod_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_prod_add.FlatAppearance.BorderSize = 0;
            this.btn_prod_add.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_prod_add.ForeColor = System.Drawing.Color.White;
            this.btn_prod_add.Location = new System.Drawing.Point(400, 325);
            this.btn_prod_add.Name = "btn_prod_add";
            this.btn_prod_add.Size = new System.Drawing.Size(339, 65);
            this.btn_prod_add.TabIndex = 8;
            this.btn_prod_add.Text = "Ajouter";
            this.btn_prod_add.UseVisualStyleBackColor = false;
            this.btn_prod_add.Click += new System.EventHandler(this.btn_prod_add_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(739, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 390);
            this.panel3.TabIndex = 1;
            // 
            // lbl_war
            // 
            this.lbl_war.AutoSize = true;
            this.lbl_war.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_war.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_war.ForeColor = System.Drawing.Color.White;
            this.lbl_war.Location = new System.Drawing.Point(400, 143);
            this.lbl_war.Name = "lbl_war";
            this.lbl_war.Size = new System.Drawing.Size(0, 25);
            this.lbl_war.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_nomvendeur);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txt_N_facteure);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(17, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 307);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facture Information";
            // 
            // txt_nomvendeur
            // 
            this.txt_nomvendeur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nomvendeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomvendeur.ForeColor = System.Drawing.Color.White;
            this.txt_nomvendeur.Location = new System.Drawing.Point(193, 218);
            this.txt_nomvendeur.Name = "txt_nomvendeur";
            this.txt_nomvendeur.ReadOnly = true;
            this.txt_nomvendeur.Size = new System.Drawing.Size(162, 26);
            this.txt_nomvendeur.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 29);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_N_facteure
            // 
            this.txt_N_facteure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_N_facteure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_N_facteure.ForeColor = System.Drawing.Color.White;
            this.txt_N_facteure.Location = new System.Drawing.Point(243, 63);
            this.txt_N_facteure.Name = "txt_N_facteure";
            this.txt_N_facteure.ReadOnly = true;
            this.txt_N_facteure.Size = new System.Drawing.Size(89, 26);
            this.txt_N_facteure.TabIndex = 21;
            this.txt_N_facteure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_N_facteure_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nom du Vendeur  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "N° de Facture ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "La Date de la Vente  :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_client_ID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 390);
            this.panel2.TabIndex = 0;
            // 
            // cb_client_ID
            // 
            this.cb_client_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_client_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_client_ID.ForeColor = System.Drawing.Color.White;
            this.cb_client_ID.FormattingEnabled = true;
            this.cb_client_ID.Location = new System.Drawing.Point(112, 35);
            this.cb_client_ID.Name = "cb_client_ID";
            this.cb_client_ID.Size = new System.Drawing.Size(273, 21);
            this.cb_client_ID.TabIndex = 23;
            this.cb_client_ID.SelectedIndexChanged += new System.EventHandler(this.cb_client_ID_SelectedIndexChanged);
            this.cb_client_ID.SelectionChangeCommitted += new System.EventHandler(this.cb_client_ID_SelectionChangeCommitted);
            this.cb_client_ID.TextUpdate += new System.EventHandler(this.cb_client_ID_TextUpdate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Client";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_user_ville);
            this.groupBox1.Controls.Add(this.txt_user_Email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_user_num);
            this.groupBox1.Controls.Add(this.txt_user_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_user_lname);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 254);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information de Client";
            // 
            // txt_user_ville
            // 
            this.txt_user_ville.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_ville.ForeColor = System.Drawing.Color.White;
            this.txt_user_ville.Location = new System.Drawing.Point(203, 196);
            this.txt_user_ville.Name = "txt_user_ville";
            this.txt_user_ville.ReadOnly = true;
            this.txt_user_ville.Size = new System.Drawing.Size(129, 26);
            this.txt_user_ville.TabIndex = 20;
            // 
            // txt_user_Email
            // 
            this.txt_user_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_Email.ForeColor = System.Drawing.Color.White;
            this.txt_user_Email.Location = new System.Drawing.Point(203, 155);
            this.txt_user_Email.Name = "txt_user_Email";
            this.txt_user_Email.ReadOnly = true;
            this.txt_user_Email.Size = new System.Drawing.Size(129, 26);
            this.txt_user_Email.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ville :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email :";
            // 
            // txt_user_num
            // 
            this.txt_user_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_num.ForeColor = System.Drawing.Color.White;
            this.txt_user_num.Location = new System.Drawing.Point(203, 114);
            this.txt_user_num.Name = "txt_user_num";
            this.txt_user_num.ReadOnly = true;
            this.txt_user_num.Size = new System.Drawing.Size(129, 26);
            this.txt_user_num.TabIndex = 18;
            // 
            // txt_user_name
            // 
            this.txt_user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.ForeColor = System.Drawing.Color.White;
            this.txt_user_name.Location = new System.Drawing.Point(203, 32);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.ReadOnly = true;
            this.txt_user_name.Size = new System.Drawing.Size(129, 26);
            this.txt_user_name.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Téléphone :";
            // 
            // txt_user_lname
            // 
            this.txt_user_lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_lname.ForeColor = System.Drawing.Color.White;
            this.txt_user_lname.Location = new System.Drawing.Point(203, 73);
            this.txt_user_lname.Name = "txt_user_lname";
            this.txt_user_lname.ReadOnly = true;
            this.txt_user_lname.Size = new System.Drawing.Size(129, 26);
            this.txt_user_lname.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 390);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1139, 58);
            this.panel4.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Gray;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(999, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 58);
            this.label19.TabIndex = 42;
            this.label19.Text = "Montant Total";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Gray;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Dock = System.Windows.Forms.DockStyle.Left;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(828, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 58);
            this.label18.TabIndex = 40;
            this.label18.Text = "Taux d\'actualisation(%)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Gray;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Dock = System.Windows.Forms.DockStyle.Left;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(665, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 58);
            this.label17.TabIndex = 38;
            this.label17.Text = "Montant";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Gray;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Dock = System.Windows.Forms.DockStyle.Left;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(511, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 58);
            this.label16.TabIndex = 36;
            this.label16.Text = "Quantité de Produit";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Gray;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Dock = System.Windows.Forms.DockStyle.Left;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(319, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 58);
            this.label15.TabIndex = 30;
            this.label15.Text = "Prix de Produit";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Gray;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(114, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 58);
            this.label14.TabIndex = 31;
            this.label14.Text = "Nom Produit";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Gray;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 58);
            this.label13.TabIndex = 32;
            this.label13.Text = "ID Produit";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_prod_total);
            this.panel5.Controls.Add(this.txt_discount);
            this.panel5.Controls.Add(this.txt_prod_montant);
            this.panel5.Controls.Add(this.txt_qte_prod);
            this.panel5.Controls.Add(this.txt_prix_prod);
            this.panel5.Controls.Add(this.txt_nom_prod);
            this.panel5.Controls.Add(this.txt_ID_prod);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 448);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1139, 40);
            this.panel5.TabIndex = 3;
            // 
            // txt_prod_total
            // 
            this.txt_prod_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prod_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_prod_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prod_total.Location = new System.Drawing.Point(999, 0);
            this.txt_prod_total.Name = "txt_prod_total";
            this.txt_prod_total.ReadOnly = true;
            this.txt_prod_total.Size = new System.Drawing.Size(140, 38);
            this.txt_prod_total.TabIndex = 50;
            this.txt_prod_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_discount
            // 
            this.txt_discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_discount.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(828, 0);
            this.txt_discount.MaxLength = 2;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(171, 38);
            this.txt_discount.TabIndex = 49;
            this.txt_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            this.txt_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            this.txt_discount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_discount_KeyUp);
            // 
            // txt_prod_montant
            // 
            this.txt_prod_montant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prod_montant.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_prod_montant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prod_montant.Location = new System.Drawing.Point(665, 0);
            this.txt_prod_montant.Name = "txt_prod_montant";
            this.txt_prod_montant.ReadOnly = true;
            this.txt_prod_montant.Size = new System.Drawing.Size(163, 38);
            this.txt_prod_montant.TabIndex = 48;
            this.txt_prod_montant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_qte_prod
            // 
            this.txt_qte_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qte_prod.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_qte_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qte_prod.Location = new System.Drawing.Point(511, 0);
            this.txt_qte_prod.MaxLength = 8;
            this.txt_qte_prod.Name = "txt_qte_prod";
            this.txt_qte_prod.Size = new System.Drawing.Size(154, 38);
            this.txt_qte_prod.TabIndex = 47;
            this.txt_qte_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qte_prod.TextChanged += new System.EventHandler(this.txt_qte_prod_TextChanged);
            this.txt_qte_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qte_prod_KeyPress);
            this.txt_qte_prod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_qte_prod_KeyUp);
            // 
            // txt_prix_prod
            // 
            this.txt_prix_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prix_prod.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_prix_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix_prod.Location = new System.Drawing.Point(319, 0);
            this.txt_prix_prod.Name = "txt_prix_prod";
            this.txt_prix_prod.ReadOnly = true;
            this.txt_prix_prod.Size = new System.Drawing.Size(192, 38);
            this.txt_prix_prod.TabIndex = 44;
            this.txt_prix_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nom_prod
            // 
            this.txt_nom_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nom_prod.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_nom_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom_prod.Location = new System.Drawing.Point(114, 0);
            this.txt_nom_prod.Name = "txt_nom_prod";
            this.txt_nom_prod.ReadOnly = true;
            this.txt_nom_prod.Size = new System.Drawing.Size(205, 38);
            this.txt_nom_prod.TabIndex = 45;
            // 
            // txt_ID_prod
            // 
            this.txt_ID_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID_prod.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_ID_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_prod.Location = new System.Drawing.Point(0, 0);
            this.txt_ID_prod.Name = "txt_ID_prod";
            this.txt_ID_prod.ReadOnly = true;
            this.txt_ID_prod.Size = new System.Drawing.Size(114, 38);
            this.txt_ID_prod.TabIndex = 46;
            this.txt_ID_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGV_addVENT
            // 
            this.DGV_addVENT.AllowUserToAddRows = false;
            this.DGV_addVENT.AllowUserToDeleteRows = false;
            this.DGV_addVENT.AllowUserToResizeColumns = false;
            this.DGV_addVENT.AllowUserToResizeRows = false;
            this.DGV_addVENT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_addVENT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_addVENT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_addVENT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_addVENT.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_addVENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_addVENT.Location = new System.Drawing.Point(0, 488);
            this.DGV_addVENT.Name = "DGV_addVENT";
            this.DGV_addVENT.Size = new System.Drawing.Size(1139, 11);
            this.DGV_addVENT.TabIndex = 4;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Add_New_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1139, 499);
            this.Controls.Add(this.DGV_addVENT);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_New_Sell";
            this.Text = "Add_New_Sell";
            this.Load += new System.EventHandler(this.Add_New_Sell_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_addVENT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_prod_Reset;
        private System.Windows.Forms.Button btn_prod_add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nomvendeur;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_N_facteure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_client_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_user_ville;
        private System.Windows.Forms.TextBox txt_user_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_user_num;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_user_lname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txt_prod_total;
        public System.Windows.Forms.TextBox txt_discount;
        public System.Windows.Forms.TextBox txt_prod_montant;
        public System.Windows.Forms.TextBox txt_qte_prod;
        public System.Windows.Forms.TextBox txt_prix_prod;
        public System.Windows.Forms.TextBox txt_nom_prod;
        public System.Windows.Forms.TextBox txt_ID_prod;
        private System.Windows.Forms.ComboBox CB_PRODUIT;
        private System.Windows.Forms.ComboBox CB_CAT;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.DataGridView DGV_addVENT;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lbl_war;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROD;
        //private System.Windows.Forms.DataGridViewTextBoxColumn NOM_PROD;
        //private System.Windows.Forms.DataGridViewTextBoxColumn PROD_PRX;
        //private System.Windows.Forms.DataGridViewTextBoxColumn QTE_PROD;
        //private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT;
        //private System.Windows.Forms.DataGridViewTextBoxColumn REMISE;
        //private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT_T;
    }
}