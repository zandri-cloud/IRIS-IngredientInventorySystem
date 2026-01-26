using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IRIS.Infrastructure.Data;

namespace IRIS.Presentation
{
    internal static class Program
    {
        public static ServiceProvider? Services;

        [STAThread]
        static void Main()
        {
            // Setup DI
            var services = new ServiceCollection();
            services.AddDbContext<IrisDbContext>(options =>
                options.UseSqlServer(
                    System.Configuration.ConfigurationManager
                        .ConnectionStrings["IrisConnection"].ConnectionString));

            Services = services.BuildServiceProvider();

            // Seed database
            using (var scope = Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<IrisDbContext>();
                SeedData.Initialize(context);
            }

            // Initialize WinForms
            ApplicationConfiguration.Initialize();

            // Pass DbContext to LoginForm via constructor
            using (var scope = Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<IrisDbContext>();
                System.Windows.Forms.Application.Run(new LoginForm());
            }
        }
    }
}
