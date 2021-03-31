using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

using InventoryManagement.Models;
using InventoryManagement.Data;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Controllers{
    public class InventoryController: Controller{
        private readonly IMSContext db;
        public InventoryController(IMSContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {   
            var product = db.Inventories.ToList();
            return View(product);
        }

        public IActionResult lessquantity()
        {   
            var product = db.Inventories.ToList();
            return View(product);
        }

        public IActionResult expired()
        {   
            var product = db.Inventories.ToList();
            return View(product);
        }        

        // public ActionResult Detail(int Id)
        // {
        //     var abc = db.Employees.Find(Id);
        //     return View(abc);
        // }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Inventory inventoy)
        {
            db.Inventories.Add(inventoy);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var abcd = db.Inventories.Find(Id);
            return View(abcd);
        }


        [HttpPost]
        public ActionResult Edit(Inventory inventory)
        {
            db.Inventories.Attach(inventory);
            db.Inventories.Update(inventory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var abcde = db.Inventories.Find(Id);
            return View(abcde);
        }


        [HttpPost]
        public ActionResult Delete(Inventory inventory)
        {
            db.Inventories.Attach(inventory);
            db.Inventories.Remove(inventory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Sell(int Id)
        {
            var abcdef = db.Inventories.Find(Id);
            return View(abcdef);
        }


        [HttpPost]
        public ActionResult Sell(Inventory inventory)
        {
            db.Inventories.Attach(inventory);
            db.Inventories.Update(inventory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }    

        public async Task<IActionResult> Search(string searchString)
        {
            var goods = from m in db.Inventories
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                goods = goods.Where(s => s.Name.Contains(searchString));
            }

            return View(await goods.ToListAsync());
        }



    }
}