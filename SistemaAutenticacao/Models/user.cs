using System;
namespace SistemaAutenticacao.Models
{
    public class User
    {
        public int ID { get; set; }
        public int IdTipoUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public int Nif { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }


    }
}