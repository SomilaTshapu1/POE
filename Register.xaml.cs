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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }
        //linking database
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (txtRegUsername.Text == "" && txtRegpass.Text == "" && txtRegConfirm.Text == "")
            {

            }
            else if (txtRegpass.Text == txtRegConfirm.Text)
            {
                conn.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtRegUsername.Text + "','" + txtRegpass.Text + "')";
                cmd = new OleDbCommand(register, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                txtRegUsername.Text = "";
                txtRegpass.Text = "";
                txtRegConfirm.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButton.OK, MessageBoxImage.Information);

                this.Hide();
                Login l = new Login();
                l.ShowDialog();
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                txtRegpass.Text = "";
                txtRegUsername.Text = "";
                txtRegConfirm.Focus();
            }
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }
    }
}
