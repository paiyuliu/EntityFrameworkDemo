using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Demo.Core.Domain;
using Demo.Core.Repositories;

namespace Demo.Persistance.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(PlutoContext context)
            : base(context)
        {
        }
        
        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return PlutoContext.Courses
                .OrderByDescending(c => c.FullPrice)
                .Take(count)
                .ToList();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize)
        {
            return PlutoContext.Courses
                .Include(a => a.Author)
                .OrderBy(a => a.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public PlutoContext PlutoContext => Context as PlutoContext;
    }
}
