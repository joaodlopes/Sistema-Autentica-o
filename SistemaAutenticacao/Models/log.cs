using System;
namespace SistemaAutenticacao.Models
{
    public class Log
    {
        public int ID { get; set; }
        public DateTime CreatedOn { get; set; }

        public TipoLog IdTipoLog { get; set; }


    }

}
