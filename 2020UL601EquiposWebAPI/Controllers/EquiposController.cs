using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _2020UL601EquiposWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace _2020UL601EquiposWebAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        private readonly PrestamosContext _contexto;

        public EquiposController(PrestamosContext mycontext)
        {
            this._contexto=mycontext;
        }

        [HttpGet]
        [Route("api/equipos")]
        public IActionResult Get()
        {
            IEnumerable<Equipos> equiplist = from e in _contexto.equipos select e;

            if (equiplist.Count()>0)
            {
                return Ok(equiplist);
            }

            return NotFound();
        }

        //[HttpGet]
        //[Route("api/equipos/{idequipo}")]
        //public IActionResult Get(int idequipo)
        //{

        //    Equipos equiplist = (from e in _contexto.equipos where e.id_equipos==idequipo select e).FirstOrDefault();

        //    if (equiplist!=null)
        //    {
        //        return Ok(equiplist);
        //    }

        //    return NotFound();
        //}

    }
}
