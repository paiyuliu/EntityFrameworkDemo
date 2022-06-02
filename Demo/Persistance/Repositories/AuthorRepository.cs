﻿using System.Linq;
using System.Data.Entity;
using Demo.Core.Domain;
using Demo.Core.Repositories;

namespace Demo.Persistance.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(PlutoContext context)
            : base(context)
        {
        }

        public Author GetAuthorWithCourses(int id)
        {
            return PlutoContext.Authors
                .Include(a => a.Courses)
                .SingleOrDefault(a => a.Id == id);
        }

        public PlutoContext PlutoContext => Context as PlutoContext;
    }
}
