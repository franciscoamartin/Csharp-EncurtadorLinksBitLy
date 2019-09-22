namespace EncurtadorDeLinksBitLy
{
    partial class FrmEncurtador
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrlLonga = new System.Windows.Forms.TextBox();
            this.btnEncurtar = new System.Windows.Forms.Button();
            this.txtURLEncurtada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEncurtarListasDeLinks = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL Longa:";
            // 
            // txtUrlLonga
            // 
            this.txtUrlLonga.Location = new System.Drawing.Point(23, 51);
            this.txtUrlLonga.Name = "txtUrlLonga";
            this.txtUrlLonga.Size = new System.Drawing.Size(733, 22);
            this.txtUrlLonga.TabIndex = 1;
            // 
            // btnEncurtar
            // 
            this.btnEncurtar.Location = new System.Drawing.Point(209, 100);
            this.btnEncurtar.Name = "btnEncurtar";
            this.btnEncurtar.Size = new System.Drawing.Size(367, 41);
            this.btnEncurtar.TabIndex = 2;
            this.btnEncurtar.Text = "Encurtar Link";
            this.btnEncurtar.UseVisualStyleBackColor = true;
            this.btnEncurtar.Click += new System.EventHandler(this.BtnEncurtar_Click_1);
            // 
            // txtURLEncurtada
            // 
            this.txtURLEncurtada.Location = new System.Drawing.Point(23, 167);
            this.txtURLEncurtada.Name = "txtURLEncurtada";
            this.txtURLEncurtada.Size = new System.Drawing.Size(733, 22);
            this.txtURLEncurtada.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL Encurtada:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEncurtar);
            this.groupBox1.Controls.Add(this.txtURLEncurtada);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUrlLonga);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 216);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BitLink Individual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEncurtarListasDeLinks);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BitLinks Coletivos";
            // 
            // btnEncurtarListasDeLinks
            // 
            this.btnEncurtarListasDeLinks.Location = new System.Drawing.Point(260, 21);
            this.btnEncurtarListasDeLinks.Name = "btnEncurtarListasDeLinks";
            this.btnEncurtarListasDeLinks.Size = new System.Drawing.Size(253, 50);
            this.btnEncurtarListasDeLinks.TabIndex = 0;
            this.btnEncurtarListasDeLinks.Text = "Encurtar Links";
            this.btnEncurtarListasDeLinks.UseVisualStyleBackColor = true;
            this.btnEncurtarListasDeLinks.Click += new System.EventHandler(this.BtnEncurtarListasDeLinks_Click_1);
            // 
            // FrmEncurtador
            // 
            this.ClientSize = new System.Drawing.Size(809, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmEncurtador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Encurtador de Links";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrlLonga;
        private System.Windows.Forms.Button btnEncurtar;
        private System.Windows.Forms.TextBox txtURLEncurtada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEncurtarListasDeLinks;
    }
}

