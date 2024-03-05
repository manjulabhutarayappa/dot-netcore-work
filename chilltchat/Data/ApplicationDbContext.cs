using chilltchat.Modal;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace chilltchat.Data
{
    public class ApplicationDbContext:DbContext
    {
       public DbSet<Registration> registration { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }
    }
}
