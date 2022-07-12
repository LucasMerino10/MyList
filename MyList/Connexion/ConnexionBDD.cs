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
        public List<T> CollectionToList<T>(string nomCollection, string utilisateur)
        {
            if (utilisateur != null)
            {
                var filter = new BsonDocument("utilisateur", utilisateur);
                return GetCollection<T>(nomCollection).Find(filter).ToList();
            }
            else
            {
                return GetCollection<T>(nomCollection).AsQueryable().ToList();
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

