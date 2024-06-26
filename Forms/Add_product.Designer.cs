
namespace WindowsFormsApp1.Forms
{
    partial class Add_product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_product));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_FOUR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_prix_prod = new System.Windows.Forms.TextBox();
            this.txt_num_qte = new System.Windows.Forms.NumericUpDown();
            this.cb_CAT_Prod = new System.Windows.Forms.ComboBox();
            this.txt_nom_prod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_reset_product = new System.Windows.Forms.Button();
            this.btn_prod_add = new System.Windows.Forms.Button();
            this.DGV_addPROD1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_qte)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_addPROD1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_FOUR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_prix_prod);
            this.groupBox1.Controls.Add(this.txt_num_qte);
            this.groupBox1.Controls.Add(this.cb_CAT_Prod);
            this.groupBox1.Controls.Add(this.txt_nom_prod);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un Nouveau Produit";
            // 
            // TXT_FOUR
            // 
            this.TXT_FOUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_FOUR.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.TXT_FOUR.ForeColor = System.Drawing.Color.White;
            this.TXT_FOUR.Location = new System.Drawing.Point(351, 258);
            this.TXT_FOUR.Name = "TXT_FOUR";
            this.TXT_FOUR.Size = new System.Drawing.Size(300, 34);
            this.TXT_FOUR.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fournisseur :";
            // 
            // txt_prix_prod
            // 
            this.txt_prix_prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_prix_prod.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txt_prix_prod.ForeColor = System.Drawing.Color.White;
            this.txt_prix_prod.Location = new System.Drawing.Point(351, 209);
            this.txt_prix_prod.Name = "txt_prix_prod";
            this.txt_prix_prod.Size = new System.Drawing.Size(300, 34);
            this.txt_prix_prod.TabIndex = 13;
            this.txt_prix_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prix_prod_KeyPress);
            // 
            // txt_num_qte
            // 
            this.txt_num_qte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_num_qte.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txt_num_qte.ForeColor = System.Drawing.Color.White;
            this.txt_num_qte.Location = new System.Drawing.Point(351, 161);
            this.txt_num_qte.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txt_num_qte.Name = "txt_num_qte";
            this.txt_num_qte.Size = new System.Drawing.Size(300, 34);
            this.txt_num_qte.TabIndex = 12;
            // 
            // cb_CAT_Prod
            // 
            this.cb_CAT_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_CAT_Prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CAT_Prod.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.cb_CAT_Prod.ForeColor = System.Drawing.Color.White;
            this.cb_CAT_Prod.FormattingEnabled = true;
            this.cb_CAT_Prod.Location = new System.Drawing.Point(351, 63);
            this.cb_CAT_Prod.Name = "cb_CAT_Prod";
            this.cb_CAT_Prod.Size = new System.Drawing.Size(300, 36);
            this.cb_CAT_Prod.TabIndex = 10;
            // 
            // txt_nom_prod
            // 
            this.txt_nom_prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nom_prod.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txt_nom_prod.ForeColor = System.Drawing.Color.White;
            this.txt_nom_prod.Location = new System.Drawing.Point(351, 113);
            this.txt_nom_prod.Name = "txt_nom_prod";
            this.txt_nom_prod.Size = new System.Drawing.Size(300, 34);
            this.txt_nom_prod.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Prix du Produit :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Catégorie Produit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom du Produit :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantité Stockée :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 398);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_reset_product);
            this.panel2.Controls.Add(this.btn_prod_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(816, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 398);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_reset_product
            // 
            this.btn_reset_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_reset_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reset_product.FlatAppearance.BorderSize = 0;
            this.btn_reset_product.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_reset_product.ForeColor = System.Drawing.Color.White;
            this.btn_reset_product.Location = new System.Drawing.Point(0, 63);
            this.btn_reset_product.Name = "btn_reset_product";
            this.btn_reset_product.Size = new System.Drawing.Size(323, 63);
            this.btn_reset_product.TabIndex = 8;
            this.btn_reset_product.Text = "Réinitialiser";
            this.btn_reset_product.UseVisualStyleBackColor = false;
            this.btn_reset_product.Click += new System.EventHandler(this.btn_reset_product_Click);
            // 
            // btn_prod_add
            // 
            this.btn_prod_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_prod_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_prod_add.FlatAppearance.BorderSize = 0;
            this.btn_prod_add.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_prod_add.ForeColor = System.Drawing.Color.White;
            this.btn_prod_add.Location = new System.Drawing.Point(0, 0);
            this.btn_prod_add.Name = "btn_prod_add";
            this.btn_prod_add.Size = new System.Drawing.Size(323, 63);
            this.btn_prod_add.TabIndex = 7;
            this.btn_prod_add.Text = "Ajouter";
            this.btn_prod_add.UseVisualStyleBackColor = false;
            this.btn_prod_add.Click += new System.EventHandler(this.btn_prod_add_Click);
            // 
            // DGV_addPROD1
            // 
            this.DGV_addPROD1.AllowUserToAddRows = false;
            this.DGV_addPROD1.AllowUserToDeleteRows = false;
            this.DGV_addPROD1.AllowUserToResizeColumns = false;
            this.DGV_addPROD1.AllowUserToResizeRows = false;
            this.DGV_addPROD1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_addPROD1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGV_addPROD1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_addPROD1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_addPROD1.Location = new System.Drawing.Point(0, 398);
            this.DGV_addPROD1.Name = "DGV_addPROD1";
            this.DGV_addPROD1.Size = new System.Drawing.Size(1139, 178);
            this.DGV_addPROD1.TabIndex = 9;
            // 
            // Add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 576);
            this.Controls.Add(this.DGV_addPROD1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_product";
            this.Text = "Add_product";
            this.Load += new System.EventHandler(this.Add_product_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_qte)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_addPROD1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_prix_prod;
        private System.Windows.Forms.NumericUpDown txt_num_qte;
        private System.Windows.Forms.ComboBox cb_CAT_Prod;
        private System.Windows.Forms.TextBox txt_nom_prod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_reset_product;
        private System.Windows.Forms.Button btn_prod_add;
        private System.Windows.Forms.DataGridView DGV_addPROD1;
        private System.Windows.Forms.TextBox TXT_FOUR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}