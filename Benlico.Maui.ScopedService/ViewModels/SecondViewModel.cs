using Benlico.Maui.ScopedService.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Benlico.Maui.ScopedService.ViewModels;
public partial class SecondViewModel : ObservableObject
{
    private readonly SharedService _sharedService;

    [ObservableProperty]
    public string data;

    public SecondViewModel(ServiceScopeManager scopeManager)
    {
        _sharedService = scopeManager.GetScopedService<SharedService>();
        Data = _sharedService.SharedData;
    }

    [RelayCommand]
    public void UpdateSharedData()
    {
        _sharedService.SharedData = "Updated from SecondViewModel";
        Data = _sharedService.SharedData;
    }
}