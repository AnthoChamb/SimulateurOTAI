using System;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un état d'observation</summary>
    public class EtatObservation : EtatVol {
        /// <summary>Crée un état d'observation</summary>
        /// <param name="destination">Position de destination de l'observation</param>
        /// <param name="vitesse">Vitesse du véhicule en observation</param>
        public EtatObservation(Position destination, int vitesse) : base(destination, destination, vitesse) { }

        /// <summary>Obtient la position actuelle du véhicule en observation</summary>
        public override Position Position { get => throw new NotImplementedException(); }

        /// <summary>Obtient une représentation en chaine de l'état ainsi que du temps écoulé depuis le début de l'observation</summary>
        /// <returns>Retourne une représentation en chaine de l'état ainsi que du temps écoulé depuis le début de l'observation</returns>
        /// <remarks>Le temps est retourné sous le format <c>hh:mm:ss</c></remarks>
        public override string ToString() => "En observation - " + base.ToString();
    }
}
