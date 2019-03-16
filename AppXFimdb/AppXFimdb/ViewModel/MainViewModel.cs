using AppXFimdb.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AppXFimdb.ViewModel
{
    class MainViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<FilmViewModel> ListFilms { get; set; }

        public MainViewModel()
        {
            ListFilms = GetDataFilms.GetDataFilmAsync().Result.Select(u => new FilmViewModel { Cover_url = u.cover_url, Title = u.title }) as ObservableCollection<FilmViewModel>;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
