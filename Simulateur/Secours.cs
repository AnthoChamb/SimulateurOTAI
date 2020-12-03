using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAI.Simulateur {
    /// <summary>Classe du client secours </summary>
    public class Secours : Client {

        #region Constructeur
        public Secours(Position position) : base(position) {

        }
        #endregion

        #region Méthodes publiques
        public override string ToString() => Clientele.SECOURS.ToString();

        #endregion
    }
}
