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
    public class IndexModel : PageModel
    {
        private readonly Authentification.DataContext _context;

        public IndexModel(Authentification.DataContext context)
        {
            _context = context;
        }

        public IList<Livre> Livre { get;set; }

        public async Task OnGetAsync()
        {
            Livre = await _context.Livres.ToListAsync();
        }
    }
}
