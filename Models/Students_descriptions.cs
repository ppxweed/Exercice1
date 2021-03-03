using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models
{
    public class Students_description
    {
        [Key]
        public int Id { get; set; }
        public int Students_Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Adresse { get; set; }
        public string Country { get; set; }
    }
}