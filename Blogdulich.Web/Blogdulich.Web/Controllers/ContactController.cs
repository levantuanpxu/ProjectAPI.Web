using Blogdulich.Web.Models;
using Blogdulich.Web.Models.Contact;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blogdulich.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            List<Contact> contacts = new List<Contact>();
            contacts = Helper.ApiHelper<List<Contact>>.HttpGetAsync("api/contact/gets");
            return View(contacts);
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
        public IActionResult Create(CreateContact model)
        {
            if (ModelState.IsValid)
            {
                var result = new CreateContactResult();
                result = Helper.ApiHelper<CreateContactResult>.HttpPostAsync("api/contact/create", "POST", model);
                if (result.ContactId > 0)
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
        public IActionResult Delete(DeleteContact model)
        {
            if (ModelState.IsValid)
            {
                var result = new DeleteContactResult();
                result = Helper.ApiHelper<DeleteContactResult>.HttpPostAsync("api/contact/delete", "POST", model);
                if (result.ContactId > 0)
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
        public IActionResult Edit(UpdateContact model)
        {
            if (ModelState.IsValid)
            {
                var result = new UpdateContactResult();
                result = Helper.ApiHelper<UpdateContactResult>.HttpPostAsync("api/contact/update", "POST", model);
                if (result.ContactId > 0)
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
