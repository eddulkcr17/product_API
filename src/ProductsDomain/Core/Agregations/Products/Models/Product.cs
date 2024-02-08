using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsDomain.Core.Agregations.Products.Models
{
  internal class Product
  {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public int Id { get; set; }
    public int UPC { get; set; }
    [BsonElement("productName")]
    public string ProductNmae { get; set; }
    [BsonElement("mfgr")]
    public string Mfgr { get; set; }
    [BsonElement("model")]
    public string Model { get; set; }
    [BsonElement("unitListPrice")]
    public double UnitListPrice { get; set; }
    [BsonElement("unitInStock")]
    public int UnitInStock { get; set; }
  }
}
