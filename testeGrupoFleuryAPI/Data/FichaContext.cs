using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeGrupoFleuryAPI.Models;

namespace testeGrupoFleuryAPI.Data
{
    public class FichaContext: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ficha> Fichas { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Item> Itens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=123456;Persist Security Info=True;User ID=sa;Initial Catalog=FichaApp;Data Source=GUASSELLI-PC\\SQLEXPRESS");
        }

    }
}
