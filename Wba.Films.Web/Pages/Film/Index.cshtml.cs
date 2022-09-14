using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wba.Films.Web.Data;
using Wba.Films.Web.Models;

namespace Wba.Films.Web.Pages.Film
{
    public class IndexModel : PageModel
    {
        private readonly Wba.Films.Web.Data.WbaFilmsWebContext _context;

        public IndexModel(Wba.Films.Web.Data.WbaFilmsWebContext context)
        {
            _context = context;
        }

        public IList<Wba.Films.Web.Models.Film> Film { get;set; } = default!;

        //public void OnGet()
        //{
        //    if (_context.Film != null)
        //    {
        //        Film =  _context.Film.ToList();
        //    }
        //}
        public async Task OnGetAsync()
        {
            Film = await _context.Film.ToListAsync();
        }

    }
}
