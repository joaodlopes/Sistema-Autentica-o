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

namespace SistemaAutenticacao.Pages.Escola
{
    public class EditModel : PageModel
    {
        private readonly SistemaAutenticacao.Data.SistemaAutenticacaoContext _context;

        public EditModel(SistemaAutenticacao.Data.SistemaAutenticacaoContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Escola).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EscolaExists(Escola.ID))
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

        private bool EscolaExists(int id)
        {
            return _context.Escola.Any(e => e.ID == id);
        }
    }
}
