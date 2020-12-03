using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAI.Scenario {
    public class ControleurCarte {

        #region Données membres

        private FormCarte interfaceCarte;

        #endregion

        #region Constructeurs

        public ControleurCarte() {
            interfaceCarte = new FormCarte();
        }

        #endregion


        #region Méthodes publiques

        public Position SelectionnerPosition() {
            return new Position();
        }

        #endregion
    }
}
