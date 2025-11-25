using BCN_MauiLearning.Models;
using BCN_MauiLearning.PageModels;

namespace BCN_MauiLearning.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}