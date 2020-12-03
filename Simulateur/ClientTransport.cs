using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un client transportant une charge</summary>
   public abstract class ClientTransport : Client {
        #region Données membres
        protected Aeroport aeroportDestination;
        protected int quantite;
        #endregion

        #region Constructeur
        /// <summary>Crée un client dont le rôle est de transporter une charge à destination  </summary>
        /// <param name="position">Position initiale du client</param>
        /// <param name="aeroportDestination">Destination du client</param>
        /// <param name="quantite">Quantité d'unités chargées à bord du client</param>
        public ClientTransport(Position position, Aeroport aeroportDestination, int quantite) : base(position) {
            this.aeroportDestination = aeroportDestination;
            this.quantite = quantite;
        }

        #endregion

        #region Propriétés publiques

        /// <summary>Obtient la destination du client</summary>
        public Aeroport AreoportDestination { get => aeroportDestination; set => aeroportDestination = value; }

        /// <summary>Obtient la quantité chargée du client</summary>
        public int Quantite { get => quantite; set => quantite = value; }

        #endregion


    }
}
