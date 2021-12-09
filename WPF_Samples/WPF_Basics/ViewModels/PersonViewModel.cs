using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WPF_Basics.Models;

namespace WPF_Basics.ViewModels
{
    public class PersonViewModel : BaseViewModel
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _favoriteColor;

        public Brush BackColor
        {
            get
            {
                try
                {
                    var col = (Color)ColorConverter.ConvertFromString(_favoriteColor);
                    return new SolidColorBrush(col) { Opacity = 0.4 };
                }
                catch
                {
                    return Brushes.White;
                }
            }
        }
        public string FavoriteColor
        {
            get { return _favoriteColor; }
            set { _favoriteColor = value; NotifyPropertyChanged(); }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; NotifyPropertyChanged(); }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; NotifyPropertyChanged(); }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; NotifyPropertyChanged(); }
        }
        public int Id { get; set; }
       
        public static PersonViewModel Create(Person p)
        {
            return new PersonViewModel
            {
                Age = p.Age,
                FavoriteColor = p.FavoriteColor,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Id = p.Id
            };
        }
    }
}
