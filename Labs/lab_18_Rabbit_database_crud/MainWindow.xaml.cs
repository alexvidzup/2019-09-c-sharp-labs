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

namespace lab_18_Rabbit_database_crud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Rabbit> rabbits;
        static Rabbit rabbit = new Rabbit();
        static Color color1 = (Color)ColorConverter.ConvertFromString("#FFF091");
        static Color color2 = (Color)ColorConverter.ConvertFromString("#E8D389");
        static Color color3 = (Color)ColorConverter.ConvertFromString("#FFE2A3");
        static Color color4 = (Color)ColorConverter.ConvertFromString("#EBCA9B");
        static Color color5 = (Color)ColorConverter.ConvertFromString("#FFC999");

        static Brush brush1 = new SolidColorBrush(color1);
        static Brush brush2 = new SolidColorBrush(color2);
        static Brush brush3 = new SolidColorBrush(color3);
        static Brush brush4 = new SolidColorBrush(color4);
        static Brush brush5 = new SolidColorBrush(color5);

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }


        // using : automatic clean-up ((C# does not know
        // inherently when we're done so this block help
        // C# know that we are done, and clean all memory
        public void Initialise()
        {
            using (var db = new RabbitDbEntities())
            {
                rabbits = db.Rabbits.ToList();
            }

            //// MANUAL METHOD
            //// Fancy 'lambda' to a) loop rabbits b) each loop, add item to listbox on screen
            //// get the list of rabbits.  For each rabbit in the list of rabbits do the following
            // rabbits.ForEach(rabbit => ListBoxRabbits.Items.Add(rabbit));
            // foreach (var rabbit in rabbits){ ... ListBoxRabbits.Items.Add...}


            // BINDING METHOD : Bind ListBox to database (better method)
            ListBoxRabbit.DisplayMemberPath = "Name";
            ListBoxRabbit.ItemsSource = rabbits;

            TextBoxAge.IsReadOnly = false;
            TextBoxName.IsReadOnly = true;

            ButtonEdit.IsEnabled = false;
            ButtonDelete.IsEnabled = false;


        }

        private void ListBoxRabbit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // when delesect a rabbit, don't run this code
            // if(rabbit != null) // or 
            if (ListBoxRabbit.SelectedItem != null)
            {
                // whenever we select an item in the list, cast it from (Object) type
                // and put it as a (Rabbit) type. Put in the global 'rabbit' variable
                rabbit = (Rabbit)ListBoxRabbit.SelectedItem;
                TextBoxName.Text = rabbit.Name;
                TextBoxAge.Text = rabbit.AGE.ToString();
                // enable edit and delete
                ButtonEdit.IsEnabled = true;
                ButtonDelete.IsEnabled = true;

            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (ButtonAdd.Content.Equals("Add"))
            {
                ButtonAdd.Content = "Save";
                ButtonAdd.Background = brush2;
                // clear boxes and set to white
                TextBoxName.Text = "";
                TextBoxAge.Text = "";
                TextBoxName.Background = (SolidColorBrush)Brushes.White;
                TextBoxAge.Background = (SolidColorBrush)Brushes.White;
                TextBoxName.IsReadOnly = false;
                TextBoxAge.IsReadOnly = false;

            }
            else
            {
                ButtonAdd.Content = "Add";
                ButtonAdd.Background = brush3;
                TextBoxAge.Background = brush2;
                TextBoxName.Background = brush2;
                TextBoxName.IsReadOnly = true;
                TextBoxAge.IsReadOnly = true;
                // commit changes
                if ((TextBoxAge.Text.Length > 0) && (TextBoxName.Text.Length > 0))
                {
                    // get age
                    if (int.TryParse(TextBoxAge.Text, out int age))
                    {
                        var RabbitToAdd = new Rabbit()
                        {
                            Name = TextBoxName.Text,
                            AGE = age
                        };
                        // read db and add new rabbit to the list
                        using (var db = new RabbitDbEntities())
                        {
                            db.Rabbits.Add(RabbitToAdd);
                            db.SaveChanges();
                            // to update the view

                            rabbit = null;

                            rabbits = db.Rabbits.ToList();
                            ListBoxRabbit.ItemsSource = null;
                            ListBoxRabbit.ItemsSource = rabbits;


                        }


                    }
                }



            }
        }

        public void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (ButtonEdit.Content.Equals("Edit")) // .Equals is required instead of ==
            {
                ButtonEdit.Background = brush2;
                ButtonEdit.Content = "Save";
                // enable text boxes to be edited
                TextBoxName.IsReadOnly = false;
                TextBoxAge.IsReadOnly = false;
                // change the colour of the textboxes while they are being edited
                TextBoxAge.Background = (SolidColorBrush)Brushes.White;
                TextBoxName.Background = (SolidColorBrush)Brushes.White;
                // to keep the add button disabled
                ButtonAdd.IsEnabled = false;
                // to highlight the text of the rabbit name
                TextBoxName.Focus();
                TextBoxName.SelectAll();
            }
            else
            {
                ButtonEdit.Background = brush3;
                ButtonEdit.Content = "Edit";
                if ((TextBoxAge.Text.Length > 0) && (TextBoxName.Text.Length > 0))
                {
                    // must have selected a rabbit
                    if (rabbit != null)
                    {
                        rabbit.Name = TextBoxName.Text;
                        if (int.TryParse(TextBoxAge.Text, out int age))
                        {
                            rabbit.AGE = age;
                        }

                        using (var db = new RabbitDbEntities())
                        {
                            // read rabbit from database by ID
                            var rabbitToUpdate = db.Rabbits.Find(rabbit.RabbitId);
                            // read rabbit 
                            rabbitToUpdate.Name = rabbit.Name;
                            rabbitToUpdate.AGE = rabbit.AGE;
                            // save rabbit back to db
                            db.SaveChanges();
                            // clear listbox because we're going to change (the binding)
                            rabbit = null; // remove the binding rabbit
                            // ListBoxRabbit.ItemsSource = null; // remove binding
                            //ListBoxRabbit.Items.Clear();    // clear it out
                            // repopulate listbox // re-read from db
                            rabbits = db.Rabbits.ToList();      // get rabbits
                            ListBoxRabbit.ItemsSource = rabbits; // bind to listbox again

                        }

                    }
                    //TextBoxAge.Text = "";
                    //TextBoxName.Text = "";
                    TextBoxAge.IsReadOnly = true;
                    TextBoxName.IsReadOnly = true;
                }
            }
        }
        public void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ButtonDelete.Content.Equals("Delete"))
            {
                ButtonDelete.Content = "Confirm";

            }
            else
            {
                // delete record
                // find record in database which matches selected rabbit
                if (rabbit != null)
                {
                    using (var db = new RabbitDbEntities())

                    {
                        var rabbitToDelete = db.Rabbits.Find(rabbit.RabbitId); // creating new object and finding it's correlation in the database
                        db.Rabbits.Remove(rabbitToDelete); // remove the rabbit from the database
                        db.SaveChanges(); //  save changes to database

                        //ListBoxRabbit.ItemsSource = null;

                        // rabbit = null;
                        rabbits = db.Rabbits.ToList();
                        ListBoxRabbit.ItemsSource = rabbits;
                    }
                }
                TextBoxName.Text = "";
                TextBoxAge.Text = "";

                ButtonDelete.IsEnabled = false;

                ButtonDelete.Content = "Delete";
            }
        }
        //public void DoThis(object sender, EventArgs e)
        //{
        //    // which key?
        //   // var letterPressed = (char)sender;
        //    MessageBox.Show($"you pressed{letterPressed}");
        //    //if((char)object )
        //}
    }
}
