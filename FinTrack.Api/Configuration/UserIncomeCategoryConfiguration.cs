

using FinTrack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinTrack.Api.Configuration;

public class UserIncomeCategoryConfiguration : IEntityTypeConfiguration<UserIncomeCategory>
{
    public void Configure(EntityTypeBuilder<UserIncomeCategory> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .HasOne(x => x.User)
            .WithMany(x => x.UserIncomeCategories);

    }
}