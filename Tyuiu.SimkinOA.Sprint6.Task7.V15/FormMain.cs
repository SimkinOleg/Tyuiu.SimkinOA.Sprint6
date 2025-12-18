using Tyuiu.SimkinOA.Sprint6.Task7.V15.Lib;
namespace Tyuiu.SimkinOA.Sprint6.Task7.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SME.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialogMatrix_SME.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы (*.*)|*.";
            this.Text = "Спринт 6 | Таск 7 | Вариант 15 | Симкин О.А.";

            label1.Text = @"Дан файл InPutFileTask7V15.csv в котором хранится матрица целочисленных значений. " +
                "Загрузить файл через openFileDialog в объект dataGridViewIn. " +
                "Изменить в седьмом столбце элементы меньше 10 кратные 3 на 3. " +
                "Результат вывести в объект dataGridViewOut. " +
                "Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog.";
        }

        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }


        private void buttonDone_SME_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SME.ShowDialog();
            openFile = openFileDialogTask_SME.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewMatrixIn_SME.RowCount = rows;
            dataGridViewMatrixIn_SME.ColumnCount = columns;
            dataGridViewMatrixResult_SME.RowCount = rows;
            dataGridViewMatrixResult_SME.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixIn_SME.Columns[i].Width = 50;
                dataGridViewMatrixResult_SME.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMatrixIn_SME.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_SME.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMatrixResult_SME.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_SME.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewMatrixIn_SME.RowCount = 50;
            dataGridViewMatrixResult_SME.RowCount = 50;

            dataGridViewMatrixIn_SME.ColumnCount = 50;
            dataGridViewMatrixResult_SME.ColumnCount = 50;

            //panelMatrixIn_SME.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewMatrixIn_SME.Columns[i].Width = 25;
                dataGridViewMatrixResult_SME.Columns[i].Width = 25;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SME.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SME.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SME.ShowDialog();

            string path = saveFileDialogMatrix_SME.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMatrixResult_SME.RowCount;
            int columns = dataGridViewMatrixResult_SME.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewMatrixIn_SME.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewMatrixIn_SME.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }
    }

}