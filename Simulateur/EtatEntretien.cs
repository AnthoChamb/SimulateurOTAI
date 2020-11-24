namespace OTAI.Simulateur {
    /// <summary>Classe d'un état d'entretien</summary>
    public class EtatEntretien : EtatTemps {
        /// <summary>Crée un état d'entretien avec le temps d'entretien précisé</summary>
        /// <param name="entretien">Temps d'entretien en secondes</param>
        public EtatEntretien(int entretien) : base(entretien) { }

        /// <summary>Obtient une représentation en chaine de l'état ainsi que du temps écoulé depuis le début de l'entretien</summary>
        /// <returns>Retourne une représentation en chaine de l'état ainsi que du temps écoulé depuis le début de l'entretien</returns>
        /// <remarks>Le temps est retourné sous le format <c>hh:mm:ss</c></remarks>
        public override string ToString() => "Entretien - " + base.ToString();

    }
}
