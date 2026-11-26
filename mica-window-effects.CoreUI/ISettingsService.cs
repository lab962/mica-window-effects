using mica-window-effects.Models;
using System.ComponentModel;

namespace mica-window-effects.CoreUI;

public interface ISettingsService : INotifyPropertyChanged, IDisposable
{
    SettingsFileModel? Settings { get; set; }

    Task InitializeAsync();

    Task SaveAsync();

    Task OpenConfigurationFileAsync();
}
