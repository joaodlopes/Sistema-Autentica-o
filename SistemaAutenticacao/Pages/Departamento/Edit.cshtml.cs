using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaAutenticacao.Data;
using SistemaAutenticacao.Models;

namespace SistemaAutenticacao.Pages.Departamento
{
    public class EditModel : PageModel
    {
        private readonly SistemaAutenticacao.Data.SistemaAutenticacaoContext _context;

        public EditModel(SistemaAutenticacao.Data.SistemaAutenticacaoContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Departamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartamentoExists(Departamento.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DepartamentoExists(int id)
        {
            return _context.Departamento.Any(e => e.ID == id);
        }
    }
}
