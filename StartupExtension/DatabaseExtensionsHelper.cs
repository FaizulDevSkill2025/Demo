using Demo.Data;
using Microsoft.EntityFrameworkCore;

namespace Demo.StartupExtension
{
    public static class DatabaseExtensionsHelper
    {

        public static IServiceCollection AddDatabaseExtensionHelper(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), sqlServerOptionsAction => sqlServerOptionsAction.EnableRetryOnFailure());

            });

            return services;
        }

        public static IApplicationBuilder RunMigration(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {

                var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                db.Database.Migrate();

            }

            return app;

        }
    }
}
