using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokemones.NEGOCIO;

namespace Pokemones.Pages
{
    public class testModel : PageModel
    {
        [BindProperty]
        public int numero1 { get; set; }
        [BindProperty]
        public int numero2 { get; set; }
        [BindProperty]
        public int? resultado { get; set; }
        public void OnGet()
        {
            //this.numero1 = 123;
            //this.numero2 = 321;
  
        }
        public void OnPost()
        {
            var calculo = new calculo();
            var resultado = calculo.operacion(this.numero1, this.numero2);
        }
    }
    
}
