using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlannerApp.Data;
using PlannerApp.Models;

namespace PlannerApp.Controllers
{
    public class PlannerController : Controller
    {

        private TasksContext db;

        public PlannerController(TasksContext context)
        {
            this.db = context;
        }

        public IActionResult Index()
        {
            
            return View(db.TaskInfos);
        }

        [HttpPost]
        public IActionResult AddTask(TaskInfo task)
        {
            if (ModelState.IsValid)
            {
                db.TaskInfos.Add(task);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return BadRequest();
        }

        public IActionResult Delete(int id)
        {
            var task = db.TaskInfos.First(t => t.Id == id);
            db.Entry(task).State = EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Check(int id, string command)
        {
            var task = db.TaskInfos.First(t => t.Id == id);

            switch (command)
            {
               case "done":     task.Done = true; break;
               case "not-done": task.Done = false; break;
            }

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}