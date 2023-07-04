using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Material
    {
        [Required]
        public int MaterialID { get; set; }
        public string MaterialName { get; set; }
        public string MaterialDescription { get; set; }
        public int Views_number { get; set; }
    }
}
