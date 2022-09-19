using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace TrululuGomitas.Pages_Gomitas
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public DeleteModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Gomita Gomita { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Gomita == null)
            {
                return NotFound();
            }

            var gomita = await _context.Gomita.FirstOrDefaultAsync(m => m.ID == id);

            if (gomita == null)
            {
                return NotFound();
            }
            else 
            {
                Gomita = gomita;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Gomita == null)
            {
                return NotFound();
            }
            var gomita = await _context.Gomita.FindAsync(id);

            if (gomita != null)
            {
                Gomita = gomita;
                _context.Gomita.Remove(Gomita);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
