using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupModel
{
    public class Enums
    {
        public enum TypeOfUser { EndUser, ServiceDeskEmployee };
        public enum TypeOfIncident { Software = 0, Hardware, Service };

        public enum Branch { Haarlem, Amsterdam, Knuppeldam, Headquarters };
        public enum TypeOfPriority { Low = 0, Normal, High };
    }


}
