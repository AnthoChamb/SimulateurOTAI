namespace OTAI.Scenario {
    /// <summary>Classe d'un avion avec une capacité</summary>
    public abstract class AvionCapacite : AvionTemps {
        #region Constructeurs

        /// <summary>Constructeur de base d'un avion avec une capacité</summary>
        /// <remarks>Ce constructeur ne devrait être appelé directement que par la désérialization Xml</remarks>
        internal AvionCapacite() { }

        /// <summary>Crée un avion avec une capacité en attente avec le nom, la vitesse et les temps de chargement, largage et entretien spécifiées</summary>
        /// <param name="nom">Nom de l'avion avec une capacité</param>
        /// <param name="vitesse">Vitesse de l'avion avec une capacité</param>
        /// <param name="embarquement">Temps d'embarquement de l'avion avec une capacité en secondes</param>
        /// <param name="debarquement">Temps de débarquement de l'avion avec une capacité en secondes</param>
        /// <param name="entretien">Temps d'entretien de l'avion avec une capacité en secondes</param>
        public AvionCapacite(string nom, int vitesse, int embarquement, int debarquement, int entretien) : base(nom, vitesse, embarquement, debarquement, entretien) { }

        #endregion

        #region Propriétés publiques

        /// <summary>Obtient et définit le temps d'embarquement de l'avion avec une capacité en secondes</summary>
        public int Embarquement { get => embarquement; set => embarquement = value; }

        /// <summary>Obtient et définit le temps de débarquement de l'avion avec une capacité en secondes</summary>
        public int Debarquement { get => debarquement; set => debarquement = value; }

        #endregion
    }
}
