using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Core
{
    public class Student
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required, StringLength(80)]
        public string Gender { get; set; }

        [Required]
        public int Fees { get; set; }

        
        public Quota quota { get; set; }

        
        public Department department { get; set; }
    }
}
