using mica-window-effects.Models;

namespace mica-window-effects.CoreUI;

public interface IRuleService
{
    void Initialize();

    Task ApplyRulesToAllWindowsAsync();

    Task ApplyRuleToWindowAsync(TerraFX.Interop.Windows.HWND hwnd);

    bool AreMaterialsSupported { get; }

    bool AreAdditionalMaterialsSupported { get; }

    bool AreCornerPreferencesSupported { get; }

    BackdropType[] SupportedBackdropTypes { get; }
}
