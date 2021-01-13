using Blogdulich.Web.Models;
using Blogdulich.Web.Models.Post;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blogdulich.Web.Controllers
{
    public class PostController : Controller
    {
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            List<Post> categories = new List<Post>();
            categories = Helper.ApiHelper<List<Post>>.HttpGetAsync("api/post/gets");
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
        public IActionResult Create(CreatePost model)
        {
            if (ModelState.IsValid)
            {
                var result = new CreatePostResult();
                result = Helper.ApiHelper<CreatePostResult>.HttpPostAsync("api/post/create", "POST", model);
                if (result.PostId > 0)
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
        public IActionResult Delete(DeletePost model)
        {
            if (ModelState.IsValid)
            {
                var result = new DeletePostResult();
                result = Helper.ApiHelper<DeletePostResult>.HttpPostAsync("api/post/delete", "POST", model);
                if (result.PostId > 0)
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
        public IActionResult Edit(UpdatePost model)
        {
            if (ModelState.IsValid)
            {
                var result = new UpdatePostResult();
                result = Helper.ApiHelper<UpdatePostResult>.HttpPostAsync("api/post/update", "POST", model);
                if (result.PostId > 0)
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
