using LDR_MauiLearning.Models;
using LDR_MauiLearning.PageModels;

namespace LDR_MauiLearning.Pages
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