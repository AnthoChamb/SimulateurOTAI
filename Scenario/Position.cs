﻿using System;
using System.Drawing;

namespace OTAI.Scenario {
    /// <summary>Structure d'une position cartographique</summary>
    public struct Position {
        #region Données membres;

        private double lat;
        private double lon;

        #endregion

        #region Constructeurs

        /// <summary>Crée une position cartographique selon des coordonnées en x et y</summary>
        /// <param name="lat">Lattitude de la position</param>
        /// <param name="lon">Longitude de la position</param>
        public Position(double lat, double lon) {
            this.lat = lat;
            this.lon = lon;
        }

        /// <summary>Crée une position cartographique selon un point dans une forme aux mesures propres</summary>
        /// <param name="point">Coordonnées en x et y b</param>
        /// <param name="carte">Objet ayant des dimensions précises</param>
        public Position(Point point, Size carte) {
            lon = point.X * 360.0 / carte.Width - 180;
            lat = point.Y * 180.0 / carte.Height - 90;
        }

        #endregion

        #region Propriétés publiques
        /// <summary>Obtient et définit les valeurs de la latitude</summary>
        public double Lat { get => lat; set => lat = value; }
        /// <summary>Obtient et définit les valeurs de la longitude</summary>
        public double Lon { get => lon; set => lon = value; }

        #endregion

        #region Méthodes publiques

        /// <summary>Transpose la position selon une nouvelle image pour suivre l'échelle des grandeurs</summary>
        /// <param name="taille">Object avec une hauteur et une largeur b</param>
        /// <returns>Retourne la position selon une nouvelle image pour suivre l'échelle des grandeurs</returns>
        public Point Transposer(Size taille) => new Point((int)Math.Round((lon + 180) * taille.Width / 360), (int)Math.Round((lat + 90) * taille.Height / 180));

        /// <summary>Obtient une représentation en chaine de la position cartographique</summary>
        /// <returns>Retourne une représentation en chaine de la position cartographique</returns>
        public override string ToString() {
            double latitude = Math.Floor(lat);
            double longitude = Math.Floor(lon);

            return String.Format("{0}° {1:00}′ {2}, {3}° {4:00}′ {5}", Math.Abs(latitude), Math.Abs(Math.Round(lat - latitude * 100)) / 90, lat > 0 ? 'S' : 'N', Math.Abs(longitude), Math.Abs(Math.Round(lon - longitude * 100)) / 90, lon > 0 ? 'O' : 'E');
        }

        /// <summary>Évalue si l'objet reçu en paramètre est identique à cette position</summary>
        /// <param name="obj">Objet à comparer avec cette position</param>
        /// <returns>Retourne <c>true</c> si l'objet reçu en paramètre est identique à cette position; sinon <c>false</c></returns>
        public override bool Equals(object obj) => obj is Position position && position.lat == lat && position.lon == lon;

        #endregion

        #region Opérateurs
        /// <summary>Évalue si la position a est identique à la position b</summary>
        /// <param name="a">Position a</param>
        /// <param name="b">Position b</param>
        /// <returns>Retourne <c>true</c> si les positions sont identiques sinon <c>false</c></returns>
        public static bool operator ==(Position a, Position b) => a.Equals(b);
        /// <summary>Évalue si la position a n'est pas identique à la position b</summary>
        /// <param name="a">Position a</param>
        /// <param name="b">Position b</param>
        /// <returns>Retourne <c>true</c> si les positions ne sont pas identiques sinon <c>false</c></returns>
        public static bool operator !=(Position a, Position b) => !a.Equals(b);

        #endregion
    }
}
