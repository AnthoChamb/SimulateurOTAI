using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OTAI.Simulateur {
    /// <summary>Classe controleur du simulateur</summary>
    public class ControleurSimulateur {
        #region Données membres

        private readonly FormSimulateur interfaceSimulateur;
        private Scenario scenario;
        private int vitesse;

        #endregion

        /// <summary>Crée un controlleur du simulateur et démarre l'application</summary>
        public ControleurSimulateur() {
            interfaceSimulateur = new FormSimulateur(this);
            scenario = null;
            vitesse = 0;

            Application.Run(interfaceSimulateur);
        }

        #region Propriétés publiques

        /// <summary>Obtient et définit la vitesse de la simulation</summary>
        public int Vitesse { get => vitesse; set => vitesse = value; }

        /// <summary>Obtient les représentations en chaines des aéroports dans la simulation</summary>
        public string[] Aeroports { get => scenario.ChainesAeroports; }

        #endregion

        #region Méthodes publiques

        public void OuvrirScenario(string chemin) {
            XmlSerializer serializateur = new XmlSerializer(typeof(Scenario));
            using (StreamReader lecteur = new StreamReader(chemin)) {
                scenario = serializateur.Deserialize(lecteur) as Scenario;
            }

            // TODO : Démarrer la boucle de simulation
        }

        /// <summary>Obtient les représentations en chaine des véhicules à l'aéroport de l'indice précisé</summary>
        /// <param name="i">Indice de l'aéroport</param>
        /// <returns>Retourne les représentations en chaine des véhicules à l'aéroport de l'indice précisé</returns>
        public string[] Vehicules(int i) => scenario.Vehicules(i);

        /// <summary>Obtient les représentations en chaine des clients en attente à l'aéroport de l'indice précisé</summary>
        /// <param name="i">Indice de l'aéroport</param>
        /// <returns>Retourne les représentations en chaine des clients en attente à l'aéroport de l'indice précisé</returns>
        public string[] Clients(int i) => scenario.Clients(i);

        #endregion

        #region Méthodes privées

        /// <summary>Obtient la couleur associé au type de véhicule reçu en paramètre</summary>
        /// <param name="typeVehicule">Type du véhicule à identifier</param>
        /// <returns>Retourne la couleur associé au type de véhicule reçu en paramètre</returns>
        /// <exception cref="ArgumentException">Le type de véhicule reçu doit correspondre à une couleure</exception>
        private static Color TypeVehiculeCouleur(TypeVehicule typeVehicule) {
            switch (typeVehicule) {
                case TypeVehicule.SECOURS:
                    return Color.Red;
                case TypeVehicule.OBSERVATEUR:
                    return Color.Gray;
                case TypeVehicule.CITERNE:
                    return Color.Yellow;
                case TypeVehicule.PASSAGER:
                    return Color.Green;
                case TypeVehicule.MARCHANDISE:
                    return Color.Blue;
                default:
                    throw new ArgumentException("Type de véhicule inconnu");
            }
        }

        #endregion
    }
}
