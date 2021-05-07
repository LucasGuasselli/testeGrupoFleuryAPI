using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testeGrupoFleuryAPI.Dominio;
using testeGrupoFleuryAPI.Reporitory;

namespace testeGrupoFleuryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoredProcedureController : Controller
    {
               
       public readonly FichaContext _context;
       public StoredProcedureController(FichaContext context)
       {
          _context = context;
       }

       // GET: api/<ClienteController>
       [HttpGet]
       public ActionResult Get()
       {
           var storedprocedures = _context.StoredProcedures.FromSqlRaw($"EXEC consultaLista5");
              return Ok(storedprocedures);
       }


    /*
        // SOMENTE PARA TESTE

        // GET: api/<ClienteController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var cliente = new Cliente { Nome = "Lucas"};
            using (var contexto = new FichaContext())
            {
                contexto.Clientes.Add(cliente);
                    contexto.SaveChanges();
            }
            return Ok();
        }
    */
    }
}


