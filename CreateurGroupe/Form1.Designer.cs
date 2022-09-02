using System.Windows.Forms;

namespace CreateurGroupe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNomEleve = new System.Windows.Forms.Label();
            this.tboxNomEleve = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnImporter = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.lblNbGroupe = new System.Windows.Forms.Label();
            this.udNbGroupe = new System.Windows.Forms.NumericUpDown();
            this.btnRegGroupe = new System.Windows.Forms.Button();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.btnRetirerTout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsboxNomEleve = new System.Windows.Forms.ListBox();
            this.lsBoxGroupe = new System.Windows.Forms.ListBox();
            this.lblListeGroupe = new System.Windows.Forms.Label();
            this.lblListeEleve = new System.Windows.Forms.Label();
            this.btnAide = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udNbGroupe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomEleve
            // 
            resources.ApplyResources(this.lblNomEleve, "lblNomEleve");
            this.lblNomEleve.BackColor = System.Drawing.Color.Transparent;
            this.lblNomEleve.Name = "lblNomEleve";
            // 
            // tboxNomEleve
            // 
            resources.ApplyResources(this.tboxNomEleve, "tboxNomEleve");
            this.tboxNomEleve.Name = "tboxNomEleve";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnAjouter, "btnAjouter");
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnImporter
            // 
            this.btnImporter.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnImporter, "btnImporter");
            this.btnImporter.Name = "btnImporter";
            this.btnImporter.UseVisualStyleBackColor = false;
            this.btnImporter.Click += new System.EventHandler(this.btnImporter_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnSauvegarder, "btnSauvegarder");
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = false;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // lblNbGroupe
            // 
            resources.ApplyResources(this.lblNbGroupe, "lblNbGroupe");
            this.lblNbGroupe.Name = "lblNbGroupe";
            // 
            // udNbGroupe
            // 
            resources.ApplyResources(this.udNbGroupe, "udNbGroupe");
            this.udNbGroupe.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.udNbGroupe.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udNbGroupe.Name = "udNbGroupe";
            this.udNbGroupe.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnRegGroupe
            // 
            this.btnRegGroupe.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnRegGroupe, "btnRegGroupe");
            this.btnRegGroupe.Name = "btnRegGroupe";
            this.btnRegGroupe.UseVisualStyleBackColor = false;
            this.btnRegGroupe.Click += new System.EventHandler(this.BtnRegGroupe_Click);
            // 
            // btnRetirer
            // 
            this.btnRetirer.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnRetirer, "btnRetirer");
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.UseVisualStyleBackColor = false;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            // 
            // btnRetirerTout
            // 
            this.btnRetirerTout.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnRetirerTout, "btnRetirerTout");
            this.btnRetirerTout.Name = "btnRetirerTout";
            this.btnRetirerTout.UseVisualStyleBackColor = false;
            this.btnRetirerTout.Click += new System.EventHandler(this.btnRetirerTout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblNbGroupe);
            this.panel1.Controls.Add(this.btnSauvegarder);
            this.panel1.Controls.Add(this.btnRetirerTout);
            this.panel1.Controls.Add(this.btnImporter);
            this.panel1.Controls.Add(this.lblNomEleve);
            this.panel1.Controls.Add(this.btnRetirer);
            this.panel1.Controls.Add(this.tboxNomEleve);
            this.panel1.Controls.Add(this.btnRegGroupe);
            this.panel1.Controls.Add(this.udNbGroupe);
            this.panel1.Controls.Add(this.btnAjouter);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lsboxNomEleve
            // 
            this.lsboxNomEleve.BackColor = System.Drawing.SystemColors.Info;
            this.lsboxNomEleve.FormattingEnabled = true;
            resources.ApplyResources(this.lsboxNomEleve, "lsboxNomEleve");
            this.lsboxNomEleve.Name = "lsboxNomEleve";
            this.lsboxNomEleve.Sorted = true;
            // 
            // lsBoxGroupe
            // 
            this.lsBoxGroupe.BackColor = System.Drawing.SystemColors.Info;
            this.lsBoxGroupe.FormattingEnabled = true;
            resources.ApplyResources(this.lsBoxGroupe, "lsBoxGroupe");
            this.lsBoxGroupe.Name = "lsBoxGroupe";
            this.lsBoxGroupe.SelectionMode = System.Windows.Forms.SelectionMode.None;
            // 
            // lblListeGroupe
            // 
            this.lblListeGroupe.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblListeGroupe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.lblListeGroupe, "lblListeGroupe");
            this.lblListeGroupe.Name = "lblListeGroupe";
            // 
            // lblListeEleve
            // 
            this.lblListeEleve.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblListeEleve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblListeEleve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.lblListeEleve, "lblListeEleve");
            this.lblListeEleve.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListeEleve.Name = "lblListeEleve";
            // 
            // btnAide
            // 
            resources.ApplyResources(this.btnAide, "btnAide");
            this.btnAide.Name = "btnAide";
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // btnCredits
            // 
            resources.ApplyResources(this.btnCredits, "btnCredits");
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.lblListeEleve);
            this.Controls.Add(this.lblListeGroupe);
            this.Controls.Add(this.lsBoxGroupe);
            this.Controls.Add(this.lsboxNomEleve);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.udNbGroupe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNomEleve;
        private System.Windows.Forms.TextBox tboxNomEleve;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnImporter;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Label lblNbGroupe;
        private System.Windows.Forms.NumericUpDown udNbGroupe;
        private System.Windows.Forms.Button btnRegGroupe;
        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.Button btnRetirerTout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lsboxNomEleve;
        private System.Windows.Forms.ListBox lsBoxGroupe;
        private System.Windows.Forms.Label lblListeGroupe;
        private System.Windows.Forms.Label lblListeEleve;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.Button btnCredits;
    }
}

