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

        }

        private void ChargerVehicules() {

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

        public void MsgCreationAeroportReussie(string nomAeroport) {

        }

        public void MsgManqueInfoAeroport() {

        }

        #endregion

        private void btnSupprimerAeroport_Click(object sender, System.EventArgs e) {
            
        }

        private void itemCharger_Click(object sender, System.EventArgs e) {

        }

        private void itemEnregistrer_Click(object sender, System.EventArgs e) {

        }

        private void itemQuitter_Click(object sender, System.EventArgs e) {

        }
    }
}
