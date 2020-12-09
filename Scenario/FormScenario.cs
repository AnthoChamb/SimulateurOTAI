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

            string[] vehicules = controleur[lstAeroports.SelectedIndex];
            foreach (string vehicule in vehicules)
                lstVehicules.Items.Add(vehicule);
        }

        private void ChargerTypesVéhicules() {
            cmbVehiculeType.Items.Add("Helicoptère de Secours");
            cmbVehiculeType.Items.Add("Avion Observateur");
            cmbVehiculeType.Items.Add("Avion Citerne");
            cmbVehiculeType.Items.Add("Avion Passager");
            cmbVehiculeType.Items.Add("Avion Marchandise");
        }

        #endregion

        #region Méthodes publiques

        #endregion

        private void btnSupprimerAeroport_Click(object sender, System.EventArgs e) {
            if (lstAeroports.SelectedIndex == -1)
                MessageBox.Show("Veuillez sélectionner un aéroport à supprimer.");
            else {
                lstAeroports.Items.RemoveAt(lstAeroports.SelectedIndex);
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
            OpenFileDialog enregistrer = new OpenFileDialog {
                Title = "Enregistrer scénario",
                Filter = "Scénario Xml|*.xml"
            };

            if (enregistrer.ShowDialog() == DialogResult.OK) {
                controleur.EnregistrerScenario(enregistrer.FileName);
            }
        }

        private void itemQuitter_Click(object sender, System.EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Voulez vous enregistrer le scénario?", "Quitter", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                Enregistrer();
            } else if (dialogResult == DialogResult.No)
                this.Close();
        }

        private void btnAjoutAeroport_Click(object sender, System.EventArgs e) {
            if (txtAeroNom.Text == null)
                MessageBox.Show("Veuillez entrer un nom d'Aéroport.");
            else if (txtAeroPosition.Text == null)
                MessageBox.Show("Veuillez choisir la position de l'aéroport.");
            else {
                Position position = new Position(1,1);
                controleur.AjouterAeroport(txtAeroNom.Text, position, (int)numPassagersMin.Value, (int)numPassagersMax.Value, (int)numMarchandiseMin.Value, (int)numMarchandiseMax.Value);
                ChargerAeroports();
            }
        }

        private void btnAjoutVehicule_Click(object sender, System.EventArgs e) {
            if(lstAeroports.SelectedIndex == -1) {
                MessageBox.Show("Veuillez choisir dans quel aéoroport vous désirez ajouter le véhicule.");
            }
            else if(cmbVehiculeType.SelectedValue == null)
                MessageBox.Show("Veuillez choisir un type de véhicule.");
            else if(txtVehiculeNom.Text == null)
                MessageBox.Show("Veuillez entrer un nom de véhicule.");
            else {
                switch (cmbVehiculeType.SelectedIndex) {
                    case 0:
                        controleur.AjouterVehicule(lstAeroports.SelectedIndex, TypeVehicule.SECOURS, txtVehiculeNom.Text, (int)numVitesse.Value, null, null, null, null);
                        break;
                    case 1:
                        controleur.AjouterVehicule(lstAeroports.SelectedIndex, TypeVehicule.OBSERVATEUR, txtVehiculeNom.Text, (int)numVitesse.Value, null, null, null, null);
                        break;
                    case 2:
                        controleur.AjouterVehicule(lstAeroports.SelectedIndex, TypeVehicule.CITERNE, txtVehiculeNom.Text, (int)numVitesse.Value, (int)numTempsEmbarquement.Value, (int)numTempsDébarquement.Value, (int)numTempsEntretien.Value, null);
                        break;
                    case 3:
                        controleur.AjouterVehicule(lstAeroports.SelectedIndex, TypeVehicule.PASSAGER, txtVehiculeNom.Text, (int)numVitesse.Value, (int)numTempsEmbarquement.Value, (int)numTempsDébarquement.Value, (int)numTempsEntretien.Value, (int)numCapacite.Value);
                        break;
                    case 4:
                        controleur.AjouterVehicule(lstAeroports.SelectedIndex, TypeVehicule.MARCHANDISE, txtVehiculeNom.Text, (int)numVitesse.Value, (int)numTempsEmbarquement.Value, (int)numTempsDébarquement.Value, (int)numTempsEntretien.Value, (int)numCapacite.Value);
                        break;
                    default:
                        break;
                }
                ChargerVehicules();
            }
        }

        private void cmbVehiculeType_SelectedIndexChanged(object sender, System.EventArgs e) {
            if (cmbVehiculeType.SelectedIndex == 0 || cmbVehiculeType.SelectedIndex == 1) {
                numTempsEmbarquement.Enabled = false;
                numTempsDébarquement.Enabled = false;
                numTempsEntretien.Enabled = false;
                numCapacite.Enabled = false;
            }
            if (cmbVehiculeType.SelectedIndex == 2) {
                numTempsEmbarquement.Enabled = true;
                numTempsDébarquement.Enabled = true;
                numTempsEntretien.Enabled = true;
                numCapacite.Enabled = false;
            }
            if(cmbVehiculeType.SelectedIndex == 3 || cmbVehiculeType.SelectedIndex == 4) {
                numTempsEmbarquement.Enabled = true;
                numTempsDébarquement.Enabled = true;
                numTempsEntretien.Enabled = true;
                numCapacite.Enabled = true;
            }
        }

        private void lstAeroports_SelectedIndexChanged(object sender, System.EventArgs e) {
            ChargerVehicules();
        }

        private void btnSupprimerVehicule_Click(object sender, System.EventArgs e) {
            if (lstVehicules.SelectedIndex == -1)
                MessageBox.Show("Veuillez sélectionner un véhicule à supprimer.");
            else
                lstVehicules.Items.RemoveAt(lstVehicules.SelectedIndex);
        }

        private void btnAeroPosition_Click(object sender, System.EventArgs e) {
        }
    }
}
