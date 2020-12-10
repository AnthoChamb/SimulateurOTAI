namespace OTAI.Simulateur {
    public class Passagers : ClientTransport {
        #region Constructeur
        public Passagers(Aeroport aeroportDestination, int quantite) : base(aeroportDestination, quantite) {

        }
        #endregion

        /// <summary>Obtient le type de clientèle du client</summary>
        public override Clientele Clientele { get => Clientele.PASSAGERS; }

        #region Méthodes publiques

        /// <summary>Obtient une représentation en chaine du nombre de passagers et de la destination d'un client de passagers</summary>
        /// <returns>Retourne une représentation en chaine du nombre de passagers et de la destination d'un client de passagers</returns>
        public override string ToString() => quantite + " passagers destination " + AreoportDestination;

        public override bool Equals(object obj) => obj is Passagers passagers && passagers.aeroportDestination == aeroportDestination;

        /// <summary>Obtient un entier qui détermine si cette instance précède, suit ou se situe à la même position que l'objet précisé dans l'odre de tri</summary>
        /// <param name="obj">Objet à comparer avec cette instance</param>
        /// <returns>Retourne un entier qui détermine si cette instance précède, suit ou se situe à la même position que l'objet précisé dans l'odre de tri</returns>
        /// <remarks>Cette classe est classé en ordre de quantité</remarks>
        public override int CompareTo(object obj) {
            if (obj is Passagers client)
                return client.Quantite.CompareTo(Quantite);
            return base.CompareTo(obj);
        }

        #endregion
    }
}
