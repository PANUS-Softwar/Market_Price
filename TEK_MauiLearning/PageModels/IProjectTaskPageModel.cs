using CommunityToolkit.Mvvm.Input;
using TEK_MauiLearning.Models;

namespace TEK_MauiLearning.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}