using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DisplaySystem.Model
{
    [Serializable()]
    public class TrackPointAndSignal : IComparable<TrackPointAndSignal>, ICloneable
    {
        public string trackPointID { get; set; }
        public bool function { get; set; }
        //  1定位 2反位
        public int switchDirection { get; set; }
        public Point trackPoint { get; set; }
        //              ==3
        //  1===//==2
        public int firstTrackLine { get; set; }
        public int secondTrackLine { get; set; }
        public int thirdTrackLine { get; set; }

        public int CompareTo(TrackPointAndSignal other)
        {
            if (null == other)
            {
                return 1;//空值比较大，返回1
            }
            return this.trackPointID.CompareTo(other.trackPointID);//升序
            //return other.trackPointID.CompareTo(this.trackPointID);//降序
        }

        public object Clone()
        {
            TrackPointAndSignal _tp = new TrackPointAndSignal();
            _tp.trackPointID = trackPointID;
            _tp.function = function;
            _tp.switchDirection = switchDirection;
            _tp.trackPoint = trackPoint;
            _tp.firstTrackLine = firstTrackLine;
            _tp.secondTrackLine = secondTrackLine;
            _tp.thirdTrackLine = thirdTrackLine;
            return _tp as object;//深复制
        }
    }
}
