using Inventarizacia.Model.BD;
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

namespace Inventarizacia.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для POStermPage.xaml
    /// </summary>
    public partial class POStermPage : Page
    {
        InventarzEntities entities = new InventarzEntities();
        public POStermPage()
        {
            InitializeComponent();
            POSListView.ItemsSource = entities.POSTermin.ToList();
        }

        private void ToMenu_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new View.Pages.MainPage());
        }
    }
}
