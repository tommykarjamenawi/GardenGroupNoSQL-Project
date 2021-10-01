using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupUI
{
    class Enums
    {
        public enum TypeOfUser { EndUser, ServiceDeskEmployee };
        public enum TypeOfIncident { Software = 0, Hardware, Service };

        public enum TypeOfPriority { Low = 0, Normal, High };
    }


}
