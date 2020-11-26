using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAI.Scenario {
    public class Aeroport {

        #region Données membres

        private string nom;
        private Position position;
        private int minPassagers;
        private int maxPassagers;
        private int minMarchandise;
        private int maxMarchandise;
        List<Vehicule> vehicules;

        #endregion

        #region Constructeurs

        internal Aeroport() {

        }

        public Aeroport(string nom, int minPassagers, int maxPassagers, int minMarchandise, int maxMarchandise) {

        }

        #endregion

        #region Propriétés publiques

        public string Nom {get => nom;}

        public Position Position { get => position; set => position = value; }

        public int MinPassagers { get => minPassagers; set => minPassagers = value; }

        public int MaxPassagers { get => maxPassagers; set => maxPassagers = value; }

        public int MinMarchandise { get => minMarchandise; set => minMarchandise = value; }

        public int MaxMarchandise { get => maxMarchandise; set => maxMarchandise = value; }

        //public string[] Vehicules { get => vehicules.ToString(); }

        internal List<Vehicule> Vehicules { get => vehicules; set => vehicules = value; }

        #endregion

        #region Méthodes publiques

        public void AjouterVehicule(Vehicule vehicule) {

        }

        public override string ToString() => nom;

        #endregion
    }
}
