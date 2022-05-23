using Microsoft.EntityFrameworkCore;

namespace mvc_web_app.Models {
    public class DBManager : DbContext {
        
        public DBManager(DbContextOptions options) : base(options) {

        }

        public DbSet<Anticafe>? Anticafes { get; set; }
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<AppUser>? AppUsers { get; set; }

    }
}