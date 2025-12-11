using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.DunaizevAO.Sprint6.Task5.V5.Lib;

namespace Tyuiu.DunaizevAO.Sprint6.Task5.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = Path.Combine("C:", "DataSprint6", "InPutFileTask5V5.txt");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonDone_DAO_Click(object sender, EventArgs e)
        {
            dataGridViewResult_DAO.ColumnCount = 2;
            dataGridViewResult_DAO.Columns[0].Width = 20;
            dataGridViewResult_DAO.Columns[1].Width = 50;

            this.chartResult_DAO.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_DAO.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_DAO.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_DAO.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_DAO.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_DAO_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_DAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РППБ25-1 Дунайцев А.О", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
