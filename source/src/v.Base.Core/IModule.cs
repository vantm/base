using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace v.Base.Core;

public interface IModule
{
    IConfiguration Configuration { get; }
    IHostEnvironment Environment { get; }
    void ConfigureServices(IServiceCollection services);
    Task InitAsync(IServiceProvider services, CancellationToken cancellationToken = default);
}
