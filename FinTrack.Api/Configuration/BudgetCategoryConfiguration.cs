

using FinTrack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinTrack.Api.Configuration;

public class BudgetCategoryConfiguration : IEntityTypeConfiguration<BudgetCategory>
{
    public void Configure(EntityTypeBuilder<BudgetCategory> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .HasMany(x => x.Budgets)
            .WithOne(x => x.BudgetCategory);
    }
}
