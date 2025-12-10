using Tyuiu.DunaizevAO.Sprint6.Task1.V7.Lib;

namespace Tyuiu.DunaizevAO.Sprint6.Task1.V7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_DAO.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_DAO.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_DAO.Text = "";
                textBoxResult_DAO.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_DAO.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_DAO.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult_DAO.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_DAO.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППБ25-1 Дунайцев Александр Олегович", "Сообщение");
        }

        private void textBoxStopStep_DAO_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_DAO_Click(object sender, EventArgs e)
        {

        }
    }
}
