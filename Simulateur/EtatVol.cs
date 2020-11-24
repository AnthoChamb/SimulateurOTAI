using System;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un état de vol</summary>
    public class EtatVol : Etat {
        private readonly Position origine;
        protected readonly Position destination;
        protected Position position;
        protected readonly int vitesse;

        /// <summary>Crée un état de vol</summary>
        /// <param name="origine">Position d'origine du vol</param>
        /// <param name="destination">Position de destination du vol</param>
        /// <param name="vitesse">Vitesse du véhicule en vol</param>
        public EtatVol(Position origine, Position destination, int vitesse) {
            this.origine = position = origine;
            this.destination = destination;
            this.vitesse = vitesse;
        }

        #region Propriétés publiques

        /// <summary>Obtient l'origine du vol</summary>
        public Position Origine { get => origine; }

        /// <summary>Obtient la position actuelle du véhicule en vol</summary>
        public virtual Position Position { get => position; }

        /// <summary>Obtient la destination du vol</summary>
        public Position Destination { get => destination; }

        #endregion

        /// <summary>Simule le vol pendant le temps précisé</summary>
        /// <param name="temps">Temps d'exécution du vol en secondes</param>
        public override void Simuler(int temps) {
            base.Simuler(temps);

            throw new NotImplementedException();
        }

        /// <summary>Obtient une représentation en chaine de l'état ainsi que du temps écoulé depuis le début du vol</summary>
        /// <returns>Retourne une représentation en chaine de l'état ainsi que du temps écoulé depuis le début du vol</returns>
        /// <remarks>Le temps est retourné sous le format <c>hh:mm:ss</c></remarks>
        public override string ToString() => "En vol - " + base.ToString();
    }
}
