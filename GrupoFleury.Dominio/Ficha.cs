using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testeGrupoFleuryAPI.Dominio
{
    public class Ficha
    {
        public int Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public Unidade Unidade { get; set; }
        public int UnidadeId { get; set; }
        public List<Item> itens { get; set; }

    }
}
