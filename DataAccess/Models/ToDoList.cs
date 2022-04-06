﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table(nameof(ToDoList))]
    public class ToDoList
    {
        [Key]
        public long Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
    }
}
