using System;

namespace Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public double Sum { get; set; }
        public ExpenseType Type { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public double CurrentBalance { get; set; }
        public bool Service { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
