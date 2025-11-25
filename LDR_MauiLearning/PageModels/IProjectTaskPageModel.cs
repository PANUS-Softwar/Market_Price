using CommunityToolkit.Mvvm.Input;
using LDR_MauiLearning.Models;

namespace LDR_MauiLearning.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}