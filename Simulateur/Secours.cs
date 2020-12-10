namespace OTAI.Simulateur {
    /// <summary>Classe du client secours </summary>
    public class Secours : Client {
        public Secours(Position position) : base(position) { }

        /// <summary>Obtient le type de clientèle du client</summary>
        public override Clientele Clientele { get => Clientele.INCENDIE; }

        #region Méthodes publiques
        public override string ToString() => "Secours (" + base.Position + ")";

        public override bool Equals(object obj) => obj is Secours secours && secours.Position == Position;
        #endregion
    }
}
