using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyWebAPP.Models;

namespace MyWebAPP.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Category_ID = 1, Category_Name = "IPhone", Display_Order = 2 },
                new Category { Category_ID=2,Category_Name="RedMi",Display_Order=1},
                new Category { Category_ID=3,Category_Name="OPPO",Display_Order=3}
         );
        }

        }
}
