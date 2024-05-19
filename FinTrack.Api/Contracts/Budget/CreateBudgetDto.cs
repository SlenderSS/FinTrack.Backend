namespace FinTrack.Api.Contracts.Budget
{
    public class CreateBudgetDto
    {
        public string Name { get; set; }
        public decimal AmountOfMoney { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
