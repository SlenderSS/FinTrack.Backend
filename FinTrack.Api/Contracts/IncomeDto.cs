namespace FinTrack.Api.Contracts
{
    public class IncomeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ExpenseVolume { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}
