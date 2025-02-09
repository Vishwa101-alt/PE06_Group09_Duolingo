namespace FSDProject.Domain
{
    public class RewardShop : BaseDomainModel
    {
        public int RewardShopId { get; set; }//Primary key property
        public string? RewardType { get; set; }
        public string? PointCost { get; set; }

        public ICollection<UserProfile>? UserProfile { get; set; }//Navigator Property

    }
}
