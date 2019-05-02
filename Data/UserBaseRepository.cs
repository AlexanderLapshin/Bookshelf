using Models;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace Data
{
    public class UserBaseRepository
    {
        private MoneyFlowDbContext moneyFlowDbContext = new MoneyFlowDbContext();


        public int SignIn(string username, string password)
        {
            /* Fetch the stored value */
            var user = moneyFlowDbContext.Users
                            .Where(u => u.Username == username)
                            .First();

            if (user != null)
            {
                /* Extract the bytes */
                byte[] hashBytes = Convert.FromBase64String(user.PasswordHash);

                /* Get the salt */
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);

                /* Compute the hash on the password the user entered */
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);

                /* Compare the results */
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        throw new UnauthorizedAccessException("Invalid username or password");
                    }
                }

                return user.Id;
            }
            throw new UnauthorizedAccessException("Invalid username or password");
        }

        public int SignUp(string username, string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            var user = new User()
            {
                Username = username,
                PasswordHash = savedPasswordHash,
                Balance = 0
            };

            moneyFlowDbContext.Users.Add(user);
            moneyFlowDbContext.SaveChanges();

            var initialTransaction = new Transaction()
            {
                Date = DateTime.Now,
                UserID = user.Id,
                Sum = 0,
                Service = true,
                Note = "Initial transaction; Open account",
                CurrentBalance = 0,
                Type = ExpenseType.Other
            };

            moneyFlowDbContext.Transactions.Add(initialTransaction);
            moneyFlowDbContext.SaveChanges();

            return user.Id;
        }

        public double GetBalance(int userId)
        {
            double balance = moneyFlowDbContext.Users.Single(u => u.Id == userId).Balance;

            return balance;
        }

        public void SetBalance(int userId, double balance)
        {
            User user = moneyFlowDbContext.Users.Single(u => u.Id == userId);
            user.Balance = balance;

            moneyFlowDbContext.SaveChanges();
        }
    }
}
