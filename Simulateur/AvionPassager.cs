namespace OTAI.Simulateur {
    /// <summary>Classe d'un avion de passagers</summary>
    public class AvionPassager : AvionCapacite {
        private int capacite;

        #region Constructeurs

        /// <summary>Constructeur de base d'un avion de passagers</summary>
        /// <remarks>Ce constructeur ne devrait être appelé directement que par la désérialization Xml</remarks>
        internal AvionPassager() { }

        /// <summary>Crée un avion de passagers en attente avec le nom, la vitesse, les temps de chargement, largage et entretien et la capacité spécifiée</summary>
        /// <param name="nom">Nom de l'avion de passagers</param>
        /// <param name="vitesse">Vitesse de l'avion de passagers</param>
        /// <param name="chargement">Temps de chargement de l'avion de passagers en secondes</param>
        /// <param name="largage">Temps de largage de l'avion de passagers en secondes</param>
        /// <param name="entretien">Temps d'entretien de l'avion de passagers en secondes</param>
        /// <param name="capacite">Capacité de passagers de l'avion</param>
        public AvionPassager(string nom, int vitesse, int chargement, int largage, int entretien, int capacite) : base(nom, vitesse, chargement, largage, entretien) => this.capacite = capacite;

        #endregion

        #region Propriétés publiques

        /// <summary>Obtient et définit la capacité de passagers de l'avion</summary>
        public int Capacite { get => capacite; set => capacite = value; }

        #endregion

        #region Méthodes publiques

        public override string ToString() => "Avion de passagers " + base.ToString();

        #endregion
    }
}
