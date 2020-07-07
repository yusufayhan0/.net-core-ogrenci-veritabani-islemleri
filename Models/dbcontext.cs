
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Models

{
    public class dbcontext:DbContext
    {
        public DbSet<ogrenciler> ogrencilers {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Filename=./db/yusuf.db");
        }
    }
    
}