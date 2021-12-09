using DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using WpfDemo.ViewModels;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient client = new HttpClient();

        public MainWindow()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            DataContext = new PersonViewModel(client);
        }

        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    int.TryParse(txtAge.Text, out int age);
        //    var vm = DataContext as PersonViewModel;
        //    Person p = new Person
        //    {
        //        Firstname = vm.FirstName,
        //        Lastname = vm.LastName,
        //        Age = vm.Age
        //    };

        //    var json = JsonConvert.SerializeObject(p);
        //    StringContent content = new StringContent(json);
        //    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //    var result = await client.PostAsync("people", content);
        //    if (result.StatusCode == System.Net.HttpStatusCode.Created)
        //    {
        //        MessageBox.Show("Saved!!");
        //    }
        //}
    }
}
