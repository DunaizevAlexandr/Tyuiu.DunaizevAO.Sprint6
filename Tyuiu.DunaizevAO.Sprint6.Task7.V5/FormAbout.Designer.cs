namespace Tyuiu.DunaizevAO.Sprint6.Task7.V5
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonDone_DAO = new Button();
            pictureBoxAbout_DAO = new PictureBox();
            textBoxInfo_DAO = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_DAO).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_DAO
            // 
            buttonDone_DAO.Location = new Point(477, 187);
            buttonDone_DAO.Name = "buttonDone_DAO";
            buttonDone_DAO.Size = new Size(75, 23);
            buttonDone_DAO.TabIndex = 5;
            buttonDone_DAO.Text = "ОК";
            buttonDone_DAO.UseVisualStyleBackColor = true;
            buttonDone_DAO.Click += buttonDone_SNM_Click;
            // 
            // pictureBoxAbout_DAO
            // 
            pictureBoxAbout_DAO.AccessibleRole = AccessibleRole.IpAddress;
            pictureBoxAbout_DAO.Image = (Image)resources.GetObject("pictureBoxAbout_DAO.Image");
            pictureBoxAbout_DAO.Location = new Point(12, 12);
            pictureBoxAbout_DAO.Name = "pictureBoxAbout_DAO";
            pictureBoxAbout_DAO.Size = new Size(166, 198);
            pictureBoxAbout_DAO.TabIndex = 4;
            pictureBoxAbout_DAO.TabStop = false;
            // 
            // textBoxInfo_DAO
            // 
            textBoxInfo_DAO.BorderStyle = BorderStyle.None;
            textBoxInfo_DAO.Location = new Point(184, 12);
            textBoxInfo_DAO.Multiline = true;
            textBoxInfo_DAO.Name = "textBoxInfo_DAO";
            textBoxInfo_DAO.ReadOnly = true;
            textBoxInfo_DAO.Size = new Size(368, 161);
            textBoxInfo_DAO.TabIndex = 3;
            textBoxInfo_DAO.Text = resources.GetString("textBoxInfo_DAO.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(buttonDone_DAO);
            Controls.Add(pictureBoxAbout_DAO);
            Controls.Add(textBoxInfo_DAO);
            MinimumSize = new Size(600, 300);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_DAO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_DAO;
        private PictureBox pictureBoxAbout_DAO;
        private TextBox textBoxInfo_DAO;
    }
}