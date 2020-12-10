namespace OTAI.Simulateur {
    /// <summary>Classe d'un client chargé de marchandise</summary>
    public class Marchandises : ClientTransport {

        #region Constructeur
        public Marchandises(Aeroport aeroportDestination, int quantite) : base(aeroportDestination, quantite) {

        }
        #endregion

        /// <summary>Obtient le type de clientèle du client</summary>
        public override Clientele Clientele { get => Clientele.MARCHANDISES; }

        #region Méthodes publiques

        /// <summary>Obtient une représentation en chaine de la quantité et de la destination d'un client de marchandise</summary>
        /// <returns>Retourne une représentation en chaine de la quantité et de la destination d'un client de marchandise</returns>
        public override string ToString() => quantite + " tones de marchandise destination " + AreoportDestination;

        public override bool Equals(object obj) => obj is Marchandises marchandises && marchandises.aeroportDestination == aeroportDestination;

        /// <summary>Obtient un entier qui détermine si cette instance précède, suit ou se situe à la même position que l'objet précisé dans l'odre de tri</summary>
        /// <param name="obj">Objet à comparer avec cette instance</param>
        /// <returns>Retourne un entier qui détermine si cette instance précède, suit ou se situe à la même position que l'objet précisé dans l'odre de tri</returns>
        /// <remarks>Cette classe est classé en ordre de quantité</remarks>
        public override int CompareTo(object obj) {
            if (obj is Marchandises client)
                return client.Quantite.CompareTo(Quantite);
            return base.CompareTo(obj);
        }

        #endregion
    }
}
