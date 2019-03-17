using AppXFimdb.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXFimdb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            this.BindingContext = new MainViewModel() { Navigation = this.Navigation };
        }
    }
}
