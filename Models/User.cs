using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}
