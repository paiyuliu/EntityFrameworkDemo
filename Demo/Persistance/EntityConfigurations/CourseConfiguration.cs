using System.Data.Entity.ModelConfiguration;
using Demo.Core.Domain;

namespace Demo.Persistance.EntityConfigurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(2000);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasRequired(c => c.Author)
                .WithMany(a => a.Courses)
                .HasForeignKey(c => c.AuthorId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Cover)
                .WithRequiredPrincipal(c => c.Course);

            HasMany(c => c.Tags)
                .WithMany(c => c.Courses)
                .Map(m =>
                {
                    m.ToTable("CourseTags");
                    m.MapLeftKey("CourseId");
                    m.MapRightKey("TagId");
                });
        }
    }
}
