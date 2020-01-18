using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using tech_dot_net_Mluszczewski.Validation;
using System.Linq;
using System.Threading.Tasks;

namespace tech_dot_net_Mluszczewski.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        [FirstNameValidation(@"^[A-Z]+[a-za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]*$")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        [LastNameValidation(@"^[A-Z]+[a-za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]*$")]
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
