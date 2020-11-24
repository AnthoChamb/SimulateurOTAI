using System;

namespace OTAI.Scenario {
    /// <summary>Classe générique abstraite des véhicules aériens. Cette clase ne peut pas être instancié</summary>
    public abstract class Vehicule : IComparable {
        #region Données membres

        private string nom;
        private int vitesse;

        #endregion

        #region Constructeurs

        /// <summary>Constructeur de base d'un véhicule</summary>
        /// <remarks>Ce constructeur ne devrait être appelé directement que par la désérialization Xml</remarks>
        internal Vehicule() { }

        /// <summary>Crée un véhicule en attente avec le nom et la vitesse spécifiée</summary>
        /// <param name="nom">Nom du véhicule</param>
        /// <param name="vitesse">Vitesse du véhicule</param>
        public Vehicule(string nom, int vitesse) : this() {
            this.nom = nom;
            this.vitesse = vitesse;
        }

        #endregion

        #region Propriétés publiques

        /// <summary>Obtient et définit le nom du véhicule</summary>
        public string Nom { get => nom; set => nom = value; }

        /// <summary>Obtient et définit la vitesse du véhicule</summary>
        public int Vitesse { get => vitesse; set => vitesse = value; }

        #endregion

        #region Méthodes publiques

        /// <summary>Obtient une représentation en chaine du véhicule</summary>
        /// <returns>Retourne une représentation en chaine du véhicule</returns>
        public override string ToString() => nom;

        /// <summary>Obtient un entier qui détermine si cette instance précède, suit ou se situe à la même position que l'objet précisé dans l'odre de tri</summary>
        /// <param name="obj">Objet à comparer avec cette instance</param>
        /// <returns>Retourne un entier qui détermine si cette instance précède, suit ou se situe à la même position que l'objet précisé dans l'odre de tri</returns>
        /// <remarks>Cette classe est classé en ordre croissante de nom</remarks>
        /// <exception cref="ArgumentException">L'objet reçu en paramètre doit être un véhicule</exception>
        public int CompareTo(object obj) {
            if (obj is Vehicule vehicule)
                return nom.CompareTo(vehicule.nom);
            throw new ArgumentException("L'objet reçu en paramètre n'est pas un véhicule");
        }

        #endregion
    }
}

