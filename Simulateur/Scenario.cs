using System;
using System.Collections.Generic;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un scénario du simulateur</summary>
    public class Scenario {
        #region Données membres

        private List<Aeroport> aeroports;
        private int ecoule;
        // TODO : Ajouter temps restant

        #endregion

        #region Constructeurs

        /// <summary>Constructeur de base d'un scénario</summary>
        public Scenario() {
            aeroports = new List<Aeroport>();
            ecoule = 0;
            // TODO : Initialiser temps restant
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

            throw new NotImplementedException();
        }

        #endregion

        // TODO : Ajouter manipulation des temps restants
    }
}
