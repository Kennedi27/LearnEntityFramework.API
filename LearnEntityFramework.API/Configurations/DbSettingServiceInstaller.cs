using LearnEntityFramework.EFLibrary.Data;
using Microsoft.EntityFrameworkCore;

namespace LearnEntityFramework.API.Configurations
{
    public class DbSettingServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EFDataContext>(option =>
            {
                var defaultConnection = configuration.GetConnectionString("DefaultConnection");
                option.UseSqlServer(defaultConnection,
                    opts => opts.MigrationsAssembly("LearnEntityFramework.EFLibrary"));
            });

        }
    }
}
