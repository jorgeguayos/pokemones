using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokemones.NEGOCIO;

namespace Pokemones.Pages
{
    public class personasModel : PageModel
    {
        public string Saludo1 { get; set; }
        public string Saludo2 { get; set; }
        public void OnGet()
        {
           // Instaciamos objetos de clase persona
             var persona1 = new Persona();
            persona1.Nombre = "Ash";
            persona1.Altura = 1.7f;
            persona1.Peso = 70;
            persona1.Edad = 27;
            var persona2 = new Persona { Nombre = "Misty", Altura = 1.5f, Edad = 22, Peso = 55 };
            var saludoPersona1 = persona1.Presentarse();
            var saludoPersona2 = persona2.Presentarse();
            Saludo1 = saludoPersona1;
            Saludo2 = saludoPersona2;
        }
    }
}
