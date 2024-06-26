
namespace WindowsFormsApp1.Forms
{
    partial class GESTCategorie
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_CAT_searsh = new System.Windows.Forms.Button();
            this.btn_CAT_delete = new System.Windows.Forms.Button();
            this.btn_CAT_edit = new System.Windows.Forms.Button();
            this.btn_CAT_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_CAT_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_des_CAT = new System.Windows.Forms.TextBox();
            this.txt_nom_cat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_Cate = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 259);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_CAT_searsh);
            this.panel3.Controls.Add(this.btn_CAT_delete);
            this.panel3.Controls.Add(this.btn_CAT_edit);
            this.panel3.Controls.Add(this.btn_CAT_add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(660, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 259);
            this.panel3.TabIndex = 1;
            // 
            // btn_CAT_searsh
            // 
            this.btn_CAT_searsh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CAT_searsh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CAT_searsh.FlatAppearance.BorderSize = 0;
            this.btn_CAT_searsh.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_CAT_searsh.ForeColor = System.Drawing.Color.White;
            this.btn_CAT_searsh.Location = new System.Drawing.Point(0, 150);
            this.btn_CAT_searsh.Name = "btn_CAT_searsh";
            this.btn_CAT_searsh.Size = new System.Drawing.Size(239, 50);
            this.btn_CAT_searsh.TabIndex = 12;
            this.btn_CAT_searsh.Text = "Chercher";
            this.btn_CAT_searsh.UseVisualStyleBackColor = false;
            this.btn_CAT_searsh.Click += new System.EventHandler(this.btn_CAT_searsh_Click);
            // 
            // btn_CAT_delete
            // 
            this.btn_CAT_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CAT_delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CAT_delete.FlatAppearance.BorderSize = 0;
            this.btn_CAT_delete.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_CAT_delete.ForeColor = System.Drawing.Color.White;
            this.btn_CAT_delete.Location = new System.Drawing.Point(0, 100);
            this.btn_CAT_delete.Name = "btn_CAT_delete";
            this.btn_CAT_delete.Size = new System.Drawing.Size(239, 50);
            this.btn_CAT_delete.TabIndex = 11;
            this.btn_CAT_delete.Text = "Effacer";
            this.btn_CAT_delete.UseVisualStyleBackColor = false;
            this.btn_CAT_delete.Click += new System.EventHandler(this.btn_CAT_delete_Click);
            // 
            // btn_CAT_edit
            // 
            this.btn_CAT_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CAT_edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CAT_edit.FlatAppearance.BorderSize = 0;
            this.btn_CAT_edit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_CAT_edit.ForeColor = System.Drawing.Color.White;
            this.btn_CAT_edit.Location = new System.Drawing.Point(0, 50);
            this.btn_CAT_edit.Name = "btn_CAT_edit";
            this.btn_CAT_edit.Size = new System.Drawing.Size(239, 50);
            this.btn_CAT_edit.TabIndex = 10;
            this.btn_CAT_edit.Text = "Éditer";
            this.btn_CAT_edit.UseVisualStyleBackColor = false;
            this.btn_CAT_edit.Click += new System.EventHandler(this.btn_CAT_edit_Click);
            // 
            // btn_CAT_add
            // 
            this.btn_CAT_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CAT_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CAT_add.FlatAppearance.BorderSize = 0;
            this.btn_CAT_add.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_CAT_add.ForeColor = System.Drawing.Color.White;
            this.btn_CAT_add.Location = new System.Drawing.Point(0, 0);
            this.btn_CAT_add.Name = "btn_CAT_add";
            this.btn_CAT_add.Size = new System.Drawing.Size(239, 50);
            this.btn_CAT_add.TabIndex = 9;
            this.btn_CAT_add.Text = "Ajouter";
            this.btn_CAT_add.UseVisualStyleBackColor = false;
            this.btn_CAT_add.Click += new System.EventHandler(this.btn_CAT_add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_CAT_ID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_des_CAT);
            this.panel2.Controls.Add(this.txt_nom_cat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 259);
            this.panel2.TabIndex = 0;
            // 
            // txt_CAT_ID
            // 
            this.txt_CAT_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_CAT_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CAT_ID.ForeColor = System.Drawing.Color.White;
            this.txt_CAT_ID.Location = new System.Drawing.Point(66, 16);
            this.txt_CAT_ID.Name = "txt_CAT_ID";
            this.txt_CAT_ID.Size = new System.Drawing.Size(109, 38);
            this.txt_CAT_ID.TabIndex = 63;
            this.txt_CAT_ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 37);
            this.label1.TabIndex = 62;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // txt_des_CAT
            // 
            this.txt_des_CAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_des_CAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_des_CAT.ForeColor = System.Drawing.Color.White;
            this.txt_des_CAT.Location = new System.Drawing.Point(21, 132);
            this.txt_des_CAT.Multiline = true;
            this.txt_des_CAT.Name = "txt_des_CAT";
            this.txt_des_CAT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_des_CAT.Size = new System.Drawing.Size(615, 118);
            this.txt_des_CAT.TabIndex = 61;
            // 
            // txt_nom_cat
            // 
            this.txt_nom_cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nom_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom_cat.ForeColor = System.Drawing.Color.White;
            this.txt_nom_cat.Location = new System.Drawing.Point(274, 51);
            this.txt_nom_cat.Name = "txt_nom_cat";
            this.txt_nom_cat.Size = new System.Drawing.Size(204, 38);
            this.txt_nom_cat.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom Catégorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descriptions Catégorie";
            // 
            // DGV_Cate
            // 
            this.DGV_Cate.AllowUserToAddRows = false;
            this.DGV_Cate.AllowUserToDeleteRows = false;
            this.DGV_Cate.AllowUserToResizeColumns = false;
            this.DGV_Cate.AllowUserToResizeRows = false;
            this.DGV_Cate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Cate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGV_Cate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Cate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Cate.Location = new System.Drawing.Point(0, 259);
            this.DGV_Cate.Name = "DGV_Cate";
            this.DGV_Cate.Size = new System.Drawing.Size(1123, 201);
            this.DGV_Cate.TabIndex = 1;
            this.DGV_Cate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGV_Cate_MouseDoubleClick);
            // 
            // GESTCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1123, 460);
            this.Controls.Add(this.DGV_Cate);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GESTCategorie";
            this.Text = "AddCategorie";
            this.Load += new System.EventHandler(this.GESTCategorie_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nom_cat;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txt_des_CAT;
        private System.Windows.Forms.Button btn_CAT_delete;
        private System.Windows.Forms.Button btn_CAT_edit;
        private System.Windows.Forms.Button btn_CAT_add;
        private System.Windows.Forms.Button btn_CAT_searsh;
        private System.Windows.Forms.DataGridView DGV_Cate;
        private System.Windows.Forms.TextBox txt_CAT_ID;
        private System.Windows.Forms.Label label1;
    }
}