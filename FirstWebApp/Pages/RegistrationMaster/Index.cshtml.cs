using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstWebApp.DAL;
using FirstWebApp.Models;

namespace FirstWebApp.Pages.RegistrationMaster
{
    public class IndexModel : PageModel
    {
        private readonly FirstWebApp.DAL.AppDbContext _context;

        public IndexModel(FirstWebApp.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IList<Registration> Registration { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Registrations != null)
            {
                Registration = await _context.Registrations.ToListAsync();
            }
        }
    }
}
