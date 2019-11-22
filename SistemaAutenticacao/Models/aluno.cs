using System;

namespace SistemaAutenticacao.Models
{
    public class Aluno
    {

        public int ID { get; set; }
        public int numAluno { get; set; }
        public DateTime anoMatricula { get; set; }

        public Curso CursoID { get; set; }
        public User UserID { get; set; }

        public Curso Curso { get; set; }

        public User User { get; set; }

    }
}