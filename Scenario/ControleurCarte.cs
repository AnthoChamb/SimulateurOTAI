using System.Windows.Forms;

namespace OTAI.Scenario {
    /// <summary>Classe responsable de la sélection d'une position sur la carte</summary>
    public static class ControleurCarte {
        /// <summary>Sélectionne une position sur la carte</summary>
        /// <returns>Retourne la position sélectionnée sur la carte ou <c>null</c> si le formulaire est fermé avant</returns>
        public static Position? SelectionnerPosition() {
            FormCarte carte = new FormCarte();
            if (carte.ShowDialog() == DialogResult.OK)
                return new Position(carte.Position, carte.Taille);
            return null;
        }
    }
}
