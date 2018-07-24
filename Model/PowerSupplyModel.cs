using System;
using System.Collections.Generic;
using System.Text;

namespace DisplaySystem
{
    [Serializable()]
    public class PowerSupplyModel
    {
        public int powerSupplyID { get; set; }
        public string powerSupplyName { get; set; }
        public bool function { get; set; }
        public List<TrackLine> containedTrackLine { get; set; }
        public List<TrackPoint> containedTrackPoint { get; set; }
        public List<TrackPoint> fonctionalTrackPoint { get; set; }
    }
}
