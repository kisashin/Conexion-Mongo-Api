using MongoDB.Driver;
using Microsoft.Extensions.Options;
using Conexion_Mongo_Api.Models;

namespace Conexion_Mongo_Api.Services
{
    public class EstudianteService
    {
        private readonly IMongoCollection<Estudiante> _estudiantesCollection;

        public EstudianteService(IOptions<EstudiantesDBSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _estudiantesCollection = database.GetCollection<Estudiante>(settings.Value.EstudiantesCollectionName);
        }

        public async Task CreateAsync(Estudiante nuevoEstudiante)
        {
            await _estudiantesCollection.InsertOneAsync(nuevoEstudiante);
        }
    }
}
