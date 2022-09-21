using Pokemones.DATOS.Entidades;

namespace Pokemones.DATOS.Repositorios
{
    public interface IcategoriasRepositorio
    {
        List<Categoria> ObtenerTodas();
        void CrearCategoria(Categoria categoria);
        Categoria ObtenerpoId(int Id);
        void ActualizarCategoria(Categoria categoria);
        void EliminarCategoria(int id);
    }
}
