using Pokemones.DATOS.Entidades;
using Pokemones.DATOS.Repositorios;
using Pokemones.DTO;

namespace Pokemones.NEGOCIO
{
    public class CategoriaNegocio : ICategoriaNegocio
    {
        private readonly IcategoriasRepositorio _categoriaRepositorio;

        public CategoriaNegocio(IcategoriasRepositorio CategoriaRepositorio)
        {
          _categoriaRepositorio = CategoriaRepositorio;
        }
        public List<CategoriaDTO> ObtenerCategorias()
        {
            var ListaCategoriasDTO = new List<CategoriaDTO>();
            var listaCategoriasEntidades = _categoriaRepositorio.ObtenerTodas();
            foreach (var categoria in listaCategoriasEntidades)
            {
                var categoriaDTO = new CategoriaDTO { Id = categoria.Id, Nombre = categoria.Nombre };
                ListaCategoriasDTO.Add(categoriaDTO);
            }

            return ListaCategoriasDTO;
         }
        public void CrearCategoria(CategoriaDTO categoriaDTO)
        {
            Categoria categoria = new Categoria { Nombre = categoriaDTO.Nombre };
            _categoriaRepositorio.CrearCategoria(categoria);
        }
        public CategoriaDTO ObtenerCategoriaPorId(int id)
        {
            var categoria = _categoriaRepositorio.ObtenerpoId(id);
            CategoriaDTO categoriaDTO = new CategoriaDTO { Id = categoria.Id, Nombre = categoria.Nombre };
            return categoriaDTO;
        }
        public void ActualizarCategoria(CategoriaDTO categoriaDTO)
        {
            Categoria categoria = new Categoria { Id = categoriaDTO.Id, Nombre = categoriaDTO.Nombre };
            _categoriaRepositorio.ActualizarCategoria(categoria);
        }
        public void EliminarCategoria(int id)
        {
            _categoriaRepositorio.EliminarCategoria(id);
        }
    }
}
