using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1_MVC.Models
{
    public enum CarEngineType
    {
        Petrol, Diesel, Hybrid
    }
    public class Car
    {

       // make, model, engine size, and engine type (petrol, diesel, or hybrid).
        public int id { get; set; }

        public String Make { get; set; }

        public String Model { get; set;}

        public int EngSize { get; set; }

        public CarEngineType CarEngineType { get; set; }


        
    }
}