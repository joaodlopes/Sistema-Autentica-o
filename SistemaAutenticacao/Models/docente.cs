using System;
namespace SistemaAutenticacao.Models
{
    public class Docente
    {
        public int ID { get; set; }

        public AreaCientifica AreaCientificaID { get; set; }
        public User UserID { get; set; }

    }
}