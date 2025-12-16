using Tyuiu.SimkinOA.Sprint6.Task3.V18.Lib;
namespace Tyuiu.SimkinOA.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        int[,] matrix = { { -19, -19, 1, 18, 7 },
                             { 5, 3, -4, -6, -12 },
                             { -15, 6, 2, 2, -14, },
                             { -9, -10, 15, -5, -6 },
                             { -13, -15, -9, 7, 1 } };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewTask_SMA.ColumnCount = columns;
            dataGridViewTask_SMA.RowCount = rows;

            dataGridViewResult_SMA.ColumnCount = columns;
            dataGridViewResult_SMA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewTask_SMA.Columns[i].Width = 25;
                dataGridViewResult_SMA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTask_SMA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonAbout_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Îøèáêà", "1", MessageBoxButtons.OK);
        }

        private void buttonExecute_SMA_Click(object sender, EventArgs e)
        {
            int[,] result_matrix = ds.Calculate(matrix);

            int rows = result_matrix.GetUpperBound(0) + 1;
            int columns = result_matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_SMA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}