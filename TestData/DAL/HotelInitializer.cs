using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reservation.Models;

namespace Reservation.DAL
{
    public class HotelInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HotelContext>
    {
        protected override void Seed(HotelContext context)
        {

            var rooms = new List<Room>
            {
            new Room{name="Enkel",beds=1, floor = 1},
            new Room{name="Dobbel",beds=2, floor = 2 },
            new Room{name="Trippel",beds=3, floor = 2},
            new Room{name="Suite",beds=2, floor = 3},
            new Room{name="Enkel",beds=1, floor = 2},
            new Room{name="Enkel",beds=1, floor = 1},
            new Room{name="Enkel",beds=1, floor = 1},
            new Room{name="Dobbel",beds=1, floor = 1},
            };

            rooms.ForEach(r => context.Rooms.Add(r));
            context.SaveChanges();
        }
    }
}