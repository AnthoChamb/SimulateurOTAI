namespace OTAI.Simulateur {
    /// <summary>Classe d'un état de débarquement</summary>
    public class EtatDebarquement : EtatTemps {
        /// <summary>Crée un état de débarquement avec le temps de débarquement précisé</summary>
        /// <param name="debarquement">Temps de débarquement en secondes</param>
        public EtatDebarquement(int debarquement) : base(debarquement) { }

        /// <summary>Obtient une représentation en chaine de l'état ainsi que du temps écoulé depuis le début du débarquement</summary>
        /// <returns>Retourne une représentation en chaine de l'état ainsi que du temps écoulé depuis le début du débarquement</returns>
        /// <remarks>Le temps est retourné sous le format <c>hh:mm:ss</c></remarks>
        public override string ToString() => "Débarquement - " + base.ToString();

    }
}
