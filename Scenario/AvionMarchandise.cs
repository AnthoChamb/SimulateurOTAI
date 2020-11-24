using System;

namespace OTAI.Scenario {
    /// <summary>Classe d'un avion de marchandises</summary>
    public class AvionMarchandise : AvionCapacite {
        private float capacite;

        #region Constructeurs

        /// <summary>Constructeur de base d'un avion de marchandises</summary>
        /// <remarks>Ce constructeur ne devrait être appelé directement que par la désérialization Xml</remarks>
        internal AvionMarchandise() { }

        /// <summary>Crée un avion de marchandises en attente avec le nom, la vitesse, les temps de chargement, largage et entretien et la capacité spécifiée</summary>
        /// <param name="nom">Nom de l'avion de marchandises</param>
        /// <param name="vitesse">Vitesse de l'avion de marchandises</param>
        /// <param name="chargement">Temps de chargement de l'avion de marchandises en secondes</param>
        /// <param name="largage">Temps de largage de l'avion de marchandises en secondes</param>
        /// <param name="entretien">Temps d'entretien de l'avion de marchandises en secondes</param>
        /// <param name="capacite">Capacité de marchandises de l'avion en tonnes</param>
        public AvionMarchandise(string nom, int vitesse, int chargement, int largage, int entretien, float capacite) : base(nom, vitesse, chargement, largage, entretien) => this.capacite = capacite;

        #endregion

        #region Propriétés publiques

        /// <summary>Obtient et définit la capacité de marchandises de l'avion en tonnes</summary>
        public float Capacite { get => capacite; set => capacite = value; }

        #endregion

        #region Méthodes publiques

        public override string ToString() => String.Format("{0} (Avion de marchandises), Capacité : {1}, Vitesse : {2}, Temps d'embarquement : {3}, débarquement : {4}, entretien : {5}", Nom, capacite, Vitesse, embarquement, debarquement, Entretien);

        #endregion
    }
}
