using TEK_MauiLearning.Models;
using TEK_MauiLearning.PageModels;

namespace TEK_MauiLearning.Pages
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