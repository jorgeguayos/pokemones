using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokemones.DTO;
using Pokemones.NEGOCIO;
using System.ComponentModel.DataAnnotations;

namespace Pokemones.Pages
{
    public class nueva_categoriaModel : PageModel
    {
        private readonly ICategoriaNegocio _categoriaNegocio;

        public nueva_categoriaModel(ICategoriaNegocio categoriaNegocio)
        {
            _categoriaNegocio = categoriaNegocio;
        }

        [BindProperty]
        [Required (ErrorMessage ="El campo nombre es requerido")]
        public string Nombre { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var categoriaDTO = new CategoriaDTO { Nombre = Nombre };
                _categoriaNegocio.CrearCategoria(categoriaDTO);
                return RedirectToPage("./categorias");
            }

            return Page();
        }
    }
}
