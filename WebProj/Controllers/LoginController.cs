using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebProj.Models;
using WebProj.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace WebProj.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        private ILoginPortal _loginPortal;

        public LoginController(ILogger<LoginController> logger, ILoginPortal loginPortal)
        {
            _logger = logger;
            _loginPortal = loginPortal;
            
        }
        [HttpGet]
    
        public ActionResult Login()
        {
            //ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        
        public async Task<ActionResult> AuthorizeAsync(Models.Login login)
        {
            Authorize res = await _loginPortal.GetToken(login.Username,login.Password);
            if (res != null && res.Token!=null)
            {
                //return Content(res.Token);

                HttpContext.Session.SetString("token", res.Token);
                return RedirectToAction("Index", "Home");

                //return Redirect("returnUrl");
            }
            ViewBag.Message = "Invalid Login";
            return View("Login");

        }


        // GET: LoginController/Details/5
        [HttpGet]
      
        public ActionResult Register()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
       
        public async Task<ActionResult> RegisterAsync(User user)
        {
            try
            {
                string res = await _loginPortal.UserRegistration(user);
                if (res != null && res=="OK")
                {
                    return RedirectToAction("Login");
                }
                return Content("Something Happened ! Try Later...");
            }
            catch
            {
                return View("Error");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
