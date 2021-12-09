using DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfDemo.Utils;

namespace WpfDemo.ViewModels
{
    class PersonViewModel : INotifyPropertyChanged
    {
        private HttpClient _client;
        private string _firstName = "Voornaam";

        public string FirstName 
        { 
            get { return _firstName; } 
            set
            {
                _firstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
            }
        }
        public string LastName { get; set; } = "Achternaam";
        public int Age { get; set; } = 42;
        public ICommand SaveCommand { get; }


        private async void SaveDataAsync(object o)
        {
            Person p = new Person();
            p.Firstname = this.FirstName;
            p.Lastname = this.LastName;
            p.Age = this.Age;

            var json = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await _client.PostAsync("people", content);
            if (result.StatusCode == System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("Saved!!");
            }
        }
        public PersonViewModel(HttpClient client)
        {
            _client = client;
            SaveCommand = new RelayCommand(SaveDataAsync);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
