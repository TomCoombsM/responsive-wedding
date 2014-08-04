using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 

namespace DataLayer
{

        public class WeddingContext : DbContext
        {
            public DbSet<Person> Person { get; set; }
            public DbSet<FirstCourse> FirstCourse { get; set; }
            public DbSet<SecondCourse> SecondCourse { get; set; }
            public DbSet<ThirdCourse> ThirdCourse { get; set; }
            public DbSet<HotelOptions> HotelOptions { get; set; }
        } 
    
}
