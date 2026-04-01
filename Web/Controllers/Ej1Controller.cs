using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Web.Ej1;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{

    [HttpGet]
    public List<string> Get(string persona1, string persona2, string persona3)
    {
        Persona persona_uno = new Persona(persona1);
        Persona persona_dos = new Persona(persona2);
        Persona persona_tres = new Persona(persona3);

        return new List<string>
            {
                persona_uno.GetSaludo(),
                persona_dos.GetSaludo(),
                persona_tres.GetSaludo()
            };
    }
}