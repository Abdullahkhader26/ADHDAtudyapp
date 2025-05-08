using ADHDStudyApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ADHDStudyApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var userEmail = HttpContext.Session.GetString("UserEmail");

            if (string.IsNullOrEmpty(userEmail))
            {
                return RedirectToAction("EnterEmail", "Account");
            }

           
            ViewBag.UserEmail = userEmail;
            return View();
        }
    }
}