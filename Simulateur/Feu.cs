namespace OTAI.Simulateur {
    /// <summary>Classe d'un client feu</summary>
    public class Feu : Client {
        private byte envergure;
        #region Constructeur
        public Feu(Position position, byte envergure) : base(position) {
            this.envergure = envergure;
        }
        #endregion

        #region Propriétés publiques

        /// <summary>Obtient et définit l'envergure d'un feu </summary>
        public byte Envergure { get => envergure; set => envergure = value; }

        /// <summary>Obtient le type de clientèle du client</summary>
        public override Clientele Clientele { get => Clientele.INCENDIE; }

        #endregion

        #region Méthodes publiques
        public override string ToString() => "Incendie d'envergure " + envergure + " (" + base.Position + ")";

        public override bool Equals(object obj) => obj is Feu feu && feu.Position == Position && feu.envergure == envergure;

        #endregion
    }

}
