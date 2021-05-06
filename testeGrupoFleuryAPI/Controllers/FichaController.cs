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
    public class FichaController : Controller
    {
               
       public readonly FichaContext _context;
       public FichaController(FichaContext context)
       {
          _context = context;
       }

       // GET: api/<FichaController>
       [HttpGet]
       public ActionResult Get()
       {
           var fichas = _context.Fichas.ToList();
              return Ok(fichas);
       }


    /*
        //USADO SOMENTE PARA TESTE

        // GET: api/<FichaController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var ficha = new Ficha { DataNascimento = DateTime.Now , ClienteId = 1, UnidadeId = 2};
            using (var contexto = new FichaContext())
            {
                contexto.Fichas.Add(ficha);
                    contexto.SaveChanges();
            }
            return Ok();
        }
    */

    }
}
