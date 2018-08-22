using CarRent.PublicModel;
using CarRent.Service;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CarRent
{
    
    public partial class RentCarWindow : Window
    {
        private void updateComboBoxes()
        {
            var clientService = new RentDispositionService();
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

        private void FirstNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            (DataContext as CarRentDisposition).Client.FirstName = (sender as TextBox).Text;
        }
               
        private void lastNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            (DataContext as CarRentDisposition).Client.LastName = (sender as TextBox).Text;

        }

        private void DriverLicenceText_TextChanged(object sender, TextChangedEventArgs e)
        {
            (DataContext as CarRentDisposition).Client.DriverLicense = (sender as TextBox).Text;

        }

        private void Brands(object sender, SelectionChangedEventArgs e)
        {
            var selecteditem = sender as ComboBox;
            (DataContext as CarRentDisposition).Car.Brand = (sender as TextBox).Text;
            updateComboBoxes();


        }

        private void Brands_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.SelectedIndex = 0;
        }

        private void Names(object sender, SelectionChangedEventArgs e)
        {
            var selecteditem = sender as ComboBox;
            
        }
        private void Names_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            (DataContext as CarRentDisposition).Car.CarName = (sender as TextBox).Text;

            combo.SelectedIndex = 0;
        }

        private void Colours(object sender, SelectionChangedEventArgs e)
        {
            var selecteditem = sender as ComboBox;
        }

        private void Colours_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            (DataContext as CarRentDisposition).Car.Colour = (sender as TextBox).Text;
            combo.SelectedIndex = 0;
        }

        private void Prices(object sender, SelectionChangedEventArgs e)
        {
            var selecteditem = sender as ComboBox;
        }

        private void Prices_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            (DataContext as CarRentDisposition).Car.Price = Double.Parse(combo.Text);
            combo.SelectedIndex = 0;
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

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void PriceComboBox_TargetUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            updateComboBoxes();
        }
        private void ApplyButton(object sender, RoutedEventArgs e)
        {
            var service = new RentDispositionService();
            service.CreateRentDispositon(DataContext as CarRentDisposition);

            MessageBox.Show("Succes");


        }

        
    }
}
