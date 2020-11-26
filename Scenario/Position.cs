using System.Drawing;

namespace OTAI.Scenario {
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

        public override string ToString() {
            return base.ToString();
        }

        #endregion
    }
}
