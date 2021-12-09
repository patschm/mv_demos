using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPF_Basics
{
    /// <summary>
    /// Interaction logic for LifeTimeDialog.xaml
    /// </summary>
    public partial class LifeTimeDialog : Window
    {
        public LifeTimeDialog()
        {
            InitializeComponent();
            this.WindowStyle = WindowStyle.ToolWindow;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            evtList.Items.Add(nameof(Window_Activated));
            media.Play();
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            evtList.Items.Add(nameof(Window_Deactivated));
            media.Pause();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            evtList.Items.Add(nameof(Window_Closing));
            MessageBoxResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
                e.Cancel = true;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            evtList.Items.Add(nameof(Window_Closed));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            evtList.Items.Add(nameof(Window_Loaded));
        }

        private void Window_SourceInitialized(object sender, EventArgs e)
        {
            evtList.Items.Add(nameof(Window_SourceInitialized));
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            evtList.Items.Add(nameof(Window_ContentRendered));
        }
    }
}
