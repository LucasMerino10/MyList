using System;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyList.Connexion
{
    public class ConnexionBDD
    {
        /// <summary>
        /// Unique instance de la classe
        /// </summary>
        private static ConnexionBDD instance = null;
        /// <summary>
        /// objet de connexion à la BDD à partir d'une chaîne de connexion
        /// </summary>
        private MongoClient client;

        private IMongoDatabase db;

        /// <summary>
        /// Constructeur privé pour créer la connexion à la BDD et l'ouvrir
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        private ConnexionBDD(string stringConnect)
        {
            try
            {
                client = new MongoClient(stringConnect);
                db = client.GetDatabase("MyList");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }

        /// <summary>
        /// Crée une instance unique de la classe
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        /// <returns>instance unique de la classe</returns>
        public static ConnexionBDD GetInstance(string stringConnect)
        {
            if (instance is null)
            {
                instance = new ConnexionBDD(stringConnect);
            }
            return instance;
        }

    }
}

