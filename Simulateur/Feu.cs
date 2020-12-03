﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un client feu</summary>
    public class Feu: Client {
        private byte envergure;
        #region Constructeur
        public Feu(Position position, byte envergure) : base(position) {
            this.envergure = envergure;
        }
        #endregion

        #region Propriétés publiques
        /// <summary>Obtient et définit l'envergure d'un feu </summary>
        public byte Envergure { get => envergure; set => envergure = value; }

        #endregion

        #region Méthodes publiques
        public override string ToString() => Clientele.FEUX.ToString();

        #endregion
    }

}
