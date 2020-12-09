using System.Drawing;
using System.Windows.Forms;

namespace OTAI.Scenario {
    /// <summary>Formulaire de la sélection d'un position sur la carte</summary>
    public partial class FormCarte : Form {
        private Point position;

        /// <summary>Crée un formulaire de sélection d'un position sur la carte</summary>
        public FormCarte() => InitializeComponent();

        #region Propriétés publiques

        /// <summary>Obtient la position du clic sur la carte</summary>
        public Point Position { get => position; }

        /// <summary>Obtient la taille de la carte du formulaire</summary>
        public Size Taille { get => pictureCarte.Size; }

        #endregion

        /// <summary>Gestionnaire d'événement d'un clic sur la carte</summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="e">Paramètres de l'événement</param>
        private void pictureCarte_MouseClick(object sender, MouseEventArgs e) {
            position = e.Location;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
