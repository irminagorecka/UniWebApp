using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FirstWebApp.DAL;
using FirstWebApp.Models;

namespace FirstWebApp.Pages.RegistrationMaster
{
    public class CreateModel : PageModel
    {
        private readonly FirstWebApp.DAL.AppDbContext _context;


        public CreateModel(FirstWebApp.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Registration Registration { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            
            if (!ModelState.IsValid || _context.Registrations == null || Registration == null)
            {
               return Page();
                
            }

            _context.Registrations.Add(Registration);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Success");
           
        }
    }
}
