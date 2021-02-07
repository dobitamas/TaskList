using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TaskList.Domain
{
    public class TaskItem : BaseEntity
    {
        [Required]
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }

        [Display(Name = "Is completed?")]
        public bool IsCompleted { get; set; } = false;
    }
}