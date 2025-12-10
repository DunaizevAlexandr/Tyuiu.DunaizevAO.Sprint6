using Tyuiu.DunaizevAO.Sprint6.Task3.V29.Lib;

namespace Tyuiu.DunaizevAO.Sprint6.Task3.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -2, -13, -15, -9, -17 }, { 13, -20, -15, 27, 18 }, { -12, -1, -20, 13, 0 }, { 15, 32, 18, -12, -18 }, { 16, 5, 3, -5, -8 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int columns = matrix.GetLength(1);
            int rows = matrix.GetLength(0);
            dataGridViewResult_DAO.RowCount = rows;
            dataGridViewResult_DAO.ColumnCount = columns;
            for (int i = 0; i < rows; i++)
            {
                dataGridViewResult_DAO.Columns[i].Width = 25;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_DAO.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        private void buttonDone_DAO_Click(object sender, EventArgs e)
        {
            int columns = matrix.GetLength(1);
            int rows = matrix.GetLength(0);
            int[,] res = new int[5, 5];
            res = ds.Calculate(matrix);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_DAO.Rows[i].Cells[j].Value = res[i, j];
                }
            }
        }

        private void buttonHelp_DAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РППБ25-1 Дунайцев Александр Олегович", "Сообщение");
        }

        private void ButtonDone_DAO_Click_1(object sender, EventArgs e)
        {

        }
    }
}
