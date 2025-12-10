using Tyuiu.DunaizevAO.Sprint6.Task2.V15.Lib;

namespace Tyuiu.DunaizevAO.Sprint6.Task2.V15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextTask_DAO_Click(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void ButtonDone_DAO_Click(object sender, EventArgs e)
        {
            try
            {
                int stary = Convert.ToInt32(textBoxStartStep_DAO.Text);
                int stop = Convert.ToInt32(textBoxStopStep_DAO.Text);

                int len = ds.GetMassFunction(stary, stop).Length;

                double[] valueArr;
                valueArr = new double[len];
                valueArr = ds.GetMassFunction(stary, stop);

                this.chartResult_DAO.Titles.Add("График функции");
                this.chartResult_DAO.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult_DAO.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewResult_DAO.Rows.Add(Convert.ToString(stary), Convert.ToString(valueArr[i]));
                    this.chartResult_DAO.Series[0].Points.AddXY(stary, valueArr[i]);
                    stary++;
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStartStep_DAO_MouseEnter(object sender, EventArgs e)
        {

        }

        private void ButtonDone_DAO_MouseEnter(object sender, EventArgs e)
        {
            ButtonDone_DAO.BackColor = Color.Red;
        }

        private void ButtonDone_DAO_MouseLeave(object sender, EventArgs e)
        {
            ButtonDone_DAO.BackColor = Color.Green;
        }

        private void ButtonDone_DAO_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonDone_DAO.BackColor = Color.Blue;
        }

        private void buttonHelp_DAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РППБ25-1 Дунайцев Александр Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
