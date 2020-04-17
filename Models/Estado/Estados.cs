using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioTiago.Models
{
    public class Estados
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public List<Estados> ListarEstados()
        {
            return new List<Estados>
            {
                new Estados {ID=1, Nome = "São Paulo", Sigla="SP"},
                new Estados {ID=2, Nome = "Minas Gerais", Sigla="MG"},
                new Estados {ID=3, Nome = "Goiás", Sigla="GO"},
                new Estados {ID=4, Nome = "Amazonas", Sigla="AM"}                
            };
        }
    }
}