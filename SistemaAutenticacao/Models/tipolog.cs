using System;
namespace SistemaAutenticacao.Models
{
    public class TipoLog
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UrlSrc { get; set; }


    }
}