using AppXFimdb.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace AppXFimdb.ViewModel
{
    class FilmViewModel : INotifyPropertyChanged
    {
        private Film Item;
        public event PropertyChangedEventHandler PropertyChanged;

        public FilmViewModel(ImageSource _url, string _title)
        {
            Item = new Film();
            Item.Cover_url = _url;
            Item.Title = _title;
        }

        public ImageSource Cover_url
        {
            get => Item.Cover_url;
            set
            {
                if(Item.Cover_url != value)
                {
                    Item.Cover_url = value;
                    OnPropertyChanged("Cover_url");
                }
            }
        }

        public string Title
        {
            get => Item.Title;
            set
            {
                if (Item.Title != value)
                {
                    Item.Title = value;
                    OnPropertyChanged("Title");
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
