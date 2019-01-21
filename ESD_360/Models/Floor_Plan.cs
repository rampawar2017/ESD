using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESD_360.Models
{
    //Class Floor plan has connection to rooms
    public class Floor_Plan
    {
        public string Description { get; set; }
        public string Floor { get; set; }
        public object Image { get; set; }

        public ICollection<Rooms> Rooms { get; set; }
        public ICollection<Properties> Properties { get; set; }
    }
}
