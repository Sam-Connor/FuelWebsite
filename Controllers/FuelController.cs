using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fuel.Models;
using Fuel.Data;

namespace Fuel.Controllers
{
    public class FuelController : Controller
    {
        private readonly FuelDbContext Database;

        public FuelController(FuelDbContext database)
        {
            Database = database;
        }
        public IActionResult Index()
        {
            var vm = new FuelStopViewModel();
            vm.Stops = Database.Stops.ToList();

            return View(vm);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult AddFuelStop([FromForm] AddStopRequest stopRequest)
        {
            var newStop = new FuelStop();
           // newStop.stopDate = DateTime.UtcNow;
            newStop.stopDate = stopRequest.stopDate.Date;
            newStop.stopAmount = stopRequest.stopAmount;
            newStop.price = stopRequest.price;
            newStop.distanceTravelled = stopRequest.distanceTravelled;

            Database.Stops.Add(newStop);
            Database.SaveChanges();

            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Edit([FromRoute] int id)
        {
            var stop = Database.Stops.FirstOrDefault(b => b.id == id);


            return View(stop);
        }


        [HttpPost]
        public IActionResult EditStop([FromForm] FuelStop stop)
        {
            var existingStop = Database.Stops.FirstOrDefault(b => b.id == stop.id);

            existingStop.stopDate = stop.stopDate.Date;
            existingStop.stopAmount = stop.stopAmount;
            existingStop.price = stop.price;
            existingStop.distanceTravelled = stop.distanceTravelled;

            Database.Stops.Update(existingStop);
            Database.SaveChanges();

            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Delete([FromRoute] int id)
        {
            var stop = Database.Stops.FirstOrDefault(b => b.id == id);

            Database.Stops.Remove(stop);
            Database.SaveChanges();

            return RedirectToAction("index");
        }


    }

}



