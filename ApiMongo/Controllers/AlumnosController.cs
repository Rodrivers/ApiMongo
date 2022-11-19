using ApiMongo.Models;
using ApiMongo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZstdSharp.Unsafe;

namespace ApiMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        public EscuelaServices _alumnoService;

        public AlumnosController(EscuelaServices alumnoService)
        {
            _alumnoService = alumnoService;

        }
        [HttpPost]

        public ActionResult<Alumnos> Create(Alumnos alumnos)
        {
            _alumnoService.Create(alumnos);
            return Ok();

        }
        [HttpPut]

        public ActionResult Update(Alumnos alumnos)
        {
            _alumnoService.Update(alumnos.Id, alumnos);
            return Ok();
        }

        [HttpDelete("(id)")]

        public ActionResult Delete(string id)
        {
            _alumnoService.Delete(id);
            return Ok();

        }
    }
}
