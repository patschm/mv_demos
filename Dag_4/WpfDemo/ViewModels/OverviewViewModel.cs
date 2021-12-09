using DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfDemo.Utils;

namespace WpfDemo.ViewModels
{
    class OverviewViewModel
    {
        private HttpClient _client;

        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        public ICommand LoadCommand { get; }

        public OverviewViewModel(HttpClient client)
        {
            _client = client;
            LoadCommand = new RelayCommand(LoadDataAsync);
        }

        private async void LoadDataAsync(object obj)
        {
            var response = await _client.GetAsync("people");
            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                // Nuget Package Newtonsoft.Json
                var list = JsonConvert.DeserializeObject<List<Person>>(body);
                list.Take(5).ToList().ForEach(p => People.Add(p));
            }
        }
    }
}
