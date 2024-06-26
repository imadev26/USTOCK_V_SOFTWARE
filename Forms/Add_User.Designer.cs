
namespace WindowsFormsApp1.Forms
{
    partial class Add_User
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
            this.btn_prod_Reset = new System.Windows.Forms.Button();
            this.btn_User_add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_prod_Reset);
            this.panel1.Controls.Add(this.btn_User_add);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 499);
            this.panel1.TabIndex = 0;
            // 
            // btn_prod_Reset
            // 
            this.btn_prod_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_prod_Reset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_prod_Reset.FlatAppearance.BorderSize = 0;
            this.btn_prod_Reset.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_prod_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_prod_Reset.Location = new System.Drawing.Point(0, 389);
            this.btn_prod_Reset.Name = "btn_prod_Reset";
            this.btn_prod_Reset.Size = new System.Drawing.Size(559, 55);
            this.btn_prod_Reset.TabIndex = 10;
            this.btn_prod_Reset.Text = "Réinitialiser";
            this.btn_prod_Reset.UseVisualStyleBackColor = false;
            this.btn_prod_Reset.Click += new System.EventHandler(this.btn_prod_Reset_Click);
            // 
            // btn_User_add
            // 
            this.btn_User_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_User_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_User_add.FlatAppearance.BorderSize = 0;
            this.btn_User_add.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_User_add.ForeColor = System.Drawing.Color.White;
            this.btn_User_add.Location = new System.Drawing.Point(0, 444);
            this.btn_User_add.Name = "btn_User_add";
            this.btn_User_add.Size = new System.Drawing.Size(559, 55);
            this.btn_User_add.TabIndex = 9;
            this.btn_User_add.Text = "Ajouter";
            this.btn_User_add.UseVisualStyleBackColor = false;
            this.btn_User_add.Click += new System.EventHandler(this.btn_User_add_Click);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "créer un nouvel utilisateur";
            // 
            // cb_gradation
            // 
            this.cb_gradation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_gradation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gradation.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.cb_gradation.ForeColor = System.Drawing.Color.White;
            this.cb_gradation.FormattingEnabled = true;
            this.cb_gradation.Location = new System.Drawing.Point(259, 249);
            this.cb_gradation.Name = "cb_gradation";
            this.cb_gradation.Size = new System.Drawing.Size(248, 39);
            this.cb_gradation.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 31);
            this.label6.TabIndex = 28;
            this.label6.Text = "Type de gradation :";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(259, 204);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(248, 33);
            this.txt_password.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 31);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email :";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(259, 160);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(248, 33);
            this.txt_username.TabIndex = 25;
            // 
            // txt_user_name
            // 
            this.txt_user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.ForeColor = System.Drawing.Color.White;
            this.txt_user_name.Location = new System.Drawing.Point(259, 36);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(248, 33);
            this.txt_user_name.TabIndex = 20;
            // 
            // txt_user_lname
            // 
            this.txt_user_lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_lname.ForeColor = System.Drawing.Color.White;
            this.txt_user_lname.Location = new System.Drawing.Point(259, 75);
            this.txt_user_lname.Name = "txt_user_lname";
            this.txt_user_lname.Size = new System.Drawing.Size(248, 33);
            this.txt_user_lname.TabIndex = 21;
            // 
            // txt_user_Email
            // 
            this.txt_user_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_Email.ForeColor = System.Drawing.Color.White;
            this.txt_user_Email.Location = new System.Drawing.Point(259, 114);
            this.txt_user_Email.Name = "txt_user_Email";
            this.txt_user_Email.Size = new System.Drawing.Size(248, 33);
            this.txt_user_Email.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nom d\'utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Prénom :";
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.AllowUserToResizeColumns = false;
            this.dgv_users.AllowUserToResizeRows = false;
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_users.Location = new System.Drawing.Point(559, 0);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.Size = new System.Drawing.Size(580, 499);
            this.dgv_users.TabIndex = 1;
            // 
            // Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1139, 499);
            this.Controls.Add(this.dgv_users);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_User";
            this.Text = "Add_User";
            this.Load += new System.EventHandler(this.Add_User_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user_lname;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_user_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_gradation;
        private System.Windows.Forms.Button btn_User_add;
        private System.Windows.Forms.Button btn_prod_Reset;
        private System.Windows.Forms.DataGridView dgv_users;
    }
}