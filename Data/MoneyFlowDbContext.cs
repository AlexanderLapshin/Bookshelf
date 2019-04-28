using Models;
using System.Data.Entity;

namespace Data
{
    public class MoneyFlowDbContext : DbContext
    {
        public MoneyFlowDbContext() : base("moneyFlowDb")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MoneyFlowDbContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}
