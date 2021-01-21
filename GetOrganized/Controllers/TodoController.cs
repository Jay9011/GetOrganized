using GetOrganized.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetOrganized.Controllers
{
    public class TodoController : Controller
    {
        //
        // GET: /Todo/
        public ActionResult Index()
        {
            ViewData.Model = Todo.ThingsToBeDone;
            return View();
        }

        //
        // GET: /Todo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Todo/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Todo/Create
        [HttpPost]
        public ActionResult Create(Todo todo)
        {
            try
            {
                // TODO: Add insert logic here
                Todo.ThingsToBeDone.Add(todo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Todo/Edit/5
        public ActionResult Edit(string title)
        {
            ViewData.Model = Todo.ThingsToBeDone.Find(todo => todo.Title == title);
            return View();
        }

        //
        // POST: /Todo/Edit/5
        [HttpPost]
        public ActionResult Edit(string oldTitle, Todo item)
        {
            try
            {
                Todo.ThingsToBeDone.RemoveAll(aTodo => aTodo.Title == oldTitle);
                Todo.ThingsToBeDone.Add(item);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Todo/Delete/Title=제목
        public ActionResult Delete(string title)
        {
            Todo.ThingsToBeDone.RemoveAll(todo => todo.Title == title);

            return RedirectToAction("Index");
        }
    }
}
