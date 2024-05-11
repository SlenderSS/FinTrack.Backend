

using FinTrack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinTrack.Api.Configuration;

public class IncomeCategoryConfiguration : IEntityTypeConfiguration<IncomeCategory>
{
    public void Configure(EntityTypeBuilder<IncomeCategory> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .HasMany(x => x.Incomes)
            .WithOne(x => x.IncomeCategory);
    }
}
