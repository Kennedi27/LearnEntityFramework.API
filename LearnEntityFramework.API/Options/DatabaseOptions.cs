namespace LearnEntityFramework.API.Options
{
    public class DatabaseOptions
    {
        public string ConnectionString { get; set; } = string.Empty;
        public int MaxEntryCount { get; set; }
        public int CommandTimeout { get; set; }
        public bool EnableDetailErrors { get; set; }
        public bool EnableSensitiveDatalogging { get; set; }
    }
}
