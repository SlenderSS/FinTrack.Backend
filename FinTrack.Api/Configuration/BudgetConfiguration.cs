

using FinTrack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinTrack.Api.Configuration;

public class BudgetConfiguration : IEntityTypeConfiguration<Budget>
{
    public void Configure(EntityTypeBuilder<Budget> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .HasOne(x => x.User)
            .WithMany(x => x.Budgets);

        builder
            .HasOne(x => x.BudgetCategory)
            .WithMany(x => x.Budgets);

        builder
            .HasOne(x => x.Currency)
            .WithMany(x => x.Budgets);

        builder
            .HasMany(x => x.Expences)
            .WithOne(x => x.Budget);

        builder
            .HasMany(x => x.Incomes)
            .WithOne(x => x.Budget);
    }
}
