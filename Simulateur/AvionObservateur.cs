using System;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un avion observateur</summary>
    public class AvionObservateur : Vehicule {
        #region Constructeurs

        /// <summary>Constructeur de base d'un avion observateur</summary>
        /// <remarks>Ce constructeur ne devrait être appelé directement que par la désérialization Xml</remarks>
        internal AvionObservateur() { }

        /// <summary>Crée un avion observateur en attente avec le nom et la vitesse spécifiée</summary>
        /// <param name="nom">Nom de l'avion observateur</param>
        /// <param name="vitesse">Vitesse de l'avion observateur</param>
        public AvionObservateur(string nom, int vitesse) : base(nom, vitesse) { }

        #endregion

        #region Méthodes publiques

        /// <summary>Envoie l'avion observateur de l'origine à la destination</summary>
        /// <param name="origine">Position d'origine de l'avion</param>
        /// <param name="destination">Position de destination de l'observation</param>
        public void EnvoyerObservation(Position origine, Position destination) {
            // Enfile les états nécessaire à une observation
            etats.Enqueue(new EtatObservation(origine, destination, Vitesse));

            double angle = origine.Angle(destination);

            etats.Enqueue(new EtatVol(new Position(destination.Lat - Math.Sin(angle) * EtatObservation.RAYON, destination.Lon - Math.Cos(angle) * EtatObservation.RAYON), origine, Vitesse));
            etats.Enqueue(new EtatAttente());

            Envoyer();
        }

        public override string ToString() => "Avion observateur " + base.ToString();

        #endregion
    }
}
