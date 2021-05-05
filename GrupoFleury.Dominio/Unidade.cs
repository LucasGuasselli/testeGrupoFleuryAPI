using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testeGrupoFleuryAPI.Dominio
{
    public class Unidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Ficha> fichas { get; set; }
    }
}
