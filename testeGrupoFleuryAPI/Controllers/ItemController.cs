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
    public class ItemController : Controller
    {
               
       public readonly FichaContext _context;
       public ItemController(FichaContext context)
       {
          _context = context;
       }

       // GET: api/<ItemController>
       [HttpGet]
       public ActionResult Get()
       {
           var itens = _context.Itens.ToList();
              return Ok(itens);
       }

        /*
         
        //USADO SOMENTE PARA TESTE

        // GET: api/<ItemController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var item = new Item { SiglaExame = "PCR", FichaId = 1};
            using (var contexto = new FichaContext())
            {
                contexto.Itens.Add(item);
                    contexto.SaveChanges();
            }
            return Ok();
        }
        */

    }
}
