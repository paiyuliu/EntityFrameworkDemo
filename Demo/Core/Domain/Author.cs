using System.Collections.Generic;

namespace Demo.Core.Domain
{
    public class Author
    {
        public Author()
        {
            this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
