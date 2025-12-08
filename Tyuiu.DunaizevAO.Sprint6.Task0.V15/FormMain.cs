using Tyuiu.DunaizevAO.Sprint6.Task0.V15.Lib;
using System.Windows.Forms;

namespace Tyuiu.DunaizevAO.Sprint6.Task0.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_DAO_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_DAO.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_DAO.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РПППБ25-1 Дунайцев Александр Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxVarX_DAO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_DAO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 ||  e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
