using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestaurantFood.Models;

namespace RestaurantFood
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<RestaurantDbContext>();
            services.AddEntityFramework().AddSqlServer().AddDbContext<RestaurantDbContext>(option => option.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]));
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();
            app.UseFileServer();
            app.UseMvcWithDefaultRoute();
            app.UseDeveloperExceptionPage();
        }

        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
