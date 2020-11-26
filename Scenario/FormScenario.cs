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
        }

        #endregion

        #region Méthodes publiques

        public void MsgCreationAeroportReussie(string nomAeroport) {

        }

        public void MsgManqueInfoAeroport() {

        }

        #endregion
    }
}
