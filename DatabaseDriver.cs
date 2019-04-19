using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoPortfolio
{
    class DatabaseDriver
    {
        private IMongoDatabase database;
        private IMongoCollection<TeamModel> collection;
        public DatabaseDriver()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("teams");
            collection = database.GetCollection<TeamModel>("teams");
        }

        public List<TeamModel> GetAllTeams()
        {
            var result = collection.FindSync(FilterDefinition<TeamModel>.Empty).ToList();

            return result;
        }

        public TeamModel GetSpecificTeam(ObjectId id)
        {
            var filter = Builders<TeamModel>.Filter.Eq("_id", id);

            var value = collection.FindSync(filter).SingleOrDefault();

            return value;
        }

        public string Create(TeamModel teamModel)
        {
            collection.InsertOne(teamModel);

            return ("You have added a new team");
        }

        public string Update(TeamModel team)
        {
            var builder = Builders<TeamModel>.Filter;
            var filter = builder.Eq(x => x._id, team._id);

            var update = Builders<TeamModel>.Update
                .Set("team name", team.TeamName)
                .Set("number of player", team.NumberOfPlayers)
                .Set("league", team.League);

            collection.UpdateOne(filter, update, new UpdateOptions());

            return ("You have updated a team");
        }

        public string Delete(ObjectId id)
        {
            var filter = Builders<TeamModel>.Filter.Eq("_id", id);

            collection.DeleteOne(filter);

            return ("you have deleted a team");
        }

        public List<ObjectModel> Category()
        {
            var map = new BsonJavaScript("function() { emit( this.league, 1 ); }");
            var reduce = new BsonJavaScript("function(key, values) {return Array.sum(values)}");

            var result = collection.MapReduce<ObjectModel>(map, reduce);

            return result.ToList();
        }
    }
}
