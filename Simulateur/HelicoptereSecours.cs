namespace OTAI.Simulateur {
    /// <summary>Classe d'un hélicoptère de secours</summary>
    public class HelicoptereSecours : Vehicule {
        #region Constructeurs

        /// <summary>Constructeur de base d'un hélicoptère de secours</summary>
        /// <remarks>Ce constructeur ne devrait être appelé directement que par la désérialization Xml</remarks>
        internal HelicoptereSecours() { }

        /// <summary>Crée un hélicoptère de secours en attente avec le nom et la vitesse spécifiée</summary>
        /// <param name="nom">Nom de l'hélicoptère de secours</param>
        /// <param name="vitesse">Vitesse de l'hélicoptère de secours</param>
        public HelicoptereSecours(string nom, int vitesse) : base(nom, vitesse) { }

        #endregion

        #region Méthodes publiques

        /// <summary>Envoie l'hélicoptère de secours de l'origine à la destination</summary>
        /// <param name="origine">Position d'origine de l'hélicoptère</param>
        /// <param name="destination">Position de destination du secours</param>
        public void EnvoyerSecours(Position origine, Position destination) {
            // Enfile les états nécessaire à un secours
            etats.Enqueue(new EtatVol(origine, destination, Vitesse));
            etats.Enqueue(new EtatVol(destination, origine, Vitesse));
            etats.Enqueue(new EtatAttente());

            Envoyer();
        }

        public override string ToString() => "Hélicoptère de secours " + base.ToString();

        #endregion
    }
}
