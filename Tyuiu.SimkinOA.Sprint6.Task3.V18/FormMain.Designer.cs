namespace Tyuiu.SimkinOA.Sprint6.Task3.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_SMA = new GroupBox();
            pictureBoxTask_SMA = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonAbout_SMA = new Button();
            buttonExecute_SMA = new Button();
            dataGridViewTask_SMA = new DataGridView();
            groupBoxOutput_SMA = new GroupBox();
            dataGridViewResult_SMA = new DataGridView();
            labelResult_SMA = new Label();
            groupBoxTask_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_SMA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_SMA).BeginInit();
            groupBoxOutput_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SMA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_SMA
            // 
            groupBoxTask_SMA.Controls.Add(pictureBoxTask_SMA);
            groupBoxTask_SMA.Location = new Point(12, 12);
            groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            groupBoxTask_SMA.Size = new Size(410, 255);
            groupBoxTask_SMA.TabIndex = 0;
            groupBoxTask_SMA.TabStop = false;
            groupBoxTask_SMA.Text = "Условие";
            // 
            // pictureBoxTask_SMA
            // 
            pictureBoxTask_SMA.Image = (Image)resources.GetObject("pictureBoxTask_SMA.Image");
            pictureBoxTask_SMA.Location = new Point(6, 22);
            pictureBoxTask_SMA.Name = "pictureBoxTask_SMA";
            pictureBoxTask_SMA.Size = new Size(396, 226);
            pictureBoxTask_SMA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_SMA.TabIndex = 0;
            pictureBoxTask_SMA.TabStop = false;
            // 
            // buttonAbout_SMA
            // 
            buttonAbout_SMA.Location = new Point(12, 273);
            buttonAbout_SMA.Name = "buttonAbout_SMA";
            buttonAbout_SMA.Size = new Size(117, 43);
            buttonAbout_SMA.TabIndex = 1;
            buttonAbout_SMA.Text = "Справка";
            buttonAbout_SMA.UseVisualStyleBackColor = true;
            buttonAbout_SMA.Click += buttonAbout_SMA_Click;
            // 
            // buttonExecute_SMA
            // 
            buttonExecute_SMA.Location = new Point(135, 273);
            buttonExecute_SMA.Name = "buttonExecute_SMA";
            buttonExecute_SMA.Size = new Size(287, 43);
            buttonExecute_SMA.TabIndex = 2;
            buttonExecute_SMA.Text = "Выполнить";
            buttonExecute_SMA.UseVisualStyleBackColor = true;
            buttonExecute_SMA.Click += buttonExecute_SMA_Click;
            // 
            // dataGridViewTask_SMA
            // 
            dataGridViewTask_SMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask_SMA.Location = new Point(457, 67);
            dataGridViewTask_SMA.Name = "dataGridViewTask_SMA";
            dataGridViewTask_SMA.RowHeadersVisible = false;
            dataGridViewTask_SMA.Size = new Size(163, 163);
            dataGridViewTask_SMA.TabIndex = 3;
            // 
            // groupBoxOutput_SMA
            // 
            groupBoxOutput_SMA.Controls.Add(dataGridViewResult_SMA);
            groupBoxOutput_SMA.Controls.Add(labelResult_SMA);
            groupBoxOutput_SMA.Location = new Point(657, 12);
            groupBoxOutput_SMA.Name = "groupBoxOutput_SMA";
            groupBoxOutput_SMA.Size = new Size(255, 304);
            groupBoxOutput_SMA.TabIndex = 1;
            groupBoxOutput_SMA.TabStop = false;
            groupBoxOutput_SMA.Text = "Вывод данных";
            // 
            // dataGridViewResult_SMA
            // 
            dataGridViewResult_SMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SMA.Location = new Point(41, 55);
            dataGridViewResult_SMA.Name = "dataGridViewResult_SMA";
            dataGridViewResult_SMA.RowHeadersVisible = false;
            dataGridViewResult_SMA.Size = new Size(163, 163);
            dataGridViewResult_SMA.TabIndex = 4;
            // 
            // labelResult_SMA
            // 
            labelResult_SMA.AutoSize = true;
            labelResult_SMA.Location = new Point(6, 22);
            labelResult_SMA.Name = "labelResult_SMA";
            labelResult_SMA.Size = new Size(63, 15);
            labelResult_SMA.TabIndex = 4;
            labelResult_SMA.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 328);
            Controls.Add(groupBoxOutput_SMA);
            Controls.Add(dataGridViewTask_SMA);
            Controls.Add(buttonExecute_SMA);
            Controls.Add(buttonAbout_SMA);
            Controls.Add(groupBoxTask_SMA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 18 |  Симонов М.А.";
            Load += FormMain_Load;
            groupBoxTask_SMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_SMA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_SMA).EndInit();
            groupBoxOutput_SMA.ResumeLayout(false);
            groupBoxOutput_SMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SMA;
        private PictureBox pictureBoxTask_SMA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonAbout_SMA;
        private Button buttonExecute_SMA;
        private DataGridView dataGridViewTask_SMA;
        private GroupBox groupBoxOutput_SMA;
        private Label labelResult_SMA;
        private DataGridView dataGridViewResult_SMA;
    }
}