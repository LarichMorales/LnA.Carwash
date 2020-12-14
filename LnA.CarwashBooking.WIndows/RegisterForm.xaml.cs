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
using LnA.CarwashBooking.WIndows.Models.Enums;
using LnA.CarwashBooking.WIndows.Models;
using LnA.CarwashBooking.WIndows.BLL;

namespace LnA.CarwashBooking.WIndows
{
    /// <summary>
    /// Interaction logic for RegisterForm.xaml
    /// </summary>
    public partial class RegisterForm : Window
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Gender gender = Gender.Female;
            Role role = Role.Customer;
            if (cboGender.SelectedItem.ToString().ToLower() == "male")
            {
                gender = Gender.Male;
            }


            var op = UserBLL.Add(new User()
            {
                ContactNumber = txtContactNumber.Text,
                Email = txtEmailAddress.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = gender,
                Role = role,
                Password = txtPassword.Text,
                UserId = Guid.NewGuid(),

            });

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {
                MessageBox.Show("User is successfully added to table");
            }
        }

        private void txtFirstName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtFirstName.Text = "";
        }

        private void txtLastName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtLastName.Text = "";
        }

    }
}
