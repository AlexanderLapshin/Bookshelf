using Data;
using Models;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshelf
{
    public partial class MainForm : Form
    {
        private int userId;
        private string username;
        private double userBalance;
        private UserBaseRepository _userBase = new UserBaseRepository();
        private TransactionsBaseRepository _transactionsBase = new TransactionsBaseRepository();
        private List<Transaction> transactions;
        private readonly string[] ExpenseTypesArray = new string[10] { "Goods", "Restaurant", "Leisure", "Transport", "Health", "Gifts", "Family", "Clothes", "Food", "Other" };
        private readonly string[] IncomeTypesArray = new string[2] { "Salary", "Other" };

        public MainForm(int userId, string username)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
            userBalance = _userBase.GetBalance(userId);

            transactions = _transactionsBase.GetUserTransactions(userId);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            // Setting table;
            DataGridViewColumn Sum = new DataGridViewColumn();
            Sum.HeaderText = "Sum";
            Sum.CellTemplate = new DataGridViewTextBoxCell();

            DataGridViewColumn Category = new DataGridViewColumn();
            Category.HeaderText = "Category";
            Category.CellTemplate = new DataGridViewTextBoxCell();

            DataGridViewColumn Date = new DataGridViewColumn();
            Date.HeaderText = "Date";
            Date.CellTemplate = new DataGridViewTextBoxCell();

            DataGridViewColumn Note = new DataGridViewColumn();
            Note.HeaderText = "Note";
            Note.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(Sum);
            dataGridView1.Columns.Add(Category);
            dataGridView1.Columns.Add(Date);
            dataGridView1.Columns.Add(Note);


            //Setting UI
            groupBox2.Text = username;
            labelBalance.Text = userBalance.ToString();

            Color textColor = (userBalance >= 0) ? Color.Green : Color.Red;
            labelBalance.ForeColor = textColor;
            labelBalance2.ForeColor = textColor;

            foreach (Transaction transaction in transactions)
            {
                dataGridView1.Rows.Add(transaction.Sum, transaction.Type, transaction.Date, transaction.Note);
            }

        }

        private void addTransactionButton_Click(object sender, System.EventArgs e)
        {
            double sum = (double)numericUpDownValue.Value;
            if (sum != 0)
            {
                if (comboBoxType.SelectedItem != null)
                {
                    string type = comboBoxType.SelectedItem.ToString();
                    string note = (textBoxNote.Text == "Notes") ? " " : textBoxNote.Text;
                    Transaction transaction = _transactionsBase.AddTransaction(sum, userId, type, note);
                    dataGridView1.Rows.Add(transaction.Sum, transaction.Type, transaction.Date, transaction.Note);

                    userBalance += sum;
                    _userBase.SetBalance(userId, userBalance);
                    labelBalance.Text = userBalance.ToString();
                    labelBalance.ForeColor = (userBalance >= 0) ? Color.Green : Color.Red;
                }
                else
                {
                    MessageBox.Show("Choose type of transaction!");
                }
            }
            else
            {
                MessageBox.Show("Enter sum of transaction!");
            }
        }

        private void numericUpDownValue_ValueChanged(object sender, System.EventArgs e)
        {
            if (numericUpDownValue.Value >= 0)
            {
                numericUpDownValue.ForeColor = Color.Green;

                if (comboBoxType.Items.Contains("Goods"))
                {
                    comboBoxType.Items.Clear();
                    comboBoxType.Items.AddRange(IncomeTypesArray);
                }
            }
            else
            {
                numericUpDownValue.ForeColor = Color.Red;
                if (comboBoxType.Items.Contains("Salary"))
                {
                    comboBoxType.Items.Clear();
                    comboBoxType.Items.AddRange(ExpenseTypesArray);
                }
            }
        }
    }
}
