using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project.Core
{
    public class User
    {
        [Required] 
        public int Id { get; set; }
        [Required]  
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; } // TODO: Hash this
        [Required]
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Bio { get; set; }

    }
}
