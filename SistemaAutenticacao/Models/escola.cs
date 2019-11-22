using System;
namespace SistemaAutenticacao.Models
{
    public class Escola
    {

        public int ID { get; set; }
        public string Nome { get; set; }
        public int Nif { get; set; }
        public string Email { get; set; }
        public string Abreviatura { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }

        public Departamento[] Departamento { get; set; }

    }
}