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



        public List<Transaction> GetAllUserTransactions(int userID)
        {
            List<Transaction> transactions = moneyFlowDbContext.Transactions
                                                 .Where(t => t.UserID == userID)
                                                 .ToList();

            return transactions;
        }

        public List<Transaction> GetTodayUserTransactions(int userID)
        {
            DateTime today = DateTime.Now.Date;

            List<Transaction> transactions = moneyFlowDbContext.Transactions
                                                .Where(t => t.UserID == userID)
                                                .Where(t => t.Date >= today)
                                                .ToList();

            return transactions;
        }

        public List<Transaction> GetUserWeekTransactions(int userID)
        {
            DateTime week = DateTime.Now.Date.AddDays(-7);

            List<Transaction> transactions = moneyFlowDbContext.Transactions
                                                .Where(t => t.UserID == userID)
                                                .Where(t => t.Date > week)
                                                .ToList();

            return transactions;
        }

        public List<Transaction> GetUserMonthTransactions(int userID)
        {
            DateTime date = DateTime.Now.Date;
            DateTime month = date.AddDays(-date.Day + 1);

            List<Transaction> transactions = moneyFlowDbContext.Transactions
                                                .Where(t => t.UserID == userID)
                                                .Where(t => t.Date > month)
                                                .ToList();

            return transactions;
        }

        public List<Transaction> GetUserYearTransactions(int userID)
        {
            DateTime date = DateTime.Now.Date;
            DateTime year = date.AddDays(-date.Day + 1).AddMonths(-date.Month + 1);

            List<Transaction> transactions = moneyFlowDbContext.Transactions
                                                .Where(t => t.UserID == userID)
                                                .Where(t => t.Date > year)
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
