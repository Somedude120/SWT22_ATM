﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMClasses.Interfaces;
//Objektificering af TrackData
//Lavet af Frank
namespace ATMClasses.Data
{
    public class TrackData : ITracks
    {
        public string Tag { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Altitude { get; set; }
        public int Velocity { get; set; }
        public int Course { get; set; }

        public DateTime Timestamp { get; set; }

        public TrackData()
        {
            X = 0;
            Y = 0;
            Altitude = 0;
            Velocity = 0;
            Course = 0;
            Timestamp = DateTime.MinValue;
        }

        //Redigeret af Somedude120
        //public override string ToString()
        //{
        //    var str = $"{Tag}: CoordX: {X}, CoordY: {Y} ALT: {Altitude}, VEL: {Velocity}, CRS: {Course}";
        //    return str;
        //}
    }
}
