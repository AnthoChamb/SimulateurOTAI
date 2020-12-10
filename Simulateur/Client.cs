namespace OTAI.Simulateur {
    /// <summary>Classe cliente du simulateur</summary>
    public abstract class Client {

        #region Données membres
        private Position position;
        #endregion

        #region Constructeur  
        /// <summary>Constructeur de base d'un client du simulateur</summary>
        /// <param name="position">Position du client en coordonnées géographique sous l'objet Position</param>
        public Client(Position position) {
            this.position = position;
        }
        #endregion

        #region Propriétés publiques
        /// <summary>Obtient et définit la position du client en coordonnées géographiques </summary>
        public Position Position { get => position; set => position = value; }

        #endregion

        public abstract override bool Equals(object obj);

        #region Opérateurs 

        /// <summary>Évalue si le client a est identique au client b</summary>
        /// <param name="a">Client a</param>
        /// <param name="b">Client</param>
        /// <returns>Retourne <c>true</c> si les clients sont identiques sinon <c>false</c></returns>
        public static bool operator ==(Client a, Client b) => a.Equals(b);

        /// <summary>Évalue si le client a n'est pas identique au client b</summary>
        /// <param name="a">Client a</param>
        /// <param name="b">Client</param>
        /// <returns>Retourne <c>true</c> si les clients ne sont pas identiques sinon <c>false</c></returns>
        public static bool operator !=(Client a, Client b) => !a.Equals(b);

        #endregion
    }
}
