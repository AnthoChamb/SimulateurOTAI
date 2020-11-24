namespace OTAI.Simulateur {
    /// <summary>Classe d'un avion citerne</summary>
    public class AvionCiterne : AvionTemps {
        #region Constructeurs

        /// <summary>Constructeur de base d'un avion citerne</summary>
        /// <remarks>Ce constructeur ne devrait être appelé directement que par la désérialization Xml</remarks>
        internal AvionCiterne() { }

        /// <summary>Crée un avion citerne en attente avec le nom, la vitesse et les temps de chargement, largage et entretien spécifiées</summary>
        /// <param name="nom">Nom de l'avion citerne</param>
        /// <param name="vitesse">Vitesse de l'avion citerne</param>
        /// <param name="chargement">Temps de chargement de l'avion citerne en secondes</param>
        /// <param name="largage">Temps de largage de l'avion citerne en secondes</param>
        /// <param name="entretien">Temps d'entretien de l'avion citerne en secondes</param>
        public AvionCiterne(string nom, int vitesse, int chargement, int largage, int entretien) : base(nom, vitesse, chargement, largage, entretien) { }

        #endregion

        #region Propriétés publiques

        /// <summary>Obtient et définit le temps de chargement de l'avion citerne en secondes</summary>
        public int Chargement { get => embarquement; set => embarquement = value; }

        /// <summary>Obtient et définit le temps de largage de l'avion citerne en secondes</summary>
        public int Largage { get => debarquement; set => debarquement = value; }

        #endregion

        #region Méthodes publiques

        /// <summary>Envoie l'avion citerne de l'origine à la destination étendire un feu de l'envergure précisé</summary>
        /// <param name="origine">Position d'origine de l'avion</param>
        /// <param name="destination">Position de destination du feu</param>
        /// <param name="envergure">Envergure du feu. Représente le nombre d'aller-retour que l'avion doit exécuter avant d'éteindre le feu</param>
        public void EnvoyerEteindreFeu(Position origine, Position destination, byte envergure) {
            // Enfile les états nécessaire à éteindre le feu
            for (byte i = 0; i < envergure; i++) {
                etats.Enqueue(new EtatEmbarquement(embarquement));
                etats.Enqueue(new EtatVol(origine, destination, Vitesse));
                etats.Enqueue(new EtatDebarquement(debarquement));
                etats.Enqueue(new EtatVol(destination, origine, Vitesse));
            }
            etats.Enqueue(new EtatEntretien(Entretien));
            etats.Enqueue(new EtatAttente());

            Envoyer();
        }

        public override string ToString() => "Avion citerne " + base.ToString();

        #endregion
    }
}
