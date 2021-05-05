using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testeGrupoFleuryAPI.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int IdSubItem { get; set; }
        public string SiglaExame { get; set; }
        public Ficha Ficha { get; set; }
        public int FichaId { get; set; }

    }
}
