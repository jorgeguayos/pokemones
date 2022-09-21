using System.Data.SqlClient;

namespace Pokemones.DATOS.Entidades.Repositorios
{
    public class PersonajeRepositorio
    {
        private readonly IConfiguration _configuration;

        public PersonajeRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Personaje> ObtenerTodos()
        {
            var ListaPersonajes = new List<Personaje>();
            using SqlConnection sql = new SqlConnetion(_configuration.GetConnectionString("conexionPorDefecto"));
            using SqlCommand cmd = new SqlCommand("sp_obtener_personajes", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            sql.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nuevaPersonaje = new Personaje { Id = (int)reader["Id"], Nombre = reader["Nombre"].ToString(),FechaNacimiento= (DateTime)reader["FechaNacimiento"],Categoria= reader["Categoria"].ToString() };
                    ListaPersonajes.Add(nuevaPersonaje);
                }
            }

            return ListaPersonajes;
        }
    }
}
