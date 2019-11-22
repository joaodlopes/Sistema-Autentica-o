using System;
namespace SistemaAutenticacao.Models
{
    public class user_tipouser
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public User IdUser { get; set; }
        public tipoUser IdTipoUser { get; set; }

    }
}
