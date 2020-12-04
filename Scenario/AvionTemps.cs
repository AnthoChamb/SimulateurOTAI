using System.Xml.Serialization;

namespace OTAI.Scenario {
    /// <summary>Classe d'un avion avec temps</summary>
    [XmlInclude(typeof(AvionCiterne)), XmlInclude(typeof(AvionCapacite))]
    public abstract class AvionTemps : Vehicule {
        #region Données membres

        protected int embarquement, debarquement;
        private int entretien;

        #endregion

        #region Constructeurs

        /// <summary>Constructeur de base d'un avion avec temps</summary>
        /// <remarks>Ce constructeur ne devrait être appelé directement que par la désérialization Xml</remarks>
        internal AvionTemps() { }

        /// <summary>Crée un avion en attente avec le nom, la vitesse et les temps d'embarquement, débarquement et entretien spécifiées</summary>
        /// <param name="nom">Nom de l'avion</param>
        /// <param name="vitesse">Vitesse de l'avion</param>
        /// <param name="embarquement">Temps d'embarquement de l'avion en secondes</param>
        /// <param name="debarquement">Temps de débarquement de l'avion en secondes</param>
        /// <param name="entretien">Temps d'entretien de l'avion en secondes</param>
        public AvionTemps(string nom, int vitesse, int embarquement, int debarquement, int entretien) : base(nom, vitesse) {
            this.embarquement = embarquement;
            this.debarquement = debarquement;
            this.entretien = entretien;
        }

        #endregion

        #region Propriétés publiques

        /// <summary>Obtient et définit le temps d'entretien de l'avion en secondes</summary>
        public int Entretien { get => entretien; set => entretien = value; }

        #endregion
    }
}
