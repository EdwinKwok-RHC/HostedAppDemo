public class HostAppConsole : IHostedService
{
    private Timer _timer;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(PerformScheduledCleanup, null, TimeSpan.Zero, TimeSpan.FromSeconds(2)); // Cleanup every minute
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }

    private void PerformScheduledCleanup(object state)
    {
        Console.WriteLine("Performing scheduled cleanup");
    }
}
