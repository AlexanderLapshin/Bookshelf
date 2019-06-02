using Data;
using Models;
using MoneyFlow.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MoneyFlow
{
    public partial class MainForm : Form
    {

        // Balance control variables
        private User user;
        private UserBaseRepository _userBase = new UserBaseRepository();
        private TransactionsBaseRepository _transactionsBase = new TransactionsBaseRepository();
        private List<Transaction> allUserTransactions;
        private List<Transaction> periodTransactions;
        private readonly string[] ExpenseTypesArray = new string[10] { "Goods", "Restaurant", "Leisure", "Transport", "Health", "Gifts", "Family", "Clothes", "Food", "Other" };
        private readonly string[] IncomeTypesArray = new string[2] { "Salary", "Other" };


        // Calculator variables
        private int depositeMonths;
        private int depositeSum;
        private double depositePercents;
        private int depositeRepeats;
        private bool depositePercentsOnDeposite;
        private double sumAfterDeposite;

        // Menu
        Color tabColor = Color.FromArgb(20, 30, 48);
        Color activeTabColor = Color.FromArgb(36, 59, 85);


        public MainForm(User user)
        {
            InitializeComponent();

            // Balance controle initialize
            this.user = user;
            allUserTransactions = _transactionsBase.GetAllUserTransactions(user.Id);
            periodTransactions = allUserTransactions;

            // Calculator initialize
            depositeMonths = (int)numericUpDownDepositMonths.Value;
            depositePercents = (double)numericUpDownDepositPercents.Value;
            depositeSum = (int)numericUpDownDepositSum.Value;
            depositeRepeats = (int)numericUpDownDepositExtension.Value;
            depositePercentsOnDeposite = bunifuToggleSwitchDepositOnDeposit.Value;
        }

        private void OpenSignInForm()
        {
            Application.Run(new SignIn());
        }

        private void buttonMainFormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMainFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Balance control setup
            // Setting table
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

            bunifuDataGridViewMainFormTransactions.Columns.Add(Sum);
            bunifuDataGridViewMainFormTransactions.Columns.Add(Category);
            bunifuDataGridViewMainFormTransactions.Columns.Add(Date);
            bunifuDataGridViewMainFormTransactions.Columns.Add(Note);


            //Setting UI
            groupBoxMainFormBalance.Text = user.FirstName + " " + user.LastName;
            labelMainFormBalance.Text = user.Balance.ToString();

            Color textColor = (user.Balance >= 0) ? Color.LightGreen : Color.Red;
            labelMainFormBalance.ForeColor = textColor;
            labelMainFormBalanceText.ForeColor = textColor;


            foreach (Transaction transaction in allUserTransactions)
            {

                bunifuDataGridViewMainFormTransactions.Rows.Add(transaction.Sum, transaction.Type, transaction.Date, transaction.Note);

                chartMainFormBalance.Series[0].Points.AddY(transaction.CurrentBalance);
            }

            // Graphic settings
            comboBoxMainFormChartType.SelectedIndex = 0;
            comboBoxMainFormPeriod.SelectedIndex = comboBoxMainFormPeriod.Items.Count - 1;

            // Calculator chart setup
            sumAfterDeposite = Deposit.getDepositValue(depositeMonths, depositePercents, depositeSum, depositeRepeats, depositePercentsOnDeposite);
            drawDepositeChart(depositeSum, sumAfterDeposite);
        }

        private void buttonMainFormBalanceTab_Click(object sender, EventArgs e)
        {
            buttonMainFormBalanceTab.BackColor = activeTabColor;
            buttonMainFormDepositTab.BackColor = tabColor;
            bunifuPages1.SetPage(0);
        }

        private void buttonMainFormDepositTab_Click(object sender, EventArgs e)
        {
            buttonMainFormDepositTab.BackColor = activeTabColor;
            buttonMainFormBalanceTab.BackColor = tabColor;
            bunifuPages1.SetPage(1);
        }

        private void buttonMainFormLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread td = new Thread(OpenSignInForm);
            td.Start();
        }

        private void bunifuButtonMainFormAddTransaction_Click(object sender, EventArgs e)
        {
            double transactionSum = (double)numericUpDownMainFormTransactionSum.Value;
            transactionSum = Math.Round(transactionSum, 2, MidpointRounding.AwayFromZero);
            if (transactionSum != 0)
            {
                if (comboBoxMainFormTransactionType.SelectedItem != null)
                {
                    string transactionType = comboBoxMainFormTransactionType.SelectedItem.ToString();
                    string note = bunifuTextBoxMainFormTransactionNote.Text;
                    bunifuTextBoxMainFormTransactionNote.ResetText();

                    user.Balance += transactionSum;

                    Transaction transaction = _transactionsBase.AddTransaction(transactionSum, user.Id, transactionType, note, user.Balance);
                    allUserTransactions.Add(transaction);
                    periodTransactions.Add(transaction);

                    bunifuDataGridViewMainFormTransactions.Rows.Add(transaction.Sum, transaction.Type, transaction.Date, transaction.Note);
                    bunifuDataGridViewMainFormTransactions.FirstDisplayedScrollingRowIndex = bunifuDataGridViewMainFormTransactions.RowCount - 1;

                    chartMainFormBalance.Series[0].Points.AddY(transaction.CurrentBalance);
                    if (comboBoxMainFormChartType.SelectedIndex == 1)
                    {
                        DrawIncomeExpnsesChart(periodTransactions);
                    }
                    else if (comboBoxMainFormChartType.SelectedIndex == 2)
                    {
                        DrawExpensesChart(periodTransactions);
                    }

                    _userBase.SetBalance(user.Id, user.Balance);
                    labelMainFormBalance.Text = user.Balance.ToString();
                    labelMainFormBalance.ForeColor = labelMainFormBalanceText.ForeColor = (user.Balance >= 0) ? Color.LightGreen : Color.Red;
                }
                else
                {
                    MessageBox.Show("Choose type of transaction!");
                }
            }
        }

        private void numericUpDownMainFormTransactionSum_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownMainFormTransactionSum.Value >= 0)
            {
                numericUpDownMainFormTransactionSum.ForeColor = Color.Green;

                if (comboBoxMainFormTransactionType.Items.Contains("Goods"))
                {
                    comboBoxMainFormTransactionType.Items.Clear();
                    comboBoxMainFormTransactionType.Items.AddRange(IncomeTypesArray);
                    comboBoxMainFormTransactionType.SelectedIndex = 0;
                }
            }
            else
            {
                numericUpDownMainFormTransactionSum.ForeColor = Color.Red;
                if (comboBoxMainFormTransactionType.Items.Contains("Salary"))
                {
                    comboBoxMainFormTransactionType.Items.Clear();
                    comboBoxMainFormTransactionType.Items.AddRange(ExpenseTypesArray);
                    comboBoxMainFormTransactionType.SelectedIndex = 0;
                }
            }
        }

        private void comboBoxMainFormTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMainFormPeriod.SelectedIndex)
            {
                // Today
                case 0:
                    periodTransactions = _transactionsBase.GetTodayUserTransactions(user.Id);
                    break;

                // This week
                case 1:
                    periodTransactions = _transactionsBase.GetUserWeekTransactions(user.Id);
                    break;

                // This month
                case 2:
                    periodTransactions = _transactionsBase.GetUserMonthTransactions(user.Id);
                    break;

                // This year
                case 3:
                    periodTransactions = _transactionsBase.GetUserYearTransactions(user.Id);
                    break;

                // All time
                case 4:
                    periodTransactions = new List<Transaction>(allUserTransactions);
                    break;
            }
            DrawChart();
        }

        private void comboBoxMainFormChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMainFormChartType.SelectedIndex)
            {
                case 0:
                    chartMainFormBalance.Show();
                    chartMainFormExpenses.Hide();
                    DrawBalanceChart(periodTransactions);
                    break;
                case 1:
                    chartMainFormBalance.Hide();
                    chartMainFormExpenses.Show();
                    DrawIncomeExpnsesChart(periodTransactions);
                    break;
                case 2:
                    chartMainFormBalance.Hide();
                    chartMainFormExpenses.Show();
                    DrawExpensesChart(periodTransactions);
                    break;
            }
        }

        private void DrawChart()
        {
            switch (comboBoxMainFormChartType.SelectedIndex)
            {
                case 0:
                    DrawBalanceChart(periodTransactions);
                    break;
                case 1:
                    DrawIncomeExpnsesChart(periodTransactions);
                    break;
                case 2:
                    DrawExpensesChart(periodTransactions);
                    break;
            }
        }

        private void DrawBalanceChart(List<Transaction> transactions)
        {
            chartMainFormBalance.Series[0].Points.Clear();

            foreach (Transaction transaction in transactions)
            {
                chartMainFormBalance.Series[0].Points.AddY(transaction.CurrentBalance);
            }
        }

        private void DrawIncomeExpnsesChart(List<Transaction> transactions)
        {
            double income = 0, expenses = 0;

            chartMainFormExpenses.Titles[0].Visible = false;
            chartMainFormExpenses.Series[0].Points.Clear();

            foreach (Transaction transaction in transactions)
            {
                if (transaction.Sum > 0)
                {
                    income += transaction.Sum;
                }
                else
                {
                    expenses += transaction.Sum;
                }
            }
            chartMainFormExpenses.Series[0].Points.AddXY("Income\n" + income.ToString(), income);
            chartMainFormExpenses.Series[0].Points.AddXY("Expenses\n" + expenses.ToString(), Math.Abs(expenses));
        }

        private void DrawExpensesChart(List<Transaction> transactions)
        {
            double clothes = 0, family = 0, food = 0, gifts = 0, goods = 0, health = 0, leisure = 0, restaurant = 0, transport = 0, other = 0, allExpenses = 0;

            chartMainFormExpenses.Series[0].Points.Clear();

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
                        if (transaction.Sum < 0)
                        {
                            other += transaction.Sum;
                        }
                        break;
                }

                if (transaction.Sum < 0)
                {
                    allExpenses += transaction.Sum;
                }
            }

            chartMainFormExpenses.Titles[0].Visible = true;
            chartMainFormExpenses.Titles[0].Text = "All Expenses: " + Math.Abs(allExpenses);

            if (clothes != 0)
            {
                chartMainFormExpenses.Series[0].Points.AddXY("Clothes\n" + clothes.ToString(), Math.Abs(clothes));
            }

            if (family != 0)
            {
                chartMainFormExpenses.Series[0].Points.AddXY("Family\n" + family.ToString(), Math.Abs(family));
            }

            if (food != 0)
            {
                chartMainFormExpenses.Series[0].Points.AddXY("Food\n" + food.ToString(), Math.Abs(food));
            }

            if (gifts != 0)
            {
                chartMainFormExpenses.Series[0].Points.AddXY("Gifts\n" + gifts.ToString(), Math.Abs(gifts));
            }

            if (goods != 0)
            {
                chartMainFormExpenses.Series[0].Points.AddXY("Goods\n" + goods.ToString(), Math.Abs(goods));
            }

            if (health != 0)
            {
                chartMainFormExpenses.Series[0].Points.AddXY("Health\n" + health.ToString(), Math.Abs(health));
            }

            if (leisure != 0)
            {
                chartMainFormExpenses.Series[0].Points.AddXY("Leisure\n" + leisure.ToString(), Math.Abs(leisure));
            }

            if (restaurant != 0)
            {
                chartMainFormExpenses.Series[0].Points.AddXY("Restaurant\n" + restaurant.ToString(), Math.Abs(restaurant));
            }

            if (transport != 0)
            {
                chartMainFormExpenses.Series[0].Points.AddXY("Transport\n" + transport.ToString(), Math.Abs(transport));
            }

            if (other != 0)
            {
                chartMainFormExpenses.Series[0].Points.AddXY("Other\n" + other.ToString(), Math.Abs(other));
            }
        }


        // Calculator code     
        private void drawDepositeChart(double sum, double sumAfterDeposite)
        {
            chartDeposit.Series[0].Points.Clear();
            chartDeposit.Series[0].Points.AddXY("Invest", sum);
            chartDeposit.Series[0].Points[0].Color = Color.Yellow;
            chartDeposit.Series[0].Points.AddXY("Receive", sumAfterDeposite);
            chartDeposit.Series[0].Points[1].Color = Color.Green;
        }

        private void trackBarDepositMonths_Scroll(object sender, EventArgs e)
        {
            depositeMonths = trackBarDepositMonths.Value;
            numericUpDownDepositMonths.Value = depositeMonths;

            sumAfterDeposite = Deposit.getDepositValue(depositeMonths, depositePercents, depositeSum, depositeRepeats, depositePercentsOnDeposite);

            drawDepositeChart(depositeSum, sumAfterDeposite);
        }

        private void numericUpDownDepositMonths_ValueChanged(object sender, EventArgs e)
        {
            depositeMonths = (int)numericUpDownDepositMonths.Value;
            trackBarDepositMonths.Value = depositeMonths;

            sumAfterDeposite = Deposit.getDepositValue(depositeMonths, depositePercents, depositeSum, depositeRepeats, depositePercentsOnDeposite);

            drawDepositeChart(depositeSum, sumAfterDeposite);
        }

        private void trackBarDepositSum_Scroll(object sender, EventArgs e)
        {
            depositeSum = trackBarDepositSum.Value;
            numericUpDownDepositSum.Value = depositeSum;

            sumAfterDeposite = Deposit.getDepositValue(depositeMonths, depositePercents, depositeSum, depositeRepeats, depositePercentsOnDeposite);

            drawDepositeChart(depositeSum, sumAfterDeposite);
        }

        private void numericUpDownDepositSum_ValueChanged(object sender, EventArgs e)
        {
            depositeSum = (int)numericUpDownDepositSum.Value;
            trackBarDepositSum.Value = depositeSum;

            sumAfterDeposite = Deposit.getDepositValue(depositeMonths, depositePercents, depositeSum, depositeRepeats, depositePercentsOnDeposite);

            drawDepositeChart(depositeSum, sumAfterDeposite);
        }

        private void trackBarDepositExtension_Scroll(object sender, EventArgs e)
        {
            depositeRepeats = trackBarDepositExtension.Value;
            numericUpDownDepositExtension.Value = depositeRepeats;

            sumAfterDeposite = Deposit.getDepositValue(depositeMonths, depositePercents, depositeSum, depositeRepeats, depositePercentsOnDeposite);

            drawDepositeChart(depositeSum, sumAfterDeposite);
        }

        private void numericUpDownDepositExtension_ValueChanged(object sender, EventArgs e)
        {
            depositeRepeats = (int)numericUpDownDepositExtension.Value;
            trackBarDepositExtension.Value = depositeRepeats;

            sumAfterDeposite = Deposit.getDepositValue(depositeMonths, depositePercents, depositeSum, depositeRepeats, depositePercentsOnDeposite);

            drawDepositeChart(depositeSum, sumAfterDeposite);
        }

        private void numericUpDownDepositPercents_ValueChanged(object sender, EventArgs e)
        {
            depositePercents = (int)numericUpDownDepositPercents.Value;

            sumAfterDeposite = Deposit.getDepositValue(depositeMonths, depositePercents, depositeSum, depositeRepeats, depositePercentsOnDeposite);

            drawDepositeChart(depositeSum, sumAfterDeposite);
        }

        private void bunifuToggleSwitchDepositOnDeposit_OnValuechange(object sender, EventArgs e)
        {
            if (bunifuToggleSwitchDepositOnDeposit.Value)
            {
                depositePercentsOnDeposite = true;
            }
            else
            {
                depositePercentsOnDeposite = false;
            }

            sumAfterDeposite = Deposit.getDepositValue(depositeMonths, depositePercents, depositeSum, depositeRepeats, depositePercentsOnDeposite);

            drawDepositeChart(depositeSum, sumAfterDeposite);
        }
    }
}
