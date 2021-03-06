using System.Collections.Generic;

namespace Demo.Core.Domain
{
    public class Tag
    {
        public Tag()
        {
            this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
