using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPlaneCapacity
{
    public partial class MainManu : Form
    {
        public MainManu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatingForm calculatingForm = new CalculatingForm(this);
            calculatingForm.Show();
            this.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа предназанчена для решения задачи динамического программирования о распределении ресурсов или задачи о рюкзаке с предметами: " +
                "   \n1 --> 0.8 г 12 д. е. " +
                "   \n2 --> 3.2 г 60 д. е. " +
                "   \n3 --> 4.8 г 72 д. е. " +
                "   \n4 --> 6.5 г 11 д. е. " +
                "   \n5 --> 2.8 г 50 д. е. " +
                "   \n6 --> 2.1 г 15 д. е. " +
                "\nРаботу выполнил ст-т 2-го курса гр. А91ИСТ2 Дубаневич К. А.");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
