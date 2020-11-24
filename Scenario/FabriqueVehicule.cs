using System;

namespace OTAI.Scenario {
    /// <summary>Classe responsable de l'instanciation des véhicules</summary>
    /// <remarks>Cette classe agit également comme singleton</remarks>
    public class FabriqueVehicule {
        private static FabriqueVehicule singleton;

        /// <summary>Constructeur de base d'une fabrique de véhicule</summary>
        private FabriqueVehicule() { }

        /// <summary>Obtient le singleton de <see cref="FabriqueVehicule"/></summary>
        public static FabriqueVehicule Singleton {
            get {
                if (singleton == null)
                    singleton = new FabriqueVehicule();
                return singleton;
            }
        }

        /// <summary>Crée un véhicule à partir des paramètres précisés</summary>
        /// <param name="typeVehicule">Type du véhicule</param>
        /// <param name="nom">Nom du véhicule</param>
        /// <param name="vitesse">Vitesse du véhicule</param>
        /// <param name="embarquement">Paramètre optionnel du temps d'embarquement ou de chargement du véhicule en secondes</param>
        /// <param name="debarquement">Paramètre optionnel du temps de débarquement ou de largage du véhicule en secondes</param>
        /// <param name="entretien">Paramètre optionnel du temps d'entretien du véhicule en secondes</param>
        /// <param name="capacite">Paramètres optionnel de la capacité de passagers ou de marchandises du véhicule</param>
        /// <returns>Retourne le véhicule créer à partir des paramètres précisés</returns>
        /// <exception cref="ArgumentException">L'utilisateur doit fournir les paramètres nécessaires à la création du type de véhicule précisé</exception>
        public Vehicule CreerVehicule(TypeVehicule typeVehicule, string nom, int vitesse, int? embarquement = null, int? debarquement = null, int? entretien = null, object capacite = null) {
            switch (typeVehicule) {
                case TypeVehicule.SECOURS:
                    return new HelicoptereSecours(nom, vitesse);
                case TypeVehicule.OBSERVATEUR:
                    return new AvionObservateur(nom, vitesse);
                case TypeVehicule.CITERNE:
                    return new AvionCiterne(nom, vitesse, embarquement.Value, debarquement.Value, entretien.Value);
                case TypeVehicule.PASSAGER:
                    return new AvionPassager(nom, vitesse, embarquement.Value, debarquement.Value, entretien.Value, (int)capacite);
                case TypeVehicule.MARCHANDISE:
                    return new AvionMarchandise(nom, vitesse, embarquement.Value, debarquement.Value, entretien.Value, (float)capacite);
                default:
                    throw new ArgumentException("Type de véhicule inconnu");
            }
        }
    }
}
