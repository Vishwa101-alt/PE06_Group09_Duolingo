using FSDProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject.Configurations.Entities
{
    public class RewardShopSeed : IEntityTypeConfiguration<RewardShop>
    {
        public void Configure(EntityTypeBuilder<RewardShop> builder)
        {
            builder.HasData(
                new RewardShop
                {
                    RewardShopId = 1,
                    RewardType = "Monitor",
                    PointCost = "500 points"

                },
                new RewardShop
                {
                    RewardShopId = 2,
                    RewardType = "Microphone",
                    PointCost = "450 points"

                },
                new RewardShop
                {
                    RewardShopId = 3,
                    RewardType = "Laptop",
                    PointCost = "1000 points"

                },
                new RewardShop
                {
                    RewardShopId = 4,
                    RewardType = "PowerBank",
                    PointCost = "300 points"

                },
                new RewardShop
                {
                    RewardShopId = 5,
                    RewardType = "AppleWatch",
                    PointCost = "600 points"
                }
            );
        }
    }
}
