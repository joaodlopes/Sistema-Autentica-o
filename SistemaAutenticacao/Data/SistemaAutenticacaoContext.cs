using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaAutenticacao.Models;

namespace SistemaAutenticacao.Data
{
    public class SistemaAutenticacaoContext : DbContext
    {
        public SistemaAutenticacaoContext (DbContextOptions<SistemaAutenticacaoContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaAutenticacao.Models.Escola> Escola { get; set; }

        public DbSet<SistemaAutenticacao.Models.Departamento> Departamento { get; set; }

        public DbSet<SistemaAutenticacao.Models.Curso> Curso { get; set; }

        public DbSet<SistemaAutenticacao.Models.User> User { get; set; }
    }
}
