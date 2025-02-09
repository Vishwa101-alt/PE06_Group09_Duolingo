using FSDProject.Components.Pages;

namespace FSDProject.Domain
{
    public class UserAcc : BaseDomainModel
    {
        public int UserAccId { get; set; }//Primary key property
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; } = null;

        public ICollection<Course>? Courses { get; set; }//navigator property

        public int? UserProfileId { get; set; }//Foreign Property
        public UserProfile? UserProfile { get; set; }//navigator property
    }


}
