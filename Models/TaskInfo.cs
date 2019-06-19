using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerApp.Models
{
    public class TaskInfo
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool Done { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
    }
}
