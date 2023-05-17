using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly MongoClient client;
        private readonly IMongoDatabase db;



        /// <summary>
        /// Constructeur privé pour créer la connexion à la BDD et l'ouvrir
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        private ConnexionBDD(string stringConnect, string database)
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
        public static ConnexionBDD GetInstance(string stringConnect, string database)
        {
            if (instance is null)
            {
                instance = new ConnexionBDD(stringConnect, database);
            }
            return instance;
        }

        /// <summary>
        /// Ajour d'un document dans une collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nomCollection"></param>
        /// <param name="document"></param>
        public void Ajout<T>(string nomCollection, T document)
        {
            GetCollection<T>(nomCollection).InsertOne(document);
        }

        /// <summary>
        /// Suppresion d'un document dans une collection, à partir de son id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nomCollection"></param>
        /// <param name="id"></param>
        public void Suppr<T>(string nomCollection, ObjectId id)
        {
            FilterDefinition<T> filter = Builders<T>.Filter.Eq("Id", id);
            GetCollection<T>(nomCollection).DeleteOne(filter);
        }

        public void Update<T>(string nomCollection, ObjectId id, UpdateDefinition<T> update)
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            GetCollection<T>(nomCollection).UpdateOneAsync(filter, update);
        }

        /// <summary>
        /// Récupération d'une collection au format List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nomCollection"></param>
        /// <returns></returns>
        public List<T> CollectionToList<T>(string nomCollection, string utilisateur, string annee, string titre)
        {
            DateTime start = new DateTime();
            DateTime end = new DateTime();
            if (annee != "All")
            {
                switch (annee)
                {
                    case "2022":
                        start = new DateTime(2022, 01, 01, 00, 00, 00);
                        end = new DateTime(2022, 12, 31, 23, 59, 59);
                        break;
                    case "2023":
                        start = new DateTime(2023, 01, 01, 00, 00, 00);
                        end = new DateTime(2023, 12, 31, 23, 59, 59);
                        break;
                }
            }
            
            if (titre != "" && titre != null) // Titre non null
            {
                if (utilisateur != null && utilisateur != "Tous") // Utilisateur non null
                {                   
                    if (annee != "All") // Titre + Utilisateur + Année
                    {
                        var filterDefinition = Builders<T>.Filter.Eq("utilisateur", utilisateur) &
                                               Builders<T>.Filter.Gt("dateAjout", start) &
                                               Builders<T>.Filter.Lt("dateAjout", end) &
                                               Builders<T>.Filter.Regex("titre", new BsonRegularExpression(titre, "i"));
                        return GetCollection<T>(nomCollection).Find(filterDefinition).ToList();
                    }
                    else // Titre + Utilisateur
                    {
                        var filterDefinition = Builders<T>.Filter.Eq("utilisateur", utilisateur) &
                                               Builders<T>.Filter.Regex("titre", new BsonRegularExpression(titre, "i"));
                        return GetCollection<T>(nomCollection).Find(filterDefinition).ToList();
                    }
                }
                else // Utilisateur null
                {
                    if (annee != "All") // Titre + Année
                    {
                        var filterDefinition = Builders<T>.Filter.Gt("dateAjout", start) &
                                               Builders<T>.Filter.Lt("dateAjout", end) &
                                               Builders<T>.Filter.Regex("titre", new BsonRegularExpression(titre, "i"));
                        return GetCollection<T>(nomCollection).Find(filterDefinition).ToList();
                    }
                    else // Titre
                    {
                        var filterDefinition = Builders<T>.Filter.Regex("titre", new BsonRegularExpression(titre, "i"));
                        return GetCollection<T>(nomCollection).Find(filterDefinition).ToList();
                    }
                }
            }
            else // Titre null
            {
                if (utilisateur != null && utilisateur != "Tous") // Utilisateur non null
                {
                    if (annee != "All") // Utilisateur + Année
                    {
                        var filterDefinition = Builders<T>.Filter.Eq("utilisateur", utilisateur) &
                                               Builders<T>.Filter.Gt("dateAjout", start) &
                                               Builders<T>.Filter.Lt("dateAjout", end);
                        return GetCollection<T>(nomCollection).Find(filterDefinition).ToList();
                    }
                    else // Utilisateur
                    {
                        var filterDefinition = Builders<T>.Filter.Eq("utilisateur", utilisateur);
                        return GetCollection<T>(nomCollection).Find(filterDefinition).ToList();
                    }
                }
                else // Utilisateur null
                {
                    if (annee != "All") // Année
                    {
                        var filterDefinition = Builders<T>.Filter.Gt("dateAjout", start) &
                                               Builders<T>.Filter.Lt("dateAjout", end);
                        return GetCollection<T>(nomCollection).Find(filterDefinition).ToList();
                    }
                    else // Tout
                    {
                        return GetCollection<T>(nomCollection).AsQueryable().ToList();
                    }
                }
            }           
        }
      


        /// <summary>
        /// Récupération d'une collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nomCollection"></param>
        /// <returns></returns>
        private IMongoCollection<T> GetCollection<T>(string nomCollection)
        {
            return db.GetCollection<T>(nomCollection);
        }
    }
}

