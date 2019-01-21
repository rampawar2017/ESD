using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESD_360.Models
{
    //Room has connection back to floor plan
    public class Rooms
    {
        public string Description { get; set; }
        public string Floor { get; set; }

        public ICollection<Floor_Plan> Floor_Plan { get; set; }
    }
}
