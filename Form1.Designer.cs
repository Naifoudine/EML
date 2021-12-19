namespace EML
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_chemin = new System.Windows.Forms.Label();
            this.txt_chemin = new System.Windows.Forms.TextBox();
            this.lbl_objet = new System.Windows.Forms.Label();
            this.txt_objet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_Img = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_Audio = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_Application = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_chemin
            // 
            this.lbl_chemin.AutoSize = true;
            this.lbl_chemin.Location = new System.Drawing.Point(13, 42);
            this.lbl_chemin.Name = "lbl_chemin";
            this.lbl_chemin.Size = new System.Drawing.Size(139, 16);
            this.lbl_chemin.TabIndex = 0;
            this.lbl_chemin.Text = "Choisir un fichier (.eml)";
            // 
            // txt_chemin
            // 
            this.txt_chemin.Location = new System.Drawing.Point(158, 40);
            this.txt_chemin.Name = "txt_chemin";
            this.txt_chemin.Size = new System.Drawing.Size(505, 22);
            this.txt_chemin.TabIndex = 1;
            // 
            // lbl_objet
            // 
            this.lbl_objet.AutoSize = true;
            this.lbl_objet.Location = new System.Drawing.Point(13, 79);
            this.lbl_objet.Name = "lbl_objet";
            this.lbl_objet.Size = new System.Drawing.Size(100, 16);
            this.lbl_objet.TabIndex = 2;
            this.lbl_objet.Text = "Objet de l\'email";
            // 
            // txt_objet
            // 
            this.txt_objet.Location = new System.Drawing.Point(158, 76);
            this.txt_objet.Name = "txt_objet";
            this.txt_objet.Size = new System.Drawing.Size(505, 22);
            this.txt_objet.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ouvrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(13, 111);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(31, 16);
            this.lbl_from.TabIndex = 6;
            this.lbl_from.Text = "De :";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(13, 142);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(22, 16);
            this.lbl_To.TabIndex = 7;
            this.lbl_To.Text = "A :";
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(158, 109);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(505, 22);
            this.txt_from.TabIndex = 8;
            // 
            // txt_To
            // 
            this.txt_To.Location = new System.Drawing.Point(158, 142);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(505, 22);
            this.txt_To.TabIndex = 9;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Location = new System.Drawing.Point(12, 182);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(64, 16);
            this.lbl_Message.TabIndex = 11;
            this.lbl_Message.Text = "Message";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.aProposToolStripMenuItem.Text = "A Propos";
            // 
            // txt_msg
            // 
            this.txt_msg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_msg.Location = new System.Drawing.Point(6, 6);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.ReadOnly = true;
            this.txt_msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_msg.Size = new System.Drawing.Size(608, 158);
            this.txt_msg.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(148, 197);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 199);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_msg);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(620, 170);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_Img);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(620, 170);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_Img
            // 
            this.txt_Img.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Img.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Img.Location = new System.Drawing.Point(6, 6);
            this.txt_Img.Multiline = true;
            this.txt_Img.Name = "txt_Img";
            this.txt_Img.ReadOnly = true;
            this.txt_Img.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Img.Size = new System.Drawing.Size(608, 158);
            this.txt_Img.TabIndex = 15;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_Audio);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(620, 170);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Audio";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_Audio
            // 
            this.txt_Audio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Audio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Audio.Location = new System.Drawing.Point(6, 6);
            this.txt_Audio.Multiline = true;
            this.txt_Audio.Name = "txt_Audio";
            this.txt_Audio.ReadOnly = true;
            this.txt_Audio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Audio.Size = new System.Drawing.Size(608, 158);
            this.txt_Audio.TabIndex = 16;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_Application);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(620, 170);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Application";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_Application
            // 
            this.txt_Application.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Application.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Application.Location = new System.Drawing.Point(6, 6);
            this.txt_Application.Multiline = true;
            this.txt_Application.Name = "txt_Application";
            this.txt_Application.ReadOnly = true;
            this.txt_Application.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Application.Size = new System.Drawing.Size(608, 158);
            this.txt_Application.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_objet);
            this.Controls.Add(this.lbl_objet);
            this.Controls.Add(this.txt_chemin);
            this.Controls.Add(this.lbl_chemin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_chemin;
        private System.Windows.Forms.TextBox txt_chemin;
        private System.Windows.Forms.Label lbl_objet;
        private System.Windows.Forms.TextBox txt_objet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txt_Img;
        private System.Windows.Forms.TextBox txt_Audio;
        private System.Windows.Forms.TextBox txt_Application;
        //private System.Windows.Forms.FileDialog fileBrowserDialog1;
    }
}

