using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentification.Pages
{
    public class PrivacyModel : PageModel
    {
        DataContext dataContext;
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger, DataContext data)
        {
            _logger = logger;
            dataContext = data;
        }

        public void OnGet()
        {
            var Livre = new Livre() { Nom = "Livre" };
            dataContext.Livres.Add(Livre);
            dataContext.SaveChanges();
        }
    }
}
