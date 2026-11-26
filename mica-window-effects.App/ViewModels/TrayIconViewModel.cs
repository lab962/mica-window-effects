using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using mica-window-effects.App.Services;

namespace mica-window-effects.App.ViewModels;

public sealed partial class TrayIconViewModel : ObservableObject
{
    private readonly MainAppService _mainAppService;

    public TrayIconViewModel(MainAppService mainAppService)
    {
        _mainAppService = mainAppService;
    }

    [RelayCommand]
    private void Exit()
        => _mainAppService.Shutdown();

    [RelayCommand]
    private void Settings()
        => _mainAppService.ActivateSettings();
}
