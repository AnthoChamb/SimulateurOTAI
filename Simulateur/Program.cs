﻿using System;
using System.Windows.Forms;

namespace OTAI.Simulateur {
    static class Program {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new ControleurSimulateur();
        }
    }
}
