using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Reservation.Models;


namespace Reservation.DAL
{
    public class HotelContext : DbContext
    {
        public HotelContext(): base("HotelContext")
        {
            Database.SetInitializer<HotelContext>(new HotelInitializer());
        } 
        public virtual DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}