using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testeGrupoFleuryAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public int RG { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNasc { get; set; }

    }
}
