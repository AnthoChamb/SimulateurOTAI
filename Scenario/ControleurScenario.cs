using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAI.Scenario {
    public class ControleurScenario {
        #region Données membres

        private FormScenario interfaceScenario;
        private Scenario scenario;

        #endregion

        #region Constructeurs

        public ControleurScenario() {
            interfaceScenario = new FormScenario(this);
        }

        #endregion

        #region Méthodes publiques

        public void AjouterAeroport(string nom, Position position, int minPassagers, int maxPassagers, int minMarchandise, int maxMarchandise) {
            scenario.AjouterAeroport(nom, position, minPassagers, maxPassagers, minMarchandise, maxMarchandise);
        }

        public void AjouterVehicule(int Aeroport, TypeVehicule typeVehicule, string nom, int vitesse, int? embarquement, int? debarquement, int? entretien, object? capacite) {
            scenario.AjouterVehicule(Aeroport, typeVehicule, nom, vitesse, embarquement, debarquement, entretien, capacite);
        }

        public string SelectionnerPosition() {
            return "";
        }

        public void EnregistrerScenario(string chemin) {

        }

        #endregion

        #region Propriétés publiques


        #endregion

    }
}
