namespace WindowsFormsAddUser
{
    partial class ABMCategorias
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
            this.panel_categoria = new System.Windows.Forms.Panel();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.searchCategBtn = new System.Windows.Forms.Button();
            this.altaCategBtn = new System.Windows.Forms.Button();
            this.deletecategBtn = new System.Windows.Forms.Button();
            this.updatecategBtn = new System.Windows.Forms.Button();
            this.descripcategTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.namecategTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idcategTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel_categoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel_categoria
            // 
            this.panel_categoria.Controls.Add(this.cleanBtn);
            this.panel_categoria.Controls.Add(this.searchCategBtn);
            this.panel_categoria.Controls.Add(this.altaCategBtn);
            this.panel_categoria.Controls.Add(this.deletecategBtn);
            this.panel_categoria.Controls.Add(this.updatecategBtn);
            this.panel_categoria.Controls.Add(this.descripcategTxt);
            this.panel_categoria.Controls.Add(this.label3);
            this.panel_categoria.Controls.Add(this.namecategTxt);
            this.panel_categoria.Controls.Add(this.label2);
            this.panel_categoria.Controls.Add(this.idcategTxt);
            this.panel_categoria.Controls.Add(this.label1);
            this.panel_categoria.Controls.Add(this.backBtn);
            this.panel_categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_categoria.Location = new System.Drawing.Point(200, 0);
            this.panel_categoria.Name = "panel_categoria";
            this.panel_categoria.Size = new System.Drawing.Size(600, 450);
            this.panel_categoria.TabIndex = 1;
            // 
            // cleanBtn
            // 
            this.cleanBtn.Location = new System.Drawing.Point(289, 163);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(166, 23);
            this.cleanBtn.TabIndex = 56;
            this.cleanBtn.Text = "CLEAN INFO";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // searchCategBtn
            // 
            this.searchCategBtn.Location = new System.Drawing.Point(289, 125);
            this.searchCategBtn.Name = "searchCategBtn";
            this.searchCategBtn.Size = new System.Drawing.Size(166, 23);
            this.searchCategBtn.TabIndex = 61;
            this.searchCategBtn.Text = "SEARCH CATEGORÍA";
            this.searchCategBtn.UseVisualStyleBackColor = true;
            this.searchCategBtn.Click += new System.EventHandler(this.SearchCategBtn_Click);
            // 
            // altaCategBtn
            // 
            this.altaCategBtn.Location = new System.Drawing.Point(289, 96);
            this.altaCategBtn.Name = "altaCategBtn";
            this.altaCategBtn.Size = new System.Drawing.Size(166, 23);
            this.altaCategBtn.TabIndex = 60;
            this.altaCategBtn.Text = "ADD CATEGORÍA";
            this.altaCategBtn.UseVisualStyleBackColor = true;
            this.altaCategBtn.Click += new System.EventHandler(this.AltaCategBtn_Click);
            // 
            // deletecategBtn
            // 
            this.deletecategBtn.Location = new System.Drawing.Point(289, 236);
            this.deletecategBtn.Name = "deletecategBtn";
            this.deletecategBtn.Size = new System.Drawing.Size(166, 23);
            this.deletecategBtn.TabIndex = 59;
            this.deletecategBtn.Text = "DELETE CATEGORÍA";
            this.deletecategBtn.UseVisualStyleBackColor = true;
            // 
            // updatecategBtn
            // 
            this.updatecategBtn.Location = new System.Drawing.Point(289, 197);
            this.updatecategBtn.Name = "updatecategBtn";
            this.updatecategBtn.Size = new System.Drawing.Size(166, 23);
            this.updatecategBtn.TabIndex = 58;
            this.updatecategBtn.Text = "UPDATE CATEGORÍA";
            this.updatecategBtn.UseVisualStyleBackColor = true;
            this.updatecategBtn.Click += new System.EventHandler(this.UpdatecategBtn_Click);
            // 
            // descripcategTxt
            // 
            this.descripcategTxt.Location = new System.Drawing.Point(19, 239);
            this.descripcategTxt.Name = "descripcategTxt";
            this.descripcategTxt.Size = new System.Drawing.Size(185, 20);
            this.descripcategTxt.TabIndex = 6;
            this.descripcategTxt.TextChanged += new System.EventHandler(this.DescripcategTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripción Categoría";
            // 
            // namecategTxt
            // 
            this.namecategTxt.Location = new System.Drawing.Point(19, 169);
            this.namecategTxt.Name = "namecategTxt";
            this.namecategTxt.Size = new System.Drawing.Size(185, 20);
            this.namecategTxt.TabIndex = 4;
            this.namecategTxt.TextChanged += new System.EventHandler(this.NamecategTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Categoría";
            // 
            // idcategTxt
            // 
            this.idcategTxt.Location = new System.Drawing.Point(19, 99);
            this.idcategTxt.Name = "idcategTxt";
            this.idcategTxt.Size = new System.Drawing.Size(185, 20);
            this.idcategTxt.TabIndex = 2;
            this.idcategTxt.TextChanged += new System.EventHandler(this.IdcategTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Categoría";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(16, 25);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ABMCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel_categoria);
            this.Controls.Add(this.panel1);
            this.Name = "ABMCategorias";
            this.Text = "Categorías Rubros";
            this.panel_categoria.ResumeLayout(false);
            this.panel_categoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_categoria;
        private System.Windows.Forms.TextBox descripcategTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namecategTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idcategTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.Button searchCategBtn;
        private System.Windows.Forms.Button altaCategBtn;
        private System.Windows.Forms.Button deletecategBtn;
        private System.Windows.Forms.Button updatecategBtn;
    }
}