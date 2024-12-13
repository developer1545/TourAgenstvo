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
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для OOO.xaml
    /// </summary>
    public partial class OOO : Window
    {
        public OOO()
        {
            InitializeComponent();
        }

        private void Mouse(object sender, MouseEventArgs e)
        {

        }

        private void MouseLicenEnter(object sender, MouseEventArgs e)
        {
            TextL.TextDecorations = TextDecorations.Underline;
        }

        private void MouseLeaveLeave(object sender, MouseEventArgs e)
        {
            TextL.TextDecorations = null;
        }

        private void MouseLDown(object sender, MouseButtonEventArgs e)
        {
            Window newWindow = new Lice();
            newWindow.Show();
        }
    }
}
