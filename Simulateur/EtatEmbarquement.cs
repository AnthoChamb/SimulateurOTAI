namespace OTAI.Simulateur {
    /// <summary>Classe d'un état d'embarquement</summary>
    public class EtatEmbarquement : EtatTemps {
        /// <summary>Crée un état d'embarquement avec le temps d'embarquement précisé</summary>
        /// <param name="embarquement">Temps d'embarquement en secondes</param>
        public EtatEmbarquement(int embarquement) : base(embarquement) { }

        /// <summary>Obtient une représentation en chaine de l'état ainsi que du temps écoulé depuis le début de l'embarquement</summary>
        /// <returns>Retourne une représentation en chaine de l'état ainsi que du temps écoulé depuis le début de l'embarquement</returns>
        /// <remarks>Le temps est retourné sous le format <c>hh:mm:ss</c></remarks>
        public override string ToString() => "Embarquement - " + base.ToString();

    }
}
