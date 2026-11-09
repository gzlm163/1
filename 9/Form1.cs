using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiscriminant_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA.Text, out double a) ||
                !double.TryParse(txtB.Text, out double b) ||
                !double.TryParse(txtC.Text, out double c))
            {
                MessageBox.Show("Введите корректные числа");
                return;
            }

            if (a == 0)
            {
                MessageBox.Show("a не может быть равен 0");
            }

            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                double x1 = -b + Math.Sqrt(D)/ 2 * a;
                double x2 = -b - Math.Sqrt(D)/ 2 * a;
                txtResult.Text = $"D = {D}\r\nx1 = {x1}\r\n x2 = {x2}";
            }

            if (D == 0)
            {
                double x = -b / 2 * a;
                txtResult.Text = $"D = {D}\r\nx = {x}";
            }

            if (D < 0)
            {
                txtResult.Text = $"D = {D}\r\nкорней нет";
            }
        }

        private void btnVieta_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA.Text, out double a) ||
                !double.TryParse(txtB.Text, out double b) ||
                !double.TryParse(txtC.Text, out double c))
            {
                MessageBox.Show("Введите корректные числа");
                return;
            }

            if (a == 0)
            {
                MessageBox.Show("a не может быть равен 0");
            }

            double D = b * b - 4 * a * c;

            if (D < 0)
            {
                txtResult.Text = $"D = {D}/r/nКорней нет.";
                return;
            }

            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);

            double sum = x1 + x2;
            double s = -b / a;

            double product = x1 * x2;
            double p = c / a;

            txtResult.Text = $"Корни: \r\nx1 = {x1}\r\nx2 = {x2}\r\n\r\n" +
                             $"Проверка :\r\n" +
                             $"x1 + x2 = {sum} ( -b/a = {s})\r\n" +
                             $"x1 * x2 = {product} ( c/a = {p})";


        }
    }
}
