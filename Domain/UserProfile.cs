using Microsoft.EntityFrameworkCore;

namespace FSDProject.Domain
{
    public class UserProfile : BaseDomainModel
    {
        public int UserProfileId { get; set; }//Primary key property
        public string? Status { get; set; }
        public int? CurrentPoints { get; set; }

        public int? RewardId { get; set; }//Foreign keys
        public RewardShop? Reward { get; set; }//Navigator Property


        public int? CourseId { get; set; }//Foreign key
        [DeleteBehavior(DeleteBehavior.Restrict)]  // Meaning when parent deleted, this child will not be auto-deleted
        public Course? Course { get; set; }//Navigator Property
       


    }
}
