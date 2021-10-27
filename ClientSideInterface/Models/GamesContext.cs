using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClientSideInterface.Models
{
    public class GamesContext : DbContext
    {
        public GamesContext(DbContextOptions<GamesContext> options)
            : base(options)
        { }

        public DbSet<GamesModel> Games { get; set; }
        public DbSet<SystemModel> System { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamesModel>().HasData(
                 new GamesModel
                 {
                     ID = 1,
                     SystemID = 1,
                     Title = "Mario Kart 8",
                     Genere = "Sport",
                     Rating = "E"
                 },
                 new GamesModel
                 {
                     ID = 2,
                     SystemID = 2,
                     Title = "Halo",
                     Genere = "Action",
                     Rating = "M"
                 },
                 new GamesModel
                 {
                     ID = 3,
                     SystemID = 3,
                     Title = "Candy Crush",
                     Genere = "Casual",
                     Rating = "E"
                 },
                 new GamesModel
                 {
                     ID = 4,
                     SystemID = 4,
                     Title = "Microsoft Flight Simulatior",
                     Genere = "Simulation",
                     Rating = "E"
                 },
                 new GamesModel
                 {
                     ID = 5,
                     SystemID = 5,
                     Title = "Assasins Creed",
                     Genere = "Role-Playing",
                     Rating = "M"
                 },
                 new GamesModel
                 {
                     ID = 6,
                     SystemID = 4,
                     Title = "Civilization",
                     Genere = "Strategy",
                     Rating = "E 10+"
                 },
                 new GamesModel
                 {
                     ID = 7,
                     SystemID = 5,
                     Title = "Far Cry 6",
                     Genere = "Action",
                     Rating = "M"
                 },
                 new GamesModel
                 {
                     ID = 8,
                     SystemID = 4,
                     Title = "Back 4 Blood",
                     Genere = "Action",
                     Rating = "M"
                 },
                 new GamesModel
                 {
                     ID = 9,
                     SystemID = 4,
                     Title = "Minecraft",
                     Genere = "Casual",
                     Rating = "E"
                 },
                 new GamesModel
                 {
                     ID = 10,
                     SystemID = 1,
                     Title = "Super Mario Party",
                     Genere = "Casual",
                     Rating = "E"
                 },
                 new GamesModel
                 {
                     ID = 11,
                     SystemID = 2,
                     Title = "The Witcher 3: Wild Hunt",
                     Genere = "Role-Playing",
                     Rating = "M"
                 },
                 new GamesModel
                 {
                     ID = 12,
                     SystemID = 4,
                     Title = "Fallout: New Vegas",
                     Genere = "Role-Playing",
                     Rating = "M"
                 },
                 new GamesModel
                 {
                     ID = 13,
                     SystemID = 4,
                     Title = "Cities: Skylines",
                     Genere = "Simulation",
                     Rating = "E"
                 },
                 new GamesModel
                 {
                     ID = 14,
                     SystemID = 4,
                     Title = "Kerbal Space Program",
                     Genere = "Simulation",
                     Rating = "E"
                 },
                 new GamesModel
                 {
                     ID = 15,
                     SystemID = 2,
                     Title = "FIFA 21",
                     Genere = "Sport",
                     Rating = "E"
                 },
                 new GamesModel
                 {
                     ID = 16,
                     SystemID = 5,
                     Title = "NBA 2K21",
                     Genere = "Sport",
                     Rating = "E"
                 },
                 new GamesModel
                 {
                     ID = 17,
                     SystemID = 4,
                     Title = "Europa Universalis 4",
                     Genere = "Strategy",
                     Rating = "T"
                 },
                 new GamesModel
                 {
                     ID = 18,
                     SystemID = 4,
                     Title = "Sins of a Solar Empire",
                     Genere = "Strategy",
                     Rating = "T"
                 }

                );
            modelBuilder.Entity<SystemModel>().HasData(
              new SystemModel
              {
                  SystemID = 1,
                  Brand = "Nintendo",
                  Name = "Switch"
              },
              new SystemModel
              {
                  SystemID = 2,
                  Brand = "Microsoft",
                  Name = "XBox"
              },
              new SystemModel
              {
                  SystemID = 3,
                  Brand = "Apple",
                  Name = "IOS"
              },
              new SystemModel
              {
                  SystemID = 4,
                  Brand = "Microsoft",
                  Name = "Windows"
              },
              new SystemModel
              {
                  SystemID = 5,
                  Brand = "Sony",
                  Name = "Playstation"
              }
              );
        }
    }
}
