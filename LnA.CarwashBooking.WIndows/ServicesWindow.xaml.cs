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
using LnA.CarwashBooking.WIndows.Models;
using LnA.CarwashBooking.WIndows.Helpers;

namespace LnA.CarwashBooking.WIndows
{
    /// <summary>
    /// Interaction logic for ServicesWindow.xaml
    /// </summary>
    public partial class ServicesWindow : Window
    {


        private int pageSize = 5;
        private int pageIndex = 1;
        private long pageCount = 1;
        private string sortBy = "first name";
        private string sortOrder = "asc";
        private decimal Total;
        private List<string> serviceQuery = new List<string>();
        private List<BookedService> serviceQty = new List<BookedService>();
        private BookedService removethis;

        public ServicesWindow()
        {
            InitializeComponent();
            showData();
            dtPicker.DisplayDateStart = DateTime.Now.AddDays(1);
            dtPicker.SelectedDate = DateTime.Now.AddDays(1);

        }
        public void showData()
        {
            var services = ServicesBLL.Search(pageIndex, pageSize, sortOrder, sortBy);
            dgServices.ItemsSource = services.Items;
            pageCount = services.PageCount;
        }
        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            Service service = ((FrameworkElement)sender).DataContext as Service;
            serviceQuery.Add(service.Name);

            txtbSelected.Text = string.Empty;
            string[] sauce = serviceQuery.ToArray();
            var searchTerm = service.Name;
            var ssQuery = from word in sauce
                          where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                          select word;
            var ssCount = ssQuery.Count();
            
            if ( ssCount == 1)
            {
              
                serviceQty.Add(new BookedService()               
                {
                    bsID = Guid.NewGuid(),
                    serviceName = service.Name,
                    serviceCount = ssCount
                });

                Total += service.Price;

                foreach (var ss in serviceQty)
                {
                    txtbSelected.Text = txtbSelected.Text + ss.serviceName + "x" + ss.serviceCount + "\n";
                }
                    lblTotal.Content = Total.ToString();    
            }

            if ( ssCount > 1) 
            {
            foreach (var servicetype in serviceQty.Where(w => w.serviceName == service.Name))
                {
                    servicetype.serviceCount = ssCount;
                }
                Total += service.Price;
                foreach (var ss in serviceQty)
                {
                    txtbSelected.Text = txtbSelected.Text + ss.serviceName + "x" + ss.serviceCount + "\n";
                }
                lblTotal.Content = Total.ToString();
            }        
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            Service service = ((FrameworkElement)sender).DataContext as Service;
            txtbSelected.Text = string.Empty;
            serviceQuery.Remove(service.Name);
            

            txtbSelected.Text = string.Empty;
            string[] sauce = serviceQuery.ToArray();
            var searchTerm = service.Name;
            var ssQuery = from word in sauce
                          where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                          select word;
            var ssCount = ssQuery.Count();
            
            if (ssCount == 0)
            {           
                foreach (var servicetype in serviceQty.Where(w => w.serviceName == service.Name))
                {
                    removethis = servicetype;
                    Total -= service.Price;
                }
                serviceQty.Remove(removethis);      
                foreach (var ss in serviceQty)
                    
                {
                    txtbSelected.Text = txtbSelected.Text + ss.serviceName + "x" + ss.serviceCount + "\n";
                }
                lblTotal.Content = Total.ToString();
            }
            if (ssCount > 0)
            {
                
                foreach (var servicetype in serviceQty.Where(w => w.serviceName == service.Name))
                {
                    servicetype.serviceCount = ssCount;
                }
                Total -= service.Price;
                foreach (var ss in serviceQty)
                {
                    txtbSelected.Text = txtbSelected.Text + ss.serviceName + "x" + ss.serviceCount + "\n";
                }
                lblTotal.Content = Total.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Guid guid;
            guid = Guid.NewGuid();
            var op = BookingBLL.Add(new Booking()
            {
                Date = dtPicker.SelectedDate.Value,
                PayAmount = Total.ToString(),
                BookingId = guid,
                UserId = ProgramUser.Id
            });

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {

                MessageBox.Show("Booking Successful");
                foreach (var ss in serviceQty)
                {
                    var op2 = BookedServicesBLL.Add(new BookedService()
                    {
                        BookingId = guid,
                        bsID = Guid.NewGuid(),
                        serviceCount = ss.serviceCount,
                        serviceName = ss.serviceName
                    }); 
                
                }
            }
        }
    }   
}
