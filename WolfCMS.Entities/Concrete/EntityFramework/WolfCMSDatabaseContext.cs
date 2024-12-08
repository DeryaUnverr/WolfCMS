using Microsoft.EntityFrameworkCore;

namespace WolfCMS.Entities.Concrete.EntityFramework
{
    public class WolfCMSDatabaseContext :DbContext
    {

        //private readonly IConfiguration _configuration;

        //public WolfCMSDatabaseContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer(@"Server=DeryaUnver\SQLEXPRESS; Database=WolfCMSDatabase; Trusted_Connection=True; TrustServerCertificate=True");
        //    optionsBuilder.UseSqlServer(@"Server=DeryaUnver\SQLEXPRESS; Database=WolfCMSDatabase; Trusted_Connection=True;");

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DeryaUnver\\SQLEXPRESS; Database=WolfCMSDatabase; Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

    }
}
