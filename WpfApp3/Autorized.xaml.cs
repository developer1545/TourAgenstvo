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
    /// Логика взаимодействия для Autorized.xaml
    /// </summary>
    public partial class Autorized : Window
    {
        public Autorized()
        {
            InitializeComponent();
        }

        private void Register_click(object sender, MouseButtonEventArgs e)
        {
            Window newWindow = new Register();
            newWindow.Show();
        }

        private void MouseEnter(object sender, MouseEventArgs e)
        {
            TextRe.TextDecorations = TextDecorations.Underline;
        }
        private void Block_MouseLeave(object sender, MouseEventArgs e)
        {
            TextRe.TextDecorations = null;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
