using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DunaizevAO.Sprint6.Task6.V26.Lib;
using System.IO;

namespace Tyuiu.DunaizevAO.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpen_DAO_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DAO.ShowDialog();
            openFilePath = openFileDialogTask_DAO.FileName;
            textBoxInPut_DAO.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_DAO.Text = groupBoxOutPut_DAO.Text + " " + openFileDialogTask_DAO.FileName;
            buttonDoIt_DAO.Enabled = true;
        }

        private void buttonDoIt_DAO_Click(object sender, EventArgs e)
        {
            textBoxOutPut_DAO.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_DAO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void panelInPut_DAO_Paint(object sender, PaintEventArgs e)
        {
            //
        }
    }
}
