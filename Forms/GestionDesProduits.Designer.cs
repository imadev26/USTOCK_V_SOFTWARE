
namespace WindowsFormsApp1.Forms
{
    partial class GestionDesProduits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDesProduits));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_prod_reset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_prod_drop = new System.Windows.Forms.Button();
            this.CB_ID_Prod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXT_FOUR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_NOM_Prod = new System.Windows.Forms.TextBox();
            this.txt_prix_prod = new System.Windows.Forms.TextBox();
            this.txt_num_qte = new System.Windows.Forms.NumericUpDown();
            this.cb_CAT_Prod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_qte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_prod_reset);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_prod_drop);
            this.panel1.Controls.Add(this.CB_ID_Prod);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 298);
            this.panel1.TabIndex = 0;
            // 
            // btn_prod_reset
            // 
            this.btn_prod_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_prod_reset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_prod_reset.FlatAppearance.BorderSize = 0;
            this.btn_prod_reset.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_prod_reset.ForeColor = System.Drawing.Color.White;
            this.btn_prod_reset.Location = new System.Drawing.Point(744, 138);
            this.btn_prod_reset.Name = "btn_prod_reset";
            this.btn_prod_reset.Size = new System.Drawing.Size(395, 40);
            this.btn_prod_reset.TabIndex = 34;
            this.btn_prod_reset.Text = "Réinitialiser";
            this.btn_prod_reset.UseVisualStyleBackColor = false;
            this.btn_prod_reset.Click += new System.EventHandler(this.btn_prod_reset_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(744, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(395, 40);
            this.button3.TabIndex = 33;
            this.button3.Text = "Chercher";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(744, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = "Éditer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_prod_drop
            // 
            this.btn_prod_drop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_prod_drop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_prod_drop.FlatAppearance.BorderSize = 0;
            this.btn_prod_drop.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_prod_drop.ForeColor = System.Drawing.Color.White;
            this.btn_prod_drop.Location = new System.Drawing.Point(744, 258);
            this.btn_prod_drop.Name = "btn_prod_drop";
            this.btn_prod_drop.Size = new System.Drawing.Size(395, 40);
            this.btn_prod_drop.TabIndex = 30;
            this.btn_prod_drop.Text = "Effacer";
            this.btn_prod_drop.UseVisualStyleBackColor = false;
            this.btn_prod_drop.Click += new System.EventHandler(this.btn_prod_add_Click);
            // 
            // CB_ID_Prod
            // 
            this.CB_ID_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CB_ID_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ID_Prod.ForeColor = System.Drawing.Color.White;
            this.CB_ID_Prod.Location = new System.Drawing.Point(948, 33);
            this.CB_ID_Prod.Name = "CB_ID_Prod";
            this.CB_ID_Prod.Size = new System.Drawing.Size(179, 30);
            this.CB_ID_Prod.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(778, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID du Produit :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.TXT_FOUR);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CB_NOM_Prod);
            this.panel2.Controls.Add(this.txt_prix_prod);
            this.panel2.Controls.Add(this.txt_num_qte);
            this.panel2.Controls.Add(this.cb_CAT_Prod);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 298);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TXT_FOUR
            // 
            this.TXT_FOUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_FOUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_FOUR.ForeColor = System.Drawing.Color.White;
            this.TXT_FOUR.Location = new System.Drawing.Point(304, 241);
            this.TXT_FOUR.Name = "TXT_FOUR";
            this.TXT_FOUR.Size = new System.Drawing.Size(207, 30);
            this.TXT_FOUR.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fournisseur :";
            // 
            // CB_NOM_Prod
            // 
            this.CB_NOM_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CB_NOM_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_NOM_Prod.ForeColor = System.Drawing.Color.White;
            this.CB_NOM_Prod.Location = new System.Drawing.Point(304, 33);
            this.CB_NOM_Prod.Name = "CB_NOM_Prod";
            this.CB_NOM_Prod.Size = new System.Drawing.Size(207, 30);
            this.CB_NOM_Prod.TabIndex = 15;
            // 
            // txt_prix_prod
            // 
            this.txt_prix_prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_prix_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix_prod.ForeColor = System.Drawing.Color.White;
            this.txt_prix_prod.Location = new System.Drawing.Point(304, 184);
            this.txt_prix_prod.Name = "txt_prix_prod";
            this.txt_prix_prod.Size = new System.Drawing.Size(207, 30);
            this.txt_prix_prod.TabIndex = 14;
            // 
            // txt_num_qte
            // 
            this.txt_num_qte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_num_qte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_qte.ForeColor = System.Drawing.Color.White;
            this.txt_num_qte.Location = new System.Drawing.Point(304, 137);
            this.txt_num_qte.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txt_num_qte.Name = "txt_num_qte";
            this.txt_num_qte.Size = new System.Drawing.Size(207, 30);
            this.txt_num_qte.TabIndex = 13;
            // 
            // cb_CAT_Prod
            // 
            this.cb_CAT_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_CAT_Prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CAT_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CAT_Prod.ForeColor = System.Drawing.Color.White;
            this.cb_CAT_Prod.FormattingEnabled = true;
            this.cb_CAT_Prod.Location = new System.Drawing.Point(304, 76);
            this.cb_CAT_Prod.Name = "cb_CAT_Prod";
            this.cb_CAT_Prod.Size = new System.Drawing.Size(207, 39);
            this.cb_CAT_Prod.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Prix du Produit :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantité Stockée :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Catégorie Produit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom du Produit :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1139, 201);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(569, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 298);
            this.panel3.TabIndex = 19;
            // 
            // GestionDesProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1139, 499);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionDesProduits";
            this.Text = "GestionDesProduits";
            this.Load += new System.EventHandler(this.GestionDesProduits_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_qte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_CAT_Prod;
        private System.Windows.Forms.NumericUpDown txt_num_qte;
        private System.Windows.Forms.TextBox txt_prix_prod;
        private System.Windows.Forms.TextBox CB_NOM_Prod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CB_ID_Prod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_prod_drop;
        private System.Windows.Forms.Button btn_prod_reset;
        private System.Windows.Forms.TextBox TXT_FOUR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}