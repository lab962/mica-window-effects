using mica-window-effects.CoreUI;
using Windows.ApplicationModel;

namespace mica-window-effects.App.Services;

public sealed class PackagedVersionInfoService : IVersionInfoService
{
    public string GetVersion()
    {
        var version = Package.Current.Id.Version;
        return $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
    }
}
