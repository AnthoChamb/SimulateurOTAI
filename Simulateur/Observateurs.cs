namespace OTAI.Simulateur {
    /// <summary>Classe d'un client observateur</summary>
    public class Observateurs : Client {
        #region Constructeur
        public Observateurs(Position position) : base(position) {

        }
        #endregion

        /// <summary>Obtient le type de clientèle du client</summary>
        public override Clientele Clientele { get => Clientele.OBSERVATION; }

        #region Méthodes publiques

        public override string ToString() => "Observation (" + base.Position + ")";

        public override bool Equals(object obj) => obj is Observateurs observateurs && observateurs.Position == Position;
        
        #endregion
    }
}
