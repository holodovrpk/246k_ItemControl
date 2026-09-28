using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _246k_ItemControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Product> products = new ObservableCollection<Product>();

        public MainWindow()
        {
            InitializeComponent();

            products.Add(new Product { Name = "Товар 1", Count = 3, 
                Description = "Офигенный товар 1", Price = 123, Rating = 4, Cover = ""});

            products.Add(new Product
            {
                Name = "Товар 2",
                Count = 5,
                Description = "Офигенный товар 2",
                Price = 5523,
                Rating = 5,
                Cover = ""
            });
            products.Add(new Product
            {
                Name = "Товар 3",
                Count = 9,
                Description = "Офигенный товар 3",
                Price = 823,
                Rating = 3,
                Cover = ""
            });
            products.Add(new Product
            {
                Name = "Товар 4",
                Count = 45,
                Description = "Офигенный товар 4",
                Price = 454,
                Rating = 2,
                Cover = ""
            });
            products.Add(new Product
            {
                Name = "Товар 5",
                Count = 47,
                Description = "Офигенный товар 5",
                Price = 2000,
                Rating = 5,
                Cover = ""
            });



            ProductList.ItemsSource = products;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product
            {
                Name = "Товар 888",
                Count = 447,
                Description = "Офигенный товар 888",
                Price = 2000,
                Rating = 2,
                Cover = ""
            });
        }
    }
}