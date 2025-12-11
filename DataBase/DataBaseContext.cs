using System.Collections.Generic;
using System.Reflection.Emit;
using AirportApp.Constants;
using AirportApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataGridView.DataBaseStorage
{
    public class DataBaseContext : DbContext
    {
        /// <summary>
        /// Сущность <see cref="FlightModel"/>.
        /// </summary>
        public DbSet<FlightModel> Flights { get; set; }

        /// <summary>
        /// Создаёт экземпляр <see cref="DataBaseContext"/>.
        /// </summary>
        public DataBaseContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(
            @"Server=(localdb)\mssqllocaldb;Database=AirportDB;Trusted_Connection=True;");
    }
}