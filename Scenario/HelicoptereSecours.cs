using System;

namespace OTAI.Scenario {
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

        public override string ToString() => String.Format("{0} (Hélicoptère de secours), Vitesse : {1}", Nom, Vitesse);

        #endregion
    }
}
