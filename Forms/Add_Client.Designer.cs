
namespace WindowsFormsApp1.Forms
{
    partial class Add_Client
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_user_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_user_ville = new System.Windows.Forms.TextBox();
            this.txt_user_Pays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user_lname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGV_ADDCLT = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_Client_Reset = new System.Windows.Forms.Button();
            this.btn_Client_ADD = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_ADRESSE = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ADDCLT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 499);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_ADRESSE);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_user_Email);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_user_ville);
            this.groupBox1.Controls.Add(this.txt_user_Pays);
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
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter Client";
            // 
            // txt_user_Email
            // 
            this.txt_user_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_Email.ForeColor = System.Drawing.Color.White;
            this.txt_user_Email.Location = new System.Drawing.Point(382, 234);
            this.txt_user_Email.Name = "txt_user_Email";
            this.txt_user_Email.Size = new System.Drawing.Size(231, 38);
            this.txt_user_Email.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(100, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pays :";
            // 
            // txt_user_ville
            // 
            this.txt_user_ville.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_ville.ForeColor = System.Drawing.Color.White;
            this.txt_user_ville.Location = new System.Drawing.Point(382, 346);
            this.txt_user_ville.Name = "txt_user_ville";
            this.txt_user_ville.Size = new System.Drawing.Size(231, 38);
            this.txt_user_ville.TabIndex = 10;
            // 
            // txt_user_Pays
            // 
            this.txt_user_Pays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_Pays.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_Pays.ForeColor = System.Drawing.Color.White;
            this.txt_user_Pays.Location = new System.Drawing.Point(382, 290);
            this.txt_user_Pays.Name = "txt_user_Pays";
            this.txt_user_Pays.Size = new System.Drawing.Size(231, 38);
            this.txt_user_Pays.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom :";
            // 
            // txt_user_num
            // 
            this.txt_user_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_num.ForeColor = System.Drawing.Color.White;
            this.txt_user_num.Location = new System.Drawing.Point(382, 178);
            this.txt_user_num.Name = "txt_user_num";
            this.txt_user_num.Size = new System.Drawing.Size(231, 38);
            this.txt_user_num.TabIndex = 8;
            this.txt_user_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_num_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prénom :";
            // 
            // txt_user_lname
            // 
            this.txt_user_lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_lname.ForeColor = System.Drawing.Color.White;
            this.txt_user_lname.Location = new System.Drawing.Point(382, 122);
            this.txt_user_lname.Name = "txt_user_lname";
            this.txt_user_lname.Size = new System.Drawing.Size(231, 38);
            this.txt_user_lname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(100, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Téléphone :";
            // 
            // txt_user_name
            // 
            this.txt_user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.ForeColor = System.Drawing.Color.White;
            this.txt_user_name.Location = new System.Drawing.Point(382, 66);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(231, 38);
            this.txt_user_name.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(100, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ville :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_load);
            this.panel2.Controls.Add(this.btn_Client_Reset);
            this.panel2.Controls.Add(this.btn_Client_ADD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(733, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 499);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGV_ADDCLT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 250);
            this.panel3.TabIndex = 6;
            // 
            // DGV_ADDCLT
            // 
            this.DGV_ADDCLT.AllowUserToAddRows = false;
            this.DGV_ADDCLT.AllowUserToDeleteRows = false;
            this.DGV_ADDCLT.AllowUserToResizeColumns = false;
            this.DGV_ADDCLT.AllowUserToResizeRows = false;
            this.DGV_ADDCLT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ADDCLT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGV_ADDCLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ADDCLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_ADDCLT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGV_ADDCLT.Location = new System.Drawing.Point(0, 0);
            this.DGV_ADDCLT.Name = "DGV_ADDCLT";
            this.DGV_ADDCLT.Size = new System.Drawing.Size(406, 250);
            this.DGV_ADDCLT.TabIndex = 4;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_load.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_load.FlatAppearance.BorderSize = 0;
            this.btn_load.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(0, 166);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(406, 83);
            this.btn_load.TabIndex = 5;
            this.btn_load.Text = "Charger";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_Client_Reset
            // 
            this.btn_Client_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Client_Reset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Client_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Client_Reset.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Client_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Client_Reset.Location = new System.Drawing.Point(0, 83);
            this.btn_Client_Reset.Name = "btn_Client_Reset";
            this.btn_Client_Reset.Size = new System.Drawing.Size(406, 83);
            this.btn_Client_Reset.TabIndex = 3;
            this.btn_Client_Reset.Text = "Réinitialiser";
            this.btn_Client_Reset.UseVisualStyleBackColor = false;
            this.btn_Client_Reset.Click += new System.EventHandler(this.btn_Client_Reset_Click);
            // 
            // btn_Client_ADD
            // 
            this.btn_Client_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Client_ADD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Client_ADD.FlatAppearance.BorderSize = 0;
            this.btn_Client_ADD.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Client_ADD.ForeColor = System.Drawing.Color.White;
            this.btn_Client_ADD.Location = new System.Drawing.Point(0, 0);
            this.btn_Client_ADD.Name = "btn_Client_ADD";
            this.btn_Client_ADD.Size = new System.Drawing.Size(406, 83);
            this.btn_Client_ADD.TabIndex = 2;
            this.btn_Client_ADD.Text = "Ajouter";
            this.btn_Client_ADD.UseVisualStyleBackColor = false;
            this.btn_Client_ADD.Click += new System.EventHandler(this.btn_Client_ADD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(100, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adresse :";
            // 
            // TXT_ADRESSE
            // 
            this.TXT_ADRESSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_ADRESSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ADRESSE.ForeColor = System.Drawing.Color.White;
            this.TXT_ADRESSE.Location = new System.Drawing.Point(382, 396);
            this.TXT_ADRESSE.Multiline = true;
            this.TXT_ADRESSE.Name = "TXT_ADRESSE";
            this.TXT_ADRESSE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_ADRESSE.Size = new System.Drawing.Size(231, 63);
            this.TXT_ADRESSE.TabIndex = 14;
            // 
            // Add_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1139, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Client";
            this.Text = "Add_Client";
            this.Load += new System.EventHandler(this.Add_Client_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ADDCLT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_user_ville;
        private System.Windows.Forms.TextBox txt_user_Pays;
        private System.Windows.Forms.TextBox txt_user_num;
        private System.Windows.Forms.TextBox txt_user_lname;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV_ADDCLT;
        private System.Windows.Forms.Button btn_Client_Reset;
        private System.Windows.Forms.Button btn_Client_ADD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_user_Email;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TXT_ADRESSE;
        private System.Windows.Forms.Label label7;
    }
}