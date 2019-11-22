using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAutenticacao.Models
{
    public class Departamento
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Abreviatura { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }

        public AreaCientifica[] AreaCientifica { get; set; }

        public User CoordenadorID { get; set; }
        
        public User SubCoordenadorID { get; set; }
        
        public User SecretarioID { get; set; }
        public Escola IdEscola { get; set; }

    }
}