using System.Windows.Forms;

namespace Bookshelf
{
    public partial class MainForm : Form
    {
        private int userId;
        public MainForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

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
        }
    }
}
