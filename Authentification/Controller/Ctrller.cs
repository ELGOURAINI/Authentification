using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Authentification.Controller
{
    [Route("api/controller")]
    [ApiController]
    public class Ctrller : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ILogger<Livre> logger;

        public Ctrller(DataContext data , ILogger<Livre> logg)
        {
            logger = logg;
            _context = data;
        }
        public IList<Livre>  Get()
        {
            logger.LogInformation(" executing ..... ");
            return _context.Livres.ToList();
        }
    }
}