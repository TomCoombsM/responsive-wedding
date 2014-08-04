using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class HotelOptions
    {
        public int Id { get; set; }
        public int NumberNightsBefore { get; set; }
        public int NumberNightsAfter { get; set; }
        public string RoomClass { get; set; }


    }
}
