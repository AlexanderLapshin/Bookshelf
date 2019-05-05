using Data;
using Models;
using System;
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
        private List<Transaction> allUserTransactions;
        private List<Transaction> periodTransactions;
        private readonly string[] ExpenseTypesArray = new string[10] { "Goods", "Restaurant", "Leisure", "Transport", "Health", "Gifts", "Family", "Clothes", "Food", "Other" };
        private readonly string[] IncomeTypesArray = new string[2] { "Salary", "Other" };

        public MainForm(int userId, string username)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
            userBalance = _userBase.GetBalance(userId);

            allUserTransactions = _transactionsBase.GetAllUserTransactions(userId);
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


            foreach (Transaction transaction in allUserTransactions)
            {
                if (!transaction.Service)
                {
                    dataGridView1.Rows.Add(transaction.Sum, transaction.Type, transaction.Date, transaction.Note);
                }

                chartBalance.Series[0].Points.AddY(transaction.CurrentBalance);
            }

            // Graphic settings
            comboBoxGraphicType.SelectedIndex = 0;
            comboBoxPeriod.SelectedIndex = comboBoxPeriod.Items.Count - 1;



        }

        private void addTransactionButton_Click(object sender, System.EventArgs e)
        {
            double transactionSum = (double)numericUpDownValue.Value;
            if (transactionSum != 0)
            {
                if (comboBoxType.SelectedItem != null)
                {
                    string transactionType = comboBoxType.SelectedItem.ToString();
                    string note = (textBoxNote.Text == "Notes") ? " " : textBoxNote.Text;

                    userBalance += transactionSum;

                    Transaction transaction = _transactionsBase.AddTransaction(transactionSum, userId, transactionType, note, userBalance);
                    allUserTransactions.Add(transaction);

                    dataGridView1.Rows.Add(transaction.Sum, transaction.Type, transaction.Date, transaction.Note);
                    chartBalance.Series[0].Points.AddY(transaction.CurrentBalance);

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

        private void comboBoxPeriod_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch

            // Clear graphics
            chartBalance.Series[0].Points.Clear();
            chartExpenses.Series[0].Points.Clear();

            if (comboBoxGraphicType.SelectedIndex == 0)
            {
                DrawBalanceChart(periodTransactions);
            }
            else
            {
                DrawExpensesChart(periodTransactions);
            }
        }

        private void comboBoxGraphicType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxGraphicType.SelectedIndex == 0)
            {
                chartBalance.Show();
                chartExpenses.Hide();
                DrawBalanceChart(periodTransactions);
            }
            else
            {
                chartBalance.Hide();
                chartExpenses.Show();
                DrawExpensesChart(periodTransactions);
            }
        }


        private void DrawBalanceChart(List<Transaction> transactions)
        {
            foreach (Transaction transaction in transactions)
            {
                chartBalance.Series[0].Points.AddY(transaction.CurrentBalance);
            }
        }

        private void DrawExpensesChart(List<Transaction> transactions)
        {
            double clothes = 0, family = 0, food = 0, gifts = 0, goods = 0, health = 0, leisure = 0, restaurant = 0, transport = 0, other = 0;

            foreach (Transaction transaction in transactions)
            {
                switch (transaction.Type)
                {
                    case ExpenseType.Clothes:
                        clothes += transaction.Sum;
                        break;
                    case ExpenseType.Family:
                        family += transaction.Sum;
                        break;
                    case ExpenseType.Food:
                        food += transaction.Sum;
                        break;
                    case ExpenseType.Gifts:
                        gifts += transaction.Sum;
                        break;
                    case ExpenseType.Goods:
                        goods += transaction.Sum;
                        break;
                    case ExpenseType.Health:
                        health += transaction.Sum;
                        break;
                    case ExpenseType.Leisure:
                        leisure += transaction.Sum;
                        break;
                    case ExpenseType.Restaurant:
                        restaurant += transaction.Sum;
                        break;
                    case ExpenseType.Transport:
                        transport += transaction.Sum;
                        break;
                    case ExpenseType.Other:
                        other += transaction.Sum;
                        break;
                }
            }

            chartExpenses.Series[0].Points.AddXY("Clothes", Math.Abs(clothes));
            chartExpenses.Series[0].Points.AddXY("Family", Math.Abs(family));
            chartExpenses.Series[0].Points.AddXY("Food", Math.Abs(food));
            chartExpenses.Series[0].Points.AddXY("Gifts", Math.Abs(gifts));
            chartExpenses.Series[0].Points.AddXY("Goods", Math.Abs(goods));
            chartExpenses.Series[0].Points.AddXY("Health", Math.Abs(health));
            chartExpenses.Series[0].Points.AddXY("Leisure", Math.Abs(leisure));
            chartExpenses.Series[0].Points.AddXY("Restaurant", Math.Abs(restaurant));
            chartExpenses.Series[0].Points.AddXY("Transport", Math.Abs(transport));
            chartExpenses.Series[0].Points.AddXY("Other", Math.Abs(other));
        }
    }
}
