using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppXFimdb.ViewModel
{
    class FilmViewModel
    {
        private string url;
        private string title;

        public string Cover_url
        {
            get => url;
            set
            {
                if(url != value)
                {
                    url = value;
                }
            }
        }

        public string Title
        {
            get => title;
            set
            {
                if (title != value)
                {
                    title = value;
                }
            }
        }
    }
}
