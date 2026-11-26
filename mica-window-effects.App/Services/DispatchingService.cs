using mica-window-effects.App.Dispatching;
using mica-window-effects.CoreUI;
using Microsoft.UI.Dispatching;
using System.Threading.Tasks;

namespace mica-window-effects.App.Services;

public sealed class DispatchingService : IDispatchingService
{
    private DispatcherQueueValueTaskSource _dispatcherQueueValueTaskSource;

    public DispatchingService(DispatcherQueue dispatcherQueue)
    {
        _dispatcherQueueValueTaskSource = new(dispatcherQueue);
    }

    public ValueTask YieldAsync()
        => new ValueTask(_dispatcherQueueValueTaskSource, 0);
}
