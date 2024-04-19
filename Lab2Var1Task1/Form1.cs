using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Var1Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            orderButton.Click += orderButton_Click;
            cancelButton.Click += cancelButton_Click;
            exitButton.Click += exitButton_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            double totalCost = CalculateTotalCost();
            totalPrice.Text = totalCost.ToString("N2");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            PeperoniUpDown.Value = 0;
            HawaiianUpDown.Value = 0;
            MeatUpDown.Value = 0;
            JuiceUpDown.Value = 0;
            TeaUpDown.Value = 0;
            CoffeeUpDown.Value = 0;
            totalPrice.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double CalculateTotalCost()
        {
            double totalCost = (double)PeperoniUpDown.Value * Convert.ToDouble(PeperoniPrice.Text) +
                               (double)HawaiianUpDown.Value * Convert.ToDouble(HawaiianPrice.Text) +
                               (double)MeatUpDown.Value * Convert.ToDouble(MeatPrice.Text) +
                               (double)JuiceUpDown.Value * Convert.ToDouble(JuicePrice.Text) +
                               (double)TeaUpDown.Value * Convert.ToDouble(TeaPrice.Text) +
                               (double)CoffeeUpDown.Value * Convert.ToDouble(CoffeePrice.Text);
            return totalCost;
        }

        private void pizzaTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
