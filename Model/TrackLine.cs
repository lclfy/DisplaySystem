using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DisplaySystem
{
    [Serializable()]
    public class TrackLine : IComparable<TrackLine>
    {
        public int trackLineID { get; set; }
        public string trackText { get; set; }
        //左右坐标
        public Point selfLeftPoint { get; set; }
        public Point selfRightPoint { get; set; }
        //左右节点
        public TrackPoint leftTrackPoint { get; set; }
        public TrackPoint rightTrackPoint { get; set; }
        //该轨道在无电区内包含；0=全部，1=左半部，2=右半部
        public int containsInPS { get; set; }
        public int CompareTo(TrackLine other)
        {
            if (null == other)
            {
                return 1;//空值比较大，返回1
            }
            return this.trackLineID.CompareTo(other.trackLineID);//升序
            //return other.trackLineID.CompareTo(this.trackLineID);//降序
        }
    }
}
