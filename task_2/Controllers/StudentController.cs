using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using task_2.Data;
using task_2.Data.Entities;
using task_2.Models;

namespace task_2.Controllers
{
    public class StudentController : Controller
    {
        // creating a list to store the students data
        //private static List<Students> studentsList = new List<Students>();

        private StudentsContext _context;
        public StudentController(StudentsContext context)
        {
            _context = context;
        }

        [Route("add-students")]
        public IActionResult AddStudents()
        {
            return View();
        }
        [HttpPost("add-students")]
        public IActionResult AddStudents(StudentInfo students)
        {
            if (ModelState.IsValid)
            {
                var exist = _context.StudentInfos.Any(s=> s.Email == students.Email);
               if(!exist){
                _context.StudentInfos.Add(students);
                _context.SaveChanges();
                TempData["success"] ="user added";
               } else {
                TempData["error"] ="user already exixts";
               
               }
            }

            return View();
        }

        // receving data from the add students (post method) and then sending it to the list page 
        //[HttpPost("add-students")]
        [Route("students")]
        public IActionResult listOfstudents()
        {
            var Data = _context.StudentInfos.ToList();
            return View(Data);
            //}
        }

        [HttpGet("listOfstudents")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("AddStudents");
            }
            
            var std=_context.StudentInfos.Find(id);
            if( std != null){
             _context.StudentInfos.Remove(std);
             _context.SaveChanges();
             TempData["success"]="User deleted ";
            }
            return RedirectToAction("listOfstudents");
        }
    }
}
