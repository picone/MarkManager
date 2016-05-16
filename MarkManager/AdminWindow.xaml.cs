using MarkManager.ServiceReference;
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

namespace MarkManager
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AdminWindow : Window
    {
        private ServiceClient client;

        public AdminWindow()
        {
            client = new ServiceClient();

            InitializeComponent();

            clazz_grid.ItemsSource=client.GetClazzs();
        }

        private void clazz_add_Click(object sender, RoutedEventArgs e)
        {
            clazz_grid.CanUserAddRows = true;
        }

        private void clazz_edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void clazz_save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
