using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data
{
    public class UserBaseRepository
    {
        private BookshelfDbContext bookshelfDbContext = new BookshelfDbContext();


        public bool SignIn(string username, string password)
        {
            /* Fetch the stored value */
            var user = bookshelfDbContext.Users
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
                    if (hashBytes[i + 16] != hash[i])
                        throw new UnauthorizedAccessException("Invalid username or password");
                return true;
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
                PasswordHash = savedPasswordHash
            };

            bookshelfDbContext.Users.Add(user);
            bookshelfDbContext.SaveChanges();

            return user.Id;
        }
    }
}
