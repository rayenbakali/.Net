﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
   
{
    public enum PlaneType { Boing, AirBus }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManuFactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "ManufactureDate: "+this.ManuFactureDate+
                " Capacity: "+this.Capacity;
        }

        //public Plane(PlaneType pt, int capacity, DateTime date)
        //{
        //    this.PlaneType = pt;
        //    this.Capacity = capacity;
        //    this.ManuFactureDate = date;
        //}
        //public Plane() { }

    }
}
