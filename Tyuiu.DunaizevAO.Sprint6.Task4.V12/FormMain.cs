using Tyuiu.DunaizevAO.Sprint6.Task4.V12.Lib;

namespace Tyuiu.DunaizevAO.Sprint6.Task4.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void ButtonDone_DAO_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartStep_DAO.Text);
                int stopValue = Convert.ToInt32(textBoxStopStep_DAO.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] TempArray = new double[len];

                TempArray = ds.GetMassFunction(startValue, stopValue);

                this.chartResult_DAO.ChartAreas[0].AxisX.Title = "ось X";
                this.chartResult_DAO.ChartAreas[0].AxisY.Title = "ось Y";

                textBoxResult_DAO.Text = "";

                chartResult_DAO.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartResult_DAO.Series[0].Points.AddXY(startValue, TempArray[i]);
                    textBoxResult_DAO.AppendText(TempArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППБ25-1 Дунайцев А.О", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_DAO_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine("C:", "DataSprint6", "OutPutFileTask4V12.txt");
                File.WriteAllText(path, textBoxResult_DAO.Text);

                DialogResult dr = MessageBox.Show("Файл " + path + " Сохранён успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
