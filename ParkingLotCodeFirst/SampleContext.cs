using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ParkingLot
{
    public class SampleContext : DbContext
    {

        public SampleContext() : base("ParkingLotV3")
        { }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<AuthUser> AuthUsers { get; set; }

    }
}
