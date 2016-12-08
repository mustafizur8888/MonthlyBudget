using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MonthlyBudget.Modle;


namespace MonthlyBudget.DataAccess
{
    public class MonthlyBudgetContext : DbContext
    {
        public MonthlyBudgetContext() : base("MonthlyBudgetContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Expenses> Expenseses { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<MonthlyBalance> MonthlyBalances { get; set; }

    }
}
