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

    )};


}
}
