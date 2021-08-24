using System.Linq;
using System.Security.Cryptography;
using Crud.ViewModels.Widgets;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Controllers
{
    [Route("[controller]")]
    public class WidgetsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            // notification messages, implement them any way you want
            if (TempData.TryGetValue("Message", out var message)) {
                ViewBag.Message = message;
            }

            var indexViewModel = new IndexViewModel
            {
                Results = Enumerable.Range(1, 10)
                    .Select(i => new WidgetModel {
                        Id = i,
                        Name = $"Widget #{i}",
                        Manufacturer = "One",
                        Weight = RandomNumberGenerator.GetInt32(1, 20)
                    }).ToList()
            };
                
            return View(indexViewModel);
        }

        // widget/1
        [HttpGet, Route("{id}")]
        public IActionResult Show(int id)
        {
            // we would call the database
            return View("Show", new EditViewModel { Id = id });
        }

        [HttpGet, Route("new")]
        public IActionResult New()
        {
            // call the database for additional viewmodel data
            return View("New", new CreateViewModel());
        }
        
        // POST /widgets
        [HttpPost, Route("")]
        public IActionResult Create(CreateViewModel input)
        {
            if (ModelState.IsValid)
            {
                // save to database
                // redirect to display page
                return RedirectToAction("Show", new { id = 1 });
            }

            // return view with model-state errors
            // don't forget to hydrate additional viewmodel info
            return View("New", input);
        }

        [HttpGet, Route("{id}/edit")]
        public IActionResult Edit(int id)
        {
            // always call the database for data
            
            return View("Edit", new EditViewModel { Id = id });
        }
        
        [HttpPut, Route("{id}")]
        public IActionResult Update(int id, EditViewModel input)
        {
            if (ModelState.IsValid)
            {
                // save to database
                // redirect to display page
                return RedirectToAction("Show", new { id = input.Id });
            }

            // return view with model-state errors
            // don't forget to hydrate additional viewmodel info
            return View("Edit", input);
        }

        [HttpDelete, Route("{id}")]
        public IActionResult Delete(int id)
        {
            TempData["Message"] = $"Deleted Widget #{id}!";
            return RedirectToAction("Index");
        }
    }
}