using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokemones.DATOS.Entidades;
using Pokemones.DTO;
using Pokemones.NEGOCIO;

namespace Pokemones.Pages
{
    public class CategoriasModel : PageModel
    {
        public List<CategoriaDTO> Categoria { get; set; }
        private readonly ICategoriaNegocio _categoriaNegocio;

        public CategoriasModel(ICategoriaNegocio categoriaNegocio)
        {
            _categoriaNegocio = categoriaNegocio;
        }
       
        public void OnGet()
        {
            Categoria = _categoriaNegocio.ObtenerCategorias();
        }
    }
}
