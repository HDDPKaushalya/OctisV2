
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;


namespace octisv2.Components.Data
{
    // Azure Database Connection
    public class AppDb : DbContext
    {
        static readonly string connectionString = "Server=localhost; Database=mastransport; Uid=root; Pwd=Dakshina@123@345;";


        public DbSet<Routed> Routed { get; set; }

        public DbSet<SeatCap> SeatCap { get; set; }
        public DbSet<MNroutes> NMNroutes { get; set; }
        public DbSet<DriverPool> DriverPool { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder
                .Entity<SeatCap>(
                eb =>
                {
                    eb.HasNoKey();
                });

            modelBuilder
                .Entity<MNroutes>(
                    eb =>
                    {
                        eb.HasNoKey();
                    });

            modelBuilder
                .Entity<Routed>(
                    eb =>
                    {
                        eb.HasKey("EPF");
                    });
            modelBuilder
                .Entity<DriverPool>(
                    eb =>
                    {
                        eb.HasKey("EPF");
                    });
        }
    }
}

