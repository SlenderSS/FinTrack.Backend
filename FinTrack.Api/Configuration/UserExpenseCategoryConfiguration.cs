

using FinTrack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinTrack.Api.Configuration;

//public class UserExpenseCategoryConfiguration : IEntityTypeConfiguration<UserExpenseCategory>
//{
//    public void Configure(EntityTypeBuilder<UserExpenseCategory> builder)
//    {
//        builder
//            .HasKey(x => x.Id);

//        builder
//            .HasOne(x => x.User)
//            .WithMany(x => x.UserExpenseCategories)
//            .HasForeignKey(x => x.UserId);

//    }
//}
