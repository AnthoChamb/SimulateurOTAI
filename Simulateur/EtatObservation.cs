using System;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un état d'observation</summary>
    public class EtatObservation : EtatVol {
        private double observation;

        /// <summary>Crée un état d'observation</summary>
        /// <param name="destination">Position de destination de l'observation</param>
        /// <param name="vitesse">Vitesse du véhicule en observation</param>
        public EtatObservation(Position origine, Position destination, int vitesse) : base(origine, destination, vitesse) => observation = Math.Atan(origine.Lon - destination.Lon / origine.Lat - destination.Lat);

        /// <summary>Simule le vol d'observation pendant le temps précisé</summary>
        /// <param name="temps">Temps d'exécution du vol en secondes</param>
        public override void Simuler(int temps) {
            ecoule += temps;

            while (position.Distance(Destination) > 1 && position > Destination == Origine > Destination && temps > 0) {
                position.Lon += (float)Math.Cos(angle) * vitesse;
                position.Lat += (float)Math.Sin(angle) * vitesse;
            }

            if (position.Distance(Destination) <= 1)
                while (observation < angle + 2 * Math.PI && temps > 0) {
                    observation += Math.PI / 360 * vitesse;
                    position.Lon = Destination.Lon + (float)Math.Cos(observation);
                    position.Lat = Destination.Lat + (float)Math.Sin(observation);
                }

            if (temps > 0)
                LeverFinEtat(this, temps);
        }

        /// <summary>Obtient une représentation en chaine de l'état ainsi que du temps écoulé depuis le début de l'observation</summary>
        /// <returns>Retourne une représentation en chaine de l'état ainsi que du temps écoulé depuis le début de l'observation</returns>
        /// <remarks>Le temps est retourné sous le format <c>hh:mm:ss</c></remarks>
        public override string ToString() => "En observation - " + String.Format("{0:00}:{1:00}:{2:00}", ecoule / 60 / 60, ecoule / 60, ecoule % 60);
    }
}
