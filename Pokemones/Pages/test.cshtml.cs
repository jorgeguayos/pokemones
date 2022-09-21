using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokemones.NEGOCIO;

namespace Pokemones.Pages
{
    public class testModel : PageModel
    {
        private readonly ICalculo _calculo;

        public testModel(ICalculo calculo)
        {
            _calculo = calculo;
           
        }
        [BindProperty]
        public int numero1 { get; set; }
        [BindProperty]
        public int numero2 { get; set; }
        [BindProperty]
        public int resultado { get; set; }
        public void OnGet()
        {
            //this.numero1 = 123;
            //this.numero2 = 321;
  
        }
        public void OnPost()
        { 
            var resultado = _calculo.Operacion(this.numero1, this.numero2);
        }
    }
    
}
