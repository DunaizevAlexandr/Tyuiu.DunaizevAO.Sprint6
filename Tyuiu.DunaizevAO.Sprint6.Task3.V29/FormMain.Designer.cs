namespace Tyuiu.DunaizevAO.Sprint6.Task3.V29
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
            ButtonDone_DAO = new Button();
            buttonHelp_DAO = new Button();
            groupBoxResult_DAO = new GroupBox();
            dataGridViewResult_DAO = new DataGridView();
            TestResult_DAO = new Label();
            GroupBoxTask_DAO = new GroupBox();
            textBox1 = new TextBox();
            groupBoxResult_DAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DAO).BeginInit();
            GroupBoxTask_DAO.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonDone_DAO
            // 
            ButtonDone_DAO.BackColor = Color.FromArgb(0, 64, 0);
            ButtonDone_DAO.Font = new Font("Segoe UI", 10F);
            ButtonDone_DAO.Location = new Point(237, 318);
            ButtonDone_DAO.Name = "ButtonDone_DAO";
            ButtonDone_DAO.Size = new Size(116, 65);
            ButtonDone_DAO.TabIndex = 14;
            ButtonDone_DAO.Text = "Выполнить";
            ButtonDone_DAO.UseVisualStyleBackColor = false;
            ButtonDone_DAO.Click += ButtonDone_DAO_Click_1;
            // 
            // buttonHelp_DAO
            // 
            buttonHelp_DAO.BackColor = SystemColors.Highlight;
            buttonHelp_DAO.Font = new Font("Segoe UI", 10F);
            buttonHelp_DAO.Location = new Point(137, 318);
            buttonHelp_DAO.Name = "buttonHelp_DAO";
            buttonHelp_DAO.Size = new Size(94, 65);
            buttonHelp_DAO.TabIndex = 13;
            buttonHelp_DAO.Text = "Справка";
            buttonHelp_DAO.UseVisualStyleBackColor = false;
            // 
            // groupBoxResult_DAO
            // 
            groupBoxResult_DAO.Controls.Add(dataGridViewResult_DAO);
            groupBoxResult_DAO.Controls.Add(TestResult_DAO);
            groupBoxResult_DAO.Location = new Point(359, 21);
            groupBoxResult_DAO.Name = "groupBoxResult_DAO";
            groupBoxResult_DAO.Size = new Size(340, 362);
            groupBoxResult_DAO.TabIndex = 12;
            groupBoxResult_DAO.TabStop = false;
            groupBoxResult_DAO.Text = "Вывод данных";
            // 
            // dataGridViewResult_DAO
            // 
            dataGridViewResult_DAO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_DAO.Location = new Point(9, 46);
            dataGridViewResult_DAO.Name = "dataGridViewResult_DAO";
            dataGridViewResult_DAO.ReadOnly = true;
            dataGridViewResult_DAO.RowHeadersVisible = false;
            dataGridViewResult_DAO.Size = new Size(317, 295);
            dataGridViewResult_DAO.TabIndex = 1;
            // 
            // TestResult_DAO
            // 
            TestResult_DAO.AutoSize = true;
            TestResult_DAO.Font = new Font("Segoe UI", 10F);
            TestResult_DAO.Location = new Point(9, 24);
            TestResult_DAO.Name = "TestResult_DAO";
            TestResult_DAO.Size = new Size(73, 19);
            TestResult_DAO.TabIndex = 0;
            TestResult_DAO.Text = "Результат:";
            // 
            // GroupBoxTask_DAO
            // 
            GroupBoxTask_DAO.Controls.Add(textBox1);
            GroupBoxTask_DAO.Location = new Point(12, 12);
            GroupBoxTask_DAO.Name = "GroupBoxTask_DAO";
            GroupBoxTask_DAO.Size = new Size(341, 300);
            GroupBoxTask_DAO.TabIndex = 10;
            GroupBoxTask_DAO.TabStop = false;
            GroupBoxTask_DAO.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(7, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 272);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дана матрица 5 на 5\r\n-2 -13 -15  -9 -17\r\n  13 -20 -15  27  18\r\n -12  -1 -20  13   0\r\n  15  32  18 -12 -18\r\n  16   5   3  -5  -8\r\nВыполнить сортировку по возрастанию в пятом столбце\r\n";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 400);
            Controls.Add(ButtonDone_DAO);
            Controls.Add(buttonHelp_DAO);
            Controls.Add(groupBoxResult_DAO);
            Controls.Add(GroupBoxTask_DAO);
            Name = "FormMain";
            Text = "Form1";
            groupBoxResult_DAO.ResumeLayout(false);
            groupBoxResult_DAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DAO).EndInit();
            GroupBoxTask_DAO.ResumeLayout(false);
            GroupBoxTask_DAO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonDone_DAO;
        private Button buttonHelp_DAO;
        private GroupBox groupBoxResult_DAO;
        private DataGridView dataGridViewResult_DAO;
        private Label TestResult_DAO;
        private GroupBox GroupBoxTask_DAO;
        private TextBox textBox1;
    }
}
