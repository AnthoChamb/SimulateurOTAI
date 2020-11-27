using System;
using System.Collections.Generic;

namespace OTAI.Scenario {
    /// <summary>Classe d'un aéroport</summary>
    public class Aeroport : IComparable {
        #region Données membres

        private string nom;
        private Position position;
        private int minPassagers;
        private int maxPassagers;
        private int minMarchandise;
        private int maxMarchandise;
        private List<Vehicule> vehicules;

        #endregion

        #region Constructeurs

        /// <summary>Constructeur de base d'un aéroport</summary>
        /// <remarks>Ce constructeur ne devrait être appelé directement que par la désérialization Xml</remarks>
        internal Aeroport() => vehicules = new List<Vehicule>();

        /// <summary>Crée un aéroport avec toutes ses propriétés</summary>
        /// <param name="nom">Nom de l'aéroport</param>
        /// <param name="position">Position de l'aéroport</param>
        /// <param name="minPassagers">Taux d'achalandage minimal de passagers pour une heure dans l'aéroport</param>
        /// <param name="maxPassagers">Taux d'achalandage maximal de passagers pour une heure dans l'aéroport</param>
        /// <param name="minMarchandise">Taux d'achalandage minimal de marchandise pour une heure dans l'aéroport</param>
        /// <param name="maxMarchandise">Taux d'achalandage maximal de marchandise pour une heure dans l'aéroport</param>
        public Aeroport(string nom, Position position, int minPassagers, int maxPassagers, int minMarchandise, int maxMarchandise) : this() {
            this.nom = nom;
            this.position = position;
            this.minPassagers = minPassagers;
            this.maxPassagers = maxPassagers;
            this.minMarchandise = minMarchandise;
            this.maxMarchandise = maxMarchandise;
        }

        #endregion

        #region Propriétés publiques

        /// <summary>Obtient et définit le nom de l'aéroport</summary>
        public string Nom { get => nom; set => nom = value; }

        /// <summary>Obtient et définit la position de l'aéroport</summary>
        public Position Position { get => position; set => position = value; }

        /// <summary>Obtient et définit le taux d'achalandage minimal de passagers pour une heure dans l'aéroport</summary>
        public int MinPassagers { get => minPassagers; set => minPassagers = value; }

        /// <summary>Obtient et définit le taux d'achalandage maximal de passagers pour une heure dans l'aéroport</summary>
        public int MaxPassagers { get => maxPassagers; set => maxPassagers = value; }

        /// <summary>Obtient et définit le taux d'achalandage minimal de marchandise pour une heure dans l'aéroport</summary>
        public int MinMarchandise { get => minMarchandise; set => minMarchandise = value; }

        /// <summary>Obtient et définit le taux d'achalandage maximal de marchandise pour une heure dans l'aéroport</summary>
        public int MaxMarchandise { get => maxMarchandise; set => maxMarchandise = value; }

        /// <summary>Obtient une représentation en chaine des véhicules dans l'aéroport</summary>
        public string[] ChainesVehicules {
            get {
                string[] chaines = new string[vehicules.Count];
                for (int i = 0; i < vehicules.Count; i++)
                    chaines[i] = vehicules[i].ToString();
                return chaines;
            }
        }

        /// <summary>Obtient la liste des véhicules de l'aéroport</summary>
        /// <remarks>Cette propriété ne devrait être appelé directement que par la sérialization et désérialization Xml</remarks>
        internal List<Vehicule> Vehicules { get => vehicules; set => vehicules = value; }

        #endregion

        #region Méthodes publiques

        /// <summary>Ajoute un véhicule à l'aéroport</summary>
        /// <param name="vehicule">Véhicule à ajouter à l'aéroport</param>
        public void AjouterVehicule(Vehicule vehicule) => vehicules.Add(vehicule);

        /// <summary>Obtient un entier qui détermine si cette instance précède, suit ou se situe à la même position que l'objet précisé dans l'odre de tri</summary>
        /// <param name="obj">Objet à comparer avec cette instance</param>
        /// <returns>Retourne un entier qui détermine si cette instance précède, suit ou se situe à la même position que l'objet précisé dans l'odre de tri</returns>
        /// <remarks>Cette classe est classé en ordre croissante de nom</remarks>
        /// <exception cref="ArgumentException">L'objet reçu en paramètre doit être un aéroport</exception>
        public int CompareTo(object obj) {
            if (obj is Aeroport aeroport)
                return nom.CompareTo(aeroport.nom);
            throw new ArgumentException("L'objet reçu en paramètre n'est pas un aéroport");
        }

        /// <summary>Obtient une représentation en chaine de l'aéroport</summary>
        /// <returns>Retourne une représentation en chaine de l'aéroport</returns>
        public override string ToString() => String.Format("{0} ({1}) MinPassagers : {2}, MaxPassagers : {3}, MinMarchandise : {4}, MaxMarchandise : {5}", Nom, position, minPassagers, maxPassagers, minMarchandise, maxMarchandise);

        #endregion
    }
}
