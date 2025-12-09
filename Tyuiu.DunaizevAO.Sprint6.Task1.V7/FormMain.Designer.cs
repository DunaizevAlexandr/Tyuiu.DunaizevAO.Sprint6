namespace Tyuiu.DunaizevAO.Sprint6.Task1.V7
{
    partial class Form1
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
            GroupBoxTask_DAO = new GroupBox();
            TextTask_DAO = new Label();
            groupBoxInput_DAO = new GroupBox();
            textBoxStopStep_DAO = new TextBox();
            TextStop_DAO = new Label();
            textBoxStartStep_DAO = new TextBox();
            TextStart_DAO = new Label();
            groupBoxResult_DAO = new GroupBox();
            textBoxResult_DAO = new TextBox();
            TestResult_DAO = new Label();
            buttonHelp_DAO = new Button();
            ButtonDone_DAO = new Button();
            GroupBoxTask_DAO.SuspendLayout();
            groupBoxInput_DAO.SuspendLayout();
            groupBoxResult_DAO.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxTask_DAO
            // 
            GroupBoxTask_DAO.Controls.Add(TextTask_DAO);
            GroupBoxTask_DAO.Location = new Point(12, 12);
            GroupBoxTask_DAO.Name = "GroupBoxTask_DAO";
            GroupBoxTask_DAO.Size = new Size(514, 244);
            GroupBoxTask_DAO.TabIndex = 0;
            GroupBoxTask_DAO.TabStop = false;
            GroupBoxTask_DAO.Text = "Условие";
            // 
            // TextTask_DAO
            // 
            TextTask_DAO.Font = new Font("Segoe UI", 10F);
            TextTask_DAO.Location = new Point(6, 31);
            TextTask_DAO.Name = "TextTask_DAO";
            TextTask_DAO.Size = new Size(320, 62);
            TextTask_DAO.TabIndex = 2;
            TextTask_DAO.Text = "Потабулировать функцию ((2x-3)/cos(x)+x)+5 на заданном диапазоне. Результат вывести в виде таблице.";
            // 
            // groupBoxInput_DAO
            // 
            groupBoxInput_DAO.Controls.Add(textBoxStopStep_DAO);
            groupBoxInput_DAO.Controls.Add(TextStop_DAO);
            groupBoxInput_DAO.Controls.Add(textBoxStartStep_DAO);
            groupBoxInput_DAO.Controls.Add(TextStart_DAO);
            groupBoxInput_DAO.Location = new Point(19, 262);
            groupBoxInput_DAO.Name = "groupBoxInput_DAO";
            groupBoxInput_DAO.Size = new Size(285, 77);
            groupBoxInput_DAO.TabIndex = 1;
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
            textBoxStopStep_DAO.TextChanged += textBoxStopStep_DAO_TextChanged;
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
            // groupBoxResult_DAO
            // 
            groupBoxResult_DAO.Controls.Add(textBoxResult_DAO);
            groupBoxResult_DAO.Controls.Add(TestResult_DAO);
            groupBoxResult_DAO.Location = new Point(542, 12);
            groupBoxResult_DAO.Name = "groupBoxResult_DAO";
            groupBoxResult_DAO.Size = new Size(229, 362);
            groupBoxResult_DAO.TabIndex = 2;
            groupBoxResult_DAO.TabStop = false;
            groupBoxResult_DAO.Text = "Вывод данных";
            // 
            // textBoxResult_DAO
            // 
            textBoxResult_DAO.Font = new Font("Consolas", 10F);
            textBoxResult_DAO.Location = new Point(6, 46);
            textBoxResult_DAO.Multiline = true;
            textBoxResult_DAO.Name = "textBoxResult_DAO";
            textBoxResult_DAO.ReadOnly = true;
            textBoxResult_DAO.ScrollBars = ScrollBars.Vertical;
            textBoxResult_DAO.Size = new Size(195, 310);
            textBoxResult_DAO.TabIndex = 1;
            textBoxResult_DAO.TextAlign = HorizontalAlignment.Center;
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
            // buttonHelp_DAO
            // 
            buttonHelp_DAO.BackColor = SystemColors.Highlight;
            buttonHelp_DAO.Font = new Font("Segoe UI", 10F);
            buttonHelp_DAO.Location = new Point(310, 274);
            buttonHelp_DAO.Name = "buttonHelp_DAO";
            buttonHelp_DAO.Size = new Size(94, 65);
            buttonHelp_DAO.TabIndex = 3;
            buttonHelp_DAO.Text = "Справка";
            buttonHelp_DAO.UseVisualStyleBackColor = false;
            // 
            // ButtonDone_DAO
            // 
            ButtonDone_DAO.BackColor = Color.FromArgb(0, 64, 0);
            ButtonDone_DAO.Font = new Font("Segoe UI", 10F);
            ButtonDone_DAO.Location = new Point(410, 274);
            ButtonDone_DAO.Name = "ButtonDone_DAO";
            ButtonDone_DAO.Size = new Size(116, 63);
            ButtonDone_DAO.TabIndex = 4;
            ButtonDone_DAO.Text = "Выполнить";
            ButtonDone_DAO.UseVisualStyleBackColor = false;
            ButtonDone_DAO.Click += buttonDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 386);
            Controls.Add(ButtonDone_DAO);
            Controls.Add(buttonHelp_DAO);
            Controls.Add(groupBoxResult_DAO);
            Controls.Add(groupBoxInput_DAO);
            Controls.Add(GroupBoxTask_DAO);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 7 | Дунайцев А.О";
            GroupBoxTask_DAO.ResumeLayout(false);
            groupBoxInput_DAO.ResumeLayout(false);
            groupBoxInput_DAO.PerformLayout();
            groupBoxResult_DAO.ResumeLayout(false);
            groupBoxResult_DAO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxTask_DAO;
        private Label TextTask_DAO;
        private GroupBox groupBoxInput_DAO;
        private TextBox textBoxStartStep_DAO;
        private Label TextStart_DAO;
        private GroupBox groupBoxResult_DAO;
        private TextBox textBoxResult_DAO;
        private Label TestResult_DAO;
        private Button buttonHelp_DAO;
        private Button ButtonDone_DAO;
        private TextBox textBoxStopStep_DAO;
        private Label TextStop_DAO;

    }
}
