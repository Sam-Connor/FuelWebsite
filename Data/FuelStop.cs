using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fuel.Data
{
    public class FuelStop
    {
        public int id {get; set;}
        
        
        public DateTime stopDate {get; set;}
        public double stopAmount {get; set;}
        public double price {get; set;}
        public double distanceTravelled {get; set;}


    }
}