namespace OTAI.Simulateur {
    /// <summary>Classe d'un client observateur</summary>
    public class Observateurs : Client {
        #region Constructeur
        public Observateurs(Position position) : base(position) {

        }
        #endregion

        #region Méthodes publiques
        public override string ToString() => "Observation (" + base.Position + ")";

        public override bool Equals(object obj) => obj is Observateurs observateurs && observateurs.Position == Position;
        #endregion
    }
}
