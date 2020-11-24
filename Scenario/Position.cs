namespace OTAI.Scenario {
    /// <summary>Structure d'une position cartographique</summary>
    public struct Position {
        private float lat, lon;

        /// <summary>Crée une position cartographique</summary>
        /// <param name="lat">Lattitude de la position</param>
        /// <param name="lon">Longitude de la position</param>
        public Position(float lat, float lon) {
            this.lat = lat;
            this.lon = lon;
        }
    }
}
