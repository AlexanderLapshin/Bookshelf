using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class TransactionsBaseRepository
    {
        private MoneyFlowDbContext moneyFlowDbContext = new MoneyFlowDbContext();

        Dictionary<string, ExpenseType> transactionsTypes = new Dictionary<string, ExpenseType>()
        {
            ["Salary"] = ExpenseType.Salary,
            ["Goods"] = ExpenseType.Goods,
            ["Restaurant"] = ExpenseType.Restaurant,
            ["Leisure"] = ExpenseType.Leisure,
            ["Transport"] = ExpenseType.Transport,
            ["Health"] = ExpenseType.Health,
            ["Gifts"] = ExpenseType.Gifts,
            ["Family"] = ExpenseType.Family,
            ["Clothes"] = ExpenseType.Clothes,
            ["Food"] = ExpenseType.Food,
            ["Other"] = ExpenseType.Other
        };



        public List<Transaction> GetUserTransactions(int userID)
        {
            List<Transaction> transactions = moneyFlowDbContext.Transactions
                                                 .Where(t => t.UserID == userID)
                                                 .ToList();

            return transactions;
        }

        public Transaction AddTransaction(double sum, int userId, string type, string note, double curBalance)
        {
            ExpenseType expenseType;
            if (transactionsTypes.TryGetValue(type, out expenseType))
            {
                Transaction transaction = new Transaction()
                {
                    Sum = sum,
                    UserID = userId,
                    Type = expenseType,
                    Date = DateTime.Now,
                    CurrentBalance = curBalance,
                    Note = note
                };

                moneyFlowDbContext.Transactions.Add(transaction);
                moneyFlowDbContext.SaveChanges();

                return transaction;
            }

            throw new ArgumentException();

        }
    }
}
