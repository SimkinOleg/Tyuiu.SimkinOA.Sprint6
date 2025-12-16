using Tyuiu.SimkinOA.Sprint6.Task5.V29.Lib;
namespace Tyuiu.SimkinOA.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\konev\source\repos\Tyuiu.KonevaDD.Sprint6\Tyuiu.KonevaDD.Sprint6.Task5.V29\bin\Debug\net8.0-windows\InPutDataFileTask5V29.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewRes_SYP.ColumnCount = 2;
            dataGridViewRes_SYP.Columns[0].Width = 20;
            dataGridViewRes_SYP.Columns[1].Width = 50;

            this.chartDiagRes_SYP.ChartAreas[0].AxisX.Title = "Îñü X";
            this.chartDiagRes_SYP.ChartAreas[0].AxisY.Title = "Îñü Y";

            chartDiagRes_SYP.Series[0].Points.Clear();

            double[] numsArray = new double[ds.len];

            numsArray = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsArray.Length; i++)
            {
                dataGridViewRes_SYP.Rows.Add(Convert.ToString(i), Convert.ToString(numsArray[i]));
                chartDiagRes_SYP.Series[0].Points.AddXY(i, numsArray[i]);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы АСОиУБ-24-1 Конева Дарья Денисовна ", "О программе ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}