using System.Collections.Generic;

namespace TesteJson.Models
{
    public class CanalDeAtendimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }    

    public class BuildListCanalDeAtendimento
    {    
        public List<CanalDeAtendimento> ListaCanais { get; set; }
        public BuildListCanalDeAtendimento()
        {
            ListaCanais = new List<CanalDeAtendimento>();
            ListaCanais.Add(new CanalDeAtendimento(){Id = 1, Nome = "NomeCanal-1", Telefone = "1111-1111"});
            ListaCanais.Add(new CanalDeAtendimento(){Id = 2, Nome = "NomeCanal-2", Telefone = "2222-2222"});
            ListaCanais.Add(new CanalDeAtendimento(){Id = 2, Nome = "NomeCanal-2", Telefone = "2222-2222"});
            ListaCanais.Add(new CanalDeAtendimento(){Id = 3, Nome = "NomeCanal-3", Telefone = "3333-3333"});
            ListaCanais.Add(new CanalDeAtendimento(){Id = 3, Nome = "NomeCanal-3", Telefone = "3333-3333"});
            ListaCanais.Add(new CanalDeAtendimento(){Id = 3, Nome = "NomeCanal-3", Telefone = "3333-3333"});
            ListaCanais.Add(new CanalDeAtendimento(){Id = 4, Nome = "NomeCanal-4", Telefone = "4444-4444"});
        }
    }
}

