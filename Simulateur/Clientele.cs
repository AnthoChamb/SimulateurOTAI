using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAI.Simulateur {
    /// <summary>Enumération des types de clients</summary>
    public enum Clientele {
        /// <summary>Situation de secours</summary>
        SECOURS,
        /// <summary>Situation de feu</summary>
        INCENDIE,
        /// <summary>Situation de passagers</summary>
        PASSAGERS,
        /// <summary>Situation de marchandises</summary>
        MARCHANDISES,
        /// <summary>Situation d'observation</summary>
        OBSERVATION
    }
}
