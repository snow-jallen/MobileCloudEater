using Mobile.ViewModels;
using Xamarin.Forms;

namespace Mobile.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel();
        }
    }
}