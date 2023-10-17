using Microsoft.Extensions.DependencyInjection;

namespace DiscordBot
{
    public interface IBot
    {
        Task StartAsync(ServiceProvider services);

        Task StopAsync();
    }
}