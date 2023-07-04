using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Exam
    {
        [Required]
        public int ExamId { get; set; }

        public string examName { get; set; }

        public int From_hour { get; set; }

        public int To_hour { get; set; }
    }
}
