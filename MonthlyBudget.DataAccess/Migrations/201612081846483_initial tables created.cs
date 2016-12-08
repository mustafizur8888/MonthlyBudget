namespace MonthlyBudget.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialtablescreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        ExpenseId = c.Int(nullable: false, identity: true),
                        MonthName = c.String(),
                        ExpenseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ExpenseId);
            
            CreateTable(
                "dbo.Income",
                c => new
                    {
                        IncomeId = c.Int(nullable: false, identity: true),
                        MonthName = c.String(),
                        IncomeDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IncomeId);
            
            CreateTable(
                "dbo.MonthlyBalance",
                c => new
                    {
                        BalanceId = c.Int(nullable: false, identity: true),
                        MonthName = c.String(),
                        BalanceAmount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BalanceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MonthlyBalance");
            DropTable("dbo.Income");
            DropTable("dbo.Expenses");
        }
    }
}
