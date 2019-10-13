using apiLeviathansChilds.domain.interfaces.repositories;
using apiLeviathansChilds.domain.interfaces.services;
using apiLeviathansChilds.domain.services;
using apiLeviathansChilds.infra.persistence.repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authentication;
// using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace apiLeviathansChilds.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IServiceUser, ServiceUser>();
            services.AddTransient<IServiceCharacter, ServiceCharacter>();
            services.AddTransient<IServiceAmulet, ServiceAmulet>();
            services.AddTransient<IServiceElement, ServiceElement>();
            services.AddTransient<IServiceJob, ServiceJob>();
            services.AddTransient<IRepositoryUser>(s => new RepositoryUser(Configuration.GetConnectionString("LocalDBConnection")));
            services.AddTransient<IRepositoryCharacter>(s => new RepositoryCharacter(Configuration.GetConnectionString("LocalDBConnection")));
            services.AddTransient<IRepositoryAmulet>(s => new RepositoryAmulet(Configuration.GetConnectionString("LocalDBConnection")));
            services.AddTransient<IRepositoryElement>(s => new RepositoryElement(Configuration.GetConnectionString("LocalDBConnection")));
            services.AddTransient<IRepositoryJob>(s => new RepositoryJob(Configuration.GetConnectionString("LocalDBConnection")));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
