﻿using System;
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
        public FormSimulateur(ControleurSimulateur controleur) : this() => this.controleur = controleur;

        /// <summary>Définit le temps écoulé en secondes depuis le début de la simulation</summary>
        public int Ecoule { set => labEcoule.Text = String.Format("{0:00}:{1:00}:{2:00} écoulé", value / 60 / 60, value / 60, value % 60); }

        #region Méthodes publiques

        /// <summary>Dessine une aéroport à la position reçu en paramètre</summary>
        /// <param name="position">Position de l'aéroport</param>
        public void DessinerAeroport(Position position) {
            throw new NotImplementedException();
        }

        /// <summary>Dessine un vol avec les informations reçu en paramètres</summary>
        /// <param name="origine">Position d'origine du vol</param>
        /// <param name="position">Position actuel du véhicule</param>
        /// <param name="destination">Position de destination du vol</param>
        /// <param name="couleur">Couleur du trajet</param>
        public void DessinerVol(Position origine, Position position, Position destination, Color couleur) {
            throw new NotImplementedException();
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
        private void lstAeroports_SelectedIndexChanged(object sender, EventArgs e) {
            // Vide les listes actuels
            lstClients.Items.Clear();
            lstAeroports.Items.Clear();

            // Remplit la liste de clients
            string[] clients = controleur.Clients(lstAeroports.SelectedIndex);
            foreach (string client in clients)
                lstClients.Items.Add(client);

            // Remplit la liste de véhicules
            string[] vehicules = controleur.Vehicules(lstAeroports.SelectedIndex);
            foreach (string vehicule in vehicules)
                lstVehicules.Items.Add(vehicule);
        }

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

                lstAeroports.Items.Clear();

                // Remplit la liste d'aéroports
                string[] aeroports = controleur.Aeroports;
                foreach (string aeroport in aeroports)
                    lstAeroports.Items.Add(aeroport);
            }
        }

        /// <summary>Gestionnaire d'événement d'un clic sur l'option Quitter</summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="e">Paramètres de l'événement</param>
        private void itemQuitter_Click(object sender, EventArgs e) => Application.Exit();

        #endregion

    }
}
