using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public double Balance { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
