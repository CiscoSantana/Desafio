using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioTiago.Models
{
    public class Cidades
    {
        public int ID { get; set; }
        public int IDEstado { get; set; }
        public string Nome { get; set; }

        public List<Cidades> ListarCidades(bool vazio)
        {
            if (vazio)
            {
                return new List<Cidades>();
            }
            return new List<Cidades>()
            {
                new Cidades {ID = 1, IDEstado = 1, Nome = "São José dos Campos"},
                new Cidades {ID = 2, IDEstado = 1, Nome = "Jacareí"},
                new Cidades {ID = 3, IDEstado = 1, Nome = "Caçapava"},
                new Cidades {ID = 4, IDEstado = 1, Nome = "Taubaté"},
                new Cidades {ID = 5, IDEstado = 2, Nome = "Abadia dos Dourados"},
                new Cidades {ID = 6, IDEstado = 2, Nome = "Betim"},
                new Cidades {ID = 7, IDEstado = 2, Nome = "Campanhas"},
                new Cidades {ID = 8, IDEstado = 3, Nome = "Jataí"},
                new Cidades {ID = 9, IDEstado = 3, Nome = "Catalão"},
                new Cidades {ID = 10, IDEstado = 3, Nome = "Formosa"},
                new Cidades {ID = 11, IDEstado = 4, Nome = "Manaus"},
                new Cidades {ID = 11, IDEstado = 4, Nome = "Parintins"},
                new Cidades {ID = 11, IDEstado = 4, Nome = "Humaitá"},

            };
        }
    }
}