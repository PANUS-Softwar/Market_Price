using TTEK_MAUI.ViewModels;

namespace TTEK_MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();
        }

    }
}
