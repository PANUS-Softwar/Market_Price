using ATAN_MauiLearning.Models;
using CommunityToolkit.Mvvm.Input;

namespace ATAN_MauiLearning.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}