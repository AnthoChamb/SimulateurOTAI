namespace OTAI.Simulateur {
    /// <summary>Classe d'un état en attente</summary>
    /// <remarks>Cette état ne lèvera jamais l'événement <see cref="Etat.FinEtat>"/></remarks>
    public class EtatAttente : Etat {
        /// <summary>Constructeur de base de l'état en attente</summary>
        public EtatAttente() { }

        /// <summary>Obtient une représentation en chaine de l'état ainsi que du temps écoulé depuis le début de l'état en attente</summary>
        /// <returns>Retourne une représentation en chaine de l'état ainsi que du temps écoulé depuis le début de l'état en attemte</returns>
        /// <remarks>Le temps est retourné sous le format <c>hh:mm:ss</c></remarks>
        public override string ToString() => "En attente - " + base.ToString();
    }
}
