using FSDProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject.Configurations.Entities
{
    public class CourseSeed : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder) => builder.HasData(
                // Seeding courses linked to the CourseDatabase
                new Course
                {
                    CourseId = 1,
                    CourseName = "English language course",
                    CoursePrice = 10.5f, 
                    CourseDuration = "60 minutes", 
                    CompletionPercentage = 0,
                    CourseDatabaseId = 1 // Linked to English in CourseDatabase
                },
                new Course
                {
                    CourseId = 2,
                    CourseName = "Burmese language course",
                    CoursePrice = 15.0f,
                    CourseDuration = "90 minutes",
                    CompletionPercentage = 0,
                    CourseDatabaseId = 2 // Linked to Burmese in CourseDatabase
                },
                new Course
                {
                    CourseId = 3,
                    CourseName = "Malay language course",
                    CoursePrice = 8.0f,
                    CourseDuration = "50 minutes",
                    CompletionPercentage = 0,
                    CourseDatabaseId = 3 // Linked to malay in CourseDatabase
                },
                new Course
                {
                    CourseId = 4,
                    CourseName = "Hindi language course",
                    CoursePrice = 12.0f,
                    CourseDuration = "75 minutes",
                    CompletionPercentage = 0,
                    CourseDatabaseId = 4 // Linked to Hindi in CourseDatabase
                }
            );
    }
}
