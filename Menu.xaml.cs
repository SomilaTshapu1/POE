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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btncar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Car c = new Car(); //loads to car window
            c.ShowDialog();
        }

        private void btnRent_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow(); //loads to rent window
            main.ShowDialog();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            house h = new house(); //loads to home loan window
            h.ShowDialog();
        }

        private void btnExpenses_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Expenses ex = new Expenses(); //loads to main window
            ex.ShowDialog();
        }

        private void btnSavings_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Savings s = new Savings(); //loads to main window
            s.ShowDialog();
        }
    }
}
