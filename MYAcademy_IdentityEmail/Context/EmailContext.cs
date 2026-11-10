using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MYAcademy_IdentityEmail.Entities;

namespace MYAcademy_IdentityEmail.Context
{
    public class EmailContext:IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS01;initial catalog=IdentityEmailDbNight;integrated security=true;trustservercertificate=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Message> Messages { get; set; }
        
    }

}
