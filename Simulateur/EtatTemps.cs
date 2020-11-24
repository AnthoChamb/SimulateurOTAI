using System;

namespace OTAI.Simulateur {
    /// <summary>Classe abstraite d'un état où le temps s'écoule. Cette classe ne peut pas être instancié</summary>
    public abstract class EtatTemps : Etat {
        private int restant;

        /// <summary>Crée un état avec le temps a écoulé</summary>
        /// <param name="temps">Durée de l'état en secondes</param>
        public EtatTemps(int temps) => restant = temps;

        /// <summary>Simule l'action respectif à un état concret où le temps s'écoule</summary>
        /// <param name="temps">Temps d'exécution de l'état en secondes</param>
        public override void Simuler(int temps) {
            base.Simuler(temps);

            restant -= temps;

            if (restant <= 0)
                LeverFinEtat(this, Math.Abs(restant));
        }
    }
}
