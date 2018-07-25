using System;
using System.Collections.Generic;
using System.Text;

namespace DisplaySystem.Model
{
    [Serializable()]
    class ModelData
    {
        public string title { get; set; }
        public List<TrackLine> tLine { get; set; }
        public List<TrackPointAndSignal> tPoint { get; set; }
        public List<PowerSupplyModel> psModel { get; set; }
    }
}
