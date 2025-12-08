namespace Tyuiu.DunaizevAO.Sprint6.Task0.V15
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
            GroupBoxTask_DAO = new GroupBox();
            textBoxTask_DAO = new TextBox();
            pictureBoxFormula_DAO = new PictureBox();
            groupBoxInput_DAO = new GroupBox();
            textBoxNameX_DAO = new TextBox();
            textBoxVarX_DAO = new TextBox();
            groupBoxOutput_DAO = new GroupBox();
            textBoxNameResult_DAO = new TextBox();
            textBoxResult_DAO = new TextBox();
            buttonDone_DAO = new Button();
            buttonHelp_DAO = new Button();
            GroupBoxTask_DAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_DAO).BeginInit();
            groupBoxInput_DAO.SuspendLayout();
            groupBoxOutput_DAO.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxTask_DAO
            // 
            GroupBoxTask_DAO.Controls.Add(textBoxTask_DAO);
            GroupBoxTask_DAO.Controls.Add(pictureBoxFormula_DAO);
            GroupBoxTask_DAO.Location = new Point(12, 26);
            GroupBoxTask_DAO.Name = "GroupBoxTask_DAO";
            GroupBoxTask_DAO.Size = new Size(776, 221);
            GroupBoxTask_DAO.TabIndex = 0;
            GroupBoxTask_DAO.TabStop = false;
            GroupBoxTask_DAO.Text = "Условие";
            // 
            // textBoxTask_DAO
            // 
            textBoxTask_DAO.BackColor = SystemColors.MenuBar;
            textBoxTask_DAO.BorderStyle = BorderStyle.None;
            textBoxTask_DAO.Font = new Font("Segoe UI", 10F);
            textBoxTask_DAO.Location = new Point(6, 22);
            textBoxTask_DAO.Multiline = true;
            textBoxTask_DAO.Name = "textBoxTask_DAO";
            textBoxTask_DAO.ReadOnly = true;
            textBoxTask_DAO.Size = new Size(504, 193);
            textBoxTask_DAO.TabIndex = 1;
            textBoxTask_DAO.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_DAO
            // 
            pictureBoxFormula_DAO.Image = (Image)resources.GetObject("pictureBoxFormula_DAO.Image");
            pictureBoxFormula_DAO.Location = new Point(522, 22);
            pictureBoxFormula_DAO.Name = "pictureBoxFormula_DAO";
            pictureBoxFormula_DAO.Size = new Size(248, 39);
            pictureBoxFormula_DAO.TabIndex = 0;
            pictureBoxFormula_DAO.TabStop = false;
            pictureBoxFormula_DAO.Click += pictureBox1_Click;
            // 
            // groupBoxInput_DAO
            // 
            groupBoxInput_DAO.Controls.Add(textBoxNameX_DAO);
            groupBoxInput_DAO.Controls.Add(textBoxVarX_DAO);
            groupBoxInput_DAO.Location = new Point(12, 253);
            groupBoxInput_DAO.Name = "groupBoxInput_DAO";
            groupBoxInput_DAO.Size = new Size(530, 129);
            groupBoxInput_DAO.TabIndex = 1;
            groupBoxInput_DAO.TabStop = false;
            groupBoxInput_DAO.Text = "Ввод данных";
            // 
            // textBoxNameX_DAO
            // 
            textBoxNameX_DAO.BackColor = SystemColors.MenuBar;
            textBoxNameX_DAO.BorderStyle = BorderStyle.None;
            textBoxNameX_DAO.Font = new Font("Segoe UI", 11F);
            textBoxNameX_DAO.Location = new Point(24, 48);
            textBoxNameX_DAO.Name = "textBoxNameX_DAO";
            textBoxNameX_DAO.ReadOnly = true;
            textBoxNameX_DAO.Size = new Size(131, 20);
            textBoxNameX_DAO.TabIndex = 1;
            textBoxNameX_DAO.Text = "Переменная X:";
            textBoxNameX_DAO.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxVarX_DAO
            // 
            textBoxVarX_DAO.Location = new Point(24, 77);
            textBoxVarX_DAO.Name = "textBoxVarX_DAO";
            textBoxVarX_DAO.Size = new Size(131, 23);
            textBoxVarX_DAO.TabIndex = 0;
            textBoxVarX_DAO.TextChanged += textBoxVarX_DAO_TextChanged;
            textBoxVarX_DAO.KeyPress += textBoxVarX_DAO_KeyPress;
            // 
            // groupBoxOutput_DAO
            // 
            groupBoxOutput_DAO.Controls.Add(textBoxNameResult_DAO);
            groupBoxOutput_DAO.Controls.Add(textBoxResult_DAO);
            groupBoxOutput_DAO.Location = new Point(548, 253);
            groupBoxOutput_DAO.Name = "groupBoxOutput_DAO";
            groupBoxOutput_DAO.Size = new Size(240, 129);
            groupBoxOutput_DAO.TabIndex = 2;
            groupBoxOutput_DAO.TabStop = false;
            groupBoxOutput_DAO.Text = "Вывод данных";
            // 
            // textBoxNameResult_DAO
            // 
            textBoxNameResult_DAO.BackColor = SystemColors.MenuBar;
            textBoxNameResult_DAO.BorderStyle = BorderStyle.None;
            textBoxNameResult_DAO.Font = new Font("Segoe UI", 11F);
            textBoxNameResult_DAO.Location = new Point(55, 48);
            textBoxNameResult_DAO.Name = "textBoxNameResult_DAO";
            textBoxNameResult_DAO.ReadOnly = true;
            textBoxNameResult_DAO.Size = new Size(131, 20);
            textBoxNameResult_DAO.TabIndex = 3;
            textBoxNameResult_DAO.Text = "Результат:";
            textBoxNameResult_DAO.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxResult_DAO
            // 
            textBoxResult_DAO.BackColor = SystemColors.ButtonHighlight;
            textBoxResult_DAO.Location = new Point(55, 77);
            textBoxResult_DAO.Name = "textBoxResult_DAO";
            textBoxResult_DAO.ReadOnly = true;
            textBoxResult_DAO.Size = new Size(131, 23);
            textBoxResult_DAO.TabIndex = 2;
            // 
            // buttonDone_DAO
            // 
            buttonDone_DAO.BackColor = SystemColors.ButtonFace;
            buttonDone_DAO.Font = new Font("Segoe UI", 11F);
            buttonDone_DAO.Location = new Point(634, 388);
            buttonDone_DAO.Name = "buttonDone_DAO";
            buttonDone_DAO.Size = new Size(148, 40);
            buttonDone_DAO.TabIndex = 3;
            buttonDone_DAO.Text = "Выполнить";
            buttonDone_DAO.UseVisualStyleBackColor = false;
            buttonDone_DAO.Click += buttonDone_DAO_Click;
            // 
            // buttonHelp_DAO
            // 
            buttonHelp_DAO.BackColor = SystemColors.ButtonFace;
            buttonHelp_DAO.FlatStyle = FlatStyle.Flat;
            buttonHelp_DAO.Font = new Font("Segoe UI", 11F);
            buttonHelp_DAO.Location = new Point(587, 388);
            buttonHelp_DAO.Name = "buttonHelp_DAO";
            buttonHelp_DAO.Size = new Size(41, 40);
            buttonHelp_DAO.TabIndex = 4;
            buttonHelp_DAO.Text = "?";
            buttonHelp_DAO.UseVisualStyleBackColor = false;
            buttonHelp_DAO.Click += buttonHelp_DAO_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_DAO);
            Controls.Add(buttonDone_DAO);
            Controls.Add(groupBoxOutput_DAO);
            Controls.Add(groupBoxInput_DAO);
            Controls.Add(GroupBoxTask_DAO);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 15 | Дунайцев А.О.";
            Load += FormMain_Load;
            GroupBoxTask_DAO.ResumeLayout(false);
            GroupBoxTask_DAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_DAO).EndInit();
            groupBoxInput_DAO.ResumeLayout(false);
            groupBoxInput_DAO.PerformLayout();
            groupBoxOutput_DAO.ResumeLayout(false);
            groupBoxOutput_DAO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxTask_DAO;
        private GroupBox groupBoxInput_DAO;
        private GroupBox groupBoxOutput_DAO;
        private PictureBox pictureBoxFormula_DAO;
        private TextBox textBoxTask_DAO;
        private TextBox textBoxNameX_DAO;
        private TextBox textBoxVarX_DAO;
        private TextBox textBoxNameResult_DAO;
        private TextBox textBoxResult_DAO;
        private Button buttonDone_DAO;
        private Button buttonHelp_DAO;
    }
}
