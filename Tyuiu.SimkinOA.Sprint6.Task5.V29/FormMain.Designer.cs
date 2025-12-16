using System.Windows.Forms.DataVisualization.Charting;
namespace Tyuiu.SimkinOA.Sprint6.Task5.V29
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            splitterSplineandOutPut_SYP = new Splitter();
            panelForOutPutData_SYP = new Panel();
            groupBoxResult_SYP = new GroupBox();
            dataGridViewRes_SYP = new DataGridView();
            panelInPutTask_SYP = new Panel();
            groupBoxTask_SYP = new GroupBox();
            textBoxTask_SYP = new TextBox();
            buttonDoHelp_SYP = new Button();
            buttonToOpenFile_SYP = new Button();
            buttonDoResult_SYP = new Button();
            panelForFunction_SYP = new Panel();
            chartDiagRes_SYP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelForOutPutData_SYP.SuspendLayout();
            groupBoxResult_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_SYP).BeginInit();
            panelInPutTask_SYP.SuspendLayout();
            groupBoxTask_SYP.SuspendLayout();
            panelForFunction_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiagRes_SYP).BeginInit();
            SuspendLayout();
            // 
            // splitterSplineandOutPut_SYP
            // 
            splitterSplineandOutPut_SYP.Location = new Point(212, 106);
            splitterSplineandOutPut_SYP.Name = "splitterSplineandOutPut_SYP";
            splitterSplineandOutPut_SYP.Size = new Size(3, 344);
            splitterSplineandOutPut_SYP.TabIndex = 18;
            splitterSplineandOutPut_SYP.TabStop = false;
            // 
            // panelForOutPutData_SYP
            // 
            panelForOutPutData_SYP.Controls.Add(groupBoxResult_SYP);
            panelForOutPutData_SYP.Dock = DockStyle.Left;
            panelForOutPutData_SYP.Location = new Point(0, 106);
            panelForOutPutData_SYP.Name = "panelForOutPutData_SYP";
            panelForOutPutData_SYP.Size = new Size(212, 344);
            panelForOutPutData_SYP.TabIndex = 17;
            // 
            // groupBoxResult_SYP
            // 
            groupBoxResult_SYP.Controls.Add(dataGridViewRes_SYP);
            groupBoxResult_SYP.Dock = DockStyle.Fill;
            groupBoxResult_SYP.Location = new Point(0, 0);
            groupBoxResult_SYP.Name = "groupBoxResult_SYP";
            groupBoxResult_SYP.Size = new Size(212, 344);
            groupBoxResult_SYP.TabIndex = 8;
            groupBoxResult_SYP.TabStop = false;
            groupBoxResult_SYP.Text = "Вывод данных";
            // 
            // dataGridViewRes_SYP
            // 
            dataGridViewRes_SYP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_SYP.ColumnHeadersVisible = false;
            dataGridViewRes_SYP.Dock = DockStyle.Fill;
            dataGridViewRes_SYP.Location = new Point(3, 19);
            dataGridViewRes_SYP.Name = "dataGridViewRes_SYP";
            dataGridViewRes_SYP.RowHeadersVisible = false;
            dataGridViewRes_SYP.Size = new Size(206, 322);
            dataGridViewRes_SYP.TabIndex = 0;
            // 
            // panelInPutTask_SYP
            // 
            panelInPutTask_SYP.Controls.Add(groupBoxTask_SYP);
            panelInPutTask_SYP.Controls.Add(buttonDoHelp_SYP);
            panelInPutTask_SYP.Controls.Add(buttonToOpenFile_SYP);
            panelInPutTask_SYP.Controls.Add(buttonDoResult_SYP);
            panelInPutTask_SYP.Dock = DockStyle.Top;
            panelInPutTask_SYP.Location = new Point(0, 0);
            panelInPutTask_SYP.Name = "panelInPutTask_SYP";
            panelInPutTask_SYP.Size = new Size(800, 106);
            panelInPutTask_SYP.TabIndex = 15;
            // 
            // groupBoxTask_SYP
            // 
            groupBoxTask_SYP.Controls.Add(textBoxTask_SYP);
            groupBoxTask_SYP.Location = new Point(12, 3);
            groupBoxTask_SYP.Name = "groupBoxTask_SYP";
            groupBoxTask_SYP.Size = new Size(338, 94);
            groupBoxTask_SYP.TabIndex = 6;
            groupBoxTask_SYP.TabStop = false;
            groupBoxTask_SYP.Text = "Условие";
            // 
            // textBoxTask_SYP
            // 
            textBoxTask_SYP.BackColor = SystemColors.Control;
            textBoxTask_SYP.BorderStyle = BorderStyle.None;
            textBoxTask_SYP.Location = new Point(6, 18);
            textBoxTask_SYP.Multiline = true;
            textBoxTask_SYP.Name = "textBoxTask_SYP";
            textBoxTask_SYP.ReadOnly = true;
            textBoxTask_SYP.Size = new Size(326, 70);
            textBoxTask_SYP.TabIndex = 1;
            textBoxTask_SYP.Text = "Прочитать данные из файла InPutFileTask5V29.txt. Вывести в dataGridView. Вывести все числа, больше или равные 10.";
            // 
            // buttonDoHelp_SYP
            // 
            buttonDoHelp_SYP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDoHelp_SYP.BackColor = Color.DodgerBlue;
            buttonDoHelp_SYP.Location = new Point(694, 22);
            buttonDoHelp_SYP.Name = "buttonDoHelp_SYP";
            buttonDoHelp_SYP.Size = new Size(74, 40);
            buttonDoHelp_SYP.TabIndex = 9;
            buttonDoHelp_SYP.Text = "Справка";
            buttonDoHelp_SYP.UseVisualStyleBackColor = false;
            buttonDoHelp_SYP.Click += buttonHelp_Click;
            // 
            // buttonToOpenFile_SYP
            // 
            buttonToOpenFile_SYP.BackColor = Color.SteelBlue;
            buttonToOpenFile_SYP.Location = new Point(614, 21);
            buttonToOpenFile_SYP.Name = "buttonToOpenFile_SYP";
            buttonToOpenFile_SYP.Size = new Size(74, 40);
            buttonToOpenFile_SYP.TabIndex = 10;
            buttonToOpenFile_SYP.Text = "Открыть";
            buttonToOpenFile_SYP.UseVisualStyleBackColor = false;
            buttonToOpenFile_SYP.Click += buttonOpenFile_Click;
            // 
            // buttonDoResult_SYP
            // 
            buttonDoResult_SYP.BackColor = Color.Green;
            buttonDoResult_SYP.Location = new Point(524, 22);
            buttonDoResult_SYP.Name = "buttonDoResult_SYP";
            buttonDoResult_SYP.Size = new Size(84, 40);
            buttonDoResult_SYP.TabIndex = 5;
            buttonDoResult_SYP.Text = "Выполнить";
            buttonDoResult_SYP.UseVisualStyleBackColor = false;
            buttonDoResult_SYP.Click += buttonDone_Click;
            // 
            // panelForFunction_SYP
            // 
            panelForFunction_SYP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForFunction_SYP.AutoSize = true;
            panelForFunction_SYP.Controls.Add(chartDiagRes_SYP);
            panelForFunction_SYP.Location = new Point(215, 106);
            panelForFunction_SYP.Name = "panelForFunction_SYP";
            panelForFunction_SYP.Size = new Size(585, 344);
            panelForFunction_SYP.TabIndex = 16;
            // 
            // chartDiagRes_SYP
            // 
            chartArea1.Name = "ChartArea1";
            chartDiagRes_SYP.ChartAreas.Add(chartArea1);
            chartDiagRes_SYP.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiagRes_SYP.Legends.Add(legend1);
            chartDiagRes_SYP.Location = new Point(0, 0);
            chartDiagRes_SYP.Name = "chartDiagRes_SYP";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiagRes_SYP.Series.Add(series1);
            chartDiagRes_SYP.Size = new Size(585, 344);
            chartDiagRes_SYP.TabIndex = 0;
            chartDiagRes_SYP.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitterSplineandOutPut_SYP);
            Controls.Add(panelForOutPutData_SYP);
            Controls.Add(panelInPutTask_SYP);
            Controls.Add(panelForFunction_SYP);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 29 | Конева Д.Д. ";
            panelForOutPutData_SYP.ResumeLayout(false);
            groupBoxResult_SYP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_SYP).EndInit();
            panelInPutTask_SYP.ResumeLayout(false);
            groupBoxTask_SYP.ResumeLayout(false);
            groupBoxTask_SYP.PerformLayout();
            panelForFunction_SYP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiagRes_SYP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter splitterSplineandOutPut_SYP;
        private Panel panelForOutPutData_SYP;
        private GroupBox groupBoxResult_SYP;
        private Panel panelInPutTask_SYP;
        private GroupBox groupBoxTask_SYP;
        private TextBox textBoxTask_SYP;
        private Button buttonDoHelp_SYP;
        private Button buttonToOpenFile_SYP;
        private Button buttonDoResult_SYP;
        private Panel panelForFunction_SYP;
        private DataGridView dataGridViewRes_SYP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagRes_SYP;
    }
}