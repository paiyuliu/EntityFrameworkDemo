using System.Collections.Generic;
using Demo.Core.Domain;

namespace Demo.Core.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
        IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
