using Microsoft.EntityFrameworkCore;
using PlannerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerApp.Data
{
    public class TasksContext: DbContext
    {
       

        public DbSet<TaskInfo> TaskInfos { get; set; }

        public TasksContext(DbContextOptions options): base(options)
        {

        }
    }
}
