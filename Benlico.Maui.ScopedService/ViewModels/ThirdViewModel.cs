using Benlico.Maui.ScopedService.Services;
using CommunityToolkit.Mvvm.ComponentModel;


namespace Benlico.Maui.ScopedService.ViewModels;
public partial class ThirdViewModel : ObservableObject
{
    public string Data => "End of Scope";

    public ThirdViewModel(ServiceScopeManager scopeManager)
    {
        scopeManager.DisposeScope();
    }
}