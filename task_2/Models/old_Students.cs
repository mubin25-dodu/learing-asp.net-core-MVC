using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace task_2.Models
{
    public class old_Students
    {
        [Required]
        [SID]
        public string StudentId { get; set; }
        [Required]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Enter a valid name")]
        public string StudentName { get; set; }
        [Required]
        [EmailAddress]
        public string StudentEmail { get; set; }
        [Required]
        public double StudentCGPA { get; set; }
        [Required]
        [Phone]
        public string StudentPhone { get; set; }

        //bool Studentid(string id) {
        //    if (id!=null && id[id.Length - 1] == '-' && id[id.Length + 1] == '-') {
        //        return true;
        //    }
        //    return false;
        //    }
    }
}
