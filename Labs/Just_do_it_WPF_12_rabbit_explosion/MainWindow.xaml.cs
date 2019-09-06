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

namespace Just_do_it_WPF_12_rabbit_explosion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        static int counter = 0;
        public void Initialise()
        {
            //counter++;
            //Button01_Add.Content = $" you've clicked {counter} times";
            
        }

        public void Button01_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            Button01_Add.Content = $" you've clicked {counter} times";
        }
    }
    

}
