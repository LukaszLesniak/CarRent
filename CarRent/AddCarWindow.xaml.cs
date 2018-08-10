using CarRent.PublicModel;
using CarRent.Service;
using System.Windows;
using System.Windows.Controls;

namespace CarRent
{
    /// <summary>
    /// Interaction logic for AddCar.xaml
    /// </summary>
    public partial class AddCarWindow : Window
    {
        private static string[] colours = new[] { "Red", "Soul red", "Blue", "Black", "Metalic" };
        private static int[] pricees = new[] { 90, 100, 110, 120 };


        public AddCarWindow()
        {
            InitializeComponent();
            DataContext = new CarPub();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Add_Car(object sender, RoutedEventArgs e)
        {
            var message = new CarService().CreateCar(DataContext as CarPub);

            MessageBox.Show(message);
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;

            var service = new CarService();

            combo.ItemsSource = service.GetCars();

            combo.DisplayMemberPath = "PublicCars";
            combo.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selecteditem = sender as ComboBox;
            var car = selecteditem.SelectedItem;
            MessageBox.Show(car.ToString());
        }



        private void ComboBox_Colour_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selecteditem = sender as ComboBox;
            (DataContext as CarPub).Colour = selecteditem.SelectedItem as string;
        }

        private void ComboBox_Colour_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.ItemsSource = colours;
        }


        private void ComboBox_Price_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedprice = sender as ComboBox;
            (DataContext as CarPub).Price = int.Parse(selectedprice.Items[selectedprice.SelectedIndex].ToString());
        }

        private void ComboBox_Price_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.ItemsSource = pricees;
        }

        private void CarList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

