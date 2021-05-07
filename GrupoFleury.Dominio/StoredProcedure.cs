using System;
using System.Collections.Generic;
using System.Text;

namespace testeGrupoFleuryAPI.Dominio
{
    public class StoredProcedure
    {

        public int Id { get; set; }
        public string UnidadeNome { get; set; }
        public int UnidadeId { get; set; }
        public int FichaId { get; set; }
        public DateTime DataAtendimento { get; set; }
        public string ClienteNome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNasc { get; set; }
        public int IdSubItem { get; set; }
        public string SiglaExame { get; set; }


    }
}
