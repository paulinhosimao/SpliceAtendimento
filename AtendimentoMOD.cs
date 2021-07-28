using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpliceAtendimentoWebAPI.Models
{
    public class AtendimentoMOD
    {
        public Int32 codigo { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public string veiculo { get; set; }
        public string operador { get; set; }
        public Boolean finalizado { get; set; }


    
}
}