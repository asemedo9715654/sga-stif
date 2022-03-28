

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sga_stif.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {

        private readonly ContextoBaseDados _context;

        public NavigationMenuViewComponent(ContextoBaseDados context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // var items = await _context.Menu(HttpContext.User);
            var items = await _context.Menu.ToListAsync();

            return View(items);
        }




    }
}