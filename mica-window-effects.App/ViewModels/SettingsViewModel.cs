using CommunityToolkit.Mvvm.ComponentModel;
using mica-window-effects.CoreUI;

namespace mica-window-effects.App.ViewModels;

public sealed partial class SettingsViewModel : ObservableObject
{
    public ISettingsService SettingsService { get; }

    public SettingsViewModel(ISettingsService settingsService)
    {
        SettingsService = settingsService;
    }
}