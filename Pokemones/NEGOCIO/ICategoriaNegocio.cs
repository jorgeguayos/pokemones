using Pokemones.DATOS.Entidades;
using Pokemones.DTO;

namespace Pokemones.NEGOCIO
{
    public interface ICategoriaNegocio
    {
        List<CategoriaDTO> ObtenerCategorias();
        void CrearCategoria(CategoriaDTO categoriaDTO);
        CategoriaDTO ObtenerCategoriaPorId(int id);
        void ActualizarCategoria(CategoriaDTO categoriaDTO);
        void EliminarCategoria(int id);
    }
}
