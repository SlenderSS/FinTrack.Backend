using FinTrack.Models;

namespace FinTrack.Api.Contracts.Budget
{
    public class ReadBudgetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal AmountOfMoney { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
