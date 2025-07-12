using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class HomeController : Controller
    {
        TodoContext db = new TodoContext();
        public ActionResult Index()
        {
            var todos = db.Todos.ToList();
            return View(todos);
        }
        [HttpPost]
        public ActionResult Index(Todo todo)
        {
            db.Todos.Add(todo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var task = db.Todos.Where(t => t.TodoId.Equals(id)).FirstOrDefault();
            db.Todos.Remove(task);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}