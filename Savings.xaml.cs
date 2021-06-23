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
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings : Window
    {
        public Savings()
        {
            InitializeComponent();
        }

        private void bbtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // the system will calculate the loan payments
            double InterestRate = Convert.ToDouble(txtInnterest.Text);
            double monthlyInteresetRate = InterestRate / 1200;
            double numberOfYears = Convert.ToInt32(txtYears.Text);
            double goal = Convert.ToDouble(txtGoal.Text);
            double MonthlyPayment = Convert.ToInt32(goal * monthlyInteresetRate / (1 - 1 / Math.Pow(1 + monthlyInteresetRate, numberOfYears * 12)));
            double TotalPayment = Convert.ToInt32(MonthlyPayment * numberOfYears * 12);
            double profit = Convert.ToInt32(TotalPayment - goal);


            listView.Items.Add("******************************************************************");
            listView.Items.Add("Goal :" + "\t\t\t" + "R" + txtGoal.Text);
            listView.Items.Add("Interest :" + "\t\t\t" + txtInnterest.Text + "%");
            listView.Items.Add("Period of Years :" + "\t\t" + txtYears.Text);
            //monthly payment
            listView.Items.Add("******************************************************************");
            listView.Items.Add("Monthly Payment : " + "\t" + "R" + (+MonthlyPayment));
            //interest
            listView.Items.Add("Profit : " + "\t\t\t" + "R" + (+profit));
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
    }
}
