using AppXFimdb.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppXFimdb.ViewModel
{
    class MainViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<FilmViewModel> ListFilms { get; set; }
        public INavigation Navigation { get; set; }
        //public ICommand SelectItemFilm { protected set; get; }
        FilmViewModel select_item;

        public MainViewModel()
        {
            var t = GetDataFilms.GetListFilms();
            var y = t.Select(u => new FilmViewModel (ImageSource.FromUri(new Uri(u.cover_url != null ? u.cover_url : "http://ia.media-imdb.com/images/M/MV5BMTMwNTEyMTE1NV5BMl5BanBnXkFtZTcwNjI1NDA3NA@@.V1.SX94_SY140.jpg")), u.title ));
            ListFilms = new ObservableCollection<FilmViewModel>(y);
            //SelectItemFilm = new Command(SelectFilm);
        }

        public FilmViewModel SelectItemFilm
        {
            get { return select_item; }
            set
            {
                if (select_item != value)
                {
                    select_item = value;
                    OnPropertyChanged("SelectItemFilm");
                    Navigation.PushAsync(new DetailPage());
                }
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
