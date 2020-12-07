using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OTAI.Simulateur {
    /// <summary>Classe controleur du simulateur</summary>
    public class ControleurSimulateur {
        #region Données membres

        private readonly FormSimulateur interfaceSimulateur;
        private Scenario scenario;
        private readonly BackgroundWorker simulation;
        private int vitesse;

        #endregion

        /// <summary>Crée un controlleur du simulateur et démarre l'application</summary>
        public ControleurSimulateur() {
            interfaceSimulateur = new FormSimulateur(this);

            simulation = new BackgroundWorker {
                WorkerSupportsCancellation = true
            };

            simulation.DoWork += simulation_DoWork;
            simulation.ProgressChanged += simulation_ProgressChanged;

            scenario = null;
            vitesse = 0;

            Application.Run(interfaceSimulateur);
        }

        #region Propriétés publiques

        /// <summary>Obtient et définit la vitesse de la simulation</summary>
        public int Vitesse { get => vitesse; set => vitesse = value; }

        /// <summary>Obtient les représentations en chaines des aéroports dans la simulation</summary>
        public string[] ChainesAeroports { get => scenario.ChainesAeroports; }

        /// <summary>Obtient la position des aéroports dans la simulation</summary>
        public Position[] PositionsAeroports { get => scenario.PositionsAeroports; }

        #endregion

        #region Méthodes publiques

        public void OuvrirScenario(string chemin) {
            if (simulation.IsBusy)
                simulation.CancelAsync();

            XmlSerializer serializateur = new XmlSerializer(typeof(Scenario));
            using (StreamReader lecteur = new StreamReader(chemin)) {
                scenario = serializateur.Deserialize(lecteur) as Scenario;
            }

            simulation.RunWorkerAsync();
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

        #region Événement SimulationChange

        /// <summary>Délégué du gestionnaire d'événement d'un changement de la simulation</summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="vols">Vols actuels de la simulation</param>
        /// <param name="ecoule">Temps écoulé en secondes depuis le début de la simulation</param>
        public delegate void SimulationChangeEventHandler(object sender, (Color, Position, Position, Position)[] vols, int ecoule);

        /// <summary>Événement levé lors d'un changement dans la simulation</summary>
        public event SimulationChangeEventHandler SimulationChange;

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

        #region Gestionnaires d'événement

        /// <summary>Gestionnaire d'événement principal de la simulation</summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="e">Paramètres de l'événement</param>
        private void simulation_DoWork(object sender, DoWorkEventArgs e) {
            while (!simulation.CancellationPending) {
                scenario.Simuler(vitesse);
                simulation.ReportProgress(vitesse);

                Thread.Sleep(200);
            }

            e.Cancel = true;
        }

        /// <summary>Gestionnaire d'événement d'un changement de la simulation</summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="e">Paramètres de l'événement</param>
        private void simulation_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            (TypeVehicule typeVehicule, Position origine, Position position, Position destination)[] volsType = scenario.Vols;
            (Color, Position, Position, Position)[] volsCouleur = new (Color, Position, Position, Position)[volsType.Length];

            for (int i = 0; i < volsType.Length; i++)
                volsCouleur[i] = (TypeVehiculeCouleur(volsType[i].typeVehicule), volsType[i].origine, volsType[i].position, volsType[i].destination);

            SimulationChange?.Invoke(sender, volsCouleur, scenario.Ecoule);
        }

        #endregion
    }
}
