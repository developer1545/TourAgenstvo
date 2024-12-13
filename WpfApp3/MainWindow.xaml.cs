using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool MenuClick = false;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new ToursPage());
            Manager.MainFrame = MainFrame;
            //ImportTours();
           Border.Visibility = Visibility.Hidden;
           
        }
        private void MouseExitOpt()
        {
            Border.Visibility = Visibility.Hidden;
        }
        private void MouseMoveOpt()
        {
            Border.Visibility = Visibility.Visible;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                Manager.MainFrame.GoBack();
            }
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                Back.IsEnabled = true;
            }
            else
            {
                Back.IsEnabled = false;
            }

        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {

            MouseMoveOpt();
            //Window newWindow = new Autorized();
            //newWindow.Show();

        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveOpt();
        }

        private void MouseLeave(object sender, MouseEventArgs e)
        {
            MouseExitOpt();
        }

        private void Account_click(object sender, MouseButtonEventArgs e)
        {
            Window newWindow = new Autorized();
            newWindow.Show();
        }
    }
}
        /*private void ImportTours()
        {
            var fileData = File.ReadAllLines(@"D:\1\Tours.txt");
            var images = Directory.GetFiles(@"C:\\Users\\antom\\OneDrive\\Рабочий стол\\2024-2025\\УП.01.01\\import до\\Туры фото");
            foreach (var line in fileData)
            {
                var data = line.Split('\t');
                var tempTour = new Tour
                {
                    Name = data[0].Replace("\"", ""),
                    TicketCount = int.Parse(data[2]),
                    Price = decimal.Parse(data[3]),
                    IsActual = (data[4] == "0") ? false : true
                };
                foreach (var TypeOfTour in data[5].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var currentType = Import_FileEntities.GetContext().Types.ToList().FirstOrDefault(p => p.Name == TypeOfTour);
                    if (currentType != null)
                    {
                        tempTour.Types.Add(currentType);
                    }
                    try
                    {
                        tempTour.ImagePreview = File.ReadAllBytes(images.FirstOrDefault(p => p.Contains(tempTour.Name)));
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                }
                Import_FileEntities.GetContext().Tours.Add(tempTour);
                Import_FileEntities.GetContext().SaveChanges();
            }
        }
    }
} */
/*public partial class Import_FileEntities : DbContext
   {
       private static Import_FileEntities _context;
       public Import_FileEntities()
       : base("name=Import_FileEntities")
       {
       }
       public static Import_FileEntities GetContext()
       {
           if (_context == null)
               _context = new Import_FileEntities();
           return _context;
       }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           throw new UnintentionalCodeFirstException();
       }
   }
   private void ImportTours()
   {
       var fileData = File.ReadAllLines(@"C:\\Users\antom\\OneDrive\\Рабочий стол\\2024-2025\\УП.01.01\\import до\\Туры.txt");
       var images = Directory.GetFiles(@"C:\\Users\\antom\\OneDrive\\Рабочий стол\\2024-2025\\УП.01.01\\import до\\Туры фото");
       foreach (var line in fileData)
       {
           var data = line.Split('\t');
           var tempTour = new Tour
           {
               Name = data[0].Replace("\"", ""),
               TicketCount = int.Parse(data[2]),
               Price = decimal.Parse(data[3]),
               IsActual = (data[4] == "0") ? false : true
           };
           foreach (var TypeOfTour in data[5].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries))
           {
               var currentType = Import_FileEntities.GetContext().Types.ToList().FirstOrDefault(p => p.Name == TypeOfTour);
               if (currentType != null)
               {
                   tempTour.Types.Add(currentType);
               }
               try
               {
                   tempTour.ImagePreview = File.ReadAllBytes(images.FirstOrDefault(p => p.Contains(tempTour.Name)));
               }
               catch (Exception ex) { Console.WriteLine(ex.Message); }
           }
           Import_FileEntities.GetContext().Tours.Add(tempTour);
           Import_FileEntities.GetContext().SaveChanges();
       }
   }
}
}
*/

