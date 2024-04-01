using Inventarizacia.Model.Classes;
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

namespace Inventarizacia
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            Set.user = null;
            if (Logtxt != null && Pastxt != null)
            {
                ViewModel.VMAuth vM;
                vM = new ViewModel.VMAuth(Logtxt.Text,Pastxt.Password);
            }
            if(Set.user!=null)
            {
                View.MainMenu mainMenu = new View.MainMenu();
                this.Close();
                mainMenu.Show();
            }
            this.Cursor = Cursors.Arrow;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
