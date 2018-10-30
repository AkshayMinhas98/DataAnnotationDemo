using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationDemo
{
    class Course
    {
        public Course()
        {
            Tags = new HashSet<Tag>();
        }
        public int Id { get; set; }

        [Required]                                     //Setting Name column not nullable
        [MaxLength(255)]                               //maximum character is 255 
        public string Name { get; set; }

        public int Level { get; set; }

        [Required]              
        [MaxLength(2000)]
        public string Description { get; set; }

        public float FullPrice { get; set; }

        public int AuthorId { get; set; }                      //property to name foreign key column

        [ForeignKey("AuthorId")]                               //setting foreign key
        public virtual Author Author { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

    }
}
