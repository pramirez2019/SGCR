namespace WindowsFormsAddUser
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.abmconsorcioBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.categBtn = new System.Windows.Forms.Button();
            this.abmBtn = new System.Windows.Forms.Button();
            this.clocklabel = new System.Windows.Forms.Label();
            this.labelclock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE GESTIÓN DE CONSORCIOS RAMIREZ";
            // 
            // abmconsorcioBtn
            // 
            this.abmconsorcioBtn.Location = new System.Drawing.Point(206, 96);
            this.abmconsorcioBtn.Name = "abmconsorcioBtn";
            this.abmconsorcioBtn.Size = new System.Drawing.Size(174, 22);
            this.abmconsorcioBtn.TabIndex = 2;
            this.abmconsorcioBtn.Text = "ABM CONSORCIO";
            this.abmconsorcioBtn.UseVisualStyleBackColor = true;
            this.abmconsorcioBtn.Click += new System.EventHandler(this.abmconsorcioBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.categBtn);
            this.panel2.Controls.Add(this.abmBtn);
            this.panel2.Controls.Add(this.clocklabel);
            this.panel2.Controls.Add(this.labelclock);
            this.panel2.Controls.Add(this.abmconsorcioBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 4;
            // 
            // categBtn
            // 
            this.categBtn.Location = new System.Drawing.Point(206, 171);
            this.categBtn.Name = "categBtn";
            this.categBtn.Size = new System.Drawing.Size(174, 22);
            this.categBtn.TabIndex = 6;
            this.categBtn.Text = "ABM RUBROS CATEGORÍAS";
            this.categBtn.UseVisualStyleBackColor = true;
            this.categBtn.Click += new System.EventHandler(this.CategBtn_Click);
            // 
            // abmBtn
            // 
            this.abmBtn.Location = new System.Drawing.Point(206, 133);
            this.abmBtn.Name = "abmBtn";
            this.abmBtn.Size = new System.Drawing.Size(174, 22);
            this.abmBtn.TabIndex = 5;
            this.abmBtn.Text = "ABM CONSORCISTA";
            this.abmBtn.UseVisualStyleBackColor = true;
            this.abmBtn.Click += new System.EventHandler(this.AbmBtn_Click);
            // 
            // clocklabel
            // 
            this.clocklabel.AutoSize = true;
            this.clocklabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clocklabel.Location = new System.Drawing.Point(504, 99);
            this.clocklabel.Name = "clocklabel";
            this.clocklabel.Size = new System.Drawing.Size(45, 19);
            this.clocklabel.TabIndex = 4;
            this.clocklabel.Text = "label2";
            // 
            // labelclock
            // 
            this.labelclock.AutoSize = true;
            this.labelclock.Location = new System.Drawing.Point(619, 104);
            this.labelclock.Name = "labelclock";
            this.labelclock.Size = new System.Drawing.Size(0, 13);
            this.labelclock.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Home";
            this.Text = "Home";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button abmconsorcioBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelclock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clocklabel;
        private System.Windows.Forms.Button abmBtn;
        private System.Windows.Forms.Button categBtn;
    }
}