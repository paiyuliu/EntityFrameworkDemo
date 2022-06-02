using Demo.Core.Domain;

namespace Demo.Core.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}
