
namespace Tirage_Champions
{
    partial class ManageList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageList));
            this.ChampionsAvailable = new System.Windows.Forms.ListBox();
            this.Selected = new System.Windows.Forms.ListBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChampionsAvailable
            // 
            this.ChampionsAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ChampionsAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChampionsAvailable.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChampionsAvailable.ForeColor = System.Drawing.Color.White;
            this.ChampionsAvailable.FormattingEnabled = true;
            this.ChampionsAvailable.ItemHeight = 19;
            this.ChampionsAvailable.Location = new System.Drawing.Point(24, 36);
            this.ChampionsAvailable.Name = "ChampionsAvailable";
            this.ChampionsAvailable.Size = new System.Drawing.Size(120, 325);
            this.ChampionsAvailable.TabIndex = 0;
            // 
            // Selected
            // 
            this.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Selected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Selected.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selected.ForeColor = System.Drawing.Color.White;
            this.Selected.FormattingEnabled = true;
            this.Selected.ItemHeight = 19;
            this.Selected.Location = new System.Drawing.Point(309, 36);
            this.Selected.Name = "Selected";
            this.Selected.Size = new System.Drawing.Size(120, 325);
            this.Selected.TabIndex = 0;
            // 
            // Ajouter
            // 
            this.Ajouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(167, 82);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(120, 23);
            this.Ajouter.TabIndex = 1;
            this.Ajouter.Text = "Ajouter >>>";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supprimer.ForeColor = System.Drawing.Color.White;
            this.Supprimer.Location = new System.Drawing.Point(167, 147);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(120, 23);
            this.Supprimer.TabIndex = 1;
            this.Supprimer.Text = "<<< Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Fermer
            // 
            this.Fermer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fermer.ForeColor = System.Drawing.Color.White;
            this.Fermer.Location = new System.Drawing.Point(167, 415);
            this.Fermer.Name = "Fermer";
            this.Fermer.Size = new System.Drawing.Size(120, 23);
            this.Fermer.TabIndex = 2;
            this.Fermer.Text = "Fermer";
            this.Fermer.UseVisualStyleBackColor = true;
            this.Fermer.Click += new System.EventHandler(this.Fermer_Click);
            // 
            // ManageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.Fermer);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Selected);
            this.Controls.Add(this.ChampionsAvailable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageList";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageList_FormClosing);
            this.Load += new System.EventHandler(this.ManageList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ChampionsAvailable;
        private System.Windows.Forms.ListBox Selected;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Fermer;
    }
}