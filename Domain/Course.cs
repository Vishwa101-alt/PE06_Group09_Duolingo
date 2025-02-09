using Microsoft.EntityFrameworkCore;

namespace FSDProject.Domain
{
    public class Course : BaseDomainModel
    {
        public int CourseId { get; set; } //Primary key property
        public string? CourseName { get; set; }
        public float? CoursePrice { get; set; }
        public string? CourseDuration { get; set; }
        public int? CompletionPercentage { get; set; }

        
        public int? UserAccId { get; set; }//Foreign key Property
        [DeleteBehavior(DeleteBehavior.Restrict)]  // Meaning when parent deleted, this child will not be auto-deleted

        public UserAcc? UserAcc { get; set; }//Navigator Property

        public int CourseDatabaseId { get; set; }//Foreign key Property
        public CourseDatabase? CourseDatabase { get; set; }//Navigator Property
       
        public int? ScoreId { get; set; }//Foreign key Property
        public Score? Score { get; set; }//Navigator Property
       



    }
}
