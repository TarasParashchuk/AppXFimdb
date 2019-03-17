using AppXFimdb.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppXFimdb
{
    class GetDataFilms
    {
        public static IEnumerable<DataFilm> GetListFilms()
        {
            var webClient = new WebClient();

            try
            {
                var json = webClient.DownloadString("http://gist.githubusercontent.com/yannski/3019778/raw/dfb34d018165f47b61b3bf089358a3d5ca199d96/movies.json");
                return JsonConvert.DeserializeObject<IEnumerable<DataFilm>>(json);
            }
            catch
            {
                return null;
            }
        }
    }
}
