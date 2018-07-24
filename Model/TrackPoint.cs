﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DisplaySystem
{
    [Serializable()]
    public class TrackPoint : IComparable<TrackPoint>
    {
        public int trackPointID { get; set; }
        //是否被供电臂所停用
        public bool function { get; set; }
        //  1定位 2反位
        public int switchDirection { get; set; }
        public Point trackPoint { get; set; }
        //              ==3
        //  1===//==2
        public int firstTrackLine { get; set; }
       public int secondTrackLine { get; set; }
        public int thirdTrackLine { get; set; }

        public int CompareTo(TrackPoint other)
        {
            if (null == other)
            {
                return 1;//空值比较大，返回1
            }
            return this.trackPointID.CompareTo(other.trackPointID);//升序
            //return other.trackPointID.CompareTo(this.trackPointID);//降序
        }
    }
}