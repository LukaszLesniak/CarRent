using System.Windows;

namespace CarRent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rent_Car(object sender, RoutedEventArgs e)
        {
            RentCarWindow rentCarWindow = new RentCarWindow();
            rentCarWindow.Show();

        }

        private void Add_Car(object sender, RoutedEventArgs e)
        {
            AddCarWindow addCar = new AddCarWindow();
            addCar.Show();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
