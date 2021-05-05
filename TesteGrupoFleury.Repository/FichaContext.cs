using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeGrupoFleuryAPI.Dominio;

namespace testeGrupoFleuryAPI.Reporitory
{
    public class FichaContext: DbContext
    {
        public FichaContext(DbContextOptions<FichaContext> options): base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ficha> Fichas { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Item> Itens { get; set; }        

    }
}
