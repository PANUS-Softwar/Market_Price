using BCN_MauiLearning.Models;
using CommunityToolkit.Mvvm.Input;

namespace BCN_MauiLearning.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}