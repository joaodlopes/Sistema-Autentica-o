using System;
namespace SistemaAutenticacao.Models
{
    public class tipoUser
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }

        public user_tipouser User_tipoUser { get; set; }

    }
}