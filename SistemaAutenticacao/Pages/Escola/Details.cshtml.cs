using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SistemaAutenticacao.Data;
using SistemaAutenticacao.Models;

namespace SistemaAutenticacao.Pages.Escola
{
    public class DetailsModel : PageModel
    {
        private readonly SistemaAutenticacao.Data.SistemaAutenticacaoContext _context;

        public DetailsModel(SistemaAutenticacao.Data.SistemaAutenticacaoContext context)
        {
            _context = context;
        }

        public Models.Escola Escola { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Escola = await _context.Escola.FirstOrDefaultAsync(m => m.ID == id);

            if (Escola == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
