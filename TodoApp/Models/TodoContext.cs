using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    public class TodoContext:DbContext
    {
        public DbSet<Todo> Todos { get; set; }
    }
}