using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testeGrupoFleuryAPI.Dominio;
using testeGrupoFleuryAPI.Reporitory;

namespace testeGrupoFleuryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadeController : Controller
    {
               
       public readonly FichaContext _context;
       public UnidadeController(FichaContext context)
       {
          _context = context;
       }

       // GET: api/<ClienteController>
       [HttpGet]
       public ActionResult Get()
       {
           var Unidades = _context.Unidades.ToList();
              return Ok(Unidades);
       }        

    }
}
