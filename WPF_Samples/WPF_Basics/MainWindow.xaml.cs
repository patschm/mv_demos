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
using WPF_Basics.DI;
using WPF_Basics.ViewModels;

namespace WPF_Basics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IViewContainer _viewContainer;
        public MainWindow(IViewContainer viewContainer)
        {
            InitializeComponent();
            _viewContainer = viewContainer;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window dlg = new LifeTimeDialog();
            dlg.Owner = this;
            dlg.Show();
        }

        private void Button_Fancy(object sender, RoutedEventArgs e)
        {
            Window dlg = new FancyWindow();
            dlg.Owner = this;
            dlg.Show();
        }

        private void Button_Styles(object sender, RoutedEventArgs e)
        {
            Window dlg = _viewContainer.StylesWindow;
            dlg.Owner = this;
            dlg.Show();
        }
        private void Button_MVVM(object sender, RoutedEventArgs e)
        {
            Window dlg = _viewContainer.BindingWindow;
            dlg.Owner = this;
            dlg.Show();
        }
    }
}
