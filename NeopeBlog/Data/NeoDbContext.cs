using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Blog.Models.Domain;
using System.Reflection.Emit;

namespace NeopeBlog.Data
{
    public class NeoDbContext : DbContext
    {
        public NeoDbContext(DbContextOptions options) 
            : base(options)
        {
        }


        // ... configure other relationships
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
       




    }
}
