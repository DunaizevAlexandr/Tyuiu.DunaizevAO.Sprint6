namespace Tyuiu.DunaizevAO.Sprint6.Task2.V15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            ButtonDone_DAO = new Button();
            buttonHelp_DAO = new Button();
            groupBoxResult_DAO = new GroupBox();
            chartResult_DAO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult_DAO = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            fx = new DataGridViewTextBoxColumn();
            TestResult_DAO = new Label();
            groupBoxInput_DAO = new GroupBox();
            textBoxStopStep_DAO = new TextBox();
            TextStop_DAO = new Label();
            textBoxStartStep_DAO = new TextBox();
            TextStart_DAO = new Label();
            GroupBoxTask_DAO = new GroupBox();
            pictureBoxTask_DAO = new PictureBox();
            TextTask_DAO = new Label();
            groupBoxResult_DAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_DAO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DAO).BeginInit();
            groupBoxInput_DAO.SuspendLayout();
            GroupBoxTask_DAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_DAO).BeginInit();
            SuspendLayout();
            // 
            // ButtonDone_DAO
            // 
            ButtonDone_DAO.BackColor = Color.FromArgb(0, 64, 0);
            ButtonDone_DAO.Font = new Font("Segoe UI", 10F);
            ButtonDone_DAO.Location = new Point(419, 341);
            ButtonDone_DAO.Name = "ButtonDone_DAO";
            ButtonDone_DAO.Size = new Size(116, 65);
            ButtonDone_DAO.TabIndex = 9;
            ButtonDone_DAO.Text = "Выполнить";
            ButtonDone_DAO.UseVisualStyleBackColor = false;
            ButtonDone_DAO.Click += ButtonDone_DAO_Click;
            ButtonDone_DAO.MouseDown += ButtonDone_DAO_MouseDown;
            ButtonDone_DAO.MouseEnter += ButtonDone_DAO_MouseEnter;
            ButtonDone_DAO.MouseLeave += ButtonDone_DAO_MouseLeave;
            // 
            // buttonHelp_DAO
            // 
            buttonHelp_DAO.BackColor = SystemColors.Highlight;
            buttonHelp_DAO.Font = new Font("Segoe UI", 10F);
            buttonHelp_DAO.Location = new Point(319, 341);
            buttonHelp_DAO.Name = "buttonHelp_DAO";
            buttonHelp_DAO.Size = new Size(94, 65);
            buttonHelp_DAO.TabIndex = 8;
            buttonHelp_DAO.Text = "Справка";
            buttonHelp_DAO.UseVisualStyleBackColor = false;
            buttonHelp_DAO.Click += buttonHelp_DAO_Click;
            // 
            // groupBoxResult_DAO
            // 
            groupBoxResult_DAO.Controls.Add(chartResult_DAO);
            groupBoxResult_DAO.Controls.Add(dataGridViewResult_DAO);
            groupBoxResult_DAO.Controls.Add(TestResult_DAO);
            groupBoxResult_DAO.Location = new Point(551, 44);
            groupBoxResult_DAO.Name = "groupBoxResult_DAO";
            groupBoxResult_DAO.Size = new Size(750, 362);
            groupBoxResult_DAO.TabIndex = 7;
            groupBoxResult_DAO.TabStop = false;
            groupBoxResult_DAO.Text = "Вывод данных";
            // 
            // chartResult_DAO
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_DAO.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult_DAO.Legends.Add(legend1);
            chartResult_DAO.Location = new Point(228, 32);
            chartResult_DAO.Name = "chartResult_DAO";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_DAO.Series.Add(series1);
            chartResult_DAO.Size = new Size(516, 324);
            chartResult_DAO.TabIndex = 2;
            chartResult_DAO.Text = "chart1";
            // 
            // dataGridViewResult_DAO
            // 
            dataGridViewResult_DAO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_DAO.Columns.AddRange(new DataGridViewColumn[] { X, fx });
            dataGridViewResult_DAO.Location = new Point(17, 32);
            dataGridViewResult_DAO.Name = "dataGridViewResult_DAO";
            dataGridViewResult_DAO.ReadOnly = true;
            dataGridViewResult_DAO.RowHeadersVisible = false;
            dataGridViewResult_DAO.Size = new Size(205, 324);
            dataGridViewResult_DAO.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            // 
            // fx
            // 
            fx.HeaderText = "F(x)";
            fx.Name = "fx";
            fx.ReadOnly = true;
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
            // groupBoxInput_DAO
            // 
            groupBoxInput_DAO.Controls.Add(textBoxStopStep_DAO);
            groupBoxInput_DAO.Controls.Add(TextStop_DAO);
            groupBoxInput_DAO.Controls.Add(textBoxStartStep_DAO);
            groupBoxInput_DAO.Controls.Add(TextStart_DAO);
            groupBoxInput_DAO.Location = new Point(27, 329);
            groupBoxInput_DAO.Name = "groupBoxInput_DAO";
            groupBoxInput_DAO.Size = new Size(285, 77);
            groupBoxInput_DAO.TabIndex = 6;
            groupBoxInput_DAO.TabStop = false;
            groupBoxInput_DAO.Text = "Ввод данных";
            // 
            // textBoxStopStep_DAO
            // 
            textBoxStopStep_DAO.Location = new Point(153, 48);
            textBoxStopStep_DAO.Name = "textBoxStopStep_DAO";
            textBoxStopStep_DAO.Size = new Size(103, 23);
            textBoxStopStep_DAO.TabIndex = 3;
            textBoxStopStep_DAO.Text = "5";
            // 
            // TextStop_DAO
            // 
            TextStop_DAO.AutoSize = true;
            TextStop_DAO.Font = new Font("Segoe UI", 10F);
            TextStop_DAO.Location = new Point(153, 21);
            TextStop_DAO.Name = "TextStop_DAO";
            TextStop_DAO.Size = new Size(85, 19);
            TextStop_DAO.TabIndex = 2;
            TextStop_DAO.Text = "Конец шага:";
            // 
            // textBoxStartStep_DAO
            // 
            textBoxStartStep_DAO.Location = new Point(11, 52);
            textBoxStartStep_DAO.Name = "textBoxStartStep_DAO";
            textBoxStartStep_DAO.Size = new Size(103, 23);
            textBoxStartStep_DAO.TabIndex = 1;
            textBoxStartStep_DAO.Text = "-5";
            textBoxStartStep_DAO.MouseEnter += textBoxStartStep_DAO_MouseEnter;
            // 
            // TextStart_DAO
            // 
            TextStart_DAO.AutoSize = true;
            TextStart_DAO.Font = new Font("Segoe UI", 10F);
            TextStart_DAO.Location = new Point(11, 21);
            TextStart_DAO.Name = "TextStart_DAO";
            TextStart_DAO.Size = new Size(82, 19);
            TextStart_DAO.TabIndex = 0;
            TextStart_DAO.Text = "Старт шага:";
            // 
            // GroupBoxTask_DAO
            // 
            GroupBoxTask_DAO.Controls.Add(pictureBoxTask_DAO);
            GroupBoxTask_DAO.Controls.Add(TextTask_DAO);
            GroupBoxTask_DAO.Location = new Point(21, 44);
            GroupBoxTask_DAO.Name = "GroupBoxTask_DAO";
            GroupBoxTask_DAO.Size = new Size(514, 279);
            GroupBoxTask_DAO.TabIndex = 5;
            GroupBoxTask_DAO.TabStop = false;
            GroupBoxTask_DAO.Text = "Условие";
            // 
            // pictureBoxTask_DAO
            // 
            pictureBoxTask_DAO.Image = (Image)resources.GetObject("pictureBoxTask_DAO.Image");
            pictureBoxTask_DAO.Location = new Point(6, 96);
            pictureBoxTask_DAO.Name = "pictureBoxTask_DAO";
            pictureBoxTask_DAO.Size = new Size(314, 41);
            pictureBoxTask_DAO.TabIndex = 3;
            pictureBoxTask_DAO.TabStop = false;
            // 
            // TextTask_DAO
            // 
            TextTask_DAO.Font = new Font("Segoe UI", 10F);
            TextTask_DAO.Location = new Point(6, 31);
            TextTask_DAO.Name = "TextTask_DAO";
            TextTask_DAO.Size = new Size(320, 62);
            TextTask_DAO.TabIndex = 2;
            TextTask_DAO.Text = "Протабулировать функцию F(x) на заданном диапазоне. Результат вывести в DataGridView и построить график функции\r\n";
            TextTask_DAO.Click += TextTask_DAO_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 420);
            Controls.Add(ButtonDone_DAO);
            Controls.Add(buttonHelp_DAO);
            Controls.Add(groupBoxResult_DAO);
            Controls.Add(groupBoxInput_DAO);
            Controls.Add(GroupBoxTask_DAO);
            Name = "Form1";
            Text = "Спринт 6 | Таск 2 | Вариант 15 | Дунайцев А.О.";
            groupBoxResult_DAO.ResumeLayout(false);
            groupBoxResult_DAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_DAO).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DAO).EndInit();
            groupBoxInput_DAO.ResumeLayout(false);
            groupBoxInput_DAO.PerformLayout();
            GroupBoxTask_DAO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_DAO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonDone_DAO;
        private Button buttonHelp_DAO;
        private GroupBox groupBoxResult_DAO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_DAO;
        private DataGridView dataGridViewResult_DAO;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn fx;
        private Label TestResult_DAO;
        private GroupBox groupBoxInput_DAO;
        private TextBox textBoxStopStep_DAO;
        private Label TextStop_DAO;
        private TextBox textBoxStartStep_DAO;
        private Label TextStart_DAO;
        private GroupBox GroupBoxTask_DAO;
        private Label TextTask_DAO;
        private PictureBox pictureBoxTask_DAO;
    }
}
