using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoPortfolio
{
    class TeamModel
    {
        [BsonId]
        public ObjectId  _id { get; set; }
        [BsonElement("teamName")]
        public string TeamName { get; set; }
        [BsonElement("numberOfPlayers")]
        public int NumberOfPlayers { get; set; }
        [BsonElement("league")]
        public string League { get; set; }
    }
}
