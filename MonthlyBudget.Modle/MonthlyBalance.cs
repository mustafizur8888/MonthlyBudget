using System.ComponentModel.DataAnnotations;

namespace MonthlyBudget.Modle
{
    public class MonthlyBalance
    {
        [Key]
        public int BalanceId { get; set; }
        public string MonthName { get; set; }

        public double BalanceAmount { get; set; }

    }
}