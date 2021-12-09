using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using WpfDemo.ViewModels;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for OverviewWindow.xaml
    /// </summary>
    public partial class OverviewWindow : Window
    {
        private HttpClient client = new HttpClient();

        public OverviewWindow()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            DataContext = new OverviewViewModel(client);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window wnd = new MainWindow();
            wnd.ShowDialog();

        }
    }
}
