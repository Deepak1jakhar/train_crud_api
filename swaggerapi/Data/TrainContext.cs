using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using swaggerapi.Models;
using System;

namespace swaggerapi.Data
{
    public class TrainContext : DbContext
    {
        public TrainContext(DbContextOptions<TrainContext> options) : base(options)
        {

        }

        public DbSet<Train> trains { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Train>().HasData(
                new Train
                {
                    trainId = 12131,
                    trainName = "Vande Bharat",
                    from = "Pune",
                    to = "Mumbai"
                },
                new Train
                {
                    trainId = 12132,
                    trainName = "Vande Bharat",
                    from = "Mumbai",
                    to = "Pune"
                },
                new Train
                {
                    trainId = 12732,
                    trainName = "Sarbat Da Bhala",
                    from = "Delhi",
                    to = "Jalandhar"
                },
                new Train
                {
                    trainId = 12535,
                    trainName = "Kathgodam Express",
                    from = "Uk",
                    to = "Delhi"
                }
                );
        }
    }
}
