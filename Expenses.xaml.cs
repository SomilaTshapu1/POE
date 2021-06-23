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
    /// Interaction logic for Expenses.xaml
    /// </summary>
    public partial class Expenses : Window
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //conerting string to int, declare int variable and assign it to string text value
            int groccery = Convert.ToInt32(txtGroceries.Text);
            int clothing = Convert.ToInt32(txtClothing.Text);
            int electricty = Convert.ToInt32(txtElectricity1.Text);
            int entertainment = Convert.ToInt32(txtEntertaiment.Text);
            int tax = Convert.ToInt32(txtTax.Text);
            int investments = Convert.ToInt32(txtInvestment.Text);
            int phone = Convert.ToInt32(txtPhone.Text);
            int transport = Convert.ToInt32(txttransport.Text);
            int water = Convert.ToInt32(txtWater1.Text);
            int gross = Convert.ToInt32(txtGross.Text);
            int total = (gross)-(+phone + transport + groccery + water + clothing
                + tax + entertainment + investments + electricty) ;



            listView.Items.Add("Date :" + "\t\t\t" + date.Text);
            listView.Items.Add("******************************************************************");
            listView.Items.Add("Groceries :" + "\t\t" + "R" + txtGroceries.Text);
            listView.Items.Add("Clothing :" + "\t\t" + "R" + txtClothing.Text);
            listView.Items.Add("Electricity :" + "\t\t" + "R" + txtElectricity1.Text);
            listView.Items.Add("Water :" + "\t\t\t" + "R" + txtWater1.Text);
            listView.Items.Add("Transport :" + "\t\t" + "R" + txttransport.Text);
            listView.Items.Add("Investments :" + "\t\t" + "R" + txtInvestment.Text);
            listView.Items.Add("Phone :" + "\t\t\t" + "R" + txtPhone.Text);
            listView.Items.Add("Entertainment :" + "\t\t" + "R" + txtEntertaiment.Text);
            listView.Items.Add("Tax :" + "\t\t\t" + "R" + txtTax.Text);
            //total amount spent
            listView.Items.Add("******************************************************************");
            listView.Items.Add("Money Spent : " + "\t\t" + "R" + (+phone + transport + groccery + water + clothing 
                + tax + entertainment + investments + electricty));
            //money left after expenses
            listView.Items.Add("Money Left : " + "\t\t" + "R" + (total));
            listView.Items.Add("******************************************************************");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //this will clear everything in the form for the user to start fresh
            txtClothing.Clear();
            txtTax.Clear();
            txtElectricity1.Clear();
            txtEntertaiment.Clear();
            txtGroceries.Text = "";
            txtGross.Text = "";
            txtInvestment.Text = "";
            txtPhone.Clear();
            txttransport.Text = "";
            txtWater1.Text = "";
            
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(); //loads to menu window
            menu.ShowDialog();
        }
    }
}
