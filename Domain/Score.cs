using FSDProject.Components.Pages;

namespace FSDProject.Domain
{
    public class Score : BaseDomainModel
    {
        public int ScoreId { get; set; }//Primary key 
        public int? PointsAwarded { get; set; }

        public int StoreId { get; set; }//Foreign key 
        public StoreItem? StoreItem { get; set; }//Navigator Property
        public ICollection<Course>?Courses { get; set; }//Navigaor Property
        public int UserProfileId { get; set; }//Foreign keys
        public UserProfile? UserProfile { get; set; }//Navigator Property
        


    }
}
