

using FinTrack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinTrack.Api.Configuration;

//public class UserBudgetCategoryConfiguration : IEntityTypeConfiguration<UserBudgetCategory>
//{
//    public void Configure(EntityTypeBuilder<UserBudgetCategory> builder)
//    {
//        builder
//            .HasKey(x => x.Id);

//        builder
//            .HasOne(x => x.User)
//            .WithMany(x => x.UserBudgetCategories)
//            .HasForeignKey(x => x.UserId);

//    }
//}
