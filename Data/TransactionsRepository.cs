using Models;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class TransactionsRepository
    {
        private MoneyFlowDbContext moneyFlowDbContext = new MoneyFlowDbContext();

        Dictionary<int, ExpenseType> transactionsTypes = new Dictionary<int, ExpenseType>()
        {
            [1] = ExpenseType.salary,
            [2] = ExpenseType.goods,
            [3] = ExpenseType.restaurant,
            [4] = ExpenseType.leisure,
            [5] = ExpenseType.transport,
            [6] = ExpenseType.health,
            [7] = ExpenseType.gifts,
            [8] = ExpenseType.family,
            [9] = ExpenseType.clothes,
            [10] = ExpenseType.food,
            [11] = ExpenseType.other
        };



        public List<Transaction> GetUserTransactions(int userID)
        {
            List<Transaction> transactions = moneyFlowDbContext.Transactions
                                                 .Where(t => t.UserID == userID)
                                                 .ToList();

            return transactions;
        }

        public void AddTransaction(int sum, int userId, int type, string note)
        {
            ExpenseType expenseType;
            if (transactionsTypes.TryGetValue(type, out expenseType))
            {
                Transaction transaction = new Transaction()
                {
                    Sum = sum,
                    UserID = userId,
                    Type = expenseType,
                    Note = note
                };

                moneyFlowDbContext.Transactions.Add(transaction);
                moneyFlowDbContext.SaveChanges();
            }

        }
    }
}
