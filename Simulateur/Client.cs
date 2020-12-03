using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

      

    }
}
