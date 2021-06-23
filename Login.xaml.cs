using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        //linking database
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            //exporting data from the database in order to login if it doesnt exit it wont loging
            conn.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtLogUsername.Text + "' and password= '" + txtLogPass.Text + "'";
            cmd = new OleDbCommand(login, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
           

            txtLogPass.Text = "";
            txtLogUsername.Text = "";
            MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButton.OK, MessageBoxImage.Information);

            if (dr.Read() == true)
            {
                new Menu().Show();
                this.Hide();
            }
            else
            {
                //this is an error message that pops up if the user enter incorrect password or username and clears the textboxes
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                txtLogPass.Text = "";
                txtLogUsername.Text = "";
                txtLogUsername.Focus();
            }
            conn.Close();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.ShowDialog();
        }
    }
}
