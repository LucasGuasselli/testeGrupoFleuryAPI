﻿using System;
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

       // GET: api/<UnidadeController>
       [HttpGet]
       public ActionResult Get()
       {
           var unidades = _context.Unidades.ToList();
              return Ok(unidades);
       }

    /*
        //SOMENTE PARA TESTE

        // GET: api/<UnidadeController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var unidade = new Unidade { Nome = "Nilo" };
            using (var contexto = new FichaContext())
            {
                contexto.Unidades.Add(unidade);
                    contexto.SaveChanges();
            }
            return Ok();
        }
    */
    }
}
