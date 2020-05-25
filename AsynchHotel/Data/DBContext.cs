using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace AsynchHotel.Data
{
    public class Class AsynchHotelDbContext : DbContext
    {
        public AsynchHotelDbContext(DbContextOptions) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hotel>().HasData(
            new
            {
                ID = 1,
                name = "hoetell",
                street = "123 divorce ln",
                city = "Gothem",
                state = "Florida",
                country = "US",
                phone = 5555555555,
            },
            new
            {
                ID = 2,
                name = "hostel",
                street = "420 Sketchy dr",
                city = "Aberdeen",
                state = "Washington",
                country = "US",
                phone = 5555555555

            },
            new
            {
                ID = 3,
                name = "doomsday",
                street = "666 pergatory ave",
                city = "crossroads",
                state = "mississippi",
                country = "US",
                phone = 6666666666
            }


    );
        modelBuilder.Entity<Room>().HasData(
            new
            {
                ID = 1,
                name = "The quinby",
                layout = "hidden mistress"
            },
            new
            {
                ID = 2,
                name = "big city",
                layout = "studio"
            },
            new
            {
                ID = 3,
                name = "forest dweller",
                layout = "rustic mahogany"
            },
            new
            {
                ID = 4,
                name = "the playboy",
                layout = "king bed, hot tub"
            },
            new
            {
                ID = 5,
                name = "The family",
                layout = "twoBed, xbox"
            },
            new
            {
                ID = 6,
                name = "dorm",
                layout = "twoBed, rAnDoM rOoMmAtE"
            })
            ;

        modelBuilder.Entity<Amenities>().HasData(
            new
            {
                ID = 1,
                name = "scotchguard soaked everything"
            },
            new
            {
                ID = 2,
                name = "white noise machine"
            },
            new
            {
                ID = 3,
                name = "videogame console of choice"
            },
            new
            {
                ID = 4,
                name = "blunt protective object"
            },
            new
            {
                ID = 5,
                name = "wake up call"
            }
            );


    }

}

