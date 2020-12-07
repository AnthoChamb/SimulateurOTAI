using System;
using System.Drawing;
using System.Windows.Forms;

namespace OTAI.Simulateur {
    /// <summary>Formulaire de la simulation</summary>
    public partial class FormSimulateur : Form {
        private readonly ControleurSimulateur controleur;

        /// <summary>Constructeur de base du formulaire</summary>
        private FormSimulateur() => InitializeComponent();

        /// <summary>Crée un formulaire de la simulation avec son controleur</summary>
        /// <param name="controleur">Controleur du formulaire</param>
        public FormSimulateur(ControleurSimulateur controleur) : this() {
            this.controleur = controleur;
            controleur.SimulationChange += controleur_SimulationChange;
        }

        /// <summary>Définit le temps écoulé en secondes depuis le début de la simulation</summary>
        private int Ecoule { set => labEcoule.Text = String.Format("{0:00}:{1:00}:{2:00} écoulé", value / 60 / 60, value / 60, value % 60); }

        #region Méthodes privées

        /// <summary>Actualise la liste les aéroports</summary>
        private void ActualiserAeroports() {
            lstAeroports.Items.Clear();

            // Remplit la liste d'aéroports
            string[] aeroports = controleur.ChainesAeroports;
            foreach (string aeroport in aeroports)
                lstAeroports.Items.Add(aeroport);

            DessinerAeroports();
        }

        /// <summary>Actualise les listes de clients et véhicules avec l'aéroport choisi</summary>
        private void ActualiserListes() {
            // Vide les listes actuels
            lstClients.Items.Clear();
            lstVehicules.Items.Clear();

            // Remplit la liste de clients
            string[] clients = controleur.Clients(lstAeroports.SelectedIndex);
            foreach (string client in clients)
                lstClients.Items.Add(client);

            // Remplit la liste de véhicules
            string[] vehicules = controleur.Vehicules(lstAeroports.SelectedIndex);
            foreach (string vehicule in vehicules)
                lstVehicules.Items.Add(vehicule);
        }

        /// <summary>Dessine les aéroports</summary>
        private void DessinerAeroports() {
            Graphics canvas = pictureCarte.CreateGraphics();
            Pen crayon = new Pen(Color.Black);

            foreach (Position position in controleur.PositionsAeroports)
                canvas.DrawRectangle(crayon, new Rectangle(position.Transposer(pictureCarte.Size), new Size(4, 4)));
        }

        /// <summary>Dessine un vol avec les informations reçu en paramètres</summary>
        /// <param name="couleur">Couleur du trajet</param>
        /// <param name="origine">Position d'origine du vol</param>
        /// <param name="position">Position actuel du véhicule</param>
        /// <param name="destination">Position de destination du vol</param>
        private  void DessinerVol(Color couleur, Position origine, Position position, Position destination) {
            Graphics canvas = pictureCarte.CreateGraphics();
            Pen crayon = new Pen(couleur);

            canvas.DrawLine(crayon, origine.Transposer(pictureCarte.Size), destination.Transposer(pictureCarte.Size));
            canvas.DrawRectangle(crayon, new Rectangle(position.Transposer(pictureCarte.Size), new Size(4, 4)));
        }

        #endregion

        #region Gestionnaires d'événement

        /// <summary>Gestionnaire d'événement d'un changement de la vitesse de la simulation</summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="e">Paramètres de l'événement</param>
        private void trackVitesse_ValueChanged(object sender, EventArgs e) => controleur.Vitesse = trackVitesse.Value;

        /// <summary>Gestionnaire d'événement d'un changement dans la liste d'aéroports</summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="e">Paramètres de l'événement</param>
        private void lstAeroports_SelectedIndexChanged(object sender, EventArgs e) => ActualiserListes();

        /// <summary>Gestionnaire d'événement d'un clic sur l'option Ouvrir scénario...</summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="e">Paramètres de l'événement</param>
        private void itemOuvrir_Click(object sender, EventArgs e) {
            OpenFileDialog ouvrir = new OpenFileDialog {
                Title = "Ouvrir scénario",
                Filter = "Scénario Xml|*.xml"
            };

            if (ouvrir.ShowDialog() == DialogResult.OK) {
                controleur.OuvrirScenario(ouvrir.FileName);
                ActualiserAeroports();
            }
        }

        /// <summary>Gestionnaire d'événement d'un clic sur l'option Quitter</summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="e">Paramètres de l'événement</param>
        private void itemQuitter_Click(object sender, EventArgs e) => Application.Exit();

        /// <summary>Gestionnaire d'événement d'un changement de la simulation</summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="vols">Vols actuels de la simulation</param>
        /// <param name="ecoule">Temps écoulé en secondes depuis le début de la simulation</param>
        private void controleur_SimulationChange(object sender, (Color, Position, Position, Position)[] vols, int ecoule) {
            ActualiserListes();

            foreach ((Color couleur, Position origine, Position position, Position destination) in vols)
                DessinerVol(couleur, origine, position, destination);

            Ecoule = ecoule;
        }

        #endregion

    }
}
