using System;
using System.Collections.Generic;
using System.Linq;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un scénario du simulateur</summary>
    public class Scenario {
        #region Données membres

        private List<Aeroport> aeroports;
        private int ecoule;
        private readonly Dictionary<Clientele, int> restant;

        #endregion

        #region Constructeurs

        /// <summary>Constructeur de base d'un scénario</summary>
        public Scenario() {
            aeroports = new List<Aeroport>();
            ecoule = 0;
            restant = new Dictionary<Clientele, int>(5) {
                { Clientele.SECOURS, ClienteleAttente(Clientele.SECOURS) },
                { Clientele.INCENDIE, ClienteleAttente(Clientele.INCENDIE) },
                { Clientele.PASSAGERS, ClienteleAttente(Clientele.PASSAGERS) },
                { Clientele.MARCHANDISES, ClienteleAttente(Clientele.MARCHANDISES) },
                { Clientele.OBSERVATION, ClienteleAttente(Clientele.OBSERVATION) }
            };
        }

        #endregion

        #region Propriétés des aéroports

        /// <summary>Obtient les représentations en chaines des aéroports dans le scénario</summary>
        public string[] ChainesAeroports {
            get {
                string[] chaines = new string[aeroports.Count];
                for (int i = 0; i < aeroports.Count; i++)
                    chaines[i] = aeroports[i].ToString();
                return chaines;
            }
        }

        /// <summary>Obtient la position des aéroports dans le scénario</summary>
        public Position[] PositionsAeroports {
            get {
                Position[] positions = new Position[aeroports.Count];
                for (int i = 0; i < aeroports.Count; i++)
                    positions[i] = aeroports[i].Position;
                return positions;
            }
        }

        /// <summary>Obtient la liste des aéroports dans le scénario</summary>
        /// <remarks>Cette propriété ne devrait être appelé directement que par la sérialization et désérialization Xml</remarks>
        internal List<Aeroport> Aeroports { get => aeroports; set => aeroports = value; }

        #endregion

        #region Propriétés des représentations en chaines

        /// <summary>Obtient les représentations en chaine des véhicules à l'aéroport de l'indice précisé</summary>
        /// <param name="i">Indice de l'aéroport</param>
        /// <returns>Retourne les représentations en chaine des véhicules à l'aéroport de l'indice précisé</returns>
        public string[] Vehicules(int i) => aeroports[i].ChainesVehicules;

        /// <summary>Obtient les représentations en chaine des clients en attente à l'aéroport de l'indice précisé</summary>
        /// <param name="i">Indice de l'aéroport</param>
        /// <returns>Retourne les représentations en chaine des clients en attente à l'aéroport de l'indice précisé</returns>
        public string[] Clients(int i) => aeroports[i].Clients;

        #endregion

        #region Autres propriétés publiques

        /// <summary>Obtient le temps écoulé dans le scénario en secondes</summary>
        public int Ecoule { get => ecoule; }

        /// <summary>Obtient un ensemble de valeurs identifiant les véhicules en vol dans le scénario</summary>
        public (TypeVehicule, Position, Position, Position)[] Vols {
            get {
                List<(TypeVehicule, Position, Position, Position)> vols = new List<(TypeVehicule, Position, Position, Position)>();

                foreach (Aeroport aeroport in aeroports)
                    vols.AddRange(aeroport.Vols);

                return vols.ToArray();
            }
        }

        #endregion

        #region Méthodes publiques

        /// <summary>Simule l'action du scénario</summary>
        /// <param name="temps">Temps de simulation en secondes</param>
        public void Simuler(int temps) {
            ecoule += temps;

            foreach (Clientele clientele in restant.Keys) {
                restant[clientele] -= temps;

                if (restant[clientele] <= 0) {
                    switch (clientele) {
                        case Clientele.PASSAGERS:
                            EnvoyerPassagers();
                            break;
                        case Clientele.MARCHANDISES:
                            EnvoyerMarchandises();
                            break;
                        default:
                            Random rand = new Random();
                            Position alea = new Position(rand.Next(-90, 90), rand.Next(-180, 180));

                            aeroports.OrderBy(aeroport => aeroport.Position.Distance(alea)).First().AjouterClient(FabriqueClient.Singleton.CreerClient(clientele, alea));
                            break;
                    }

                    restant[clientele] = restant[clientele] + ClienteleAttente(clientele);
                }
            }

            foreach (Aeroport aeroport in aeroports)
                aeroport.Simuler(temps);
        }

        #endregion

        #region Méthodes privées

        /// <summary>Obtient le temps d'attente en secondes de la clientèle reçu en paramètre</summary>
        /// <param name="clientele">Clientèle à identifier</param>
        /// <returns>Retourne le temps d'attente en secondes de la clientèle</returns>
        /// <exception cref="ArgumentException">La clintèle reçu doit être d'un type valide</exception>
        private static int ClienteleAttente(Clientele clientele) {
            switch (clientele) {
                case Clientele.SECOURS:
                    return 1200;
                case Clientele.INCENDIE:
                    return 2400;
                case Clientele.PASSAGERS:
                case Clientele.MARCHANDISES:
                case Clientele.OBSERVATION:
                    return 3600;
                default:
                    throw new ArgumentException("Clientèle inconnue");
            }
        }

        /// <summary>Envoie des passagers dans tous les aéroports en fonction de leur taux d'achalandage</summary>
        private void EnvoyerPassagers() {
            if (aeroports.Count > 1) {
                Random rand = new Random();
                foreach (Aeroport aeroport in aeroports) {
                    int autre = rand.Next(0, aeroports.Count);

                    while (aeroports[autre] == aeroport)
                        autre = rand.Next(0, aeroports.Count);

                    aeroport.AjouterClient(FabriqueClient.Singleton.CreerClient(Clientele.PASSAGERS, aeroports[autre], rand.Next(aeroport.MinPassagers, aeroport.MaxPassagers)));
                }
            }
        }

        /// <summary>Envoie des marchandises dans tous les aéroports en fonction de leur taux d'achalandage</summary>
        private void EnvoyerMarchandises() {
            if (aeroports.Count > 1) {
                Random rand = new Random();
                foreach (Aeroport aeroport in aeroports) {
                    int autre = rand.Next(0, aeroports.Count);

                    while (aeroports[autre] == aeroport)
                        autre = rand.Next(0, aeroports.Count);

                    aeroport.AjouterClient(FabriqueClient.Singleton.CreerClient(Clientele.MARCHANDISES, aeroports[autre], rand.Next(aeroport.MinMarchandise, aeroport.MaxMarchandise)));
                }
            }
        }

        #endregion

    }
}
