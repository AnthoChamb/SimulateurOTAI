using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAI.Scenario {
    public class Scenario {

        #region Données membres

        //private SortedList<Aeroport> aeroports;

        #endregion

        #region Constructeurs

        public Scenario() {

        }

        #endregion

        #region Propriétés publiques

        //public string[] Aeroports { get; }

        //internal SortedList<Aeroport> Aeroports { get; set; }

        //public string[] Vehicules[int i] { get;}

        #endregion

        #region Méthodes publiques

        public void AjouterAeroport(string nom, Position position, int minPassagers, int maxPassagers, int minMarchandise, int maxMarchandise) {

        }

        public void AjouterVehicule(int aeroport, TypeVehicule typeVehicule, string nom, int vitesse, int? embarquement, int? debarquement, int? entretien, object? capacite) {

        }

        #endregion
    }
}
