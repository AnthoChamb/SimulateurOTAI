using System;

namespace OTAI.Simulateur {
    /// <summary>Classe abstraite d'un état. Cette classe ne peut pas être instancié</summary>
    public abstract class Etat {
        protected int ecoule;

        /// <summary>Constructeur de base d'un état</summary>
        public Etat() => ecoule = 0;

        #region Méthodes publiques

        /// <summary>Simule l'action respectif à un état concret</summary>
        /// <param name="temps">Temps d'exécution de l'état en secondes</param>
        public virtual void Simuler(int temps) => ecoule += temps;

        /// <summary>Obtient une représentation en chaine du temps écoulé depuis le début de l'état concret</summary>
        /// <returns>Retourne une représentation en chaine du temps écoulé depuis le début de l'état concret</returns>
        /// <remarks>Le temps est retourné sous le format <c>hh:mm:ss</c></remarks>
        public override string ToString() => String.Format("{0:00}:{1:00}:{2:00}", ecoule / 60 / 60, ecoule / 60 % 60, ecoule % 60);

        #endregion

        #region Événement FinEtat

        /// <summary>Délégué du gestionnaire d'événement de la fin de l'état</summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="restant">Temps restant à l'action lorsque l'événement est levé</param>
        public delegate void FinEtatEventHandler(object sender, int restant);

        /// <summary>Événement levé lorsque l'état est terminé</summary>
        public event FinEtatEventHandler FinEtat;

        /// <summary>Lève l'événement <see cref="FinEtat"/></summary>
        /// <param name="sender">Objet à l'origine de l'événement</param>
        /// <param name="restant">Temps restant à l'action lorsque l'événement est levé</param>
        protected void LeverFinEtat(object sender, int restant) => FinEtat?.Invoke(sender, restant);

        #endregion
    }
}

