﻿namespace FinTrack.Api.Contracts.Income
{
    public class ReadIncomeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ExpenseVolume { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}