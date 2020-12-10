namespace OTAI.Simulateur {
    /// <summary>Classe du client secours </summary>
    public class Secours : Client {

        #region Constructeur
        public Secours(Position position) : base(position) {

        }
        #endregion

        #region Méthodes publiques
        public override string ToString() => "Secours (" + base.Position + ")";

        public override bool Equals(object obj) => obj is Secours secours && secours.Position == Position;
        #endregion
    }
}
