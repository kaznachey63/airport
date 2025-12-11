using AirportApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataGridView.DataBaseStorage
{
    public class DataBaseContext : DbContext
    {
        /// <summary>
        /// Сущность <see cref="FlightModel"/>.
        /// </summary>
        public DbSet<FlightModel> Flights { get; set; } = null!;

        /// <summary>
        /// Создание экземпляра <see cref="DataBaseContext"/>.
        /// </summary>
        public DataBaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AirportDB;Trusted_Connection=True;");
            }
        }
    }
}