using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using mica-window-effects.CoreUI;
using mica-window-effects.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mica-window-effects.App.ViewModels;

public partial class AddClassRuleContentDialogViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsAddButtonEnabled))]
    public partial string ClassName { get; set; }

    [ObservableProperty]
    public partial IEnumerable<string>? Recommendations { get; set; }

    public bool IsAddButtonEnabled => !string.IsNullOrWhiteSpace(ClassName);

    private readonly ISettingsService _settingsService;

    public AddClassRuleContentDialogViewModel(ISettingsService settingsService)
    {
        _settingsService = settingsService;
        ClassName = string.Empty;
    }

    [RelayCommand]
    private async Task AddRuleAsync()
    {
        _settingsService.Settings!.Rules.Insert(1, new ClassRule() { ClassName = ClassName });
        await _settingsService.SaveAsync();
    }
}
