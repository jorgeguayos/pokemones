using System.Data.SqlClient;

namespace Pokemones.DATOS.Entidades.Repositorios
{
    internal class SqlConnetion
    {
        private string v;

        public SqlConnetion(string v)
        {
            this.v = v;
        }

        public static implicit operator SqlConnection(SqlConnetion v)
        {
            throw new NotImplementedException();
        }
    }
}