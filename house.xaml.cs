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
    /// Interaction logic for house.xaml
    /// </summary>
    public partial class house : Window
    {
        public house()
        {
            InitializeComponent();
        }

        private void btnCalculateHouse_Click(object sender, RoutedEventArgs e)
        {
            // the system will calculate the loan payments
            double InterestRate = Convert.ToDouble(txtInterestHouse.Text);
             double monthlyInteresetRate = InterestRate / 1200;
            double numberOfYears = Convert.ToInt32(txtLoanYearsHouse.Text);
            double loanAmount = Convert.ToDouble(txtLoanHouse.Text);
            double MonthlyPayment = Convert.ToInt32 (loanAmount * monthlyInteresetRate / (1 - 1 / Math.Pow(1 + monthlyInteresetRate, numberOfYears * 12)));
            double TotalPayment = Convert.ToInt32(MonthlyPayment * numberOfYears * 12);

            listView.Items.Add("Date :" + "\t\t\t" + date.Text);
            listView.Items.Add("******************************************************************");
            listView.Items.Add("Loan Amount :" + "\t\t" +"R" + txtLoanHouse.Text);
            listView.Items.Add("Interest :" + "\t\t\t" + txtInterestHouse.Text + "%");
            listView.Items.Add("Period of Years :" + "\t\t" + txtLoanYearsHouse.Text);
            listView.Items.Add("Deposit :" + "\t\t\t" + "R" + txtDepositHouse.Text);
            //monthly payment
            listView.Items.Add("******************************************************************");
            listView.Items.Add("Monthly Payment : " + "\t" + "R" + (+MonthlyPayment));
            //Total amouunt
            listView.Items.Add("Total : " + "\t\t\t" + "R" + (+TotalPayment));
            listView.Items.Add("******************************************************************");
        }

        private void btnClearhouse_Click(object sender, RoutedEventArgs e)
        {
            //this will clear everything in the form for the user to start fresh
            txtDepositHouse.Clear();
            txtInterestHouse.Clear();
            txtLoanHouse.Clear();
            txtLoanYearsHouse.Clear();
            

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(); //loads to menu window
            menu.ShowDialog();
        }
    }
}
