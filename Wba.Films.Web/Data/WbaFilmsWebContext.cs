using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wba.Films.Web.Models;

namespace Wba.Films.Web.Data
{
    public class WbaFilmsWebContext : DbContext
    {
        public WbaFilmsWebContext (DbContextOptions<WbaFilmsWebContext> options)
            : base(options)
        {
        }

        public DbSet<Wba.Films.Web.Models.Film> Film { get; set; } = default!;
    }
}
