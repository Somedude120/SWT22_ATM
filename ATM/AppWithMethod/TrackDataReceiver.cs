﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMClasses.Data;
using ATMClasses.Filtering;
using ATMClasses.Interfaces;

namespace AppWithMethod
{
    class TrackDataReceiver : ITrackReceiver
    {
        //Denne ting køre igennem tracks og "printer" dem ud
        public void ReceiveTracks(List<TrackData> tracks)
        {
            foreach (var track in tracks)
            {
                System.Console.WriteLine(track);
                //Tilsat filtering
                //if (monitor.MonitorFlight(track) == false)
                //{
                //    System.Console.WriteLine(track);
                //}
                //else
                //{
                //    System.Console.WriteLine("Nothing");
                //}
            }
        }
    }
}
