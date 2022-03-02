﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Authentification;
using Microsoft.AspNetCore.Authorization;

namespace Authentification.Pages.admin.Livres
{
    [Authorize]
    public class CreateModel : PageModel
    {

        private readonly Authentification.DataContext _context;

        public CreateModel(Authentification.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Livre Livre { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Livres.Add(Livre);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
