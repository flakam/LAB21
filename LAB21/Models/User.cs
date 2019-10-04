using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LAB21.Models
{
    public class User
    {
        [Key]
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Key]
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [MinLength(9)]
        [MaxLength(9)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(20)]
        public string Email { get; set; }

        [MinLength(3)]
        [MaxLength(10)]
        [Required]
        public string Password { get; set; }

        [Required]
        [Range(18, 99)]
        public int Age { get; set; }
    }
}
