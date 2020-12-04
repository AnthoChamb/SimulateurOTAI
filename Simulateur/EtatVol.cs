using System;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un état de vol</summary>
    public class EtatVol : Etat {
        #region Données mmebres

        protected Position origine, position, destination;
        protected readonly int vitesse;
        protected double angle;

        #endregion

        #region Constructeurs

        /// <summary>Constructeur de base d'un état de vol</summary>
        /// <param name="vitesse">Vitesse du véhicule en vol</param>
        protected EtatVol(int vitesse) => this.vitesse = vitesse;

        /// <summary>Crée un état de vol</summary>
        /// <param name="origine">Position d'origine du vol</param>
        /// <param name="destination">Position de destination du vol</param>
        /// <param name="vitesse">Vitesse du véhicule en vol</param>
        public EtatVol(Position origine, Position destination, int vitesse) : this(vitesse) {
            this.origine = position = origine;
            this.destination = destination;

            angle = Math.Atan(origine.Lon - destination.Lon / origine.Lat - destination.Lat);
        }

        #endregion

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

            while (position > destination == origine > destination && temps > 0) {
                position.Lon += (float)Math.Cos(angle) * vitesse;
                position.Lon += (float)Math.Sin(angle) * vitesse;
            }

            if (temps > 0)
                LeverFinEtat(this, temps);
        }

        /// <summary>Obtient une représentation en chaine de l'état ainsi que du temps écoulé depuis le début du vol</summary>
        /// <returns>Retourne une représentation en chaine de l'état ainsi que du temps écoulé depuis le début du vol</returns>
        /// <remarks>Le temps est retourné sous le format <c>hh:mm:ss</c></remarks>
        public override string ToString() => "En vol - " + base.ToString();
    }
}
