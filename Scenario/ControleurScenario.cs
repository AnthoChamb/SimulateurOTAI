using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace OTAI.Scenario {
    /// <summary>Classe du contrôleur du programme de gestion de scénarios</summary>
    public class ControleurScenario {
        #region Données membres

        /// <summary>
        /// Formulaire de gestion des scénarios
        /// </summary>
        private FormScenario interfaceScenario;

        /// <summary>
        /// Scénario présentement utilisé
        /// </summary>
        private Scenario scenario;

        #endregion

        #region Constructeurs
        /// <summary>
        /// Création du formulaire de gestion de scénarios
        /// </summary>
        public ControleurScenario() {
            interfaceScenario = new FormScenario(this);
            scenario = new Scenario();
        }

        #endregion

        #region Méthodes publiques

        /// <summary>
        /// Ajoute un aéroport et ses informations au présent scénario
        /// </summary>
        /// <param name="nom">Nom de l'aéroport</param>
        /// <param name="position">Position de l'aéroport</param>
        /// <param name="minPassagers">Nombre minimum de passagers</param>
        /// <param name="maxPassagers">Nombre maximum de passagers</param>
        /// <param name="minMarchandise">Quantité minimum de marchandise</param>
        /// <param name="maxMarchandise">Quantité maximum de marchandise</param>
        public void AjouterAeroport(string nom, Position position, int minPassagers, int maxPassagers, int minMarchandise, int maxMarchandise) {
            scenario.AjouterAeroport(nom, position, minPassagers, maxPassagers, minMarchandise, maxMarchandise);
        }

        /// <summary>
        /// Ajoute un véhicule et ses informations à un aéroport à l'indice spécifié
        /// </summary>
        /// <param name="Aeroport">Indice de l'aéroport</param>
        /// <param name="typeVehicule">Type de véhicule</param>
        /// <param name="nom">Nom du véhicule</param>
        /// <param name="vitesse">Vitesse du véhicule</param>
        /// <param name="embarquement">Temps d'embarquement</param>
        /// <param name="debarquement">Temps de débaquement</param>
        /// <param name="entretien">Temps d'entretien</param>
        /// <param name="capacite">Capacité de clients</param>
        public void AjouterVehicule(int Aeroport, TypeVehicule typeVehicule, string nom, int vitesse, int? embarquement, int? debarquement, int? entretien, int? capacite) {
            scenario.AjouterVehicule(Aeroport, typeVehicule, nom, vitesse, embarquement, debarquement, entretien, capacite);
        }

        /// <summary>
        /// Demande la suppression d'un aéroport à l'indice spécifié
        /// </summary>
        /// <param name="index">Indice de l'aéroport</param>
        public void SupprimerAeroport(int index) {
            scenario.SupprimerAeroport(index);
        }

        /// <summary>
        /// Demande la suppression d'un véhicule à l'indice spécifié d'un aéroport à l'indice spécifié
        /// </summary>
        /// <param name="indexAeroport">Indice de l'aéroport</param>
        /// <param name="indexVehicule">Indice du véhicule</param>
        public void SupprimerVehicule(int indexAeroport, int indexVehicule) {
            scenario.SupprimerVehicule(indexAeroport, indexVehicule);
        }

        /// <summary>
        /// Enregistre le présent scénario dans un fichier xml à l'endroit spécifié
        /// </summary>
        /// <param name="chemin">Chemin du fichier</param>
        public void EnregistrerScenario(string chemin) {
            XmlSerializer serializateur = new XmlSerializer(typeof(Scenario));
            using (StreamWriter ecriture = new StreamWriter(chemin)) {
                serializateur.Serialize(ecriture, scenario);
            }
        }

        /// <summary>
        /// Définit le présent scénario selon les informations du fichier xml spécifié
        /// </summary>
        /// <param name="chemin">Chemin du fichier</param>
        public void OuvrirScenario(string chemin) {
            XmlSerializer serializateur = new XmlSerializer(typeof(Scenario));
            using (StreamReader lecteur = new StreamReader(chemin)) {
                scenario = serializateur.Deserialize(lecteur) as Scenario;
            }
        }

        #endregion

        #region Propriétés publiques

        /// <summary>
        /// Obtient un tableau de chaînes contenant les aéroports et le retourne
        /// </summary>
        public string[] ChainesAeroports { get => scenario.ChainesAeroports; }

        /// <summary>
        /// Obtient un tableau de chaînes contenant les véhicules d'un aéroport et le retourne
        /// </summary>
        /// <param name="i">Index de l'aéroport</param>
        /// <returns>Véhicules</returns>
        public string[] this[int i] { get => scenario[i]; }

        #endregion

    }
}
