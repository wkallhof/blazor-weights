using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Weights.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services){ }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<Index>("app");
        }
    }
}