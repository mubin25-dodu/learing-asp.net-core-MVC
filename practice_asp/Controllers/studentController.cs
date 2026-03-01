using Microsoft.AspNetCore.Mvc;
using practice_asp.Models;

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
            var data = new
            {
                id = "23-50139-1",
                name = "abdullah al mubin"
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
            return File(thefile, "application/pdf", "File.pdf"); // to download change the name  

        }
        [Route("list")]
        public IActionResult studentlist()
        {
            var list = new List<students>
            {
                new students { ID = 1, Name = "Abdullah Al Mubin", email = "mubin23-50139-1@aiub.edu" },
                new students { ID = 2, Name = "Nusrat Jahan", email = "nusrat.jahan@aiub.edu" },
                new students { ID = 3, Name = "Tanvir Hasan", email = "tanvir.hasan@aiub.edu" },
                new students { ID = 4, Name = "Fariha Islam", email = "fariha.islam@aiub.edu" },
                new students { ID = 5, Name = "Siam Ahmed", email = "siam.ahmed@aiub.edu" },
                new students { ID = 6, Name = "Rafiul Karim", email = "rafiul.karim@aiub.edu" },
                new students { ID = 7, Name = "Mehjabin Rahman", email = "mehjabin.rahman@aiub.edu" },
                new students { ID = 8, Name = "Arif Hossain", email = "arif.hossain@aiub.edu" }
            };
            return View(list);
        }

    }
}
