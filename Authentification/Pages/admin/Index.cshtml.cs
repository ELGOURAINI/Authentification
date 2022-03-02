using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Authentification;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace Authentification.admin
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {

            if (HttpContext.User.Identity.IsAuthenticated) return Redirect("./admin/Livres");
            return Page();
        }
        public async Task<IActionResult> OnPost(string username, string password, string ReturnUrl)
        {
             if (username == "admin") { 
             var claims = new List<Claim>
             {
                new Claim(ClaimTypes.Name, username)
             };
            var claimsIdentity = new ClaimsIdentity(claims, "Login");
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.
            AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            return Redirect(ReturnUrl == null ? "/admin/Livres" : ReturnUrl);
            }
            return Page();
        }
    }
}
