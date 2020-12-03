using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAI.Simulateur {
    public class Passagers: ClientTransport {
        #region Constructeur
        public Passagers(Position position, Aeroport aeroportDestination, int quantite) : base(position, aeroportDestination, quantite) {

        }
        #endregion


        #region Méthodes publiques
        /// <summary>Obtient une représentation en chaine du nombre de passagers et de la destination d'un client de passagers</summary>
        /// <returns>Retourne une représentation en chaine du nombre de passagers et de la destination d'un client de passagers</returns>
        public override string ToString() => base.quantite + " passagers destination " + base.AreoportDestination;

        #endregion
    }
}
