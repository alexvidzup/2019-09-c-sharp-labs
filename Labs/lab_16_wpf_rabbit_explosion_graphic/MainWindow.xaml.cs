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
using System.Windows.Threading;

namespace lab_16_wpf_rabbit_explosion_graphic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise()
        {
            Button01.Content = "Click here";
            timer.Interval = TimeSpan.FromMilliseconds(200);
            timer.Tick += changeColor;
        }
        static int counter = 0;
        //private void Button01_Click(object sender, RoutedEventArgs e)
        //{

        //    counter++;
        //    Button01.Content = $" you've clicked {counter} times";

        //    // random color generator
            

        //    //Create "Alex"

            



            
        //}
        public void changeColor(object sender, EventArgs e)
        {
            var r = new Random();
            Label01.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label02.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label03.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label04.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label05.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label06.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label07.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label08.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Button01.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label

            

            
            //Label00.Background = new SolidColorBrush(Color.FromRgb(color1, color2, color3));
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {

            timer.Start();
        }

        public (byte c1, byte c2, byte c3, byte c4, byte c5, byte c6) RandomColorGenerator()
        {
            var r = new Random();
            byte c1 = (byte)r.Next(0, 256);
            byte c2 = (byte)r.Next(0, 256);
            byte c3 = (byte)r.Next(0, 256);

            byte c4 = (byte)r.Next(0, 256);
            byte c5 = (byte)r.Next(0, 256);
            byte c6 = (byte)r.Next(0, 256);

            byte c7 = (byte)r.Next(0, 256);
            byte c8 = (byte)r.Next(0, 256);
            byte c9 = (byte)r.Next(0, 256);
            return (c1, c2, c3,c4,c5,c6);
            
        }

    }
}
