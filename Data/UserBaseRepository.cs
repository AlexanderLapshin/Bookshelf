using Bookshelf.Exceptions;
using Data.Exceptions;
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
            User user = moneyFlowDbContext.Users
                            .Where(u => u.Username.Equals(username))
                            .FirstOrDefault();

            if (user != null && user.Username == username)
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
                        throw new InvalidPasswordException("Login Failed");
                    }
                }

                return user.Id;
            }
            throw new InvalidUsernameException("Login Failed");
        }

        //!!
        // MAKE VERIFICATION IF USER WItH THIS USERNAME ALREADY EXIST!!!
        //!!
        public int SignUp(string username, string password, string firstName, string lastName)
        {
            User user = moneyFlowDbContext.Users
                            .Where(u => u.Username == username)
                            .FirstOrDefault();

            if (user == null)
            {
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                string savedPasswordHash = Convert.ToBase64String(hashBytes);

                User newUser = new User()
                {
                    Username = username,
                    PasswordHash = savedPasswordHash,
                    FirstName = firstName,
                    LastName = lastName,
                    Balance = 0
                };

                moneyFlowDbContext.Users.Add(newUser);
                moneyFlowDbContext.SaveChanges();

                Transaction initialTransaction = new Transaction()
                {
                    Date = DateTime.Now,
                    UserID = newUser.Id,
                    Sum = 0,
                    Note = "You have created the account",
                    CurrentBalance = 0,
                    Type = ExpenseType.Other
                };

                moneyFlowDbContext.Transactions.Add(initialTransaction);
                moneyFlowDbContext.SaveChanges();

                return newUser.Id;
            }
            throw new InvalidUsernameException("This username already exists");
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
