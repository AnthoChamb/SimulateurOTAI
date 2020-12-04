using System;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un état d'observation</summary>
    public class EtatObservation : EtatVol {
        const float DISTANCE = 2;

        /// <summary>Crée un état d'observation</summary>
        /// <param name="destination">Position de destination de l'observation</param>
        /// <param name="vitesse">Vitesse du véhicule en observation</param>
        public EtatObservation(Position destination, int vitesse) : base(vitesse) {
            this.destination = destination;

            Position origine = destination;
            origine.Lon -= DISTANCE;

            this.origine = position = origine;

            angle = Math.Atan(origine.Lon - destination.Lon / origine.Lat - destination.Lat);
        }

        /// <summary>Obtient la position actuelle du véhicule en observation</summary>
        public override Position Position {
            get {
                float lat, lon;
                double rad = ConvertirDegRad(((position.Lon - origine.Lon) * 360) / DISTANCE);

                lat = (float)Math.Sin(rad);
                lon = (float)Math.Cos(rad);

                return new Position(lat, lon);
            }
        }

        /// <summary>Obtient une représentation en chaine de l'état ainsi que du temps écoulé depuis le début de l'observation</summary>
        /// <returns>Retourne une représentation en chaine de l'état ainsi que du temps écoulé depuis le début de l'observation</returns>
        /// <remarks>Le temps est retourné sous le format <c>hh:mm:ss</c></remarks>
        public override string ToString() => "En observation - " + base.ToString();

        /// <summary>Converti un angle en degré en valeur radian</summary>
        /// <param name="deg">Angle en degré</param>
        /// <returns>Retourne la valeur en radian d'un angle en degré</returns>
        private double ConvertirDegRad(double deg) => Math.PI * deg / 100;
    }
}
