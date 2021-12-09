using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Basics.Models;
using WPF_Basics.Utils;

namespace WPF_Basics.ViewModels
{
    public class BindingViewModel : BaseViewModel
    {
        private IPersonRepository _repository;
        public BindingViewModel(IPersonRepository repository)
        {
            _repository = repository;
        }

        public ObservableCollection<PersonViewModel> People { get; set; } = new ObservableCollection<PersonViewModel>();

        private int _currentPage = 0;
        private int _pageSize = 10;
        private bool _canPageUp = false;

        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = value;
                NotifyPropertyChanged();
            }
        }
        public int CurrentPage
        {
            get { return _currentPage; }
            set
            {
                _currentPage = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand Next
        {
            get
            {
                return new RelayCommand<int>(NextPage, x => _canPageUp);
            }
        }
        public ICommand Previous
        {
            get
            {
                return new RelayCommand<int>(PreviousPage, x => _currentPage > 0);
            }
        }

        public void Initialize()
        {
            var tmp = _repository.Get(0, PageSize);
            if (tmp.Count == 0) return;
            _canPageUp = tmp.Count == PageSize;
            RefreshList(tmp);
        }
        private void PreviousPage(int obj)
        {
            var nrToSkip = PageSize * --CurrentPage;
            var tmp = _repository.Get(nrToSkip, PageSize);
            if (CurrentPage >= 0)
            {
                RefreshList(tmp);
            }
        }

        private void NextPage(int obj)
        {
            var nrToSkip = PageSize * ++CurrentPage;
            var tmp = _repository.Get(nrToSkip, PageSize);
            _canPageUp = tmp.Count == PageSize;
            if (tmp.Count > 0)
            {
                RefreshList(tmp);
            }
        }
        private void RefreshList(List<Person> people)
        {
            People.Clear();
            people.ForEach(p => People.Add(PersonViewModel.Create(p)));
        }
    }
}
