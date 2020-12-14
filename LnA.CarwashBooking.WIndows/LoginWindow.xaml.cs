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
using LnA.CarwashBooking.WIndows.BLL;
using LnA.CarwashBooking.WIndows.DAL;
using LnA.CarwashBooking.WIndows.Helpers;

namespace LnA.CarwashBooking.WIndows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                MessageBox.Show("Invalid Login");
            };

            if (string.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Invalid Login");
            };

            var op = UserBLL.Login(txtEmailAddress.Text, txtPassword.Password);

            if (op.Code == "200")
            {
                var user = UserBLL.GetbyId(op.ReferenceId);
                
                ProgramUser.Id = user.UserId;
                
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}
