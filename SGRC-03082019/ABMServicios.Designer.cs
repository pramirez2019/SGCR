namespace WindowsFormsAddUser
{
    partial class ABMServicios
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
            this.panel_servicios = new System.Windows.Forms.Panel();
            this.SearchServbtn = new System.Windows.Forms.Button();
            this.CleanBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.delServBtn = new System.Windows.Forms.Button();
            this.nameservicioTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DomServicioTxt = new System.Windows.Forms.TextBox();
            this.uptServBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.altaServBtn = new System.Windows.Forms.Button();
            this.idcategTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailServicioTxt = new System.Windows.Forms.TextBox();
            this.searchCategBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CuitservicioTxt = new System.Windows.Forms.TextBox();
            this.phoneServicioTxt = new System.Windows.Forms.TextBox();
            this.namecategTxt = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel_servicios.SuspendLayout();
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
            // panel_servicios
            // 
            this.panel_servicios.Controls.Add(this.SearchServbtn);
            this.panel_servicios.Controls.Add(this.CleanBtn);
            this.panel_servicios.Controls.Add(this.label10);
            this.panel_servicios.Controls.Add(this.delServBtn);
            this.panel_servicios.Controls.Add(this.nameservicioTxt);
            this.panel_servicios.Controls.Add(this.label6);
            this.panel_servicios.Controls.Add(this.DomServicioTxt);
            this.panel_servicios.Controls.Add(this.uptServBtn);
            this.panel_servicios.Controls.Add(this.label1);
            this.panel_servicios.Controls.Add(this.label5);
            this.panel_servicios.Controls.Add(this.label7);
            this.panel_servicios.Controls.Add(this.altaServBtn);
            this.panel_servicios.Controls.Add(this.idcategTxt);
            this.panel_servicios.Controls.Add(this.label4);
            this.panel_servicios.Controls.Add(this.emailServicioTxt);
            this.panel_servicios.Controls.Add(this.searchCategBtn);
            this.panel_servicios.Controls.Add(this.label2);
            this.panel_servicios.Controls.Add(this.CuitservicioTxt);
            this.panel_servicios.Controls.Add(this.phoneServicioTxt);
            this.panel_servicios.Controls.Add(this.namecategTxt);
            this.panel_servicios.Controls.Add(this.backBtn);
            this.panel_servicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_servicios.Location = new System.Drawing.Point(200, 0);
            this.panel_servicios.Name = "panel_servicios";
            this.panel_servicios.Size = new System.Drawing.Size(600, 450);
            this.panel_servicios.TabIndex = 1;
            // 
            // SearchServbtn
            // 
            this.SearchServbtn.Location = new System.Drawing.Point(298, 131);
            this.SearchServbtn.Name = "SearchServbtn";
            this.SearchServbtn.Size = new System.Drawing.Size(166, 23);
            this.SearchServbtn.TabIndex = 183;
            this.SearchServbtn.Text = "SEARCH SERVICIO";
            this.SearchServbtn.UseVisualStyleBackColor = true;
            this.SearchServbtn.Click += new System.EventHandler(this.SearchServbtn_Click);
            // 
            // CleanBtn
            // 
            this.CleanBtn.Location = new System.Drawing.Point(298, 226);
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.Size = new System.Drawing.Size(166, 23);
            this.CleanBtn.TabIndex = 182;
            this.CleanBtn.Text = "CLEAN INFO";
            this.CleanBtn.UseVisualStyleBackColor = true;
            this.CleanBtn.Click += new System.EventHandler(this.CleanBtn_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 13);
            this.label10.TabIndex = 173;
            this.label10.Text = "Nombre completo del proveedor";
            // 
            // delServBtn
            // 
            this.delServBtn.Location = new System.Drawing.Point(298, 197);
            this.delServBtn.Name = "delServBtn";
            this.delServBtn.Size = new System.Drawing.Size(166, 23);
            this.delServBtn.TabIndex = 181;
            this.delServBtn.Text = "DELETE SERVICIO";
            this.delServBtn.UseVisualStyleBackColor = true;
            this.delServBtn.Click += new System.EventHandler(this.DelServBtn_Click);
            // 
            // nameservicioTxt
            // 
            this.nameservicioTxt.Location = new System.Drawing.Point(28, 176);
            this.nameservicioTxt.Name = "nameservicioTxt";
            this.nameservicioTxt.Size = new System.Drawing.Size(226, 20);
            this.nameservicioTxt.TabIndex = 172;
            this.nameservicioTxt.TextChanged += new System.EventHandler(this.NameservicioTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 170;
            this.label6.Text = "Email";
            // 
            // DomServicioTxt
            // 
            this.DomServicioTxt.Location = new System.Drawing.Point(28, 268);
            this.DomServicioTxt.Name = "DomServicioTxt";
            this.DomServicioTxt.Size = new System.Drawing.Size(226, 20);
            this.DomServicioTxt.TabIndex = 165;
            this.DomServicioTxt.TextChanged += new System.EventHandler(this.DomServicioTxt_TextChanged);
            // 
            // uptServBtn
            // 
            this.uptServBtn.Location = new System.Drawing.Point(298, 160);
            this.uptServBtn.Name = "uptServBtn";
            this.uptServBtn.Size = new System.Drawing.Size(166, 23);
            this.uptServBtn.TabIndex = 180;
            this.uptServBtn.Text = "UPDATE SERVICIO";
            this.uptServBtn.UseVisualStyleBackColor = true;
            this.uptServBtn.Click += new System.EventHandler(this.UptServBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 174;
            this.label1.Text = "ID Categoría";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 169;
            this.label5.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 171;
            this.label7.Text = "Domilicio";
            // 
            // altaServBtn
            // 
            this.altaServBtn.Location = new System.Drawing.Point(298, 102);
            this.altaServBtn.Name = "altaServBtn";
            this.altaServBtn.Size = new System.Drawing.Size(166, 23);
            this.altaServBtn.TabIndex = 179;
            this.altaServBtn.Text = "ADD SERVICIO";
            this.altaServBtn.UseVisualStyleBackColor = true;
            this.altaServBtn.Click += new System.EventHandler(this.AltaServBtn_Click);
            // 
            // idcategTxt
            // 
            this.idcategTxt.Location = new System.Drawing.Point(28, 85);
            this.idcategTxt.Name = "idcategTxt";
            this.idcategTxt.Size = new System.Drawing.Size(226, 20);
            this.idcategTxt.TabIndex = 175;
            this.idcategTxt.TextChanged += new System.EventHandler(this.IdcategTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 168;
            this.label4.Text = "CUIT";
            // 
            // emailServicioTxt
            // 
            this.emailServicioTxt.Location = new System.Drawing.Point(28, 361);
            this.emailServicioTxt.Name = "emailServicioTxt";
            this.emailServicioTxt.Size = new System.Drawing.Size(226, 20);
            this.emailServicioTxt.TabIndex = 167;
            this.emailServicioTxt.TextChanged += new System.EventHandler(this.EmailServicioTxt_TextChanged);
            // 
            // searchCategBtn
            // 
            this.searchCategBtn.Location = new System.Drawing.Point(298, 66);
            this.searchCategBtn.Name = "searchCategBtn";
            this.searchCategBtn.Size = new System.Drawing.Size(166, 23);
            this.searchCategBtn.TabIndex = 178;
            this.searchCategBtn.Text = "SEARCH CATEGORÍA";
            this.searchCategBtn.UseVisualStyleBackColor = true;
            this.searchCategBtn.Click += new System.EventHandler(this.SearchCategBtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 176;
            this.label2.Text = "Nombre Categoría";
            // 
            // CuitservicioTxt
            // 
            this.CuitservicioTxt.Location = new System.Drawing.Point(28, 226);
            this.CuitservicioTxt.Name = "CuitservicioTxt";
            this.CuitservicioTxt.Size = new System.Drawing.Size(226, 20);
            this.CuitservicioTxt.TabIndex = 164;
            this.CuitservicioTxt.TextChanged += new System.EventHandler(this.CuitservicioTxt_TextChanged);
            // 
            // phoneServicioTxt
            // 
            this.phoneServicioTxt.Location = new System.Drawing.Point(28, 315);
            this.phoneServicioTxt.Name = "phoneServicioTxt";
            this.phoneServicioTxt.Size = new System.Drawing.Size(226, 20);
            this.phoneServicioTxt.TabIndex = 166;
            this.phoneServicioTxt.TextChanged += new System.EventHandler(this.PhoneServicioTxt_TextChanged);
            // 
            // namecategTxt
            // 
            this.namecategTxt.Location = new System.Drawing.Point(28, 128);
            this.namecategTxt.Name = "namecategTxt";
            this.namecategTxt.Size = new System.Drawing.Size(226, 20);
            this.namecategTxt.TabIndex = 177;
            this.namecategTxt.TextChanged += new System.EventHandler(this.NamecategTxt_TextChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(28, 23);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(112, 25);
            this.backBtn.TabIndex = 163;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click_1);
            // 
            // ABMServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel_servicios);
            this.Controls.Add(this.panel1);
            this.Name = "ABMServicios";
            this.Text = "ABM Servicios";
            this.panel_servicios.ResumeLayout(false);
            this.panel_servicios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_servicios;
        private System.Windows.Forms.Button CleanBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button delServBtn;
        private System.Windows.Forms.TextBox nameservicioTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DomServicioTxt;
        private System.Windows.Forms.Button uptServBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button altaServBtn;
        private System.Windows.Forms.TextBox idcategTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailServicioTxt;
        private System.Windows.Forms.Button searchCategBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CuitservicioTxt;
        private System.Windows.Forms.TextBox phoneServicioTxt;
        private System.Windows.Forms.TextBox namecategTxt;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button SearchServbtn;
    }
}