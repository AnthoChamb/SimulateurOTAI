using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un client observateur</summary>
    public class Observateurs: Client {
        #region Constructeur
        public Observateurs(Position position) : base(position) {

        }
        #endregion

        #region Méthodes publiques
        public override string ToString() => Clientele.OBSERVATEURS.ToString();

        #endregion
    }
}
