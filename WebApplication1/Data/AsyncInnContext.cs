using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Data

{
    public class AsyncInnContext: DbContext
    {
        public DbSet<Amenity> Amenities;
        public DbSet<RoomAmenity> RoomAmenities;
        public DbSet<Room> Rooms;
        public DbSet<HotelRoom> HotelRooms;
        public DbSet<Hotel> Hotels;

        public AsyncInnContext(DbContextOptions<AsyncInnContext> options) : base(options) 
        { 
        }
    }
}
