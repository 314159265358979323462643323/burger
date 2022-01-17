using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WilliamToddSite.Models
{
    public class ForumContext : DbContext
    {
        public ForumContext(DbContextOptions<ForumContext> options)
            : base(options) { }

        public DbSet<ForumModel> Forum { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ForumModel>().HasData(
                new ForumModel
                {
                    CommentId = 1,
                    Page = "Home",
                    Rating = 5,
                    Text = "this is asample comment",
                    Name = "William Todd"
                }
            ); 
        }
    }
}
