namespace Tyuiu.DunaizevAO.Sprint6.Task5.V5
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
            panelChart_DAO = new Panel();
            chartResult_DAO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelResult_DAO = new Panel();
            groupBoxResult_DAO = new GroupBox();
            dataGridViewResult_DAO = new DataGridView();
            panelTask = new Panel();
            buttonOpen_DAO = new Button();
            GroupBoxTask_DAO = new GroupBox();
            TextTask_DAO = new Label();
            ButtonDone_DAO = new Button();
            buttonHelp_DAO = new Button();
            panelChart_DAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_DAO).BeginInit();
            panelResult_DAO.SuspendLayout();
            groupBoxResult_DAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DAO).BeginInit();
            panelTask.SuspendLayout();
            GroupBoxTask_DAO.SuspendLayout();
            SuspendLayout();
            // 
            // panelChart_DAO
            // 
            panelChart_DAO.BackColor = SystemColors.ControlLight;
            panelChart_DAO.BorderStyle = BorderStyle.Fixed3D;
            panelChart_DAO.Controls.Add(chartResult_DAO);
            panelChart_DAO.Location = new Point(420, 121);
            panelChart_DAO.Name = "panelChart_DAO";
            panelChart_DAO.Size = new Size(559, 404);
            panelChart_DAO.TabIndex = 20;
            // 
            // chartResult_DAO
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_DAO.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult_DAO.Legends.Add(legend1);
            chartResult_DAO.Location = new Point(3, 3);
            chartResult_DAO.Name = "chartResult_DAO";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_DAO.Series.Add(series1);
            chartResult_DAO.Size = new Size(545, 395);
            chartResult_DAO.TabIndex = 0;
            chartResult_DAO.Text = "chart1";
            // 
            // panelResult_DAO
            // 
            panelResult_DAO.BackColor = SystemColors.ControlLight;
            panelResult_DAO.BorderStyle = BorderStyle.Fixed3D;
            panelResult_DAO.Controls.Add(groupBoxResult_DAO);
            panelResult_DAO.Location = new Point(-1, 121);
            panelResult_DAO.Name = "panelResult_DAO";
            panelResult_DAO.Size = new Size(402, 404);
            panelResult_DAO.TabIndex = 19;
            // 
            // groupBoxResult_DAO
            // 
            groupBoxResult_DAO.BackColor = SystemColors.Control;
            groupBoxResult_DAO.Controls.Add(dataGridViewResult_DAO);
            groupBoxResult_DAO.Location = new Point(3, 3);
            groupBoxResult_DAO.Name = "groupBoxResult_DAO";
            groupBoxResult_DAO.Size = new Size(381, 385);
            groupBoxResult_DAO.TabIndex = 12;
            groupBoxResult_DAO.TabStop = false;
            groupBoxResult_DAO.Text = "Вывод данных";
            // 
            // dataGridViewResult_DAO
            // 
            dataGridViewResult_DAO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_DAO.Location = new Point(6, 22);
            dataGridViewResult_DAO.Name = "dataGridViewResult_DAO";
            dataGridViewResult_DAO.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult_DAO.Size = new Size(369, 357);
            dataGridViewResult_DAO.TabIndex = 0;
            // 
            // panelTask
            // 
            panelTask.BackColor = SystemColors.ControlLight;
            panelTask.BorderStyle = BorderStyle.Fixed3D;
            panelTask.Controls.Add(buttonOpen_DAO);
            panelTask.Controls.Add(GroupBoxTask_DAO);
            panelTask.Controls.Add(ButtonDone_DAO);
            panelTask.Controls.Add(buttonHelp_DAO);
            panelTask.Location = new Point(-1, 1);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(980, 119);
            panelTask.TabIndex = 18;
            // 
            // buttonOpen_DAO
            // 
            buttonOpen_DAO.BackColor = Color.DodgerBlue;
            buttonOpen_DAO.Font = new Font("Segoe UI", 10F);
            buttonOpen_DAO.Location = new Point(734, 10);
            buttonOpen_DAO.Name = "buttonOpen_DAO";
            buttonOpen_DAO.Size = new Size(116, 89);
            buttonOpen_DAO.TabIndex = 15;
            buttonOpen_DAO.Text = "Открыть файл";
            buttonOpen_DAO.UseVisualStyleBackColor = false;
            buttonOpen_DAO.Click += buttonOpen_DAO_Click;
            // 
            // GroupBoxTask_DAO
            // 
            GroupBoxTask_DAO.BackColor = SystemColors.Control;
            GroupBoxTask_DAO.Controls.Add(TextTask_DAO);
            GroupBoxTask_DAO.Location = new Point(7, 3);
            GroupBoxTask_DAO.Name = "GroupBoxTask_DAO";
            GroupBoxTask_DAO.Size = new Size(599, 109);
            GroupBoxTask_DAO.TabIndex = 10;
            GroupBoxTask_DAO.TabStop = false;
            GroupBoxTask_DAO.Text = "Условие";
            // 
            // TextTask_DAO
            // 
            TextTask_DAO.Font = new Font("Segoe UI", 10F);
            TextTask_DAO.Location = new Point(6, 19);
            TextTask_DAO.Name = "TextTask_DAO";
            TextTask_DAO.Size = new Size(587, 87);
            TextTask_DAO.TabIndex = 2;
            TextTask_DAO.Text = "Прочитать данные из файла InPutFileTask5V5.txt. Вывести в dataGridView. Вывести все числа, кратные 2. Построить диаграмму по этим значениям.\r\n";
            // 
            // ButtonDone_DAO
            // 
            ButtonDone_DAO.BackColor = Color.FromArgb(0, 64, 0);
            ButtonDone_DAO.Font = new Font("Segoe UI", 10F);
            ButtonDone_DAO.Location = new Point(612, 10);
            ButtonDone_DAO.Name = "ButtonDone_DAO";
            ButtonDone_DAO.Size = new Size(116, 89);
            ButtonDone_DAO.TabIndex = 14;
            ButtonDone_DAO.Text = "Выполнить";
            ButtonDone_DAO.UseVisualStyleBackColor = false;
            ButtonDone_DAO.Click += ButtonDone_DAO_Click;
            // 
            // buttonHelp_DAO
            // 
            buttonHelp_DAO.BackColor = SystemColors.Highlight;
            buttonHelp_DAO.Font = new Font("Segoe UI", 10F);
            buttonHelp_DAO.Location = new Point(856, 22);
            buttonHelp_DAO.Name = "buttonHelp_DAO";
            buttonHelp_DAO.Size = new Size(94, 65);
            buttonHelp_DAO.TabIndex = 13;
            buttonHelp_DAO.Text = "Справка";
            buttonHelp_DAO.UseVisualStyleBackColor = false;
            buttonHelp_DAO.Click += buttonHelp_DAO_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(panelChart_DAO);
            Controls.Add(panelResult_DAO);
            Controls.Add(panelTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 5 | Дунайцев А.О.";
            Load += Form1_Load;
            panelChart_DAO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult_DAO).EndInit();
            panelResult_DAO.ResumeLayout(false);
            groupBoxResult_DAO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DAO).EndInit();
            panelTask.ResumeLayout(false);
            GroupBoxTask_DAO.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChart_DAO;
        private Panel panelResult_DAO;
        private GroupBox groupBoxResult_DAO;
        private Panel panelTask;
        private Button buttonOpen_DAO;
        private GroupBox GroupBoxTask_DAO;
        private Label TextTask_DAO;
        private Button ButtonDone_DAO;
        private Button buttonHelp_DAO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_DAO;
        private DataGridView dataGridViewResult_DAO;
    }
}
