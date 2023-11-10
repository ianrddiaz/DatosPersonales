using DatosPersonales.bdd.data;
using DatosPersonales.bdd.data.entity;
using DatosPersonales.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DatosPersonales.Server.Controllers
{
    [ApiController]
    [Route("api/personas")]
    public class PersonasController : ControllerBase
    {
        private readonly Context context;

        public PersonasController(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Persona>>> Get()
        {
            return await context.Personas.ToListAsync();

        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(PersonaDTO personaDTO)
        {
            Persona entidad = new Persona();
            entidad.Nombre = personaDTO.Nombre;
            entidad.Apellido = personaDTO.Apellido;
            entidad.Edad = personaDTO.Edad;
            entidad.Domicilio = personaDTO.Domicilio;
            context.Personas.Add(entidad);
            await context.SaveChangesAsync();
            return entidad.Id;
        }
}
}
