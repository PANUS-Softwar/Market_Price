using CNT_MauiLearning.Models;
using CNT_MauiLearning.PageModels;

namespace CNT_MauiLearning.Pages
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