using System.Windows.Forms;

namespace OTAI.Scenario {
    public partial class FormScenario : Form {
        #region Données membres

        private ControleurScenario controleur;

        #endregion

        #region Constructeurs

        public FormScenario(ControleurScenario controleur) {
            InitializeComponent();
            this.controleur = controleur;

            ChargerTypesVéhicules();
        }

        #endregion

        #region Méthodes privées

        private void ChargerAeroports() {
            lstAeroports.Items.Clear();
            lstVehicules.Items.Clear();

            string[] aeroports = controleur.ChainesAeroports;
            foreach (string aeroport in aeroports)
                lstAeroports.Items.Add(aeroport);
        }

        private void ChargerVehicules() {
            lstVehicules.Items.Clear();

            if (lstAeroports.SelectedIndex > -1) {
                string[] vehicules = controleur[lstAeroports.SelectedIndex];
                foreach (string vehicule in vehicules)
                    lstVehicules.Items.Add(vehicule);
            }
        }

        private void ChargerTypesVéhicules() {
            cmbVehiculeType.Items.Add("Helicoptère de Secours");
            cmbVehiculeType.Items.Add("Avion Observateur");
            cmbVehiculeType.Items.Add("Avion Passager");
            cmbVehiculeType.Items.Add("Avion Marchandise");
            cmbVehiculeType.Items.Add("Avion Citerne");
        }

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

        #endregion

        #region Méthodes publiques

        #endregion

        private void btnSupprimerAeroport_Click(object sender, System.EventArgs e) {
            if (lstAeroports.SelectedIndex == -1)
                MessageBox.Show("Veuillez sélectionner un aéroport à supprimer.");
            else {
                controleur.SupprimerAeroport(lstAeroports.SelectedIndex);
                ChargerAeroports();
            }
        }

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

        private void itemEnregistrer_Click(object sender, System.EventArgs e) {
            Enregistrer();
        }

        private void Enregistrer() {
            SaveFileDialog enregistrer = new SaveFileDialog {
                Title = "Enregistrer scénario",
                Filter = "Scénario Xml|*.xml"
            };

            if (enregistrer.ShowDialog() == DialogResult.OK) {
                controleur.EnregistrerScenario(enregistrer.FileName);
            }
        }

        private void itemQuitter_Click(object sender, System.EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Voulez vous enregistrer le scénario avant de quitter?", "Quitter", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                Enregistrer();
            }
            Close();
        }

        private void btnAjoutAeroport_Click(object sender, System.EventArgs e) {
            if (txtAeroNom.Text.Length == 0)
                MessageBox.Show("Veuillez entrer un nom d'Aéroport.");
            else if (txtAeroPosition.Text.Length == 0)
                MessageBox.Show("Veuillez choisir la position de l'aéroport.");
            else {
                controleur.AjouterAeroport(txtAeroNom.Text, (Position)txtAeroPosition.Tag, (int)numPassagersMin.Value, (int)numPassagersMax.Value, (int)numMarchandiseMin.Value, (int)numMarchandiseMax.Value);
                ChargerAeroports();
                RestaurerValeurs();
            }
        }

        private void btnAjoutVehicule_Click(object sender, System.EventArgs e) {
            if(lstAeroports.SelectedIndex == -1) {
                MessageBox.Show("Veuillez choisir dans quel aéoroport vous désirez ajouter le véhicule.");
            }
            else if(cmbVehiculeType.SelectedIndex == -1)
                MessageBox.Show("Veuillez choisir un type de véhicule.");
            else if(txtVehiculeNom.Text.Length == 0)
                MessageBox.Show("Veuillez entrer un nom de véhicule.");
            else {
                controleur.AjouterVehicule(lstAeroports.SelectedIndex, (TypeVehicule)cmbVehiculeType.SelectedIndex, txtVehiculeNom.Text, (int)numVitesse.Value, (int)numTempsEmbarquement.Value, (int)numTempsDébarquement.Value, (int)numTempsEntretien.Value, (int)numCapacite.Value);
                ChargerVehicules();
                RestaurerValeurs();
            }
        }

        private void cmbVehiculeType_SelectedIndexChanged(object sender, System.EventArgs e) {
            numTempsEmbarquement.Enabled = cmbVehiculeType.SelectedIndex > 1;
            numTempsDébarquement.Enabled = cmbVehiculeType.SelectedIndex > 1;
            numTempsEntretien.Enabled = cmbVehiculeType.SelectedIndex > 1;
            numCapacite.Enabled = (cmbVehiculeType.SelectedIndex & 2) == 2 && cmbVehiculeType.SelectedIndex > -1;

            
        }

        private void lstAeroports_SelectedIndexChanged(object sender, System.EventArgs e) {
            ChargerVehicules();
        }

        private void btnSupprimerVehicule_Click(object sender, System.EventArgs e) {
            if (lstVehicules.SelectedIndex == -1)
                MessageBox.Show("Veuillez sélectionner un véhicule à supprimer.");
            else {
                controleur.SupprimerVehicule(lstAeroports.SelectedIndex, lstVehicules.SelectedIndex);
                ChargerVehicules();
                //lstVehicules.Items.RemoveAt(lstVehicules.SelectedIndex);
            }
        }

        private void btnAeroPosition_Click(object sender, System.EventArgs e) {
            Position? position = ControleurCarte.SelectionnerPosition();
            if (position != null) {
                txtAeroPosition.Tag = position.Value;
                txtAeroPosition.Text = position.ToString();
            }
        }

        private void numPassagersMin_ValueChanged(object sender, System.EventArgs e) {
            numPassagersMax.Minimum = numPassagersMin.Value;
        }

        private void numPassagersMax_ValueChanged(object sender, System.EventArgs e) {
            numPassagersMin.Maximum = numPassagersMax.Value;
        }

        private void numMarchandiseMin_ValueChanged(object sender, System.EventArgs e) {
            numMarchandiseMax.Minimum = numMarchandiseMin.Value;
        }

        private void numMarchandiseMax_ValueChanged(object sender, System.EventArgs e) {
            numMarchandiseMin.Maximum = numMarchandiseMax.Value;
        }
    }
}
