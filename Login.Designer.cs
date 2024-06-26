
namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label_login_exit = new System.Windows.Forms.Label();
            this.label_login_clear = new System.Windows.Forms.Label();
            this.button_login_login = new System.Windows.Forms.Button();
            this.checkBox_login_show = new System.Windows.Forms.CheckBox();
            this.textBox_login_password = new System.Windows.Forms.TextBox();
            this.label_login_password = new System.Windows.Forms.Label();
            this.textBox_login_username = new System.Windows.Forms.TextBox();
            this.label_login_username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_login_exit
            // 
            this.label_login_exit.AutoSize = true;
            this.label_login_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_login_exit.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_exit.ForeColor = System.Drawing.Color.White;
            this.label_login_exit.Location = new System.Drawing.Point(139, 477);
            this.label_login_exit.Name = "label_login_exit";
            this.label_login_exit.Size = new System.Drawing.Size(68, 22);
            this.label_login_exit.TabIndex = 28;
            this.label_login_exit.Text = "Quitter";
            this.label_login_exit.Click += new System.EventHandler(this.label_login_exit_Click);
            // 
            // label_login_clear
            // 
            this.label_login_clear.AutoSize = true;
            this.label_login_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_login_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label_login_clear.ForeColor = System.Drawing.Color.White;
            this.label_login_clear.Location = new System.Drawing.Point(45, 369);
            this.label_login_clear.Name = "label_login_clear";
            this.label_login_clear.Size = new System.Drawing.Size(78, 16);
            this.label_login_clear.TabIndex = 27;
            this.label_login_clear.Text = "Réinitialiser";
            this.label_login_clear.Click += new System.EventHandler(this.label_login_clear_Click);
            // 
            // button_login_login
            // 
            this.button_login_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_login_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login_login.ForeColor = System.Drawing.Color.White;
            this.button_login_login.Location = new System.Drawing.Point(34, 431);
            this.button_login_login.Name = "button_login_login";
            this.button_login_login.Size = new System.Drawing.Size(279, 34);
            this.button_login_login.TabIndex = 26;
            this.button_login_login.Text = "Se connecter";
            this.button_login_login.UseVisualStyleBackColor = false;
            this.button_login_login.Click += new System.EventHandler(this.button_login_login_Click);
            // 
            // checkBox_login_show
            // 
            this.checkBox_login_show.AutoSize = true;
            this.checkBox_login_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_login_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_login_show.ForeColor = System.Drawing.Color.White;
            this.checkBox_login_show.Location = new System.Drawing.Point(157, 365);
            this.checkBox_login_show.Name = "checkBox_login_show";
            this.checkBox_login_show.Size = new System.Drawing.Size(156, 20);
            this.checkBox_login_show.TabIndex = 25;
            this.checkBox_login_show.Text = "Afficher Mot de passe";
            this.checkBox_login_show.UseVisualStyleBackColor = true;
            this.checkBox_login_show.CheckedChanged += new System.EventHandler(this.checkBox_login_show_CheckedChanged);
            // 
            // textBox_login_password
            // 
            this.textBox_login_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login_password.ForeColor = System.Drawing.Color.White;
            this.textBox_login_password.Location = new System.Drawing.Point(34, 335);
            this.textBox_login_password.Name = "textBox_login_password";
            this.textBox_login_password.Size = new System.Drawing.Size(279, 30);
            this.textBox_login_password.TabIndex = 24;
            this.textBox_login_password.UseSystemPasswordChar = true;
            // 
            // label_login_password
            // 
            this.label_login_password.AutoSize = true;
            this.label_login_password.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_password.ForeColor = System.Drawing.Color.White;
            this.label_login_password.Location = new System.Drawing.Point(44, 310);
            this.label_login_password.Name = "label_login_password";
            this.label_login_password.Size = new System.Drawing.Size(117, 22);
            this.label_login_password.TabIndex = 23;
            this.label_login_password.Text = "Mot de passe";
            // 
            // textBox_login_username
            // 
            this.textBox_login_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login_username.ForeColor = System.Drawing.Color.White;
            this.textBox_login_username.Location = new System.Drawing.Point(34, 257);
            this.textBox_login_username.Name = "textBox_login_username";
            this.textBox_login_username.Size = new System.Drawing.Size(279, 30);
            this.textBox_login_username.TabIndex = 22;
            // 
            // label_login_username
            // 
            this.label_login_username.AutoSize = true;
            this.label_login_username.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_username.ForeColor = System.Drawing.Color.White;
            this.label_login_username.Location = new System.Drawing.Point(44, 232);
            this.label_login_username.Name = "label_login_username";
            this.label_login_username.Size = new System.Drawing.Size(149, 22);
            this.label_login_username.TabIndex = 21;
            this.label_login_username.Text = "Nom d\'utilisateur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 229);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(41, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 1);
            this.panel2.TabIndex = 30;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(347, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_login_exit);
            this.Controls.Add(this.label_login_clear);
            this.Controls.Add(this.button_login_login);
            this.Controls.Add(this.checkBox_login_show);
            this.Controls.Add(this.textBox_login_password);
            this.Controls.Add(this.label_login_password);
            this.Controls.Add(this.textBox_login_username);
            this.Controls.Add(this.label_login_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login_exit;
        private System.Windows.Forms.Label label_login_clear;
        private System.Windows.Forms.Button button_login_login;
        private System.Windows.Forms.CheckBox checkBox_login_show;
        private System.Windows.Forms.TextBox textBox_login_password;
        private System.Windows.Forms.Label label_login_password;
        private System.Windows.Forms.TextBox textBox_login_username;
        private System.Windows.Forms.Label label_login_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}