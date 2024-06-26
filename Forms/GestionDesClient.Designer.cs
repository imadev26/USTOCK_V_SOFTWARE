
namespace WindowsFormsApp1.Forms
{
    partial class GestionDesClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_srch_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_GEST_search = new System.Windows.Forms.Button();
            this.btn_CLT_LOAD = new System.Windows.Forms.Button();
            this.btn_CLT_UPDATE = new System.Windows.Forms.Button();
            this.btn_GEST_DROP = new System.Windows.Forms.Button();
            this.cb_client_ID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_user_Pays = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_user_ville = new System.Windows.Forms.TextBox();
            this.txt_user_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user_lname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DGV_gestCLT = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_gestCLT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_srch_ID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_GEST_search);
            this.panel1.Controls.Add(this.btn_CLT_LOAD);
            this.panel1.Controls.Add(this.btn_CLT_UPDATE);
            this.panel1.Controls.Add(this.btn_GEST_DROP);
            this.panel1.Controls.Add(this.cb_client_ID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 276);
            this.panel1.TabIndex = 0;
            // 
            // txt_srch_ID
            // 
            this.txt_srch_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_srch_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_srch_ID.ForeColor = System.Drawing.Color.White;
            this.txt_srch_ID.Location = new System.Drawing.Point(800, 63);
            this.txt_srch_ID.Name = "txt_srch_ID";
            this.txt_srch_ID.Size = new System.Drawing.Size(273, 26);
            this.txt_srch_ID.TabIndex = 11;
            this.txt_srch_ID.TextChanged += new System.EventHandler(this.txt_srch_ID_TextChanged);
            this.txt_srch_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_srch_ID_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(767, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID";
            // 
            // btn_GEST_search
            // 
            this.btn_GEST_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_GEST_search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_GEST_search.FlatAppearance.BorderSize = 0;
            this.btn_GEST_search.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_GEST_search.ForeColor = System.Drawing.Color.White;
            this.btn_GEST_search.Location = new System.Drawing.Point(663, 116);
            this.btn_GEST_search.Name = "btn_GEST_search";
            this.btn_GEST_search.Size = new System.Drawing.Size(476, 40);
            this.btn_GEST_search.TabIndex = 4;
            this.btn_GEST_search.Text = "Chercher";
            this.btn_GEST_search.UseVisualStyleBackColor = false;
            this.btn_GEST_search.Click += new System.EventHandler(this.btn_GEST_search_Click);
            // 
            // btn_CLT_LOAD
            // 
            this.btn_CLT_LOAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CLT_LOAD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_CLT_LOAD.FlatAppearance.BorderSize = 0;
            this.btn_CLT_LOAD.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_CLT_LOAD.ForeColor = System.Drawing.Color.White;
            this.btn_CLT_LOAD.Location = new System.Drawing.Point(663, 156);
            this.btn_CLT_LOAD.Name = "btn_CLT_LOAD";
            this.btn_CLT_LOAD.Size = new System.Drawing.Size(476, 40);
            this.btn_CLT_LOAD.TabIndex = 1;
            this.btn_CLT_LOAD.Text = "Réinitialisation";
            this.btn_CLT_LOAD.UseVisualStyleBackColor = false;
            this.btn_CLT_LOAD.Click += new System.EventHandler(this.btn_CLT_LOAD_Click);
            // 
            // btn_CLT_UPDATE
            // 
            this.btn_CLT_UPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CLT_UPDATE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_CLT_UPDATE.FlatAppearance.BorderSize = 0;
            this.btn_CLT_UPDATE.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_CLT_UPDATE.ForeColor = System.Drawing.Color.White;
            this.btn_CLT_UPDATE.Location = new System.Drawing.Point(663, 196);
            this.btn_CLT_UPDATE.Name = "btn_CLT_UPDATE";
            this.btn_CLT_UPDATE.Size = new System.Drawing.Size(476, 40);
            this.btn_CLT_UPDATE.TabIndex = 2;
            this.btn_CLT_UPDATE.Text = "Éditer";
            this.btn_CLT_UPDATE.UseVisualStyleBackColor = false;
            this.btn_CLT_UPDATE.Click += new System.EventHandler(this.btn_CLT_UPDATE_Click);
            // 
            // btn_GEST_DROP
            // 
            this.btn_GEST_DROP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_GEST_DROP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_GEST_DROP.FlatAppearance.BorderSize = 0;
            this.btn_GEST_DROP.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_GEST_DROP.ForeColor = System.Drawing.Color.White;
            this.btn_GEST_DROP.Location = new System.Drawing.Point(663, 236);
            this.btn_GEST_DROP.Name = "btn_GEST_DROP";
            this.btn_GEST_DROP.Size = new System.Drawing.Size(476, 40);
            this.btn_GEST_DROP.TabIndex = 3;
            this.btn_GEST_DROP.Text = "Effacer";
            this.btn_GEST_DROP.UseVisualStyleBackColor = false;
            this.btn_GEST_DROP.Click += new System.EventHandler(this.btn_GEST_DROP_Click);
            // 
            // cb_client_ID
            // 
            this.cb_client_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_client_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_client_ID.ForeColor = System.Drawing.Color.White;
            this.cb_client_ID.FormattingEnabled = true;
            this.cb_client_ID.Location = new System.Drawing.Point(800, 25);
            this.cb_client_ID.Name = "cb_client_ID";
            this.cb_client_ID.Size = new System.Drawing.Size(273, 21);
            this.cb_client_ID.TabIndex = 25;
            this.cb_client_ID.SelectionChangeCommitted += new System.EventHandler(this.cb_client_ID_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(739, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Client";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 276);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_user_Pays);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_user_ville);
            this.groupBox1.Controls.Add(this.txt_user_Email);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_user_num);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_user_lname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_user_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter Client";
            // 
            // txt_user_Pays
            // 
            this.txt_user_Pays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_Pays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_Pays.ForeColor = System.Drawing.Color.White;
            this.txt_user_Pays.Location = new System.Drawing.Point(276, 170);
            this.txt_user_Pays.Name = "txt_user_Pays";
            this.txt_user_Pays.Size = new System.Drawing.Size(231, 26);
            this.txt_user_Pays.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(85, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Pays :";
            // 
            // txt_user_ville
            // 
            this.txt_user_ville.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_ville.ForeColor = System.Drawing.Color.White;
            this.txt_user_ville.Location = new System.Drawing.Point(276, 201);
            this.txt_user_ville.Name = "txt_user_ville";
            this.txt_user_ville.Size = new System.Drawing.Size(231, 26);
            this.txt_user_ville.TabIndex = 5;
            // 
            // txt_user_Email
            // 
            this.txt_user_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_Email.ForeColor = System.Drawing.Color.White;
            this.txt_user_Email.Location = new System.Drawing.Point(276, 139);
            this.txt_user_Email.Name = "txt_user_Email";
            this.txt_user_Email.Size = new System.Drawing.Size(231, 26);
            this.txt_user_Email.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom :";
            // 
            // txt_user_num
            // 
            this.txt_user_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_num.ForeColor = System.Drawing.Color.White;
            this.txt_user_num.Location = new System.Drawing.Point(276, 108);
            this.txt_user_num.Name = "txt_user_num";
            this.txt_user_num.Size = new System.Drawing.Size(231, 26);
            this.txt_user_num.TabIndex = 2;
            this.txt_user_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_num_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prénom :";
            // 
            // txt_user_lname
            // 
            this.txt_user_lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_lname.ForeColor = System.Drawing.Color.White;
            this.txt_user_lname.Location = new System.Drawing.Point(276, 77);
            this.txt_user_lname.Name = "txt_user_lname";
            this.txt_user_lname.Size = new System.Drawing.Size(231, 26);
            this.txt_user_lname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Téléphone :";
            // 
            // txt_user_name
            // 
            this.txt_user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.ForeColor = System.Drawing.Color.White;
            this.txt_user_name.Location = new System.Drawing.Point(276, 46);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(231, 26);
            this.txt_user_name.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(85, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ville :";
            // 
            // DGV_gestCLT
            // 
            this.DGV_gestCLT.AllowUserToAddRows = false;
            this.DGV_gestCLT.AllowUserToDeleteRows = false;
            this.DGV_gestCLT.AllowUserToResizeColumns = false;
            this.DGV_gestCLT.AllowUserToResizeRows = false;
            this.DGV_gestCLT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_gestCLT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGV_gestCLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_gestCLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_gestCLT.Location = new System.Drawing.Point(0, 276);
            this.DGV_gestCLT.Name = "DGV_gestCLT";
            this.DGV_gestCLT.Size = new System.Drawing.Size(1139, 223);
            this.DGV_gestCLT.TabIndex = 1;
            this.DGV_gestCLT.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGV_gestCLT_MouseDoubleClick);
            // 
            // GestionDesClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1139, 499);
            this.Controls.Add(this.DGV_gestCLT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionDesClient";
            this.Text = "GestionDesClient";
            this.Load += new System.EventHandler(this.GestionDesClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_gestCLT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_user_ville;
        private System.Windows.Forms.TextBox txt_user_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_user_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user_lname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_client_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_srch_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_GEST_search;
        private System.Windows.Forms.Button btn_CLT_LOAD;
        private System.Windows.Forms.Button btn_CLT_UPDATE;
        private System.Windows.Forms.Button btn_GEST_DROP;
        private System.Windows.Forms.DataGridView DGV_gestCLT;
        private System.Windows.Forms.TextBox txt_user_Pays;
        private System.Windows.Forms.Label label8;
    }
}