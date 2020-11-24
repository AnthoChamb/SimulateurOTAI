using System;

namespace OTAI.Scenario {
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

        public override string ToString() => String.Format("{0} (Avion observateur), Vitesse : {1}", Nom, Vitesse);

        #endregion
    }
}
