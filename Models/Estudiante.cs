using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Conexion_Mongo_Api.Models
{
    public class Estudiante
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("apellido")]
        public string Apellido { get; set; }

        [BsonElement("numeroIdentificacion")]
        public string NumeroIdentificacion { get; set; }

        [BsonElement("fechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [BsonElement("correo")]
        public string Correo { get; set; }

        [BsonElement("telefono")]
        public string Telefono { get; set; }
    }
}
