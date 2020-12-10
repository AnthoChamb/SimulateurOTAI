using System;
using System.Collections.Generic;
using System.Linq;

namespace OTAI.Simulateur {
    /// <summary>Classe d'un aéroport</summary>
    public class Aeroport : IComparable {
        #region Données membres

        private string nom;
        private Position position;
        private int minPassagers;
        private int maxPassagers;
        private int minMarchandise;
        private int maxMarchandise;
        private List<Vehicule> vehicules;
        private readonly List<Client> clients;

        #endregion

        #region Constructeurs

        /// <summary>Constructeur de base d'un aéroport</summary>
        /// <remarks>Ce constructeur ne devrait être appelé directement que par la désérialization Xml</remarks>
        internal Aeroport() {
            vehicules = new List<Vehicule>();
            clients = new List<Client>();
        }

        /// <summary>Crée un aéroport avec toutes ses propriétés</summary>
        /// <param name="nom">Nom de l'aéroport</param>
        /// <param name="position">Position de l'aéroport</param>
        /// <param name="minPassagers">Taux d'achalandage minimal de passagers pour une heure dans l'aéroport</param>
        /// <param name="maxPassagers">Taux d'achalandage maximal de passagers pour une heure dans l'aéroport</param>
        /// <param name="minMarchandise">Taux d'achalandage minimal de marchandise pour une heure dans l'aéroport</param>
        /// <param name="maxMarchandise">Taux d'achalandage maximal de marchandise pour une heure dans l'aéroport</param>
        public Aeroport(string nom, Position position, int minPassagers, int maxPassagers, int minMarchandise, int maxMarchandise) : this() {
            this.nom = nom;
            this.position = position;
            this.minPassagers = minPassagers;
            this.maxPassagers = maxPassagers;
            this.minMarchandise = minMarchandise;
            this.maxMarchandise = maxMarchandise;
        }

        #endregion

        #region Propriétés publiques

        /// <summary>Obtient et définit le nom de l'aéroport</summary>
        public string Nom { get => nom; set => nom = value; }

        /// <summary>Obtient et définit la position de l'aéroport</summary>
        public Position Position { get => position; set => position = value; }

        /// <summary>Obtient et définit le taux d'achalandage minimal de passagers pour une heure dans l'aéroport</summary>
        public int MinPassagers { get => minPassagers; set => minPassagers = value; }

        /// <summary>Obtient et définit le taux d'achalandage maximal de passagers pour une heure dans l'aéroport</summary>
        public int MaxPassagers { get => maxPassagers; set => maxPassagers = value; }

        /// <summary>Obtient et définit le taux d'achalandage minimal de marchandise pour une heure dans l'aéroport</summary>
        public int MinMarchandise { get => minMarchandise; set => minMarchandise = value; }

        /// <summary>Obtient et définit le taux d'achalandage maximal de marchandise pour une heure dans l'aéroport</summary>
        public int MaxMarchandise { get => maxMarchandise; set => maxMarchandise = value; }

        /// <summary>Obtient une représentation en chaine des véhicules dans l'aéroport</summary>
        public string[] ChainesVehicules {
            get {
                string[] chaines = new string[vehicules.Count];
                for (int i = 0; i < vehicules.Count; i++)
                    chaines[i] = vehicules[i].ToString();
                return chaines;
            }
        }

        /// <summary>Obtient une représentation en chaine des clients en attente dans l'aéroport</summary>
        public string[] Clients {
            get {
                string[] chaines = new string[clients.Count];
                for (int i = 0; i < clients.Count; i++)
                    chaines[i] = clients[i].ToString();
                return chaines;
            }
        }

        /// <summary>Obtient un ensemble de valeurs identifiant les véhicules en vol dans l'aéroport</summary>
        public (TypeVehicule, Position, Position, Position)[] Vols {
            get {
                List<(TypeVehicule, Position, Position, Position)> vols = new List<(TypeVehicule, Position, Position, Position)>();

                foreach (Vehicule vehicule in vehicules)
                    if (vehicule.EnVol)
                        vols.Add((TypeVehiculeVehicule(vehicule), vehicule.OrigineVol.Value, vehicule.PositionVol.Value, vehicule.DestinationVol.Value));

                return vols.ToArray();
            }
        }

        /// <summary>Obtient la liste des véhicules de l'aéroport</summary>
        /// <remarks>Cette propriété ne devrait être appelé directement que par la sérialization et désérialization Xml</remarks>
        public List<Vehicule> Vehicules { get => vehicules; set => vehicules = value; }

        #endregion

        #region Propriétés des véhicules

        /// <summary>Évalue si l'aéroport possède un <see cref="HelicoptereSecours"/></summary>
        public bool PossedeHelicoptereSecours { get => vehicules.Where(vehicule => vehicule is HelicoptereSecours).Count() > 0; }

        /// <summary>Évalue si l'aéroport possède un <see cref="AvionObservateur"/></summary>
        public bool PossedeAvionObservateur { get => vehicules.Where(vehicule => vehicule is AvionObservateur).Count() > 0; }

        /// <summary>Évalue si l'aéroport possède un <see cref="AvionCiterne"/></summary>
        public bool PossedeAvionCiterne { get => vehicules.Where(vehicule => vehicule is AvionCiterne).Count() > 0; }

        #endregion

        #region Méthodes publiques

        /// <summary>Simule l'action de l'aéroport</summary>
        /// <param name="temps">Temps de simulation en secondes</param>
        public void Simuler(int temps) {
            DistribuerClients();
            foreach (Vehicule vehicule in vehicules)
                vehicule.Simuler(temps);
        }

        /// <summary>Ajoute un client à l'aéroport</summary>
        /// <param name="client">Client à ajouter à l'aéroport</param>
        /// <remarks>Dans le cas où des passagers ou marchandises sont déjà en attente pour la même destination, leur quantité se verra ajusté pour accepter les nouveaux clients</remarks>
        public void AjouterClient(Client client) {
            if (clients.Find(c => c == client) is ClientTransport attente && client is ClientTransport nouveau)
                attente.Quantite += nouveau.Quantite;
            else
                clients.Add(client);
        }

        /// <summary>Obtient un entier qui détermine si cette instance précède, suit ou se situe à la même position que l'objet précisé dans l'odre de tri</summary>
        /// <param name="obj">Objet à comparer avec cette instance</param>
        /// <returns>Retourne un entier qui détermine si cette instance précède, suit ou se situe à la même position que l'objet précisé dans l'odre de tri</returns>
        /// <remarks>Cette classe est classé en ordre croissante de nom</remarks>
        /// <exception cref="ArgumentException">L'objet reçu en paramètre doit être un aéroport</exception>
        public int CompareTo(object obj) {
            if (obj is Aeroport aeroport)
                return nom.CompareTo(aeroport.nom);
            throw new ArgumentException("L'objet reçu en paramètre n'est pas un aéroport");
        }

        /// <summary>Obtient une représentation en chaine de l'aéroport</summary>
        /// <returns>Retourne une représentation en chaine de l'aéroport</returns>
        public override string ToString() => nom;

        /// <summary>Évalue si l'objet reçu en paramètre est identique à cet aéroport</summary>
        /// <param name="obj">Objet à comparer avec cet aéroport</param>
        /// <returns>Retourne <c>true</c> si l'objet reçu en paramètre est identique à cet aéroport; sinon <c>false</c></returns>
        public override bool Equals(object obj) => obj is Aeroport aeroport && aeroport.nom == nom && aeroport.position == position && aeroport.minPassagers == minPassagers && aeroport.maxPassagers == maxPassagers && aeroport.minMarchandise == minMarchandise && aeroport.maxMarchandise == maxMarchandise;

        #endregion

        #region Méthodes privées

        /// <summary>Obtient le type de véhicule du véhicule reçu en paramètre</summary>
        /// <param name="vehicule">Véhicule à identifier</param>
        /// <returns>Retourne le type de véhicule du véhicule</returns>
        /// <exception cref="ArgumentException">Le véhicule reçu doit être d'un type valide</exception>
        private static TypeVehicule TypeVehiculeVehicule(Vehicule vehicule) {
            switch (vehicule) {
                case HelicoptereSecours _:
                    return TypeVehicule.SECOURS;
                case AvionObservateur _:
                    return TypeVehicule.OBSERVATEUR;
                case AvionCiterne _:
                    return TypeVehicule.CITERNE;
                case AvionPassager _:
                    return TypeVehicule.PASSAGER;
                case AvionMarchandise _:
                    return TypeVehicule.MARCHANDISE;
                default:
                    throw new ArgumentException("Type de véhicule inconnu");
            }
        }

        /// <summary>Distribue les clients en attente de l'aéroport dans les véhicules en attente</summary>
        private void DistribuerClients() {
            Queue<Client> distribue = new Queue<Client>();

            foreach (Client client in clients) {
                switch (client) {
                    case Secours secours:
                        if (vehicules.Where(vehicule => vehicule is HelicoptereSecours && vehicule.EnAttente).FirstOrDefault() is HelicoptereSecours helicoptere) {
                            helicoptere.EnvoyerSecours(position, secours.Position);
                            distribue.Enqueue(secours);
                        }
                        break;

                    case Feu feu:
                        if (vehicules.Where(vehicule => vehicule is AvionCiterne && vehicule.EnAttente).FirstOrDefault() is AvionCiterne citerne) {
                            citerne.EnvoyerEteindreFeu(position, feu.Position, feu.Envergure);
                            distribue.Enqueue(feu);
                        }
                        break;

                    case Passagers passagers:
                        List<AvionPassager> passagerDispo = vehicules.Where(vehicule => vehicule is AvionPassager && vehicule.EnAttente).Cast<AvionPassager>().ToList();
                        passagerDispo.Sort((a, b) => b.Capacite.CompareTo(a.Capacite));

                        while (passagers.Quantite > 0 && passagerDispo.Count > 0) {
                            // Prends le plus petit avion disponible avec une capacité plus grande que la quantité ou le plus grand avion avec une capacité plus petite
                            AvionPassager passager = passagerDispo.Where(simple => simple.Capacite > passagers.Quantite).LastOrDefault() ?? passagerDispo.First();
                            passagers.Quantite -= passager.Capacite;
                            TransfereAvion(passagers, passager);
                            passagerDispo.Remove(passager);
                        }

                        if (passagers.Quantite <= 0)
                            distribue.Enqueue(passagers);
                        break;

                    case Marchandises marchandises:
                        List<AvionMarchandise> marchandiseDispo = vehicules.Where(vehicule => vehicule is AvionMarchandise && vehicule.EnAttente).Cast<AvionMarchandise>().ToList();
                        marchandiseDispo.Sort((a, b) => b.Capacite.CompareTo(a.Capacite));

                        while (marchandises.Quantite > 0 && marchandiseDispo.Count > 0) {
                            // Prends le plus petit avion disponible avec une capacité plus grande que la quantité ou le plus grand avion avec une capacité plus petite
                            AvionMarchandise marchandise = marchandiseDispo.Where(simple => simple.Capacite > marchandises.Quantite).LastOrDefault() ?? marchandiseDispo.First();
                            marchandises.Quantite -= (int)Math.Floor(marchandise.Capacite);
                            TransfereAvion(marchandises, marchandise);
                            marchandiseDispo.Remove(marchandise);
                        }

                        if (marchandises.Quantite <= 0)
                            distribue.Enqueue(marchandises);
                        break;

                    case Observateurs observateurs:
                        if (vehicules.Where(vehicule => vehicule is AvionObservateur && vehicule.EnAttente).FirstOrDefault() is AvionObservateur observateur) {
                            observateur.EnvoyerObservation(position, observateurs.Position);
                            distribue.Enqueue(observateurs);
                        }
                        break;
                }
            }

            foreach (Client client in distribue)
                clients.Remove(client);
        }

        /// <summary>Transfère l'avion reçu en paramètre vers le client de transport</summary>
        /// <param name="client">Client de destination</param>
        /// <param name="avion">Avion à transféré</param>
        private void TransfereAvion(ClientTransport client, AvionCapacite avion) {
            client.AreoportDestination.vehicules.Add(avion);
            avion.EnvoyerTransport(position, client.Position);
            vehicules.Remove(avion);
        }

        #endregion

        #region Opérateurs 

        /// <summary>Évalue si l'aéroport a est identique à l'aéroport b</summary>
        /// <param name="a">Aéroport a</param>
        /// <param name="b">Aéroport</param>
        /// <returns>Retourne <c>true</c> si les aéroports sont identiques sinon <c>false</c></returns>
        public static bool operator ==(Aeroport a, Aeroport b) => a.Equals(b);

        /// <summary>Évalue si l'aéroport a n'est pas identique à l'aéroport b</summary>
        /// <param name="a">Aéroport a</param>
        /// <param name="b">Aéroport</param>
        /// <returns>Retourne <c>true</c> si les aéroports ne sont pas identiques sinon <c>false</c></returns>
        public static bool operator !=(Aeroport a, Aeroport b) => !a.Equals(b);

        #endregion
    }
}
