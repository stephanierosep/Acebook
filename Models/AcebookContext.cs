using System;
using Microsoft.EntityFrameworkCore;

namespace Acebook.Models
{
    public class AcebookContext : DbContext
    {
        public AcebookContext(DbContextOptions<AcebookContext> options) : base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }
    }
}
