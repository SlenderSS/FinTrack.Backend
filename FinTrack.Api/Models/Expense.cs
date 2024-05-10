using FinTrack.Models;

namespace FinTrack.DAL.MSSQL.Models
{
    public class Expense
    {
        public Expense()
        {
            
        }

        public Guid Id { get; set; }
        public decimal ExpenseVolume { get; set; }
        public DateTime ExpenseDate { get; set; }

        public Guid ExpenceCategoryId { get; set; }
        public ExpenceCategory ExpenceCategory { get; set; }


    }
}
