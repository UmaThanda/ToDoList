using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {

        public static Dictionary<int, ToDoModel> repository = new Dictionary<int, ToDoModel>();
        public IActionResult Index()       
        {

            return View();               
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(ToDoModel model)
        {
            int id = GetNextId();
            model.Id = id;
            repository.Add(id, model);
            return Json(id);

        }

        List<ToDoModel> result = new List<ToDoModel>();

        public IActionResult Read()
        {
            
            //foreach(KeyValuePair<int,ToDoModel> i in repository)
            //{
            //    result.Add(i.Value);
            //}
                        
            result = repository.Select(x => x.Value).ToList();
            ViewData["ToDo"] = result;
            return View();
            //return View(result);
            //return View(Json(result));

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            
            return View(repository[id]);
        }

        [HttpPost]
        public IActionResult Edit(ToDoModel model)
        {
            var title = model.Title;
            var isDone = model.IsDone;
            repository[model.Id] = model;
            return RedirectToAction("Read");
        }

        [HttpGet]
        public IActionResult Delete (int id)
        {
              return View(repository[id]);
        }

        [HttpPost]
        public IActionResult Delete (ToDoModel model)
        {
            int id = model.Id;
            repository.Remove(id, out model);
              
                     
              return RedirectToAction("Read");
            
        }
        
        private int GetNextId ()
        {
            return repository.Count + 1;
        }
    }
}