
namespace Tyuiu.DunaizevAO.Sprint6.Task6.V26
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_DAO = new GroupBox();
            textBoxTask_DAO = new TextBox();
            panelInPut_DAO = new Panel();
            groupBoxInPut_DAO = new GroupBox();
            textBoxInPut_DAO = new TextBox();
            panelTask__DAO = new Panel();
            buttonHelp_DAO = new Button();
            buttonDoIt_DAO = new Button();
            buttonOpen_DAO = new Button();
            panelOutPut_DAO = new Panel();
            groupBoxOutPut_DAO = new GroupBox();
            textBoxOutPut_DAO = new TextBox();
            openFileDialogTask_DAO = new OpenFileDialog();
            toolTip_DAO = new ToolTip(components);
            groupBoxTask_DAO.SuspendLayout();
            panelInPut_DAO.SuspendLayout();
            groupBoxInPut_DAO.SuspendLayout();
            panelTask__DAO.SuspendLayout();
            panelOutPut_DAO.SuspendLayout();
            groupBoxOutPut_DAO.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_DAO
            // 
            groupBoxTask_DAO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_DAO.Controls.Add(textBoxTask_DAO);
            groupBoxTask_DAO.Location = new Point(14, 87);
            groupBoxTask_DAO.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_DAO.Name = "groupBoxTask_DAO";
            groupBoxTask_DAO.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_DAO.Size = new Size(1003, 96);
            groupBoxTask_DAO.TabIndex = 0;
            groupBoxTask_DAO.TabStop = false;
            groupBoxTask_DAO.Text = "Условие:";
            // 
            // textBoxTask_DAO
            // 
            textBoxTask_DAO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTask_DAO.BackColor = SystemColors.Control;
            textBoxTask_DAO.BorderStyle = BorderStyle.None;
            textBoxTask_DAO.Location = new Point(12, 23);
            textBoxTask_DAO.Margin = new Padding(4, 3, 4, 3);
            textBoxTask_DAO.Multiline = true;
            textBoxTask_DAO.Name = "textBoxTask_DAO";
            textBoxTask_DAO.ReadOnly = true;
            textBoxTask_DAO.Size = new Size(985, 66);
            textBoxTask_DAO.TabIndex = 0;
            textBoxTask_DAO.TabStop = false;
            textBoxTask_DAO.Text = resources.GetString("textBoxTask_DAO.Text");
            // 
            // panelInPut_DAO
            // 
            panelInPut_DAO.Controls.Add(groupBoxInPut_DAO);
            panelInPut_DAO.Dock = DockStyle.Fill;
            panelInPut_DAO.Location = new Point(0, 189);
            panelInPut_DAO.Margin = new Padding(4, 3, 4, 3);
            panelInPut_DAO.Name = "panelInPut_DAO";
            panelInPut_DAO.Size = new Size(1031, 401);
            panelInPut_DAO.TabIndex = 1;
            panelInPut_DAO.Paint += panelInPut_ZEO_Paint;
            // 
            // groupBoxInPut_DAO
            // 
            groupBoxInPut_DAO.Controls.Add(textBoxInPut_DAO);
            groupBoxInPut_DAO.Dock = DockStyle.Left;
            groupBoxInPut_DAO.Location = new Point(0, 0);
            groupBoxInPut_DAO.Margin = new Padding(4, 3, 4, 3);
            groupBoxInPut_DAO.Name = "groupBoxInPut_DAO";
            groupBoxInPut_DAO.Padding = new Padding(4, 3, 4, 3);
            groupBoxInPut_DAO.Size = new Size(492, 401);
            groupBoxInPut_DAO.TabIndex = 0;
            groupBoxInPut_DAO.TabStop = false;
            groupBoxInPut_DAO.Text = "Ввод:";
            // 
            // textBoxInPut_DAO
            // 
            textBoxInPut_DAO.Dock = DockStyle.Fill;
            textBoxInPut_DAO.Location = new Point(4, 19);
            textBoxInPut_DAO.Margin = new Padding(4, 3, 4, 3);
            textBoxInPut_DAO.Multiline = true;
            textBoxInPut_DAO.Name = "textBoxInPut_DAO";
            textBoxInPut_DAO.ReadOnly = true;
            textBoxInPut_DAO.ScrollBars = ScrollBars.Vertical;
            textBoxInPut_DAO.Size = new Size(484, 379);
            textBoxInPut_DAO.TabIndex = 0;
            // 
            // panelTask__DAO
            // 
            panelTask__DAO.Controls.Add(buttonHelp_DAO);
            panelTask__DAO.Controls.Add(buttonDoIt_DAO);
            panelTask__DAO.Controls.Add(buttonOpen_DAO);
            panelTask__DAO.Dock = DockStyle.Top;
            panelTask__DAO.Location = new Point(0, 0);
            panelTask__DAO.Margin = new Padding(4, 3, 4, 3);
            panelTask__DAO.Name = "panelTask__DAO";
            panelTask__DAO.Size = new Size(1031, 189);
            panelTask__DAO.TabIndex = 2;
            // 
            // buttonHelp_DAO
            // 
            buttonHelp_DAO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_DAO.Image = (Image)resources.GetObject("buttonHelp_DAO.Image");
            buttonHelp_DAO.Location = new Point(943, 14);
            buttonHelp_DAO.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_DAO.Name = "buttonHelp_DAO";
            buttonHelp_DAO.Size = new Size(85, 65);
            buttonHelp_DAO.TabIndex = 0;
            toolTip_DAO.SetToolTip(buttonHelp_DAO, "Сведения о программе");
            buttonHelp_DAO.UseVisualStyleBackColor = true;
            buttonHelp_DAO.Click += buttonHelp_ZEO_Click;
            // 
            // buttonDoIt_DAO
            // 
            buttonDoIt_DAO.Image = (Image)resources.GetObject("buttonDoIt_DAO.Image");
            buttonDoIt_DAO.Location = new Point(106, 14);
            buttonDoIt_DAO.Margin = new Padding(4, 3, 4, 3);
            buttonDoIt_DAO.Name = "buttonDoIt_DAO";
            buttonDoIt_DAO.Size = new Size(85, 65);
            buttonDoIt_DAO.TabIndex = 0;
            toolTip_DAO.SetToolTip(buttonDoIt_DAO, "Производит поиск и возвращает последнее слово в строке");
            buttonDoIt_DAO.UseVisualStyleBackColor = true;
            buttonDoIt_DAO.Click += buttonDoIt_ZEO_Click;
            // 
            // buttonOpen_DAO
            // 
            buttonOpen_DAO.Image = (Image)resources.GetObject("buttonOpen_DAO.Image");
            buttonOpen_DAO.Location = new Point(14, 14);
            buttonOpen_DAO.Margin = new Padding(4, 3, 4, 3);
            buttonOpen_DAO.Name = "buttonOpen_DAO";
            buttonOpen_DAO.Size = new Size(85, 65);
            buttonOpen_DAO.TabIndex = 0;
            toolTip_DAO.SetToolTip(buttonOpen_DAO, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpen_DAO.UseVisualStyleBackColor = true;
            buttonOpen_DAO.Click += buttonOpen_ZEO_Click;
            // 
            // panelOutPut_DAO
            // 
            panelOutPut_DAO.Controls.Add(groupBoxOutPut_DAO);
            panelOutPut_DAO.Dock = DockStyle.Right;
            panelOutPut_DAO.Location = new Point(504, 189);
            panelOutPut_DAO.Margin = new Padding(4, 3, 4, 3);
            panelOutPut_DAO.Name = "panelOutPut_DAO";
            panelOutPut_DAO.Size = new Size(527, 401);
            panelOutPut_DAO.TabIndex = 1;
            // 
            // groupBoxOutPut_DAO
            // 
            groupBoxOutPut_DAO.Controls.Add(textBoxOutPut_DAO);
            groupBoxOutPut_DAO.Dock = DockStyle.Right;
            groupBoxOutPut_DAO.Location = new Point(3, 0);
            groupBoxOutPut_DAO.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutPut_DAO.Name = "groupBoxOutPut_DAO";
            groupBoxOutPut_DAO.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutPut_DAO.Size = new Size(524, 401);
            groupBoxOutPut_DAO.TabIndex = 0;
            groupBoxOutPut_DAO.TabStop = false;
            groupBoxOutPut_DAO.Text = "Вывод:";
            // 
            // textBoxOutPut_DAO
            // 
            textBoxOutPut_DAO.Dock = DockStyle.Fill;
            textBoxOutPut_DAO.Location = new Point(4, 19);
            textBoxOutPut_DAO.Margin = new Padding(4, 3, 4, 3);
            textBoxOutPut_DAO.Multiline = true;
            textBoxOutPut_DAO.Name = "textBoxOutPut_DAO";
            textBoxOutPut_DAO.ReadOnly = true;
            textBoxOutPut_DAO.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut_DAO.Size = new Size(516, 379);
            textBoxOutPut_DAO.TabIndex = 0;
            // 
            // openFileDialogTask_DAO
            // 
            openFileDialogTask_DAO.FileName = "openFileDialogTask_ZEO";
            // 
            // toolTip_DAO
            // 
            toolTip_DAO.ToolTipIcon = ToolTipIcon.Info;
            toolTip_DAO.ToolTipTitle = "Подсказда";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 590);
            Controls.Add(panelOutPut_DAO);
            Controls.Add(panelInPut_DAO);
            Controls.Add(groupBoxTask_DAO);
            Controls.Add(panelTask__DAO);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1047, 629);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 26 | Зарипов Е. О.";
            groupBoxTask_DAO.ResumeLayout(false);
            groupBoxTask_DAO.PerformLayout();
            panelInPut_DAO.ResumeLayout(false);
            groupBoxInPut_DAO.ResumeLayout(false);
            groupBoxInPut_DAO.PerformLayout();
            panelTask__DAO.ResumeLayout(false);
            panelOutPut_DAO.ResumeLayout(false);
            groupBoxOutPut_DAO.ResumeLayout(false);
            groupBoxOutPut_DAO.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DAO;
        private System.Windows.Forms.TextBox textBoxTask_DAO;
        private System.Windows.Forms.Panel panelInPut_DAO;
        private System.Windows.Forms.GroupBox groupBoxInPut_DAO;
        private System.Windows.Forms.TextBox textBoxInPut_DAO;
        private System.Windows.Forms.Panel panelTask__DAO;
        private System.Windows.Forms.Button buttonHelp_DAO;
        private System.Windows.Forms.Button buttonDoIt_DAO;
        private System.Windows.Forms.Button buttonOpen_DAO;
        private System.Windows.Forms.Panel panelOutPut_DAO;
        private System.Windows.Forms.GroupBox groupBoxOutPut_DAO;
        private System.Windows.Forms.TextBox textBoxOutPut_DAO;
        private System.Windows.Forms.ToolTip toolTip_DAO;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DAO;
    }
}

