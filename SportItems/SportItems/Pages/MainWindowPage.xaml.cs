using SportItems.Classes;
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

namespace SportItems.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainWindowPage.xaml
    /// </summary>
    public partial class MainWindowPage : Page
    {

        public List<Someshit> Some { get; set; }

        public MainWindowPage()
        {
            InitializeComponent();
            Some = new List<Someshit>();
            Some.Add(new Someshit { Name = "Someone", Cost = 0, Age = 0 } );
            Some.Add(new Someshit { Name = "Sometwo", Cost = 0, Age = 0 });
            Some.Add(new Someshit { Name = "Somethree", Cost = 0, Age = 0 });

            dataListBox.ItemsSource = Some;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            NavClass.PagesDictionary.TryGetValue("SignInPage", out Page? FoundPage);
            NavClass.frame.Navigate(FoundPage);
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            NavClass.PagesDictionary.TryGetValue("SignUpPage", out Page? FoundPage);
            NavClass.frame.Navigate(FoundPage);
        }
    }

    public partial class Someshit
    {
        public string Name;
        public int Cost;
        public int Age;
    }

}
