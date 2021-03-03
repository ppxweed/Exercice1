using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        
        public int grade { get; set; }
    }
}