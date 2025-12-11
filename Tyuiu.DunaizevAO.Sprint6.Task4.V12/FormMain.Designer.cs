namespace Tyuiu.DunaizevAO.Sprint6.Task4.V12
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
            textBoxResult_DAO = new TextBox();
            chartResult_DAO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxInput_DAO = new GroupBox();
            textBoxStopStep_DAO = new TextBox();
            TextStop_DAO = new Label();
            textBoxStartStep_DAO = new TextBox();
            TextStart_DAO = new Label();
            GroupBoxTask_DAO = new GroupBox();
            pictureBoxTask_DAO = new PictureBox();
            TextTask_DAO = new Label();
            panelTask = new Panel();
            buttonSave_DAO = new Button();
            panelResult_DAO = new Panel();
            panelChart_DAO = new Panel();
            groupBoxResult_DAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_DAO).BeginInit();
            groupBoxInput_DAO.SuspendLayout();
            GroupBoxTask_DAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_DAO).BeginInit();
            panelTask.SuspendLayout();
            panelResult_DAO.SuspendLayout();
            panelChart_DAO.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonDone_DAO
            // 
            ButtonDone_DAO.BackColor = Color.FromArgb(0, 64, 0);
            ButtonDone_DAO.Font = new Font("Segoe UI", 10F);
            ButtonDone_DAO.Location = new Point(880, 9);
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
            buttonHelp_DAO.Location = new Point(1124, 21);
            buttonHelp_DAO.Name = "buttonHelp_DAO";
            buttonHelp_DAO.Size = new Size(94, 65);
            buttonHelp_DAO.TabIndex = 13;
            buttonHelp_DAO.Text = "Справка";
            buttonHelp_DAO.UseVisualStyleBackColor = false;
            buttonHelp_DAO.Click += buttonHelp_DAO_Click;
            // 
            // groupBoxResult_DAO
            // 
            groupBoxResult_DAO.BackColor = SystemColors.Control;
            groupBoxResult_DAO.Controls.Add(textBoxResult_DAO);
            groupBoxResult_DAO.Location = new Point(3, 3);
            groupBoxResult_DAO.Name = "groupBoxResult_DAO";
            groupBoxResult_DAO.Size = new Size(381, 385);
            groupBoxResult_DAO.TabIndex = 12;
            groupBoxResult_DAO.TabStop = false;
            groupBoxResult_DAO.Text = "Вывод данных";
            // 
            // textBoxResult_DAO
            // 
            textBoxResult_DAO.Location = new Point(5, 22);
            textBoxResult_DAO.Multiline = true;
            textBoxResult_DAO.Name = "textBoxResult_DAO";
            textBoxResult_DAO.ScrollBars = ScrollBars.Vertical;
            textBoxResult_DAO.Size = new Size(369, 357);
            textBoxResult_DAO.TabIndex = 0;
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_DAO.Series.Add(series1);
            chartResult_DAO.Size = new Size(821, 394);
            chartResult_DAO.TabIndex = 2;
            chartResult_DAO.Text = "chart1";
            chartResult_DAO.Click += chartResult_DAO_Click;
            // 
            // groupBoxInput_DAO
            // 
            groupBoxInput_DAO.BackColor = SystemColors.Control;
            groupBoxInput_DAO.Controls.Add(textBoxStopStep_DAO);
            groupBoxInput_DAO.Controls.Add(TextStop_DAO);
            groupBoxInput_DAO.Controls.Add(textBoxStartStep_DAO);
            groupBoxInput_DAO.Controls.Add(TextStart_DAO);
            groupBoxInput_DAO.Location = new Point(612, 3);
            groupBoxInput_DAO.Name = "groupBoxInput_DAO";
            groupBoxInput_DAO.Size = new Size(262, 109);
            groupBoxInput_DAO.TabIndex = 11;
            groupBoxInput_DAO.TabStop = false;
            groupBoxInput_DAO.Text = "Ввод данных";
            // 
            // textBoxStopStep_DAO
            // 
            textBoxStopStep_DAO.Location = new Point(135, 52);
            textBoxStopStep_DAO.Name = "textBoxStopStep_DAO";
            textBoxStopStep_DAO.Size = new Size(117, 23);
            textBoxStopStep_DAO.TabIndex = 3;
            textBoxStopStep_DAO.Text = "5";
            // 
            // TextStop_DAO
            // 
            TextStop_DAO.AutoSize = true;
            TextStop_DAO.Font = new Font("Segoe UI", 10F);
            TextStop_DAO.Location = new Point(135, 19);
            TextStop_DAO.Name = "TextStop_DAO";
            TextStop_DAO.Size = new Size(85, 19);
            TextStop_DAO.TabIndex = 2;
            TextStop_DAO.Text = "Конец шага:";
            // 
            // textBoxStartStep_DAO
            // 
            textBoxStartStep_DAO.Location = new Point(11, 52);
            textBoxStartStep_DAO.Name = "textBoxStartStep_DAO";
            textBoxStartStep_DAO.Size = new Size(118, 23);
            textBoxStartStep_DAO.TabIndex = 1;
            textBoxStartStep_DAO.Text = "-5";
            // 
            // TextStart_DAO
            // 
            TextStart_DAO.AutoSize = true;
            TextStart_DAO.Font = new Font("Segoe UI", 10F);
            TextStart_DAO.Location = new Point(11, 19);
            TextStart_DAO.Name = "TextStart_DAO";
            TextStart_DAO.Size = new Size(82, 19);
            TextStart_DAO.TabIndex = 0;
            TextStart_DAO.Text = "Старт шага:";
            // 
            // GroupBoxTask_DAO
            // 
            GroupBoxTask_DAO.BackColor = SystemColors.Control;
            GroupBoxTask_DAO.Controls.Add(pictureBoxTask_DAO);
            GroupBoxTask_DAO.Controls.Add(TextTask_DAO);
            GroupBoxTask_DAO.Location = new Point(7, 3);
            GroupBoxTask_DAO.Name = "GroupBoxTask_DAO";
            GroupBoxTask_DAO.Size = new Size(599, 109);
            GroupBoxTask_DAO.TabIndex = 10;
            GroupBoxTask_DAO.TabStop = false;
            GroupBoxTask_DAO.Text = "Условие";
            // 
            // pictureBoxTask_DAO
            // 
            pictureBoxTask_DAO.Image = (Image)resources.GetObject("pictureBoxTask_DAO.Image");
            pictureBoxTask_DAO.Location = new Point(69, 62);
            pictureBoxTask_DAO.Name = "pictureBoxTask_DAO";
            pictureBoxTask_DAO.Size = new Size(363, 34);
            pictureBoxTask_DAO.TabIndex = 17;
            pictureBoxTask_DAO.TabStop = false;
            // 
            // TextTask_DAO
            // 
            TextTask_DAO.Font = new Font("Segoe UI", 10F);
            TextTask_DAO.Location = new Point(6, 19);
            TextTask_DAO.Name = "TextTask_DAO";
            TextTask_DAO.Size = new Size(587, 87);
            TextTask_DAO.TabIndex = 2;
            TextTask_DAO.Text = "Протабулировать функцию F(x) на заданном диапазоне. Результат вывести в textBox, построить график функции и сохранить в файл OutPutFileTask4V12.txt по нажатию кнопки.\r\n\r\n";
            // 
            // panelTask
            // 
            panelTask.BackColor = SystemColors.ControlLight;
            panelTask.BorderStyle = BorderStyle.Fixed3D;
            panelTask.Controls.Add(buttonSave_DAO);
            panelTask.Controls.Add(GroupBoxTask_DAO);
            panelTask.Controls.Add(ButtonDone_DAO);
            panelTask.Controls.Add(groupBoxInput_DAO);
            panelTask.Controls.Add(buttonHelp_DAO);
            panelTask.Location = new Point(2, 0);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1492, 119);
            panelTask.TabIndex = 15;
            // 
            // buttonSave_DAO
            // 
            buttonSave_DAO.BackColor = Color.DodgerBlue;
            buttonSave_DAO.Font = new Font("Segoe UI", 10F);
            buttonSave_DAO.Location = new Point(1002, 10);
            buttonSave_DAO.Name = "buttonSave_DAO";
            buttonSave_DAO.Size = new Size(116, 89);
            buttonSave_DAO.TabIndex = 15;
            buttonSave_DAO.Text = "Сохранить";
            buttonSave_DAO.UseVisualStyleBackColor = false;
            buttonSave_DAO.Click += buttonSave_DAO_Click;
            // 
            // panelResult_DAO
            // 
            panelResult_DAO.BackColor = SystemColors.ControlLight;
            panelResult_DAO.BorderStyle = BorderStyle.Fixed3D;
            panelResult_DAO.Controls.Add(groupBoxResult_DAO);
            panelResult_DAO.Location = new Point(2, 125);
            panelResult_DAO.Name = "panelResult_DAO";
            panelResult_DAO.Size = new Size(402, 404);
            panelResult_DAO.TabIndex = 16;
            // 
            // panelChart_DAO
            // 
            panelChart_DAO.BackColor = SystemColors.ControlLight;
            panelChart_DAO.BorderStyle = BorderStyle.Fixed3D;
            panelChart_DAO.Controls.Add(chartResult_DAO);
            panelChart_DAO.Location = new Point(423, 125);
            panelChart_DAO.Name = "panelChart_DAO";
            panelChart_DAO.Size = new Size(831, 404);
            panelChart_DAO.TabIndex = 17;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 541);
            Controls.Add(panelChart_DAO);
            Controls.Add(panelResult_DAO);
            Controls.Add(panelTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 12 | Дунайцев А.О.";
            groupBoxResult_DAO.ResumeLayout(false);
            groupBoxResult_DAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_DAO).EndInit();
            groupBoxInput_DAO.ResumeLayout(false);
            groupBoxInput_DAO.PerformLayout();
            GroupBoxTask_DAO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_DAO).EndInit();
            panelTask.ResumeLayout(false);
            panelResult_DAO.ResumeLayout(false);
            panelChart_DAO.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonDone_DAO;
        private Button buttonHelp_DAO;
        private GroupBox groupBoxResult_DAO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_DAO;
        private GroupBox groupBoxInput_DAO;
        private TextBox textBoxStopStep_DAO;
        private Label TextStop_DAO;
        private TextBox textBoxStartStep_DAO;
        private Label TextStart_DAO;
        private GroupBox GroupBoxTask_DAO;
        private Label TextTask_DAO;
        private Panel panelTask;
        private Button buttonSave_DAO;
        private TextBox textBoxResult_DAO;
        private Panel panelResult_DAO;
        private PictureBox pictureBoxTask_DAO;
        private Panel panelChart_DAO;
    }
}
