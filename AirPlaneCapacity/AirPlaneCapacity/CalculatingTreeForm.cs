using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirPlaneCapacity
{
    public partial class CalculatingTreeForm : Form
    {
        public int Weight { get; set; }
        MainCalculator calculator;
        CalculatingForm form;
        public CalculatingTreeForm(CalculatingForm calculatingForm , int weight, int[] minNumbesOfProducts, Product[] products)
        {
            InitializeComponent();
            calculator = new MainCalculator(minNumbesOfProducts, products);
            Weight = weight;
            form = calculatingForm;
        }

        private void CalculatingTreeForm_Load(object sender, EventArgs e)
        {
            richTextBox2.Enabled = false;
            numericUpDown2.Enabled = false;
            richTextBox3.Enabled = false;
            numericUpDown3.Enabled = false;
            richTextBox4.Enabled = false;
            numericUpDown4.Enabled = false;
            richTextBox5.Enabled = false;
            numericUpDown5.Enabled = false;
            richTextBox6.Enabled = false;
            int[] f6 = calculator.GetArrayByStep(Weight, 6, null);
            int i = 1;
            richTextBox1.Clear();
            foreach (int num in f6)
            {
                if (num == 0 && i != 1)
                {
                    i++;
                    continue;
                }
                if ((i != 1))
                    richTextBox1.AppendText($"\n");
                richTextBox1.AppendText($"{i} - {num}");
                i++;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox2.Enabled = true;
            numericUpDown2.Enabled = true;
            richTextBox3.Enabled = false;
            numericUpDown3.Enabled = false;
            richTextBox4.Enabled = false;
            numericUpDown4.Enabled = false;
            richTextBox5.Enabled = false;
            numericUpDown5.Enabled = false;
            richTextBox6.Enabled = false;
            if (numericUpDown1.Value > richTextBox1.Lines.Length)
                numericUpDown1.Value = richTextBox1.Lines.Length;
            else if (numericUpDown1.Value < 1) 
                    numericUpDown1.Value = 1;
            int[] aimNumber = { 0, 0, 0, 0, 0, (int)numericUpDown1.Value};
            int[] f5 = calculator.GetArrayByStep(Weight, 5, aimNumber);
            int i = 1;
            richTextBox2.Clear();
            foreach (int num in f5)
            {
                if (num == 0 && i != 1)
                {
                    i++;
                    continue;
                }
                if (i != 1)
                    richTextBox2.AppendText($"\n");
                richTextBox2.AppendText($"{i} - {num}");
                i++;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            richTextBox3.Enabled = true;
            numericUpDown3.Enabled = true;
            richTextBox4.Enabled = false;
            numericUpDown4.Enabled = false;
            richTextBox5.Enabled = false;
            numericUpDown5.Enabled = false;
            richTextBox6.Enabled = false;
            if (numericUpDown2.Value > richTextBox2.Lines.Length)
                numericUpDown2.Value = richTextBox2.Lines.Length;
            else if (numericUpDown1.Value < 1)
                numericUpDown1.Value = 1;
            int[] aimNumber = { 0, 0, 0, 0, (int)numericUpDown2.Value, (int)numericUpDown1.Value };
            int[] f4 = calculator.GetArrayByStep(Weight, 4, aimNumber);
            int i = 1;
            richTextBox3.Clear();
            foreach (int num in f4)
            {
                if (num == 0 && i != 1)
                {
                    i++;
                    continue;
                }
                if (i != 1)
                    richTextBox3.AppendText($"\n");
                richTextBox3.AppendText($"{i} - {num}");
                i++;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            richTextBox4.Enabled = true;
            numericUpDown4.Enabled = true;
            richTextBox5.Enabled = false;
            numericUpDown5.Enabled = false;
            richTextBox6.Enabled = false;
            if (numericUpDown3.Value > richTextBox3.Lines.Length)
                numericUpDown3.Value = richTextBox3.Lines.Length;
            else if (numericUpDown1.Value < 1)
                numericUpDown1.Value = 1;
            int[] aimNumber = { 0, 0, 0, (int)numericUpDown3.Value, (int)numericUpDown2.Value, (int)numericUpDown1.Value };
            int[] f3 = calculator.GetArrayByStep(Weight, 3, aimNumber);
            int i = 1;
            richTextBox4.Clear();
            foreach (int num in f3)
            {
                if (num == 0 && i != 1)
                {
                    i++;
                    continue;
                }
                if (i != 1)
                    richTextBox4.AppendText($"\n");
                richTextBox4.AppendText($"{i} - {num}");
                i++;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            richTextBox5.Enabled = true;
            numericUpDown5.Enabled = true;
            richTextBox6.Enabled = false;
            if (numericUpDown4.Value > richTextBox4.Lines.Length)
                numericUpDown4.Value = richTextBox4.Lines.Length;
            else if (numericUpDown1.Value < 1)
                numericUpDown1.Value = 1;
            int[] aimNumber = { 0, 0, (int)numericUpDown4.Value, (int)numericUpDown3.Value, (int)numericUpDown2.Value, (int)numericUpDown1.Value };
            int[] f2 = calculator.GetArrayByStep(Weight, 2, aimNumber);
            int i = 1;
            richTextBox5.Clear();
            foreach (int num in f2)
            {
                if (num == 0 && i != 1)
                {
                    i++;
                    continue;
                }
                if (i != 1)
                    richTextBox5.AppendText($"\n");
                richTextBox5.AppendText($"{i} - {num}");
                i++;
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            richTextBox6.Enabled = true;
            if (numericUpDown5.Value > richTextBox5.Lines.Length)
                numericUpDown5.Value = richTextBox5.Lines.Length;
            else if (numericUpDown1.Value < 1)
                numericUpDown1.Value = 1;
            int[] aimNumber = { 0, (int)numericUpDown5.Value, (int)numericUpDown4.Value, (int)numericUpDown3.Value, (int)numericUpDown2.Value, (int)numericUpDown1.Value };
            int[] f1 = calculator.GetArrayByStep(Weight, 1, aimNumber);
            int i = 1;
            richTextBox6.Clear();
            foreach (int num in f1)
            {
                if (num == 0 && i != 1)
                {
                    i++;
                    continue;
                }
                if (i != 1)
                    richTextBox6.AppendText($"\n");
                richTextBox6.AppendText($"{i} - {num}");
                i++;
            }
        }

        private void CalculatingTreeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Enabled = true;
        }
    }
}
