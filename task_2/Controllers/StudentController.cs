using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using task_2.Data;
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

        // receving data from the add students (post method) and then sending it to the list page 
        //[HttpPost("add-students")]
        [Route("students")]
        public IActionResult listOfstudents()
        {
            //if (ModelState.IsValid)
            //{
            //    studentsList.Add(students);
            //    return View(studentsList);
            //}
            //else
            //{
            var Data = _context.StudentInfos.ToList();

            return View(Data);
            //}
        }
    }
}
