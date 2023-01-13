using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace LearnEntityFramework.API.Options
{
    public class DatabaseOptionSetup : IConfigureOptions<DatabaseOptions>
    {
        private const string ConfigurationSectionName = "DatabaseOptions";
        private readonly IConfiguration _configuration;

        public DatabaseOptionSetup(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public void Configure(DatabaseOptions options)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");

            options.ConnectionString = connectionString;

            _configuration.GetSection(ConfigurationSectionName).Bind(options);


        }
    }
}
