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

namespace lab_24_customer_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Customer> customerList;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise()
        {
            StackPanel01.Visibility = Visibility.Visible;
            StackPanel02.Visibility = Visibility.Collapsed;
            StackPanel03.Visibility = Visibility.Collapsed;


            // THIS CODE CONSTANTLY REFRESHES THE DATABASE AND UPDATES IT ON WHETHER THE NAME CONTAINS THE LETTERS OF THE SEARCH
            //using (var db = new NorthwindEntities())
            //{
                
            //    ListBoxCustomer01.ItemsSource = db.Customers.ToList();
            //    //Searches by the content of the searchbox
            //    //ListBoxCustomer01.ItemsSource = db.Customers.Where(c => c.ContactName.Contains(CustomerSearch.Text)).ToList();
            //    ListBoxCustomer01.DisplayMemberPath = "ContactName";
            //}
            using (var db = new NorthwindEntities())
            {
                customerList = db.Customers.ToList();
                ListBoxCustomer01.ItemsSource = customerList;
                //ListBoxCustomer01.DisplayMemberPath = "ContactName";

            }
            
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (StackPanel01.Visibility == Visibility.Visible) // PANEL 01
            {
                StackPanel01.Visibility = Visibility.Collapsed;
                StackPanel02.Visibility = Visibility.Collapsed;
                StackPanel03.Visibility = Visibility.Visible;
            } else if (StackPanel02.Visibility == Visibility.Visible) // PANEL 02
            {
                StackPanel01.Visibility = Visibility.Visible;
                StackPanel02.Visibility = Visibility.Collapsed;
                StackPanel03.Visibility = Visibility.Collapsed;
            }
             else if (StackPanel03.Visibility == Visibility.Visible) // Panel 03
            {
                StackPanel01.Visibility = Visibility.Collapsed;
                StackPanel02.Visibility = Visibility.Visible;
                StackPanel03.Visibility = Visibility.Collapsed;
            }
        }

        private void ButtonForward_Click(object sender, RoutedEventArgs e)
        {
            if (StackPanel01.Visibility == Visibility.Visible) // PANEL 01
            {
                StackPanel01.Visibility = Visibility.Collapsed;
                StackPanel02.Visibility = Visibility.Visible;
                StackPanel03.Visibility = Visibility.Collapsed;
            }
            else if (StackPanel02.Visibility == Visibility.Visible) // PANEL 02
            {
                StackPanel01.Visibility = Visibility.Collapsed;
                StackPanel02.Visibility = Visibility.Collapsed;
                StackPanel03.Visibility = Visibility.Visible;
            }
            else if (StackPanel03.Visibility == Visibility.Visible) // Panel 03
            {
                StackPanel01.Visibility = Visibility.Visible;
                StackPanel02.Visibility = Visibility.Collapsed;
                StackPanel03.Visibility = Visibility.Collapsed;
            }
        }

        private void CustomerSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CustomerSearch_KeyUp(object sender, KeyEventArgs e)
        {
            // THIS CODE CONSTANTLY REFRESHES THE DATABASE AND UPDATES IT ON WHETHER THE NAME CONTAINS THE LETTERS OF THE SEARCH
            //using (var db = new NorthwindEntities())
            //{
            //    ListBoxCustomer01.ItemsSource = db.Customers.Where(c => c.ContactName.Contains(CustomerSearch.Text)).ToList();
            //}

            
                ListBoxCustomer01.ItemsSource = customerList.Where(c => c.ContactName.Contains(CustomerSearch.Text)).ToList();
            
        }
        private void CustomerCitySearch_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void CustomerCitySearch_KeyUp(object sender, KeyEventArgs e)
        {
            // THIS CODE CONSTANTLY REFRESHES THE DATABASE AND UPDATES IT ON WHETHER THE NAME CONTAINS THE LETTERS OF THE SEARCH
            //using (var db = new NorthwindEntities())
            //{
            //    ListBoxCustomer01.ItemsSource = db.Customers.Where(c => c.ContactName.Contains(CustomerSearch.Text)).ToList();
            //}


            ListBoxCustomer01.ItemsSource = customerList.Where(c => c.City.Contains(CustomerCitySearch.Text)).ToList();

        }

        private void CustomerCitySearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CustomerSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBoxCustomer01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
