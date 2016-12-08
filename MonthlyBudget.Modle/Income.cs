using System;
using System.ComponentModel.DataAnnotations;

namespace MonthlyBudget.Modle
{
    public class Income
    {
        [Key]
        public int IncomeId { get; set; }
        public string MonthName { get; set; }
        public DateTime IncomeDate { get; set; }

    }
}