
namespace WindowsFormsApp1.Forms
{
    partial class GestionUsers
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
            this.groupesearch = new System.Windows.Forms.GroupBox();
            this.btn_chercher = new System.Windows.Forms.Button();
            this.txt_cherch_user = new System.Windows.Forms.TextBox();
            this.cb_gradation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.txt_user_lname = new System.Windows.Forms.TextBox();
            this.txt_user_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_drope = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_show_chercher = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupesearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 499);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupesearch);
            this.groupBox1.Controls.Add(this.cb_gradation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.txt_user_name);
            this.groupBox1.Controls.Add(this.txt_user_lname);
            this.groupBox1.Controls.Add(this.txt_user_Email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 484);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion des utilisateurs";
            // 
            // groupesearch
            // 
            this.groupesearch.Controls.Add(this.btn_chercher);
            this.groupesearch.Controls.Add(this.txt_cherch_user);
            this.groupesearch.ForeColor = System.Drawing.Color.White;
            this.groupesearch.Location = new System.Drawing.Point(94, 28);
            this.groupesearch.Name = "groupesearch";
            this.groupesearch.Size = new System.Drawing.Size(351, 63);
            this.groupesearch.TabIndex = 30;
            this.groupesearch.TabStop = false;
            this.groupesearch.Text = "Chercher par nom utilisateur";
            this.groupesearch.Visible = false;
            // 
            // btn_chercher
            // 
            this.btn_chercher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_chercher.Location = new System.Drawing.Point(214, 26);
            this.btn_chercher.Name = "btn_chercher";
            this.btn_chercher.Size = new System.Drawing.Size(78, 27);
            this.btn_chercher.TabIndex = 32;
            this.btn_chercher.Text = "Chercher";
            this.btn_chercher.UseVisualStyleBackColor = true;
            this.btn_chercher.Click += new System.EventHandler(this.btn_chercher_Click);
            // 
            // txt_cherch_user
            // 
            this.txt_cherch_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cherch_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cherch_user.ForeColor = System.Drawing.Color.White;
            this.txt_cherch_user.Location = new System.Drawing.Point(41, 26);
            this.txt_cherch_user.Name = "txt_cherch_user";
            this.txt_cherch_user.Size = new System.Drawing.Size(151, 27);
            this.txt_cherch_user.TabIndex = 31;
            // 
            // cb_gradation
            // 
            this.cb_gradation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_gradation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gradation.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.cb_gradation.ForeColor = System.Drawing.Color.White;
            this.cb_gradation.FormattingEnabled = true;
            this.cb_gradation.Location = new System.Drawing.Point(254, 333);
            this.cb_gradation.Name = "cb_gradation";
            this.cb_gradation.Size = new System.Drawing.Size(248, 31);
            this.cb_gradation.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Type de gradation :";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(254, 288);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(248, 27);
            this.txt_password.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email :";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(254, 244);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(248, 27);
            this.txt_username.TabIndex = 25;
            // 
            // txt_user_name
            // 
            this.txt_user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.ForeColor = System.Drawing.Color.White;
            this.txt_user_name.Location = new System.Drawing.Point(254, 120);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.ReadOnly = true;
            this.txt_user_name.Size = new System.Drawing.Size(248, 27);
            this.txt_user_name.TabIndex = 20;
            // 
            // txt_user_lname
            // 
            this.txt_user_lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_lname.ForeColor = System.Drawing.Color.White;
            this.txt_user_lname.Location = new System.Drawing.Point(254, 159);
            this.txt_user_lname.Name = "txt_user_lname";
            this.txt_user_lname.ReadOnly = true;
            this.txt_user_lname.Size = new System.Drawing.Size(248, 27);
            this.txt_user_lname.TabIndex = 21;
            // 
            // txt_user_Email
            // 
            this.txt_user_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_Email.ForeColor = System.Drawing.Color.White;
            this.txt_user_Email.Location = new System.Drawing.Point(254, 198);
            this.txt_user_Email.Name = "txt_user_Email";
            this.txt_user_Email.Size = new System.Drawing.Size(248, 27);
            this.txt_user_Email.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nom d\'utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Prénom :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_drope);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_Reset);
            this.panel2.Controls.Add(this.btn_show_chercher);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(559, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 94);
            this.panel2.TabIndex = 1;
            // 
            // btn_drope
            // 
            this.btn_drope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_drope.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_drope.FlatAppearance.BorderSize = 0;
            this.btn_drope.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btn_drope.ForeColor = System.Drawing.Color.White;
            this.btn_drope.Location = new System.Drawing.Point(431, 0);
            this.btn_drope.Name = "btn_drope";
            this.btn_drope.Size = new System.Drawing.Size(149, 94);
            this.btn_drope.TabIndex = 12;
            this.btn_drope.Text = "Effacer";
            this.btn_drope.UseVisualStyleBackColor = false;
            this.btn_drope.Click += new System.EventHandler(this.btn_drope_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(286, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(145, 94);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Éditer";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Reset.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(145, 0);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(141, 94);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "Réinitialiser";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_show_chercher
            // 
            this.btn_show_chercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_show_chercher.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_show_chercher.FlatAppearance.BorderSize = 0;
            this.btn_show_chercher.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btn_show_chercher.ForeColor = System.Drawing.Color.White;
            this.btn_show_chercher.Location = new System.Drawing.Point(0, 0);
            this.btn_show_chercher.Name = "btn_show_chercher";
            this.btn_show_chercher.Size = new System.Drawing.Size(145, 94);
            this.btn_show_chercher.TabIndex = 9;
            this.btn_show_chercher.Text = "Chercher";
            this.btn_show_chercher.UseVisualStyleBackColor = false;
            this.btn_show_chercher.Click += new System.EventHandler(this.btn_show_chercher_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_Users);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(559, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 405);
            this.panel3.TabIndex = 2;
            // 
            // dgv_Users
            // 
            this.dgv_Users.AllowUserToAddRows = false;
            this.dgv_Users.AllowUserToDeleteRows = false;
            this.dgv_Users.AllowUserToResizeColumns = false;
            this.dgv_Users.AllowUserToResizeRows = false;
            this.dgv_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Users.Location = new System.Drawing.Point(0, 0);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.Size = new System.Drawing.Size(580, 405);
            this.dgv_Users.TabIndex = 0;
            this.dgv_Users.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Users_MouseDoubleClick);
            // 
            // GestionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1139, 499);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionUsers";
            this.Text = "GestionUsers";
            this.Load += new System.EventHandler(this.GestionUsers_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupesearch.ResumeLayout(false);
            this.groupesearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_drope;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_show_chercher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_gradation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.TextBox txt_user_lname;
        private System.Windows.Forms.TextBox txt_user_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.GroupBox groupesearch;
        private System.Windows.Forms.Button btn_chercher;
        private System.Windows.Forms.TextBox txt_cherch_user;
    }
}