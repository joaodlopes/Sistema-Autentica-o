using System;
namespace SistemaAutenticacao.Models
{
    public class Curso
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }

        public Escola IdEscola { get; set; }

    }
}