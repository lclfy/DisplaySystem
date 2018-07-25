using System;
using System.Collections.Generic;
using System.Text;

namespace DisplaySystem.Model
{
    [Serializable()]
    class ModelData
    {
        public List<TrackLine> tLine { get; set; }
        public List<TrackPoint> tPoint { get; set; }
        public List<PowerSupplyModel> psModel { get; set; }
    }
}
