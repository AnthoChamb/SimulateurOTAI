using System;
using System.Drawing;
using System.Globalization;

namespace OTAI.Scenario {
    /// <summary>Structure d'une position cartographique</summary>
    public struct Position {
        #region Données membres;

        private float lat;
        private float lon;

        #endregion

        #region Constructeurs

        /// <summary>Crée une position cartographique selon des coordonnées en x et y</summary>
        /// <param name="lat">Lattitude de la position</param>
        /// <param name="lon">Longitude de la position</param>
        public Position(float lat, float lon) {
            this.lat = lat;
            this.lon = lon;
        }

        /// <summary>Crée une position cartographique selon un point dans une forme aux mesures propres</summary>
        /// <param name="point">Coordonnées en x et y b</param>
        /// <param name="carte">Objet ayant des dimensions précises</param>
        public Position(Point point, Size carte) {

            lon = point.X / carte.Width * 360 - 180;
            lat = point.Y / carte.Height * 180 - 90;
        }

        #endregion

        #region Propriétés publiques

        public float Lat { get => lat; set => lat = value; }

        public float Lon { get => lon; set => lon = value; }

        #endregion

        #region Méthodes publiques

        /// <summary>Transpose la position selon une nouvelle image pour suivre l'échelle des grandeurs</summary>
        /// <param name="taille">Object avec une hauteur et une largeur b</param>
        /// <returns>Retourne la position selon une nouvelle image pour suivre l'échelle des grandeurs</returns>
        public Point Transposer(Size taille) => new Point((int)Math.Round((lon + 180) * taille.Width / 360), (int)Math.Round((lat + 90) * taille.Height / 180));

        /// <summary>Calcule la distance entre cette position et la position reçu en paramètre</summary>
        /// <param name="a">Position a</param>
        /// <param name="b">Position b</param>
        /// <returns>Retourne la distance entre cette position et la position reçu en paramètre</returns>
        public double Distance(Position position) => Distance(this, position);

        /// <summary>Obtient une représentation en chaine de la position cartographique</summary>
        /// <returns>Retourne une représentation en chaine de la position cartographique</returns>
        public override string ToString() {
            NumberFormatInfo carto = CultureInfo.InvariantCulture.NumberFormat;
            carto.NumberDecimalSeparator = "° ";
            carto.NumberDecimalDigits = 2;
            carto.NegativeSign = "";

            return lat.ToString("N", carto) + (lat > 0 ? "′ S, " : "′ N, ") + lon.ToString("N", carto) + (lon > 0 ? "′ O" : "′ E");
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
