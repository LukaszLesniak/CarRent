using CarRent.PublicModel;
using CarRent.Service;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CarRent
{
    /// <summary>
    /// Interaction logic for RentCarWindow.xaml
    /// </summary>
    public partial class RentCarWindow : Window
    {
        private void updateComboBoxes()
        {
            var carService = new CarService();
            BrandComboBox.ItemsSource = carService.GetCars().GroupBy(x => x.Brand).Select(x => x.Key);

            CarNamesComboBox.ItemsSource = carService.GetCars(brandFilter: BrandComboBox.SelectedValue as string).GroupBy(x => x.CarName).Select(x => x.Key);

            ColourComboBox.ItemsSource = carService.GetCars(brandFilter: BrandComboBox.SelectedValue as string, nameFilter: CarNamesComboBox.SelectedValue as string).GroupBy(x => x.Colour).Select(x => x.Key);
        }

        public RentCarWindow()
        {
            InitializeComponent();
            DataContext = new CarRentDisposition();
            updateComboBoxes();
        }
        
        private void Brands(object sender, SelectionChangedEventArgs e)
        {
            var selecteditem = sender as ComboBox;
            updateComboBoxes();

        }

        private void Brands_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.SelectedIndex = 0;
        }

        private void ApplyButton(object sender, RoutedEventArgs e)
        {
            var carRentDisposition = (DataContext as CarRentDisposition);
            string clientData = "ClientPub: " + carRentDisposition.Client.FirstName + " " + carRentDisposition.Client.LastName + " "
                + "DL number" + carRentDisposition.Client.DriverLicense + " ";
            MessageBox.Show(clientData);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            return;
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Names(object sender, SelectionChangedEventArgs e)
        {
            var selecteditem = sender as ComboBox;
            
        }
        private void Names_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.SelectedIndex = 0;
        }

        private void Colours(object sender, SelectionChangedEventArgs e)
        {
            var selecteditem = sender as ComboBox;
        }

        private void Colours_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.SelectedIndex = 0;
        }
        private void DriverLicenceText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BrandComboBox_TargetUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            updateComboBoxes();
        }

        private void CarNamesComboBox_TargetUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            updateComboBoxes();
        }

        private void ColourComboBox_TargetUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            updateComboBoxes();
        }
    }
}
