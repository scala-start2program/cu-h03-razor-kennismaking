using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wba.Films.Web.Data;
using Wba.Films.Web.Models;

namespace Wba.Films.Web.Pages.Film
{
    public class CreateModel : PageModel
    {
        private readonly Wba.Films.Web.Data.WbaFilmsWebContext _context;

        public CreateModel(Wba.Films.Web.Data.WbaFilmsWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Wba.Films.Web.Models.Film Film { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Film == null || Film == null)
            {
                return Page();
            }

            _context.Film.Add(Film);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
