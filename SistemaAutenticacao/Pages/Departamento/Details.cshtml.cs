using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SistemaAutenticacao.Data;
using SistemaAutenticacao.Models;

namespace SistemaAutenticacao.Pages.Departamento
{
    public class DetailsModel : PageModel
    {
        private readonly SistemaAutenticacao.Data.SistemaAutenticacaoContext _context;

        public DetailsModel(SistemaAutenticacao.Data.SistemaAutenticacaoContext context)
        {
            _context = context;
        }

        public Models.Departamento Departamento { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Departamento = await _context.Departamento.FirstOrDefaultAsync(m => m.ID == id);

            if (Departamento == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
