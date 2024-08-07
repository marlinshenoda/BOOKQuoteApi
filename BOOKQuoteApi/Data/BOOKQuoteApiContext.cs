using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BOOKQuoteApi.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BOOKQuoteApi.Data
{
    public class BOOKQuoteApiContext : IdentityDbContext<ApplicationUser>
    {
        public BOOKQuoteApiContext (DbContextOptions<BOOKQuoteApiContext> options)
            : base(options)
        {
        }

        public DbSet<BOOKQuoteApi.Entities.Book> Book { get; set; } = default!;
        public DbSet<BOOKQuoteApi.Entities.Quote> Quote { get; set; } = default!;
    }
}
