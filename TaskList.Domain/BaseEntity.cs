using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TaskList.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }

        public string CreatedById { get; set; }

        public string ModifiedById { get; set; }
    }
}