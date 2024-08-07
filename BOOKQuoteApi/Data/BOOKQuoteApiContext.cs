using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BOOKQuoteApi.Entities;

namespace BOOKQuoteApi.Data
{
    public class BOOKQuoteApiContext : DbContext
    {
        public BOOKQuoteApiContext (DbContextOptions<BOOKQuoteApiContext> options)
            : base(options)
        {
        }

        public DbSet<BOOKQuoteApi.Entities.Book> Book { get; set; } = default!;
    }
}
