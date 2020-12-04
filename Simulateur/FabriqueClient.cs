using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAI.Simulateur {
    /// <summary>Classe responsable de l'instanciation des clients</summary>
    /// <remarks>Cette classe agit également comme singleton</remarks>
    public class FabriqueClient {
        #region Données membres
        private static FabriqueClient singleton;
        #endregion

        /// <summary>Constructeur de base d'une fabrique de client</summary>
        #region Constructeur
        private FabriqueClient() { }
        #endregion

        /// <summary>Obtient le singleton de <see cref="FabriqueClient"/></summary>
        public static FabriqueClient Singleton {
            get {
                if (singleton == null)
                    singleton = new FabriqueClient();
                return singleton;
            }
        }
        /// <summary>Crée un client à partir des paramètres précisés</summary>
        /// <param name="clientele">Type du client</param>
        /// <param name="position">Destination du client</param>
        /// <param name="quantite">Quantité chargée des unités de transports</param>
        /// <returns>Retourne le client créer à partir des paramètres précisés</returns>
        /// <exception cref="ArgumentException">L'utilisateur doit fournir les paramètres nécessaires à la création du type de client précisé</exception>
        public Client CreerClient(Clientele clientele, object position, int? quantite = null) {
              switch(clientele) {
                case Clientele.SECOURS:
                    return new Secours((Position)position);
                  
                case Clientele.INCENDIE:
                    Random rand = new Random();
                    return new Feu((Position)position,(byte)rand.Next(1, 6));

                case Clientele.PASSAGERS:
                    return new Passagers((Aeroport)position, quantite.Value);

                case Clientele.MARCHANDISES:
                    return new Passagers((Aeroport)position, quantite.Value);

                case Clientele.OBSERVATION:
                    return new Observateurs((Position)position);

                default:
                    throw new ArgumentException("Type de client inconnu");

            };

        }
    }
}
