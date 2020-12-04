using System;
using System.Drawing;

namespace OTAI.Simulateur {
    /// <summary>Structure d'une position cartographique</summary>
    public struct Position {
        #region Données membres;

        private float lat;
        private float lon;

        #endregion

        #region Constructeurs

        /// <summary>Crée une position cartographique</summary>
        /// <param name="lat">Lattitude de la position</param>
        /// <param name="lon">Longitude de la position</param>
        public Position(float lat, float lon) {
            this.lat = lat;
            this.lon = lon;
        }

        public Position(Point point, Size carte) {
            this.lat = 0;
            this.lon = 0;
        }

        #endregion

        #region Propriétés publiques

        public float Lat { get => lat; set => lat = value; }

        public float Lon { get => lon; set => lon = value; }

        #endregion

        #region Méthodes publiques

        public PointF Transposer(Size taille) {
            return new PointF();
        }

        /// <summary>Calcule la distance entre cette position et la position reçu en paramètre</summary>
        /// <param name="a">Position a</param>
        /// <param name="b">Position b</param>
        /// <returns>Retourne la distance entre cette position et la position reçu en paramètre</returns>
        public double Distance(Position position) => Distance(this, position);

        public override string ToString() {
            return base.ToString();
        }

        public override bool Equals(object obj) => obj is Position position && position.lat == lat && position.lon == lon;

        #endregion

        #region Méthodes statiques

        /// <summary>Calcule la distance entre deux positions</summary>
        /// <param name="a">Position a</param>
        /// <param name="b">Position b</param>
        /// <returns>Retourne la distance entre les deux positions</returns>
        public static double Distance(Position a, Position b) {
            Position p2 = a > b ? a : b;
            Position p1 = a > b ? b : a;
            return Math.Sqrt(Math.Pow(p2.lon - p1.lon, 2) + Math.Pow(p2.lat - p1.lat, 2));
        }

        #endregion

        #region Opérateurs

        public static bool operator ==(Position a, Position b) => a.Equals(b);

        public static bool operator !=(Position a, Position b) => !a.Equals(b);

        /// <summary>Évalue si la position a est plus grande que la position b en comparant leur longitude</summary>
        /// <param name="a">Position a</param>
        /// <param name="b">Position b</param>
        /// <returns>Retourne <c>true</c> si la longitude de la position a est plus grande que celle de la position b; sinon <c>false</c></returns>
        public static bool operator >(Position a, Position b) => a.lon > b.lon;

        /// <summary>Évalue si la position a est plus petite que la position b en comparant leur longitude</summary>
        /// <param name="a">Position a</param>
        /// <param name="b">Position b</param>
        /// <returns>Retourne <c>true</c> si la longitude de la position a est plus petite que celle de la position b; sinon <c>false</c></returns>
        public static bool operator <(Position a, Position b) => a.lon < b.lon;

        #endregion
    }
}
