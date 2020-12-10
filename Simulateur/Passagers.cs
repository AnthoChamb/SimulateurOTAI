namespace OTAI.Simulateur {
    public class Passagers : ClientTransport {
        #region Constructeur
        public Passagers(Aeroport aeroportDestination, int quantite) : base(aeroportDestination, quantite) {

        }
        #endregion


        #region Méthodes publiques
        /// <summary>Obtient une représentation en chaine du nombre de passagers et de la destination d'un client de passagers</summary>
        /// <returns>Retourne une représentation en chaine du nombre de passagers et de la destination d'un client de passagers</returns>
        public override string ToString() => base.quantite + " passagers destination " + base.AreoportDestination;

        public override bool Equals(object obj) => obj is Passagers passagers && passagers.aeroportDestination == aeroportDestination;
        #endregion
    }
}
