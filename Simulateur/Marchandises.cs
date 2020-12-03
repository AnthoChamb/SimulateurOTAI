using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un client chargé de marchandise</summary>
    public class Marchandises : ClientTransport{

        #region Constructeur
        public Marchandises(Aeroport aeroportDestination, int quantite) :base(aeroportDestination, quantite){

        }
        #endregion

        #region Méthodes publiques
        /// <summary>Obtient une représentation en chaine de la quantité et de la destination d'un client de marchandise</summary>
        /// <returns>Retourne une représentation en chaine de la quantité et de la destination d'un client de marchandise</returns>
        public override string ToString() => base.quantite + " tones de marchandise destination " + base.AreoportDestination ;

        public override bool Equals(object obj) => obj is Marchandises marchandises && marchandises.aeroportDestination == aeroportDestination;
        #endregion
    }
}
