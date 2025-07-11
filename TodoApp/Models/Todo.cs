using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    public class Todo
    {
        [Key]
        public int TodoId { get; set; }
        public string TodoTitle { get; set; }
    }
}