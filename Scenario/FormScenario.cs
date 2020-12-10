using System.Windows.Forms;

namespace OTAI.Scenario {
    /// <summary>Classe du formulaire de gestion de scénario</summary>
    public partial class FormScenario : Form {
        #region Données membres

        /// <summary>Contrôleur de gestion de scénario</summary>
        private ControleurScenario controleur;

        #endregion

        #region Constructeurs

        /// <summary>Création du formulaire de gestion de scénario</summary>
        /// <param name="controleur"></param>
        public FormScenario(ControleurScenario controleur) {
            InitializeComponent();
            this.controleur = controleur;

            ChargerTypesVéhicules();
        }

        #endregion

        #region Méthodes privées

        /// <summary>Remplit la liste d'aéroports et demande la restauration des différents contrôles</summary>
        private void ChargerAeroports() {
            lstAeroports.Items.Clear();
            lstVehicules.Items.Clear();

            string[] aeroports = controleur.ChainesAeroports;
            foreach (string aeroport in aeroports)
                lstAeroports.Items.Add(aeroport);

            RestaurerValeurs();
        }

        /// <summary>Remplit la liste des véhicules et demande la restauration des différents contrôles</summary>
        private void ChargerVehicules() {
            lstVehicules.Items.Clear();

            if (lstAeroports.SelectedIndex > -1) {
                string[] vehicules = controleur[lstAeroports.SelectedIndex];
                foreach (string vehicule in vehicules)
                    lstVehicules.Items.Add(vehicule);
            }

            RestaurerValeurs();
        }

        /// <summary>Remplit le combo box des types de véhicules</summary>
        private void ChargerTypesVéhicules() {
            cmbVehiculeType.Items.Add("Helicoptère de Secours");
            cmbVehiculeType.Items.Add("Avion Observateur");
            cmbVehiculeType.Items.Add("Avion Passager");
            cmbVehiculeType.Items.Add("Avion Marchandise");
            cmbVehiculeType.Items.Add("Avion Citerne");
        }

        /// <summary>Rétablit les valeurs par défaut des différents contrôles du formulaire</summary>
        private void RestaurerValeurs() {
            txtAeroNom.Text = null;
            txtAeroPosition.Text = null;
            txtAeroPosition.Tag = null;
            txtVehiculeNom.Text = null;

            numPassagersMin.Value = 1;
            numPassagersMax.Value = 1;
            numMarchandiseMin.Value = 1;
            numMarchandiseMax.Value = 1;
            numVitesse.Value = 1;
            numTempsEmbarquement.Value = numTempsEmbarquement.Minimum;
            numTempsDébarquement.Value = numTempsDébarquement.Minimum;
            numTempsEntretien.Value = numTempsEntretien.Minimum;
            numCapacite.Value = 1;

            cmbVehiculeType.SelectedIndex = -1;
        }

        /// <summary>Demande dans quel fichier enregistrer le scénario et l'envoie au contrôleur
        /// si le fichier est valide</summary>
        private void Enregistrer() {
            SaveFileDialog enregistrer = new SaveFileDialog {
                Title = "Enregistrer scénario",
                Filter = "Scénario Xml|*.xml"
            };

            if (enregistrer.ShowDialog() == DialogResult.OK) {
                controleur.EnregistrerScenario(enregistrer.FileName);
            }
        }

        #endregion

        #region Méthodes d'évenements

        /// <summary>Demande la suppression de l'aéroport à l'indice sélectionné dans la liste
        /// et demande l'affichage de la liste des véhicules lors d'un clique sur le bouton.</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerAeroport_Click(object sender, System.EventArgs e) {
            if (lstAeroports.SelectedIndex == -1)
                MessageBox.Show("Veuillez sélectionner un aéroport à supprimer.");
            else {
                controleur.SupprimerAeroport(lstAeroports.SelectedIndex);
                ChargerAeroports();
            }
        }

        /// <summary>Demande la sélection du fichier xml contenant un scénario, puis
        /// l'envoie au controleur  et affiche les aéroports dans la liste 
        /// si le fichier est valide</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemCharger_Click(object sender, System.EventArgs e) {
            OpenFileDialog ouvrir = new OpenFileDialog {
                Title = "Ouvrir scénario",
                Filter = "Scénario Xml|*.xml"
            };

            if (ouvrir.ShowDialog() == DialogResult.OK) {
                controleur.OuvrirScenario(ouvrir.FileName);
                ChargerAeroports();
            }
        }

        /// <summary>Demande l'enregistrement lors d'un clique sur l'item</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemEnregistrer_Click(object sender, System.EventArgs e) {
            Enregistrer();
        }

        /// <summary>Demande si on veut sauvegarder, puis ferme le formulaire</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemQuitter_Click(object sender, System.EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Voulez vous enregistrer le scénario avant de quitter?", "Quitter", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                Enregistrer();
            }
            Close();
        }

        /// <summary>Affiche si des informations sont manquantes, si ce n'est pas le cas,
        /// envoie l'aéroport à ajouter au contrôleur et affiche les aéroports dans la liste.</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutAeroport_Click(object sender, System.EventArgs e) {
            if (txtAeroNom.Text.Length == 0)
                MessageBox.Show("Veuillez entrer un nom d'Aéroport.");
            else if (txtAeroPosition.Text.Length == 0)
                MessageBox.Show("Veuillez choisir la position de l'aéroport.");
            else {
                controleur.AjouterAeroport(txtAeroNom.Text, (Position)txtAeroPosition.Tag, (int)numPassagersMin.Value, (int)numPassagersMax.Value, (int)numMarchandiseMin.Value, (int)numMarchandiseMax.Value);
                ChargerAeroports();
            }
        }

        /// <summary>Affiche si des informations sont manquantes, si ce n'est pas le cas,
        /// envoie le véhicule à ajouter au contrôleur et affiche les véhicules dans la liste.</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutVehicule_Click(object sender, System.EventArgs e) {
            if (lstAeroports.SelectedIndex == -1) {
                MessageBox.Show("Veuillez choisir dans quel aéoroport vous désirez ajouter le véhicule.");
            } else if (cmbVehiculeType.SelectedIndex == -1)
                MessageBox.Show("Veuillez choisir un type de véhicule.");
            else if (txtVehiculeNom.Text.Length == 0)
                MessageBox.Show("Veuillez entrer un nom de véhicule.");
            else {
                controleur.AjouterVehicule(lstAeroports.SelectedIndex, (TypeVehicule)cmbVehiculeType.SelectedIndex, txtVehiculeNom.Text, (int)numVitesse.Value, (int)numTempsEmbarquement.Value, (int)numTempsDébarquement.Value, (int)numTempsEntretien.Value, (int)numCapacite.Value);
                ChargerVehicules();
            }
        }

        /// <summary>
        /// Active ou non les différents de contrôles d'ajout de véhicule selon le type de véhicule sélectionné
        /// lorsque la valeur sélectionnéee dans le combo box change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVehiculeType_SelectedIndexChanged(object sender, System.EventArgs e) {
            numTempsEmbarquement.Enabled = cmbVehiculeType.SelectedIndex > 1;
            numTempsDébarquement.Enabled = cmbVehiculeType.SelectedIndex > 1;
            numTempsEntretien.Enabled = cmbVehiculeType.SelectedIndex > 1;
            numCapacite.Enabled = (cmbVehiculeType.SelectedIndex & 2) == 2 && cmbVehiculeType.SelectedIndex > -1;
        }

        /// <summary>Affiche les véhicules de l'aéroport sélectionné dans la liste lorsque
        /// la valeur sélectionnée dans la liste d'aéroports change</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstAeroports_SelectedIndexChanged(object sender, System.EventArgs e) {
            ChargerVehicules();
        }

        /// <summary>
        /// Demande la sélection d'un véhicule si aucun n'est sélectionné dans la liste, si c'est le cas,
        /// envoie au contrôleur le véhicule à supprimer et affiche les véhicules dans la liste lors d'un
        /// clique sur le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerVehicule_Click(object sender, System.EventArgs e) {
            if (lstVehicules.SelectedIndex == -1)
                MessageBox.Show("Veuillez sélectionner un véhicule à supprimer.");
            else {
                controleur.SupprimerVehicule(lstAeroports.SelectedIndex, lstVehicules.SelectedIndex);
                ChargerVehicules();
            }
        }

        /// <summary>
        /// Demande au contrôleur de carte d'afficher le formulaire de sélection de position,
        /// puis affecte la position au text box si elle existe lors d'un clique sur le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAeroPosition_Click(object sender, System.EventArgs e) {
            Position? position = ControleurCarte.SelectionnerPosition();
            if (position != null) {
                txtAeroPosition.Tag = position.Value;
                txtAeroPosition.Text = position.ToString();
            }
        }

        /// <summary>Empêche la valeur minimum du combo box du maximum d'être plus petite
        /// que celle du minimum</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numPassagersMin_ValueChanged(object sender, System.EventArgs e) {
            numPassagersMax.Minimum = numPassagersMin.Value;
        }

        /// <summary>Empêche la valeur maximum du combo box minimum d'être plus grande
        /// que celle du maximum</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numPassagersMax_ValueChanged(object sender, System.EventArgs e) {
            numPassagersMin.Maximum = numPassagersMax.Value;
        }

        /// <summary>Empêche la valeur minimum du combo box du maximum d'être plus petite
        /// que celle du minimum</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numMarchandiseMin_ValueChanged(object sender, System.EventArgs e) {
            numMarchandiseMax.Minimum = numMarchandiseMin.Value;
        }

        /// <summary>Empêche la valeur maximum du combo box minimum d'être plus grande
        /// que celle du maximum</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numMarchandiseMax_ValueChanged(object sender, System.EventArgs e) {
            numMarchandiseMin.Maximum = numMarchandiseMax.Value;
        }

        #endregion
    }
}
