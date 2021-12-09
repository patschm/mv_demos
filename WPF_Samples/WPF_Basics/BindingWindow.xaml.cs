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
using WPF_Basics.Models;
using WPF_Basics.ViewModels;

namespace WPF_Basics
{
    /// <summary>
    /// Interaction logic for BindingWindow.xaml
    /// </summary>
    public partial class BindingWindow : Window
    {
        public BindingWindow(BindingViewModel viewModel)
        {
            InitializeComponent();
            //var data = new BindingViewModel(new FakePersonRepository());
            DataContext = viewModel;
            viewModel.Initialize();
            //data.Initialize();
        }
    }
}
