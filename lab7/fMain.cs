using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
            tbMaxValue.Text = string.Empty; // Очищення нового текстового поля
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) || (string.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "Не введено даних!";
                return;
            }

            double x1 = double.Parse(tbX1.Text);
            double x2 = double.Parse(tbX2.Text);
            double y = x1 * x2;
            tbY.Text = y.ToString("0.###"); // Форматування до 3 знаків після коми

            // Обчислення більшого значення
            double maxValue = Math.Max(x1, x2);
            tbMaxValue.Text = maxValue.ToString();
        }

        private void tbX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbY_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbX1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
