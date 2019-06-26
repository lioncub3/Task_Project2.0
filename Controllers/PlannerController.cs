using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlannerApp.Data;
using PlannerApp.Models;

namespace PlannerApp.Controllers
{
    [Authorize]
    public class PlannerController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private TasksContext db;

        public PlannerController(TasksContext context, UserManager<IdentityUser> userManager)
        {
            this.db = context;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            IdentityUser user = await userManager.GetUserAsync(User);

            return View(db.TaskInfos.Where(t => t.UserId == user.Id));
        }

        [HttpPost]
        public async Task<IActionResult> AddTask(TaskInfo task)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.GetUserAsync(User);
                task.UserId = user.Id;
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