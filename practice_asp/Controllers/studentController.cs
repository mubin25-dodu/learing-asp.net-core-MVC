using Microsoft.AspNetCore.Mvc;

namespace practice_asp.Controllers
{
    public class studentController : Controller
    {

[Route("firstpage")]
        public IActionResult Index()
        {
            return View();
        }
[Route("secondpage")]

        public IActionResult mydata()
        {
            return Content("mubin");
        } 
        public IActionResult jsondata()
        {
            var data = new {
                id = "23-50139-1",
                name ="abdullah al mubin"
            };
            return Json(data);
        } 
        public IActionResult portfolio()
        {
            return Redirect("https://www.mu-bin.dev");
        }
        public IActionResult download()
        {
            var thefile = System.IO.File.ReadAllBytes("1. Networking Basics.pdf");
            // return File(thefile,"application/pdf"); to just view
            return File(thefile,"application/pdf","File.pdf"); // to download change the name  

        }
    }
}
