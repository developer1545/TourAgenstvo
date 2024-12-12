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
            var currentTours = Import_FileEntities.GetContext().Tours.ToList();
            LViewTours.ItemsSource = currentTours;
            Images = new ObservableCollection<BitmapImage>();
            DataContext = this;

            LoadImages();

        }
        private void LoadImages()
        {
            // Пример загрузки изображений
            Images.Add(new BitmapImage(new Uri("C:\\Users\\antom\\OneDrive\\Рабочий стол\\2024-2025\\УП.01.01\\import до\\Туры фото\\Город с большими амбициями.jpg")));
            Images.Add(new BitmapImage(new Uri("C:\\Users\\antom\\OneDrive\\Рабочий стол\\2024-2025\\УП.01.01\\import до\\Туры фото\\Город четырех ворот.jpg")));
            Images.Add(new BitmapImage(new Uri("C:\\Users\\antom\\OneDrive\\Рабочий стол\\2024-2025\\УП.01.01\\import до\\Туры фото\\Древний Минск.jpg")));
            Images.Add(new BitmapImage(new Uri("C:\\Users\\antom\\OneDrive\\Рабочий стол\\2024-2025\\УП.01.01\\import до\\Туры фото\\Жемчужина Татарстана.jpg")));
            Images.Add(new BitmapImage(new Uri("C:\\Users\\antom\\OneDrive\\Рабочий стол\\2024-2025\\УП.01.01\\import до\\Туры фото\\Прекрасные острова Греции.jpg")));
            Images.Add(new BitmapImage(new Uri("C:\\Users\\antom\\OneDrive\\Рабочий стол\\2024-2025\\УП.01.01\\import до\\Туры фото\\Финская крепость.jpg")));
            // Добавьте другие изображения по мере необходимости
        }
    }
}

