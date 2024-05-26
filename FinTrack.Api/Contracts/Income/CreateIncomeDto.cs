namespace FinTrack.Api.Contracts.Income
{
    public class CreateIncomeDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ExpenseVolume { get; set; }
        public int IncomeCategoryId { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}
