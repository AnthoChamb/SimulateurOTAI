namespace OTAI.Simulateur {
    partial class FormSimulateur {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
                controleur.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.pictureCarte = new System.Windows.Forms.PictureBox();
            this.trackVitesse = new System.Windows.Forms.TrackBar();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labEcoule = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itemQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.groupVitesse = new System.Windows.Forms.GroupBox();
            this.groupAeroports = new System.Windows.Forms.GroupBox();
            this.lstAeroports = new System.Windows.Forms.ListBox();
            this.groupClients = new System.Windows.Forms.GroupBox();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.groupVehicules = new System.Windows.Forms.GroupBox();
            this.lstVehicules = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVitesse)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupVitesse.SuspendLayout();
            this.groupAeroports.SuspendLayout();
            this.groupClients.SuspendLayout();
            this.groupVehicules.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureCarte
            // 
            this.pictureCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureCarte.BackgroundImage = global::OTAI.Simulateur.Properties.Resources.carte;
            this.pictureCarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureCarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureCarte.InitialImage = null;
            this.pictureCarte.Location = new System.Drawing.Point(12, 308);
            this.pictureCarte.Name = "pictureCarte";
            this.pictureCarte.Size = new System.Drawing.Size(768, 384);
            this.pictureCarte.TabIndex = 0;
            this.pictureCarte.TabStop = false;
            // 
            // trackVitesse
            // 
            this.trackVitesse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackVitesse.LargeChange = 15;
            this.trackVitesse.Location = new System.Drawing.Point(3, 16);
            this.trackVitesse.Maximum = 60;
            this.trackVitesse.Name = "trackVitesse";
            this.trackVitesse.Size = new System.Drawing.Size(762, 42);
            this.trackVitesse.SmallChange = 5;
            this.trackVitesse.TabIndex = 1;
            this.trackVitesse.TickFrequency = 15;
            this.trackVitesse.Value = 30;
            this.trackVitesse.ValueChanged += new System.EventHandler(this.trackVitesse_ValueChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labEcoule});
            this.statusStrip.Location = new System.Drawing.Point(0, 695);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(792, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // labEcoule
            // 
            this.labEcoule.Name = "labEcoule";
            this.labEcoule.Size = new System.Drawing.Size(87, 17);
            this.labEcoule.Text = "00:00:00 écoulé";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFichier});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(792, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFichier
            // 
            this.menuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOuvrir,
            this.itemQuitter});
            this.menuFichier.Name = "menuFichier";
            this.menuFichier.Size = new System.Drawing.Size(54, 20);
            this.menuFichier.Text = "Fichier";
            // 
            // itemOuvrir
            // 
            this.itemOuvrir.Name = "itemOuvrir";
            this.itemOuvrir.Size = new System.Drawing.Size(163, 22);
            this.itemOuvrir.Text = "Ouvrir scénario...";
            this.itemOuvrir.Click += new System.EventHandler(this.itemOuvrir_Click);
            // 
            // itemQuitter
            // 
            this.itemQuitter.Name = "itemQuitter";
            this.itemQuitter.Size = new System.Drawing.Size(163, 22);
            this.itemQuitter.Text = "Quitter";
            this.itemQuitter.Click += new System.EventHandler(this.itemQuitter_Click);
            // 
            // groupVitesse
            // 
            this.groupVitesse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupVitesse.Controls.Add(this.trackVitesse);
            this.groupVitesse.Location = new System.Drawing.Point(12, 28);
            this.groupVitesse.Name = "groupVitesse";
            this.groupVitesse.Size = new System.Drawing.Size(768, 61);
            this.groupVitesse.TabIndex = 4;
            this.groupVitesse.TabStop = false;
            this.groupVitesse.Text = "Vitesse de la simulation";
            // 
            // groupAeroports
            // 
            this.groupAeroports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupAeroports.Controls.Add(this.lstAeroports);
            this.groupAeroports.Location = new System.Drawing.Point(12, 96);
            this.groupAeroports.Name = "groupAeroports";
            this.groupAeroports.Size = new System.Drawing.Size(177, 200);
            this.groupAeroports.TabIndex = 5;
            this.groupAeroports.TabStop = false;
            this.groupAeroports.Text = "Aéroports";
            // 
            // lstAeroports
            // 
            this.lstAeroports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAeroports.FormattingEnabled = true;
            this.lstAeroports.Location = new System.Drawing.Point(3, 16);
            this.lstAeroports.Name = "lstAeroports";
            this.lstAeroports.Size = new System.Drawing.Size(171, 181);
            this.lstAeroports.TabIndex = 0;
            this.lstAeroports.SelectedIndexChanged += new System.EventHandler(this.lstAeroports_SelectedIndexChanged);
            // 
            // groupClients
            // 
            this.groupClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupClients.Controls.Add(this.lstClients);
            this.groupClients.Location = new System.Drawing.Point(195, 96);
            this.groupClients.Name = "groupClients";
            this.groupClients.Size = new System.Drawing.Size(256, 200);
            this.groupClients.TabIndex = 6;
            this.groupClients.TabStop = false;
            this.groupClients.Text = "Clients";
            // 
            // lstClients
            // 
            this.lstClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstClients.FormattingEnabled = true;
            this.lstClients.Location = new System.Drawing.Point(3, 16);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(250, 181);
            this.lstClients.TabIndex = 1;
            // 
            // groupVehicules
            // 
            this.groupVehicules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupVehicules.Controls.Add(this.lstVehicules);
            this.groupVehicules.Location = new System.Drawing.Point(457, 96);
            this.groupVehicules.Name = "groupVehicules";
            this.groupVehicules.Size = new System.Drawing.Size(320, 200);
            this.groupVehicules.TabIndex = 7;
            this.groupVehicules.TabStop = false;
            this.groupVehicules.Text = "Véhicules";
            // 
            // lstVehicules
            // 
            this.lstVehicules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVehicules.FormattingEnabled = true;
            this.lstVehicules.Location = new System.Drawing.Point(3, 16);
            this.lstVehicules.Name = "lstVehicules";
            this.lstVehicules.Size = new System.Drawing.Size(314, 181);
            this.lstVehicules.TabIndex = 1;
            // 
            // FormSimulateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 717);
            this.Controls.Add(this.groupVehicules);
            this.Controls.Add(this.groupClients);
            this.Controls.Add(this.groupAeroports);
            this.Controls.Add(this.groupVitesse);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureCarte);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(808, 756);
            this.Name = "FormSimulateur";
            this.Text = "Simulateur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVitesse)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupVitesse.ResumeLayout(false);
            this.groupVitesse.PerformLayout();
            this.groupAeroports.ResumeLayout(false);
            this.groupClients.ResumeLayout(false);
            this.groupVehicules.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCarte;
        private System.Windows.Forms.TrackBar trackVitesse;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labEcoule;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFichier;
        private System.Windows.Forms.ToolStripMenuItem itemOuvrir;
        private System.Windows.Forms.ToolStripMenuItem itemQuitter;
        private System.Windows.Forms.GroupBox groupVitesse;
        private System.Windows.Forms.GroupBox groupAeroports;
        private System.Windows.Forms.ListBox lstAeroports;
        private System.Windows.Forms.GroupBox groupClients;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.GroupBox groupVehicules;
        private System.Windows.Forms.ListBox lstVehicules;
    }
}

