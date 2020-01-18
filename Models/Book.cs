using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using tech_dot_net_Mluszczewski.Validation;

namespace tech_dot_net_Mluszczewski.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        public byte[] Image { get; set; }
        [PageNumberValidation(20)]
        public int PagesNumber { get; set; }
        [ClassicBook(1960)]
        [DataType(DataType.Date)]
        public DateTime ReleasteDate { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
