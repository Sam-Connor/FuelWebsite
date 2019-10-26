using System;
using System.Collections.Generic;
using Fuel.Data;

namespace Fuel.Models
{
    public class AddStopRequest
    {
        public DateTime stopDate {get; set;}
        public double stopAmount {get; set;}
        public double price {get; set;}
        public double distanceTravelled {get; set;}
    }
}


