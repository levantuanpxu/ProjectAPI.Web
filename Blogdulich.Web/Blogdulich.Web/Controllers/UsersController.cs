using Blogdulich.Web.Models;
using Blogdulich.Web.Models.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blogdulich.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult user()
        {
            List<User> users = new List<User>();
            users = Helper.ApiHelper<List<User>>.HttpGetAsync("api/user/gets");
            return View(users);
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
        public IActionResult Create(CreateUser model)
        {
            if (ModelState.IsValid)
            {
                var result = new CreateUserResult();
                result = Helper.ApiHelper<CreateUserResult>.HttpPostAsync("api/user/create", "POST", model);
                if (result.UserId > 0)
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
        public IActionResult Delete(DeleteUser model)
        {
            if (ModelState.IsValid)
            {
                var result = new DeleteUserResult();
                result = Helper.ApiHelper<DeleteUserResult>.HttpPostAsync("api/user/delete", "POST", model);
                if (result.UserId > 0)
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
        public IActionResult Edit(UpdateUser model)
        {
            if (ModelState.IsValid)
            {
                var result = new UpdateUserResult();
                result = Helper.ApiHelper<UpdateUserResult>.HttpPostAsync("api/user/update", "POST", model);
                if (result.UserId > 0)
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
