namespace OTAI.Scenario {
    partial class FormScenario {
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
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.groupAeroports = new System.Windows.Forms.GroupBox();
            this.btnSupprimerAeroport = new System.Windows.Forms.Button();
            this.lstAeroports = new System.Windows.Forms.ListBox();
            this.groupVehicules = new System.Windows.Forms.GroupBox();
            this.lstVehicules = new System.Windows.Forms.ListBox();
            this.groupAjoutAeroport = new System.Windows.Forms.GroupBox();
            this.btnAjoutAeroport = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.lblAeroMaxMarch = new System.Windows.Forms.Label();
            this.lblAeroMinMarch = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAeroMinPassagers = new System.Windows.Forms.Label();
            this.btnAeroPosition = new System.Windows.Forms.Button();
            this.txtAeroPosition = new System.Windows.Forms.TextBox();
            this.lblAeroPosition = new System.Windows.Forms.Label();
            this.lblAeroNom = new System.Windows.Forms.Label();
            this.txtAeroNom = new System.Windows.Forms.TextBox();
            this.groupAjoutVéhicule = new System.Windows.Forms.GroupBox();
            this.lblVitesse = new System.Windows.Forms.Label();
            this.lblVehiculeNom = new System.Windows.Forms.Label();
            this.lblVehiculeType = new System.Windows.Forms.Label();
            this.cmbVehiculeType = new System.Windows.Forms.ComboBox();
            this.lblTempsEmbarquement = new System.Windows.Forms.Label();
            this.lblTempsDébarquement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCapacité = new System.Windows.Forms.Label();
            this.numVitesse = new System.Windows.Forms.NumericUpDown();
            this.numTempsEmbarquement = new System.Windows.Forms.NumericUpDown();
            this.numTempsDébarquement = new System.Windows.Forms.NumericUpDown();
            this.numTempsEntretien = new System.Windows.Forms.NumericUpDown();
            this.numCapacite = new System.Windows.Forms.NumericUpDown();
            this.txtVehiculeNom = new System.Windows.Forms.TextBox();
            this.btnAjoutVehicule = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCharger = new System.Windows.Forms.ToolStripMenuItem();
            this.itemQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.groupAeroports.SuspendLayout();
            this.groupVehicules.SuspendLayout();
            this.groupAjoutAeroport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupAjoutVéhicule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVitesse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempsEmbarquement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempsDébarquement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempsEntretien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacite)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAeroports
            // 
            this.groupAeroports.Controls.Add(this.btnSupprimerAeroport);
            this.groupAeroports.Controls.Add(this.lstAeroports);
            this.groupAeroports.Location = new System.Drawing.Point(12, 27);
            this.groupAeroports.Name = "groupAeroports";
            this.groupAeroports.Size = new System.Drawing.Size(555, 185);
            this.groupAeroports.TabIndex = 0;
            this.groupAeroports.TabStop = false;
            this.groupAeroports.Text = "Aéroports";
            // 
            // btnSupprimerAeroport
            // 
            this.btnSupprimerAeroport.Location = new System.Drawing.Point(241, 156);
            this.btnSupprimerAeroport.Name = "btnSupprimerAeroport";
            this.btnSupprimerAeroport.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerAeroport.TabIndex = 1;
            this.btnSupprimerAeroport.Text = "Supprimer Aéroport";
            this.btnSupprimerAeroport.UseVisualStyleBackColor = true;
            this.btnSupprimerAeroport.Click += new System.EventHandler(this.btnSupprimerAeroport_Click);
            // 
            // lstAeroports
            // 
            this.lstAeroports.FormattingEnabled = true;
            this.lstAeroports.Location = new System.Drawing.Point(6, 16);
            this.lstAeroports.Name = "lstAeroports";
            this.lstAeroports.Size = new System.Drawing.Size(543, 134);
            this.lstAeroports.TabIndex = 0;
            // 
            // groupVehicules
            // 
            this.groupVehicules.Controls.Add(this.button1);
            this.groupVehicules.Controls.Add(this.lstVehicules);
            this.groupVehicules.Location = new System.Drawing.Point(12, 221);
            this.groupVehicules.Name = "groupVehicules";
            this.groupVehicules.Size = new System.Drawing.Size(555, 270);
            this.groupVehicules.TabIndex = 1;
            this.groupVehicules.TabStop = false;
            this.groupVehicules.Text = "Vehicules";
            // 
            // lstVehicules
            // 
            this.lstVehicules.FormattingEnabled = true;
            this.lstVehicules.Location = new System.Drawing.Point(6, 18);
            this.lstVehicules.Name = "lstVehicules";
            this.lstVehicules.Size = new System.Drawing.Size(543, 212);
            this.lstVehicules.TabIndex = 0;
            // 
            // groupAjoutAeroport
            // 
            this.groupAjoutAeroport.Controls.Add(this.btnAjoutAeroport);
            this.groupAjoutAeroport.Controls.Add(this.numericUpDown3);
            this.groupAjoutAeroport.Controls.Add(this.numericUpDown4);
            this.groupAjoutAeroport.Controls.Add(this.lblAeroMaxMarch);
            this.groupAjoutAeroport.Controls.Add(this.lblAeroMinMarch);
            this.groupAjoutAeroport.Controls.Add(this.numericUpDown2);
            this.groupAjoutAeroport.Controls.Add(this.numericUpDown1);
            this.groupAjoutAeroport.Controls.Add(this.label1);
            this.groupAjoutAeroport.Controls.Add(this.lblAeroMinPassagers);
            this.groupAjoutAeroport.Controls.Add(this.btnAeroPosition);
            this.groupAjoutAeroport.Controls.Add(this.txtAeroPosition);
            this.groupAjoutAeroport.Controls.Add(this.lblAeroPosition);
            this.groupAjoutAeroport.Controls.Add(this.lblAeroNom);
            this.groupAjoutAeroport.Controls.Add(this.txtAeroNom);
            this.groupAjoutAeroport.Location = new System.Drawing.Point(573, 27);
            this.groupAjoutAeroport.Name = "groupAjoutAeroport";
            this.groupAjoutAeroport.Size = new System.Drawing.Size(500, 185);
            this.groupAjoutAeroport.TabIndex = 2;
            this.groupAjoutAeroport.TabStop = false;
            this.groupAjoutAeroport.Text = "Ajouter Aéroport";
            // 
            // btnAjoutAeroport
            // 
            this.btnAjoutAeroport.Location = new System.Drawing.Point(169, 156);
            this.btnAjoutAeroport.Name = "btnAjoutAeroport";
            this.btnAjoutAeroport.Size = new System.Drawing.Size(170, 23);
            this.btnAjoutAeroport.TabIndex = 13;
            this.btnAjoutAeroport.Text = "Ajouter Aéroport";
            this.btnAjoutAeroport.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(300, 116);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown3.TabIndex = 12;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(104, 116);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown4.TabIndex = 11;
            // 
            // lblAeroMaxMarch
            // 
            this.lblAeroMaxMarch.AutoSize = true;
            this.lblAeroMaxMarch.Location = new System.Drawing.Point(203, 118);
            this.lblAeroMaxMarch.Name = "lblAeroMaxMarch";
            this.lblAeroMaxMarch.Size = new System.Drawing.Size(94, 13);
            this.lblAeroMaxMarch.TabIndex = 10;
            this.lblAeroMaxMarch.Text = "Max. Marchandise";
            // 
            // lblAeroMinMarch
            // 
            this.lblAeroMinMarch.AutoSize = true;
            this.lblAeroMinMarch.Location = new System.Drawing.Point(11, 118);
            this.lblAeroMinMarch.Name = "lblAeroMinMarch";
            this.lblAeroMinMarch.Size = new System.Drawing.Size(91, 13);
            this.lblAeroMinMarch.TabIndex = 9;
            this.lblAeroMinMarch.Text = "Min. Marchandise";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(300, 85);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(104, 85);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max. Passagers";
            // 
            // lblAeroMinPassagers
            // 
            this.lblAeroMinPassagers.AutoSize = true;
            this.lblAeroMinPassagers.Location = new System.Drawing.Point(11, 87);
            this.lblAeroMinPassagers.Name = "lblAeroMinPassagers";
            this.lblAeroMinPassagers.Size = new System.Drawing.Size(79, 13);
            this.lblAeroMinPassagers.TabIndex = 5;
            this.lblAeroMinPassagers.Text = "Min. Passagers";
            // 
            // btnAeroPosition
            // 
            this.btnAeroPosition.Location = new System.Drawing.Point(361, 50);
            this.btnAeroPosition.Name = "btnAeroPosition";
            this.btnAeroPosition.Size = new System.Drawing.Size(128, 23);
            this.btnAeroPosition.TabIndex = 4;
            this.btnAeroPosition.Text = "Choisir Position";
            this.btnAeroPosition.UseVisualStyleBackColor = true;
            // 
            // txtAeroPosition
            // 
            this.txtAeroPosition.Location = new System.Drawing.Point(96, 53);
            this.txtAeroPosition.Name = "txtAeroPosition";
            this.txtAeroPosition.ReadOnly = true;
            this.txtAeroPosition.Size = new System.Drawing.Size(259, 20);
            this.txtAeroPosition.TabIndex = 3;
            // 
            // lblAeroPosition
            // 
            this.lblAeroPosition.AutoSize = true;
            this.lblAeroPosition.Location = new System.Drawing.Point(10, 55);
            this.lblAeroPosition.Name = "lblAeroPosition";
            this.lblAeroPosition.Size = new System.Drawing.Size(44, 13);
            this.lblAeroPosition.TabIndex = 2;
            this.lblAeroPosition.Text = "Position";
            // 
            // lblAeroNom
            // 
            this.lblAeroNom.AutoSize = true;
            this.lblAeroNom.Location = new System.Drawing.Point(10, 24);
            this.lblAeroNom.Name = "lblAeroNom";
            this.lblAeroNom.Size = new System.Drawing.Size(29, 13);
            this.lblAeroNom.TabIndex = 1;
            this.lblAeroNom.Text = "Nom";
            // 
            // txtAeroNom
            // 
            this.txtAeroNom.Location = new System.Drawing.Point(96, 21);
            this.txtAeroNom.Name = "txtAeroNom";
            this.txtAeroNom.Size = new System.Drawing.Size(259, 20);
            this.txtAeroNom.TabIndex = 0;
            // 
            // groupAjoutVéhicule
            // 
            this.groupAjoutVéhicule.Controls.Add(this.btnAjoutVehicule);
            this.groupAjoutVéhicule.Controls.Add(this.txtVehiculeNom);
            this.groupAjoutVéhicule.Controls.Add(this.numCapacite);
            this.groupAjoutVéhicule.Controls.Add(this.numTempsEntretien);
            this.groupAjoutVéhicule.Controls.Add(this.numTempsDébarquement);
            this.groupAjoutVéhicule.Controls.Add(this.numTempsEmbarquement);
            this.groupAjoutVéhicule.Controls.Add(this.numVitesse);
            this.groupAjoutVéhicule.Controls.Add(this.lblCapacité);
            this.groupAjoutVéhicule.Controls.Add(this.label2);
            this.groupAjoutVéhicule.Controls.Add(this.lblTempsDébarquement);
            this.groupAjoutVéhicule.Controls.Add(this.lblTempsEmbarquement);
            this.groupAjoutVéhicule.Controls.Add(this.lblVitesse);
            this.groupAjoutVéhicule.Controls.Add(this.lblVehiculeNom);
            this.groupAjoutVéhicule.Controls.Add(this.lblVehiculeType);
            this.groupAjoutVéhicule.Controls.Add(this.cmbVehiculeType);
            this.groupAjoutVéhicule.Location = new System.Drawing.Point(579, 230);
            this.groupAjoutVéhicule.Name = "groupAjoutVéhicule";
            this.groupAjoutVéhicule.Size = new System.Drawing.Size(494, 261);
            this.groupAjoutVéhicule.TabIndex = 3;
            this.groupAjoutVéhicule.TabStop = false;
            this.groupAjoutVéhicule.Text = "Ajouter Véhicule";
            // 
            // lblVitesse
            // 
            this.lblVitesse.AutoSize = true;
            this.lblVitesse.Location = new System.Drawing.Point(21, 104);
            this.lblVitesse.Name = "lblVitesse";
            this.lblVitesse.Size = new System.Drawing.Size(41, 13);
            this.lblVitesse.TabIndex = 3;
            this.lblVitesse.Text = "Vitesse";
            // 
            // lblVehiculeNom
            // 
            this.lblVehiculeNom.AutoSize = true;
            this.lblVehiculeNom.Location = new System.Drawing.Point(19, 69);
            this.lblVehiculeNom.Name = "lblVehiculeNom";
            this.lblVehiculeNom.Size = new System.Drawing.Size(29, 13);
            this.lblVehiculeNom.TabIndex = 2;
            this.lblVehiculeNom.Text = "Nom";
            // 
            // lblVehiculeType
            // 
            this.lblVehiculeType.AutoSize = true;
            this.lblVehiculeType.Location = new System.Drawing.Point(17, 34);
            this.lblVehiculeType.Name = "lblVehiculeType";
            this.lblVehiculeType.Size = new System.Drawing.Size(31, 13);
            this.lblVehiculeType.TabIndex = 1;
            this.lblVehiculeType.Text = "Type";
            // 
            // cmbVehiculeType
            // 
            this.cmbVehiculeType.FormattingEnabled = true;
            this.cmbVehiculeType.Location = new System.Drawing.Point(90, 31);
            this.cmbVehiculeType.Name = "cmbVehiculeType";
            this.cmbVehiculeType.Size = new System.Drawing.Size(261, 21);
            this.cmbVehiculeType.TabIndex = 0;
            // 
            // lblTempsEmbarquement
            // 
            this.lblTempsEmbarquement.AutoSize = true;
            this.lblTempsEmbarquement.Location = new System.Drawing.Point(21, 139);
            this.lblTempsEmbarquement.Name = "lblTempsEmbarquement";
            this.lblTempsEmbarquement.Size = new System.Drawing.Size(113, 13);
            this.lblTempsEmbarquement.TabIndex = 4;
            this.lblTempsEmbarquement.Text = "Temps Embarquement";
            // 
            // lblTempsDébarquement
            // 
            this.lblTempsDébarquement.AutoSize = true;
            this.lblTempsDébarquement.Location = new System.Drawing.Point(239, 139);
            this.lblTempsDébarquement.Name = "lblTempsDébarquement";
            this.lblTempsDébarquement.Size = new System.Drawing.Size(112, 13);
            this.lblTempsDébarquement.TabIndex = 5;
            this.lblTempsDébarquement.Text = "Temps Débarquement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Temps Entretien";
            // 
            // lblCapacité
            // 
            this.lblCapacité.AutoSize = true;
            this.lblCapacité.Location = new System.Drawing.Point(21, 208);
            this.lblCapacité.Name = "lblCapacité";
            this.lblCapacité.Size = new System.Drawing.Size(49, 13);
            this.lblCapacité.TabIndex = 7;
            this.lblCapacité.Text = "Capacité";
            // 
            // numVitesse
            // 
            this.numVitesse.Location = new System.Drawing.Point(90, 102);
            this.numVitesse.Name = "numVitesse";
            this.numVitesse.Size = new System.Drawing.Size(80, 20);
            this.numVitesse.TabIndex = 8;
            // 
            // numTempsEmbarquement
            // 
            this.numTempsEmbarquement.Location = new System.Drawing.Point(140, 137);
            this.numTempsEmbarquement.Name = "numTempsEmbarquement";
            this.numTempsEmbarquement.ReadOnly = true;
            this.numTempsEmbarquement.Size = new System.Drawing.Size(80, 20);
            this.numTempsEmbarquement.TabIndex = 9;
            // 
            // numTempsDébarquement
            // 
            this.numTempsDébarquement.Location = new System.Drawing.Point(357, 137);
            this.numTempsDébarquement.Name = "numTempsDébarquement";
            this.numTempsDébarquement.ReadOnly = true;
            this.numTempsDébarquement.Size = new System.Drawing.Size(80, 20);
            this.numTempsDébarquement.TabIndex = 10;
            // 
            // numTempsEntretien
            // 
            this.numTempsEntretien.Location = new System.Drawing.Point(140, 171);
            this.numTempsEntretien.Name = "numTempsEntretien";
            this.numTempsEntretien.ReadOnly = true;
            this.numTempsEntretien.Size = new System.Drawing.Size(80, 20);
            this.numTempsEntretien.TabIndex = 11;
            // 
            // numCapacite
            // 
            this.numCapacite.Location = new System.Drawing.Point(140, 206);
            this.numCapacite.Name = "numCapacite";
            this.numCapacite.ReadOnly = true;
            this.numCapacite.Size = new System.Drawing.Size(80, 20);
            this.numCapacite.TabIndex = 12;
            // 
            // txtVehiculeNom
            // 
            this.txtVehiculeNom.Location = new System.Drawing.Point(90, 67);
            this.txtVehiculeNom.Name = "txtVehiculeNom";
            this.txtVehiculeNom.Size = new System.Drawing.Size(261, 20);
            this.txtVehiculeNom.TabIndex = 13;
            // 
            // btnAjoutVehicule
            // 
            this.btnAjoutVehicule.Location = new System.Drawing.Point(163, 232);
            this.btnAjoutVehicule.Name = "btnAjoutVehicule";
            this.btnAjoutVehicule.Size = new System.Drawing.Size(170, 23);
            this.btnAjoutVehicule.TabIndex = 14;
            this.btnAjoutVehicule.Text = "Ajouter Véhicule";
            this.btnAjoutVehicule.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Supprimer Aéroport";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFichier});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFichier
            // 
            this.menuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCharger,
            this.itemEnregistrer,
            this.itemQuitter});
            this.menuFichier.Name = "menuFichier";
            this.menuFichier.Size = new System.Drawing.Size(54, 20);
            this.menuFichier.Text = "Fichier";
            // 
            // itemCharger
            // 
            this.itemCharger.Name = "itemCharger";
            this.itemCharger.Size = new System.Drawing.Size(180, 22);
            this.itemCharger.Text = "Charger Scénario...";
            this.itemCharger.Click += new System.EventHandler(this.itemCharger_Click);
            // 
            // itemQuitter
            // 
            this.itemQuitter.Name = "itemQuitter";
            this.itemQuitter.Size = new System.Drawing.Size(180, 22);
            this.itemQuitter.Text = "Quitter";
            this.itemQuitter.Click += new System.EventHandler(this.itemQuitter_Click);
            // 
            // itemEnregistrer
            // 
            this.itemEnregistrer.Name = "itemEnregistrer";
            this.itemEnregistrer.Size = new System.Drawing.Size(180, 22);
            this.itemEnregistrer.Text = "Enregistrer";
            this.itemEnregistrer.Click += new System.EventHandler(this.itemEnregistrer_Click);
            // 
            // FormScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 499);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupAjoutVéhicule);
            this.Controls.Add(this.groupAjoutAeroport);
            this.Controls.Add(this.groupVehicules);
            this.Controls.Add(this.groupAeroports);
            this.Name = "FormScenario";
            this.Text = "Générateur de Scénario";
            this.groupAeroports.ResumeLayout(false);
            this.groupVehicules.ResumeLayout(false);
            this.groupAjoutAeroport.ResumeLayout(false);
            this.groupAjoutAeroport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupAjoutVéhicule.ResumeLayout(false);
            this.groupAjoutVéhicule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVitesse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempsEmbarquement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempsDébarquement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempsEntretien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacite)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAeroports;
        private System.Windows.Forms.ListBox lstAeroports;
        private System.Windows.Forms.GroupBox groupVehicules;
        private System.Windows.Forms.ListBox lstVehicules;
        private System.Windows.Forms.GroupBox groupAjoutAeroport;
        private System.Windows.Forms.Label lblAeroNom;
        private System.Windows.Forms.TextBox txtAeroNom;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAeroMinPassagers;
        private System.Windows.Forms.Button btnAeroPosition;
        private System.Windows.Forms.TextBox txtAeroPosition;
        private System.Windows.Forms.Label lblAeroPosition;
        private System.Windows.Forms.Button btnSupprimerAeroport;
        private System.Windows.Forms.Button btnAjoutAeroport;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label lblAeroMaxMarch;
        private System.Windows.Forms.Label lblAeroMinMarch;
        private System.Windows.Forms.GroupBox groupAjoutVéhicule;
        private System.Windows.Forms.Label lblVitesse;
        private System.Windows.Forms.Label lblVehiculeNom;
        private System.Windows.Forms.Label lblVehiculeType;
        private System.Windows.Forms.ComboBox cmbVehiculeType;
        private System.Windows.Forms.Label lblTempsDébarquement;
        private System.Windows.Forms.Label lblTempsEmbarquement;
        private System.Windows.Forms.Button btnAjoutVehicule;
        private System.Windows.Forms.TextBox txtVehiculeNom;
        private System.Windows.Forms.NumericUpDown numCapacite;
        private System.Windows.Forms.NumericUpDown numTempsEntretien;
        private System.Windows.Forms.NumericUpDown numTempsDébarquement;
        private System.Windows.Forms.NumericUpDown numTempsEmbarquement;
        private System.Windows.Forms.NumericUpDown numVitesse;
        private System.Windows.Forms.Label lblCapacité;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFichier;
        private System.Windows.Forms.ToolStripMenuItem itemCharger;
        private System.Windows.Forms.ToolStripMenuItem itemQuitter;
        private System.Windows.Forms.ToolStripMenuItem itemEnregistrer;
    }
}

