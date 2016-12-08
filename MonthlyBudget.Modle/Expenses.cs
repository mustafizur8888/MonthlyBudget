using System;
using System.ComponentModel.DataAnnotations;

namespace MonthlyBudget.Modle
{
    public class Expenses
    {
        [Key]
        public int ExpenseId { get; set; }
        public string MonthName { get; set; }
        public DateTime ExpenseDate { get; set; }

    }
}
