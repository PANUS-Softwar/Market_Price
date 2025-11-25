using BCN_MauiLearning.Models;

namespace BCN_MauiLearning.Pages
{
    public partial class ProjectDetailPage : ContentPage
    {
        public ProjectDetailPage(ProjectDetailPageModel model)
        {
            InitializeComponent();

            BindingContext = model;
        }
    }
}
