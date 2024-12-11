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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private int[] massive = {1, 2, 3, 4, 5 };
        private Hotel _currentHotel = new Hotel();
        public AddEditPage(Hotel selectedHotel)
        {
            InitializeComponent();
            if (selectedHotel != null) 
            {
                _currentHotel = selectedHotel; 
            }
            ComboBox.ItemsSource = Import_FileEntities.GetContext().Countries.ToList();
            ComboBoxList.ItemsSource = massive;
            DataContext = _currentHotel;
        }
    
        private void BtnSave_click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentHotel.Name))
            {
                errors.AppendLine("Укажите название отеля");
            }
            if (_currentHotel.CountOfStars == 0)
            {
                errors.AppendLine("Выберите количество звёзд");
            }
            if (_currentHotel.Country == null)
            {
                errors.AppendLine("Выберите страну");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentHotel.ID == 0)
            {
                Import_FileEntities.GetContext().Hotels.Add(_currentHotel);
            }
            try
            {
                Import_FileEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация успешно сохранена!");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

     
    }
}
