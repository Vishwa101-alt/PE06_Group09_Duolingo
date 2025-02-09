using FSDProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System.Drawing;

namespace FSDProject.Configurations.Entities
{
    public class CourseDatabaseSeed : IEntityTypeConfiguration<CourseDatabase>
    {
        public void Configure(EntityTypeBuilder<CourseDatabase> builder)
        {
            builder.HasData(
                new CourseDatabase
                {
                    CourseDatabaseId = 1,
                    LanguageName = "English",

                },
                new CourseDatabase
                {
                    CourseDatabaseId = 2,
                    LanguageName = "Burmese",
                },
                new CourseDatabase
                {
                    CourseDatabaseId = 3,
                    LanguageName = "Malay",
                },
                new CourseDatabase
                {
                    CourseDatabaseId = 4,
                    LanguageName = "Hindi",
                }
            );
        }
    }
}
