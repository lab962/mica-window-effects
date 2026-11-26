namespace mica-window-effects.CoreUI;

public interface IThemingService
{
    bool IsDarkMode();

    event EventHandler? ThemeChanged;
}