using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESD_360.Models
{
    public class Properties
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public DateTime AddedDate { get; set; }

        public ICollection<Floor_Plan> Floor_Plan { get; set; }
    }
}
