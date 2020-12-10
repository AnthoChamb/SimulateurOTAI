using System;

namespace OTAI.Simulateur {
    /// <summary>Classe cliente du simulateur</summary>
    public abstract class Client : IComparable {
        private Position position;

        /// <summary>Constructeur de base d'un client du simulateur</summary>
        /// <param name="position">Position du client en coordonnées géographique sous l'objet Position</param>
        public Client(Position position) {
            this.position = position;
        }

        /// <summary>Obtient et définit la position du client en coordonnées géographiques </summary>
        public Position Position { get => position; set => position = value; }

        /// <summary>Obtient le type de clientèle du client</summary>
        public abstract Clientele Clientele { get; }

        /// <summary>Obtient un entier qui détermine si cette instance précède, suit ou se situe à la même position que l'objet précisé dans l'odre de tri</summary>
        /// <param name="obj">Objet à comparer avec cette instance</param>
        /// <returns>Retourne un entier qui détermine si cette instance précède, suit ou se situe à la même position que l'objet précisé dans l'odre de tri</returns>
        /// <remarks>Cette classe est classé en ordre de son type de clientèle</remarks>
        /// <exception cref="ArgumentException">L'objet reçu en paramètre doit être un client</exception>
        public virtual int CompareTo(object obj) {
            if (obj is Client client)
                return Clientele.CompareTo(client.Clientele);
            throw new ArgumentException("L'objet reçu en paramètre n'est pas un client");
        }

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
