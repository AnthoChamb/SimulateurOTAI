using System;
using System.Collections.Generic;

namespace OTAI.Simulateur {
    /// <summary>Classe générique abstraite des véhicules aériens. Cette clase ne peut pas être instancié</summary>
    /// <remarks>Cette clase agit également comme façade face aux états</remarks>
    public abstract class Vehicule : IComparable {
        #region Données membres

        private string nom;
        private int vitesse;
        protected Queue<Etat> etats;

        #endregion

        #region Constructeurs

        /// <summary>Constructeur de base d'un véhicule</summary>
        /// <remarks>Ce constructeur ne devrait être appelé directement que par la désérialization Xml</remarks>
        internal Vehicule() {
            etats = new Queue<Etat>(1);
            etats.Enqueue(new EtatAttente());
        }

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

        /// <summary>Évalue si le véhicule est actuellement en attente</summary>
        public bool EnAttente { get => etats.Peek() is EtatAttente; }

        /// <summary>Évalue si le véhicule est actuellement en vol</summary>
        public bool EnVol { get => etats.Peek() is EtatVol; }

        #endregion

        #region Propriétés du vol

        /// <summary>Obtient la position d'origine du vol du véhicule si possible</summary>
        /// <remarks>Si le véhicule n'est pas en vol, cette méthode retourne <c>null</c></remarks>
        public Position? OrigineVol {
            get {
                if (etats.Peek() is EtatVol vol)
                    return vol.Origine;
                return null;
            }
        }

        /// <summary>Obtient la position actuelle du véhicule si possible</summary>
        /// <remarks>Si le véhicule n'est pas en vol, cette méthode retourne <c>null</c></remarks>
        public Position? PositionVol {
            get {
                if (etats.Peek() is EtatVol vol)
                    return vol.Position;
                return null;
            }
        }

        /// <summary>Obtient la position de destination du vol du véhicule si possible</summary>
        /// <remarks>Si le véhicule n'est pas en vol, cette méthode retourne <c>null</c></remarks>
        public Position? DestinationVol {
            get {
                if (etats.Peek() is EtatVol vol)
                    return vol.Destination;
                return null;
            }
        }

        #endregion

        #region Méthodes publiques

        /// <summary>Simule l'action de ce véhicule</summary>
        /// <param name="temps">Temps de simulation en secondes</param>
        public void Simuler(int temps) => etats.Peek().Simuler(temps);

        /// <summary>Obtient une représentation en chaine du véhicule</summary>
        /// <returns>Retourne une représentation en chaine du véhicule</returns>
        public override string ToString() => nom + " (" + etats.Peek().ToString() + ")";

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

        #region Méthodes protégées

        /// <summary>Enlève le véhicule de son état d'attente</summary>
        /// <exception cref="InvalidOperationException">Le véhicule doit être en état d'attente</exception>
        protected void Envoyer() {
            if (!EnAttente)
                throw new InvalidOperationException("Impossible d'envoyer un véhicule alors qu'il n'est pas en attente");

            etats.Dequeue();
            etats.Peek().FinEtat += FinEtat;
        }

        #endregion

        #region Gestionnaire d'événement

        /// <summary>Gestionnaire d'événement de la fin de l'état actuel du véhicule</summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="restant">Temps restant à la simulation en secondes</param>
        private void FinEtat(object sender, int restant) {
            // Passe au prochain état dans la file
            etats.Dequeue();
            etats.Peek().FinEtat += FinEtat;

            // Poursuit la simulation avec le temps restant
            etats.Peek().Simuler(restant);
        }

        #endregion
    }
}

