using Blogdulich.Web.Models;
using Blogdulich.Web.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blogdulich.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger)
        {
           _logger = logger;
       }
        public IActionResult Index()
        {
            List<Category> categories = new List<Category>();
            categories = Helper.ApiHelper<List<Category>>.HttpGetAsync("api/category/gets");
            return View(categories);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCatgegory model)
        {
            if (ModelState.IsValid)
            {
                var result = new CreateCategoryResult();
                result = Helper.ApiHelper<CreateCategoryResult>.HttpPostAsync("api/category/create", "Post", model);
                if (result.CategoryId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }





        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(DeleteCategory model)
        {
            if (ModelState.IsValid)
            {
                var result = new DeleteCategoryResult();
                result = Helper.ApiHelper<DeleteCategoryResult>.HttpPostAsync("api/category/delete", "DELETE", model);
                if (result.CategoryId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }



        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(UpdateCategory model)
        {
            if (ModelState.IsValid)
            {
                var result = new UpdateCategoryResult();
                result = Helper.ApiHelper<UpdateCategoryResult>.HttpPostAsync("api/category/update", "POST", model);
                if (result.CategoryId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }
    }
}
