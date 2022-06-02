using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;

namespace Demo.Core.Domain
{
    public class Course
    {
        public Course()
        {
            this.Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        //[Required]
        //[StringLength(255)]
        public string Name { get; set; }

        //[Required]
        //[StringLength(2000)]
        public string Description { get; set; }

        public int Level { get; set; }

        public float FullPrice { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public Cover Cover { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public bool IsBegginerCourse => Level == 1;
    }
}
