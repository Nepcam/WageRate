using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WageRate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            const decimal WAGE_RATE = 25m;
            int hours = 0;
            decimal weeklyWage = 0;

            try
            {
                hours = int.Parse(textBoxHours.Text);
                weeklyWage = hours * WAGE_RATE;
                MessageBox.Show("Wages to be paid is " + weeklyWage.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
