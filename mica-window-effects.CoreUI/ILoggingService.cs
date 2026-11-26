namespace mica-window-effects.CoreUI;

public interface ILoggingService
{
    void LogException(Exception exception);

    Task FlushAsync();
}