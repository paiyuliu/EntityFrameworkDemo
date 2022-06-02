using System.Data.Entity;
using Demo.Core.Domain;
using Demo.Persistance.EntityConfigurations;

namespace Demo.Persistance
{
    public class PlutoContext : DbContext
    {
        public PlutoContext()
            : base("name=PlutoContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public virtual DbSet<Author> Authors { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());
        }
    }
}
