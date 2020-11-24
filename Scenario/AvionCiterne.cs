using System;

namespace OTAI.Scenario {
    /// <summary>Classe d'un avion citerne</summary>
    public class AvionCiterne : AvionTemps {
        #region Constructeurs

        /// <summary>Constructeur de base d'un avion citerne</summary>
        /// <remarks>Ce constructeur ne devrait être appelé directement que par la désérialization Xml</remarks>
        internal AvionCiterne() { }

        /// <summary>Crée un avion citerne en attente avec le nom, la vitesse et les temps de chargement, largage et entretien spécifiées</summary>
        /// <param name="nom">Nom de l'avion citerne</param>
        /// <param name="vitesse">Vitesse de l'avion citerne</param>
        /// <param name="chargement">Temps de chargement de l'avion citerne en secondes</param>
        /// <param name="largage">Temps de largage de l'avion citerne en secondes</param>
        /// <param name="entretien">Temps d'entretien de l'avion citerne en secondes</param>
        public AvionCiterne(string nom, int vitesse, int chargement, int largage, int entretien) : base(nom, vitesse, chargement, largage, entretien) { }

        #endregion

        #region Propriétés publiques

        /// <summary>Obtient et définit le temps de chargement de l'avion citerne en secondes</summary>
        public int Chargement { get => embarquement; set => embarquement = value; }

        /// <summary>Obtient et définit le temps de largage de l'avion citerne en secondes</summary>
        public int Largage { get => debarquement; set => debarquement = value; }

        #endregion

        #region Méthodes publiques

        public override string ToString() => String.Format("{0} (Avion citerne), Vitesse : {1}, Temps de chargement : {2}, largage : {3}, entretien : {4}", Nom, Vitesse, embarquement, debarquement, Entretien);

        #endregion
    }
}
