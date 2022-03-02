using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Authentification;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
namespace Authentification.Pages.admin
{
    public class Logout : PageModel
    {
        public IActionResult OnGet()
        {
            if (!HttpContext.User.Identity.IsAuthenticated) return Redirect("/admin");
            HttpContext.SignOutAsync();
            return Redirect("/admin");
        }
    }
}
