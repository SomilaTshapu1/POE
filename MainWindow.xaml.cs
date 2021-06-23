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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //this will clear everything in the form for the user to start fresh
            txtDeposit.Clear();
            txtTax.Clear();
            txtElectricity.Clear();
            txtCost.Clear();
            txtAddress.Text = "";
            txtPostal.Text = "";
            txtWater.Text = "";

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //conerting string to int, declare int variable and assign it to string text value
            int num1 = Convert.ToInt16(txtCost.Text);
            int num2 = Convert.ToInt16(txtDeposit.Text);
            int num3 = Convert.ToInt16(txtElectricity.Text);
            int num4= Convert.ToInt16(txtWater.Text);
            int num5 = Convert.ToInt16(txtTax.Text);
           

            listView.Items.Add("Date :" + "\t\t" + date.Text);
            listView.Items.Add("******************************************************************");
            listView.Items.Add("Address :"+ "\t" + txtAddress.Text);
            listView.Items.Add("Postal :" + "\t\t" + txtPostal.Text);
            listView.Items.Add("Cost :" + "\t\t" + "R" + txtCost.Text);
            listView.Items.Add("Deposit :" + "\t\t" + "R" + txtDeposit.Text);
            listView.Items.Add("Electricity :" + "\t" + "R" + txtElectricity.Text);
            listView.Items.Add("Water :" + "\t\t" + "R" + txtWater.Text);
            listView.Items.Add("Tax :" + "\t\t" + "R" + txtTax.Text);

            //total amount
            listView.Items.Add("******************************************************************");
            listView.Items.Add("Total : " + "\t\t" + "R" + (+num1 + num2 + num3 + num4 + num5));
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
