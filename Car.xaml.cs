using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Car.xaml
    /// </summary>
    public partial class Car : Window
    {
        public Car()
        {
            InitializeComponent();
        }

        private void txtCalculateC_Click(object sender, RoutedEventArgs e)
        {
            //conerting string to int, declare int variable and assign it to string text value
            double num1 = Convert.ToInt32(TxtPurchacePrice.Text);
            double num2 = Convert.ToInt32(txtDepositCar.Text);
            double num3 = Convert.ToInt32(txtIntrestCar.Text);
            double num4 = Convert.ToInt32(txtInsuranceCar.Text);
            double num5 = Convert.ToInt32(txtYearsCar.Text);

            double num6 = num3 / 1200;
            double MonthlyPayment = Convert.ToInt32(num1 + num2 + num3) * num6 / (1 - 1 / Math.Pow(1 + num6, num5 * 12));
            double TotalPayment = Convert.ToInt32(MonthlyPayment * num5 * 12);




            listView.Items.Add("Date :" + "\t\t\t" + dateTimePickerC.Text);
            listView.Items.Add("******************************************************************");
            listView.Items.Add("Model and Make :" + "\t\t" + txtCarModel.Text);
            listView.Items.Add("Period of Years :" + "\t\t" + txtYearsCar.Text + "Years");
            listView.Items.Add("Cost :" + "\t\t\t" + "R" + TxtPurchacePrice.Text);
            listView.Items.Add("Deposit :" + "\t\t\t" + "R" + txtDepositCar.Text);
            listView.Items.Add("Interest Rate :" + "\t\t"  + txtIntrestCar.Text + "%");
            listView.Items.Add("Insurance :" + "\t\t" + "R" + txtInsuranceCar.Text);
            //monthly payment
            listView.Items.Add("******************************************************************");
            listView.Items.Add("Monthly Payment : " + "\t" + "R" + (+MonthlyPayment));
            //Total amouunt
            listView.Items.Add("Total : " + "\t\t\t" + "R" + (+TotalPayment));
            listView.Items.Add("******************************************************************");
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(); //loads to menu window
            menu.ShowDialog();
        }

        private void btnHome_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(); //loads to menu window
            menu.ShowDialog();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //this will clear everything in the form for the user to start fresh
            txtCarModel.Clear();
            txtDepositCar.Clear();
            txtInsuranceCar.Clear();
            txtIntrestCar.Clear();
            txtYearsCar.Clear();
            TxtPurchacePrice.Clear();
        }
    }

}
