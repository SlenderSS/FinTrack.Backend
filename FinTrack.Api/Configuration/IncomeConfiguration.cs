

using FinTrack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinTrack.Api.Configuration;

public class IncomeConfiguration : IEntityTypeConfiguration<Income>
{
    public void Configure(EntityTypeBuilder<Income> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .HasOne(x => x.Budget)
            .WithMany(x => x.Incomes);

        builder
            .HasOne(x => x.IncomeCategory)
            .WithMany(x => x.Incomes);
    }
}
