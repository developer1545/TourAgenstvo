using Mysqlx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.RightsManagement;
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
        private Account _currentAccount = new Account();
        private string[] massive = { "User", "Admin", "Manager" };
        public Autorized()
        {
            InitializeComponent();
            DataContext = _currentAccount;
            
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

 

        private void Autorized_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentAccount.Login))
            {
                errors.AppendLine("Укажите логин");
            }
            if (string.IsNullOrWhiteSpace(_currentAccount.Password))
            {
                errors.AppendLine("Укажите пароль");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentAccount.Type == "")
            {
                errors.AppendLine("Укажите тип пользователя");
            }
            try
            {
                using (var context = UsersEntities.GetContext())
                {
                    string username = LoginText.Text;
                    string password = PasswordText.Text;
                    bool UserExits = context.Accounts.Any(u => u.Login == username && u.Password == password);
                    if (UserExits)
                    {
                        MessageBox.Show("Пользователь авторизован");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден");
                        MessageBox.Show("Неправильный логин или пароль");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }         
        }
        private void Autorizetion()
        {
           
            

        }
    }
}
