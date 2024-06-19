using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataTemplates
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var produkts = new ObservableCollection<Product>();
            produkts.Add(new Product()
            {
                PruductName = "Помидоы",
                ProductPrice = 189,
                ProductImage = "Data/Помидоры.jpg",
                Category = CategoriesProduct.Food
            }
            );
            produkts.Add(new Product()
            {
                PruductName = "Огурцы",
                ProductPrice = 200,
                ProductImage = "Data/Огурцы.jpg",
                Category = CategoriesProduct.Food
            }
           );
            produkts.Add(new Product()
            {
                PruductName = "Утюг",
                ProductPrice = 12000,
                ProductImage = "Data/Утюг.jpg",
                Category = CategoriesProduct.Appliances
            }
           );
            produkts.Add(new Product()
            {
                PruductName = "Блендер",
                ProductPrice = 15999,
                ProductImage = "Data/Блендер.jpg",
                Category = CategoriesProduct.Appliances
            }
           );
            listProducts.ItemsSource = produkts; 
        }
    }
}
