using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace OTAI.Scenario {
    public class ControleurScenario {
        #region Données membres

        private FormScenario interfaceScenario;
        private Scenario scenario;

        #endregion

        #region Constructeurs

        public ControleurScenario() {
            interfaceScenario = new FormScenario(this);
            scenario = new Scenario();
        }

        #endregion

        #region Méthodes publiques

        public void AjouterAeroport(string nom, Position position, int minPassagers, int maxPassagers, int minMarchandise, int maxMarchandise) {
            scenario.AjouterAeroport(nom, position, minPassagers, maxPassagers, minMarchandise, maxMarchandise);
        }

        public void AjouterVehicule(int Aeroport, TypeVehicule typeVehicule, string nom, int vitesse, int? embarquement, int? debarquement, int? entretien, object? capacite) {
            scenario.AjouterVehicule(Aeroport, typeVehicule, nom, vitesse, embarquement, debarquement, entretien, capacite);
        }

        public void SupprimerAeroport(int index) {
            scenario.SupprimerAeroport(index);
        }

        public void SupprimerVehicule(int indexAeroport, int indexVehicule) {
            scenario.SupprimerVehicule(indexAeroport, indexVehicule);
        }

        public string SelectionnerPosition() {
            return "";
        }

        public void EnregistrerScenario(string chemin) {
            XmlSerializer serializateur = new XmlSerializer(typeof(Scenario));
            using (StreamWriter ecriture = new StreamWriter(chemin)) {
                serializateur.Serialize(ecriture, scenario);
            }
        }

        public void OuvrirScenario(string chemin) {
            XmlSerializer serializateur = new XmlSerializer(typeof(Scenario));
            using (StreamReader lecteur = new StreamReader(chemin)) {
                scenario = serializateur.Deserialize(lecteur) as Scenario;
            }
        }

        #endregion

        #region Propriétés publiques

        public string[] ChainesAeroports { get => scenario.ChainesAeroports; }

        public string[] this[int i] { get => scenario[i]; }

        #endregion

    }
}
