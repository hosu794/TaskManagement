namespace Data.Models
{
    public class AppSettings
    {
        public LoggingSettings Logging { get; set; }
        public string AllowedHosts { get; set; }
        public DatabaseSettings DatabaseSettings { get; set; }
        public JwtSettings JwtSettings { get; set; }
    }

    public class LoggingSettings
    {
        public LogLevelSettings LogLevel { get; set; }
    }

    public class LogLevelSettings
    {
        public string Default { get; set; }
        public string MicrosoftAspNetCore { get; set; }
    }

    public class DatabaseSettings
    {
        public string ConnectionString { get; set; }
    }

    public class JwtSettings
    {
        public string SecretKey { get; set; }
    }
}
