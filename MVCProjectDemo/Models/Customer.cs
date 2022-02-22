using System.ComponentModel.DataAnnotations;

namespace MVCProjectDemo.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public int DOB { get; set; }    
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        
        public string Password2 { get; set; }

    }
}
