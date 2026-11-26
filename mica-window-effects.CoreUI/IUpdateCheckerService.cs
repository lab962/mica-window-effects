namespace mica-window-effects.CoreUI;

public interface IUpdateCheckerService
{
    Task<UpdateAvailability> CheckForUpdateAsync();
}

public enum UpdateAvailability
{
    NoUpdate,
    UpdateAvailable,
    Error
}