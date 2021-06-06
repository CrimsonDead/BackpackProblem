using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirPlaneCapacity
{
    public partial class CalculatingForm : Form
    {
        //TODO сделай форму для меню
        private int[] maxNumericsValues;
        private MainCalculator calculator;
        private Product[] products = new Product[6];
        private MainManu form;
        public CalculatingForm(MainManu prevForm)
        {
            InitializeComponent();
            form = prevForm;
            products[0] = new Product(0.8m, 12);
            products[1] = new Product(3.2m, 60);
            products[2] = new Product(4.0m, 72);
            products[3] = new Product(6.5m, 11);
            products[4] = new Product(2.8m, 50);
            products[5] = new Product(2.1m, 15);
        }

        private void calculateBotton_Click(object sender, EventArgs e)
        {
            int[] minNumbersOfProducts = new int[6];
            minNumbersOfProducts[0] = (int)minProductNum1.Value;
            minNumbersOfProducts[1] = (int)minProductNum2.Value;
            minNumbersOfProducts[2] = (int)minProductNum3.Value;
            minNumbersOfProducts[3] = (int)minProductNum4.Value;
            minNumbersOfProducts[4] = (int)minProductNum5.Value;
            minNumbersOfProducts[5] = (int)minProductNum6.Value;
            calculator = new MainCalculator(minNumbersOfProducts, products);
            outputCost.Text = Convert.ToString(calculator.CalculateMaxCost(Convert.ToInt32(inputWeightBox.Lines[0])));
            calculator.GetCoefficients(calculator.CalculateMaxCost(Convert.ToInt32(inputWeightBox.Lines[0])), Convert.ToInt32(inputWeightBox.Lines[0]));
            productNum1.Text = Convert.ToString(calculator.Coefficients[0]);
            productNum2.Text = Convert.ToString(calculator.Coefficients[1]);
            productNum3.Text = Convert.ToString(calculator.Coefficients[2]);
            productNum4.Text = Convert.ToString(calculator.Coefficients[3]);
            productNum5.Text = Convert.ToString(calculator.Coefficients[4]);
            productNum6.Text = Convert.ToString(calculator.Coefficients[5]);
            showTreeBotton.Enabled = true;
        }

        private void showTreeBotton_Click(object sender, EventArgs e)
        {
            CalculatingTreeForm calculatingTreeForm = new CalculatingTreeForm(this, Convert.ToInt32(inputWeightBox.Lines[0]), calculator.MinNumbersOfProducts, products);
            calculatingTreeForm.Show();
            this.Enabled = false;
        }

        private void inputWeightBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(inputWeightBox.Lines[0]);
            }
            catch
            {
                MessageBox.Show("Введено неверное занчение!!");
                inputWeightBox.Text = "20";
                return;
            }
            finally
            {
                maxNumericsValues = new int[] {
                    (int)(Convert.ToInt32(inputWeightBox.Lines[0])/products[0].Weight),
                    (int)(Convert.ToInt32(inputWeightBox.Lines[0])/products[1].Weight),
                    (int)(Convert.ToInt32(inputWeightBox.Lines[0])/products[2].Weight),
                    (int)(Convert.ToInt32(inputWeightBox.Lines[0])/products[3].Weight),
                    (int)(Convert.ToInt32(inputWeightBox.Lines[0])/products[4].Weight),
                    (int)(Convert.ToInt32(inputWeightBox.Lines[0])/products[5].Weight)
                };
                minProductNum1.Maximum = maxNumericsValues[0];
                minProductNum1.Value = 0;
                minProductNum2.Maximum = maxNumericsValues[1];
                minProductNum2.Value = 0;
                minProductNum3.Maximum = maxNumericsValues[2];
                minProductNum3.Value = 0;
                minProductNum4.Maximum = maxNumericsValues[3];
                minProductNum4.Value = 0;
                minProductNum5.Maximum = maxNumericsValues[4];
                minProductNum5.Value = 0;
                minProductNum6.Maximum = maxNumericsValues[5];
                minProductNum6.Value = 0;
            }
            showTreeBotton.Enabled = false;
        }

        private void minProductNum1_ValueChanged(object sender, EventArgs e)
        {
            decimal weight = Convert.ToDecimal(inputWeightBox.Lines[0]) - minProductNum1.Value * products[0].Weight - minProductNum2.Value * products[1].Weight -
                minProductNum3.Value * products[2].Weight - minProductNum4.Value * products[3].Weight - minProductNum5.Value * products[4].Weight -
                minProductNum6.Value * products[5].Weight;
            if (weight < 0)
            {
                minProductNum1.Value -= 1;
            }
            showTreeBotton.Enabled = false;
        }

        private void minProductNum2_ValueChanged(object sender, EventArgs e)
        {
            decimal weight = Convert.ToDecimal(inputWeightBox.Lines[0]) - minProductNum1.Value * products[0].Weight - minProductNum2.Value * products[1].Weight -
               minProductNum3.Value * products[2].Weight - minProductNum4.Value * products[3].Weight - minProductNum5.Value * products[4].Weight -
               minProductNum6.Value * products[5].Weight;
            if (weight < 0)
            {
                minProductNum2.Value -= 1;
            }
            showTreeBotton.Enabled = false;
        }

        private void minProductNum3_ValueChanged(object sender, EventArgs e)
        {
            decimal weight = Convert.ToDecimal(inputWeightBox.Lines[0]) - minProductNum1.Value * products[0].Weight - minProductNum2.Value * products[1].Weight -
               minProductNum3.Value * products[2].Weight - minProductNum4.Value * products[3].Weight - minProductNum5.Value * products[4].Weight -
               minProductNum6.Value * products[5].Weight;
            if (weight < 0)
            {
                minProductNum3.Value -= 1;
            }
            showTreeBotton.Enabled = false;
        }

        private void minProductNum4_ValueChanged(object sender, EventArgs e)
        {
            decimal weight = Convert.ToDecimal(inputWeightBox.Lines[0]) - minProductNum1.Value * products[0].Weight - minProductNum2.Value * products[1].Weight -
               minProductNum3.Value * products[2].Weight - minProductNum4.Value * products[3].Weight - minProductNum5.Value * products[4].Weight -
               minProductNum6.Value * products[5].Weight;
            if (weight < 0)
            {
                minProductNum4.Value -= 1;
            }
            showTreeBotton.Enabled = false;
        }

        private void minProductNum5_ValueChanged(object sender, EventArgs e)
        {
            decimal weight = Convert.ToDecimal(inputWeightBox.Lines[0]) - minProductNum1.Value * products[0].Weight - minProductNum2.Value * products[1].Weight -
               minProductNum3.Value * products[2].Weight - minProductNum4.Value * products[3].Weight - minProductNum5.Value * products[4].Weight -
               minProductNum6.Value * products[5].Weight;
            if (weight < 0)
            {
                minProductNum5.Value -= 1;
            }
            showTreeBotton.Enabled = false;
        }

        private void minProductNum6_ValueChanged(object sender, EventArgs e)
        {
            decimal weight = Convert.ToDecimal(inputWeightBox.Lines[0]) - minProductNum1.Value * products[0].Weight - minProductNum2.Value * products[1].Weight -
               minProductNum3.Value * products[2].Weight - minProductNum4.Value * products[3].Weight - minProductNum5.Value * products[4].Weight -
               minProductNum6.Value * products[5].Weight;
            if (weight < 0)
            {
                minProductNum6.Value -= 1;
            }
            showTreeBotton.Enabled = false;
        }

        private void CalculatingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Кнопка вычеслить расчитывает оптимальное количество каждого предмета и наивысшую стоимость набора, ограниченных вводимым весом и " +
                "минимальным колличеством каждого предмета\n    Кнопка показать дерево вычислений открывает форму для просмотра отдельной ветви дерева решений задачи.");
        }
    }
}
