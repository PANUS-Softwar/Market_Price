using CNT_MauiLearning.Models;
using CommunityToolkit.Mvvm.Input;

namespace CNT_MauiLearning.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}