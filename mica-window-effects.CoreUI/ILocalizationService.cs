using mica-window-effects.Models;

namespace mica-window-effects.CoreUI;

public interface ILocalizationService
{
    string GetLocalizedString(string key);

    string GetLocalizedTitleBarColor(TitleBarColorMode titleBarColorMode);

    string GetLocalizedBackdropType(BackdropType backdropType);

    string GetLocalizedCornerPreference(CornerPreference cornerPreference);

    string GetRuleName(Rule rule);
}