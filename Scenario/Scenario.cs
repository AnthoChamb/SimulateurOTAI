using System;
using System.Collections.Generic;

namespace OTAI.Scenario {
    /// <summary>Classe d'un scénario du simulateur</summary>
    public class Scenario {
        private List<Aeroport> aeroports;

        #region Constructeurs

        /// <summary>Constructeur de base d'un scénario</summary>
        public Scenario() => aeroports = new List<Aeroport>();

        #endregion

        #region Propriétés publiques

        /// <summary>Obtient les représentations en chaines des aéroports dans le scénario</summary>
        public string[] ChainesAeroports {
            get {
                string[] chaines = new string[aeroports.Count];
                for (int i = 0; i < aeroports.Count; i++)
                    chaines[i] = aeroports[i].ToString();
                return chaines;
            }
        }

        /// <summary>Obtient la liste des aéroports dans le scénario</summary>
        /// <remarks>Cette propriété ne devrait être appelé directement que par la sérialization et désérialization Xml</remarks>
        internal List<Aeroport> Aeroports { get => aeroports; set => aeroports = value; }

        /// <summary>Obtient les représentations en chaine des véhicules à l'aéroport de l'indice précisé</summary>
        /// <param name="i">Indice de l'aéroport</param>
        /// <returns>Retourne les représentations en chaine des véhicules à l'aéroport de l'indice précisé</returns>
        public string[] this[int i] { get => aeroports[i].ChainesVehicules; }

        #endregion

        #region Méthodes publiques

        /// <summary>Ajoute un aéroport avec toutes ses propriétés dans le scénario</summary>
        /// <param name="nom">Nom de l'aéroport</param>
        /// <param name="position">Position de l'aéroport</param>
        /// <param name="minPassagers">Taux d'achalandage minimal de passagers pour une heure dans l'aéroport</param>
        /// <param name="maxPassagers">Taux d'achalandage maximal de passagers pour une heure dans l'aéroport</param>
        /// <param name="minMarchandise">Taux d'achalandage minimal de marchandise pour une heure dans l'aéroport</param>
        /// <param name="maxMarchandise">Taux d'achalandage maximal de marchandise pour une heure dans l'aéroport</param>
        /// <exception cref="ArgumentException">Un aéroport identique ne peut déjà exister dans ce scénario</exception>
        public void AjouterAeroport(string nom, Position position, int minPassagers, int maxPassagers, int minMarchandise, int maxMarchandise) {
            Aeroport aeroport = new Aeroport(nom, position, minPassagers, maxPassagers, minMarchandise, maxMarchandise);

            if (aeroports.Contains(aeroport))
                throw new ArgumentException("Un aéroport identique existe déjà");

            aeroports.Add(aeroport);
            aeroports.Sort();
        }

        /// <summary>Ajoute un véhicule avec toutes ses propriétés dans l'aéroport à l'indice précisé</summary>
        /// <param name="aeroport">Indice de l'aéroport</param>
        /// <param name="typeVehicule">Type du véhicule</param>
        /// <param name="nom">Nom du véhicule</param>
        /// <param name="vitesse">Vitesse du véhicule</param>
        /// <param name="embarquement">Paramètre optionnel du temps d'embarquement ou de chargement du véhicule en secondes</param>
        /// <param name="debarquement">Paramètre optionnel du temps de débarquement ou de largage du véhicule en secondes</param>
        /// <param name="entretien">Paramètre optionnel du temps d'entretien du véhicule en secondes</param>
        /// <param name="capacite">Paramètres optionnel de la capacité de passagers ou de marchandises du véhicule</param>
        /// <exception cref="ArgumentException">L'utilisateur doit fournir les paramètres nécessaires à la création du type de véhicule précisé</exception>
        public void AjouterVehicule(int aeroport, TypeVehicule typeVehicule, string nom, int vitesse, int? embarquement = null, int? debarquement = null, int? entretien = null, object capacite = null) => aeroports[aeroport].AjouterVehicule(FabriqueVehicule.Singleton.CreerVehicule(typeVehicule, nom, vitesse, embarquement, debarquement, entretien, capacite));

        #endregion
    }
}
