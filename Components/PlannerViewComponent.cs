using Microsoft.AspNetCore.Mvc;
using PlannerApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerApp.Components
{
    public class PlannerViewComponent : ViewComponent
    {
        private TasksContext db;

        public PlannerViewComponent(TasksContext context)
        {
            this.db = context;
        }
        public IViewComponentResult Invoke(bool showTotal)
        {
            int total = db.TaskInfos.Count();
            int done = db.TaskInfos.Count(t => t.Done == true);

            ViewBag.Total = total;
            ViewBag.Done = done;

            //string result = showTotal ? $"Завдань: {total}" : $"Виконано {done}/{total} завдань";

            return View();
        }
    }
}
