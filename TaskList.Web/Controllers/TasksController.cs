using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskList.DAL;
using TaskList.Domain;

namespace TaskList.Web.Controllers
{
    public class TasksController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private TaskListDbContext _db;

        public TasksController(ILogger<HomeController> logger, TaskListDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.TaskItems.AsEnumerable());
        }

        public IActionResult Create()
        {
            return View(new TaskItem());
        }

        [HttpPost]
        public IActionResult Create(TaskItem model)
        {
            if (ModelState.IsValid)
            {
                _db.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            return View(_db.TaskItems.FirstOrDefault(a => a.Id == id));
        }

        [HttpPost]
        public IActionResult Edit(TaskItem model)
        {
            if (ModelState.IsValid)
            {
                var editModel = _db.TaskItems.Find(model.Id);
                editModel.TaskName = model.TaskName;
                editModel.IsCompleted = model.IsCompleted;

                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}