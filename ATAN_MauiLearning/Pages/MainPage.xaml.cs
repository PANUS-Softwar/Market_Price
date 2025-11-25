using ATAN_MauiLearning.Models;
using ATAN_MauiLearning.PageModels;

namespace ATAN_MauiLearning.Pages
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