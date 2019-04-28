using System;

namespace Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int Sum { get; set; }
        public ExpenseType Type { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
