using Demo.Core;
using Demo.Core.Repositories;
using Demo.Persistance.Repositories;

namespace Demo.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
        {
            this._context = context;

            Courses = new CourseRepository(this._context);
            Authors = new AuthorRepository(this._context);
        }

        public ICourseRepository Courses { get; }
        public IAuthorRepository Authors { get; }

        public int Complete()
        {
            return this._context.SaveChanges();
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
