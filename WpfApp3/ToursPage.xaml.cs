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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для ToursPage.xaml
    /// </summary>
    public partial class ToursPage : Page
    {
        public ObservableCollection<BitmapImage> Images { get; set; }
  

        public ToursPage()
        {
            InitializeComponent();
            var allTypes = Import_FileEntities.GetContext().Types.ToList();
            allTypes.Insert(0, new Type { Name = "Все типы" });
            ComboType.ItemsSource = allTypes;
            CheckActual.IsChecked = true;
            ComboType.SelectedIndex = 0;
            var currentTours = Import_FileEntities.GetContext().Tours.ToList();
            LViewTours.ItemsSource = currentTours;
            Images = new ObservableCollection<BitmapImage>();
            DataContext = this;
            
            
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void CheckActual_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

