using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Authentification;
using Microsoft.AspNetCore.Authorization;

namespace Authentification.Pages.admin.Livres
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly Authentification.DataContext _context;

        public DetailsModel(Authentification.DataContext context)
        {
            _context = context;
        }

        public Livre Livre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Livre = await _context.Livres.FirstOrDefaultAsync(m => m.LivreID == id);

            if (Livre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
