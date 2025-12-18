using Tyuiu.SimkinOA.Sprint6.Task7.V15.Lib;
namespace Tyuiu.SimkinOA.Sprint6.Task7.V15
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
            buttonDone_SME = new Button();
            buttonSave_SME = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridViewMatrixIn_SME = new DataGridView();
            groupBox3 = new GroupBox();
            dataGridViewMatrixResult_SME = new DataGridView();
            openFileDialogTask_SME = new OpenFileDialog();
            saveFileDialogMatrix_SME = new SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixIn_SME).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixResult_SME).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_SME
            // 
            buttonDone_SME.Image = Properties.Resources.folder_page;
            buttonDone_SME.Location = new Point(12, 12);
            buttonDone_SME.Name = "buttonDone_SME";
            buttonDone_SME.Size = new Size(81, 54);
            buttonDone_SME.TabIndex = 0;
            buttonDone_SME.UseVisualStyleBackColor = true;
            buttonDone_SME.Click += buttonDone_SME_Click;
            // 
            // buttonSave_SME
            // 
            buttonSave_SME.Image = Properties.Resources.page_white_go;
            buttonSave_SME.Location = new Point(99, 12);
            buttonSave_SME.Name = "buttonSave_SME";
            buttonSave_SME.Size = new Size(81, 54);
            buttonSave_SME.TabIndex = 1;
            buttonSave_SME.UseVisualStyleBackColor = true;
            buttonSave_SME.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.page_save;
            button3.Location = new Point(186, 12);
            button3.Name = "button3";
            button3.Size = new Size(81, 54);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.information;
            button4.Location = new Point(803, 12);
            button4.Name = "button4";
            button4.Size = new Size(81, 54);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(874, 90);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewMatrixIn_SME);
            groupBox2.Location = new Point(16, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(482, 262);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод:";
            // 
            // dataGridViewMatrixIn_SME
            // 
            dataGridViewMatrixIn_SME.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixIn_SME.Location = new Point(6, 22);
            dataGridViewMatrixIn_SME.Name = "dataGridViewMatrixIn_SME";
            dataGridViewMatrixIn_SME.Size = new Size(476, 234);
            dataGridViewMatrixIn_SME.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewMatrixResult_SME);
            groupBox3.Location = new Point(504, 176);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(380, 262);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // dataGridViewMatrixResult_SME
            // 
            dataGridViewMatrixResult_SME.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixResult_SME.Location = new Point(6, 22);
            dataGridViewMatrixResult_SME.Name = "dataGridViewMatrixResult_SME";
            dataGridViewMatrixResult_SME.Size = new Size(368, 234);
            dataGridViewMatrixResult_SME.TabIndex = 1;
            // 
            // openFileDialogTask_SME
            // 
            openFileDialogTask_SME.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(buttonSave_SME);
            Controls.Add(buttonDone_SME);
            Name = "FormMain";
            Text = "э";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixIn_SME).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixResult_SME).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_SME;
        private Button buttonSave_SME;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridViewMatrixIn_SME;
        private DataGridView dataGridViewMatrixResult_SME;
        private OpenFileDialog openFileDialogTask_SME;
        private SaveFileDialog saveFileDialogMatrix_SME;
    }
}