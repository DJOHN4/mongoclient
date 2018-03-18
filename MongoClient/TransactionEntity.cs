using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoClientTool
{
    public class Transactions : Entity
    {
        public string TransactionType { get; set; }
        public string Symbol { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CreatedDate { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime ModifiedDate { get; set; }
        public string TransactionData { get; set; }
        public Int32 TransactionCount { get; set; }
        public string Strategy { get; set; }
        public string Exchange { get; set; }
        public string Market { get; set; }

        public Transactions()
        {

        }
    }
}
