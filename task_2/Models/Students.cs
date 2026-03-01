using System.ComponentModel.DataAnnotations;

namespace task_2.Models
{
    public class Students
    {
        [EmailAddress(ErrorMessage ="enter a validasdas da")]
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public double StudentCGPA { get; set; }
        public string StudentPhone { get; set; }

    }
}
