using Frontend.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace Frontend
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider provider = services.BuildServiceProvider();

            Application.Run(provider.GetRequiredService<MainForm>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {

            services.AddHttpClient<ApiService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7265");
            }).AddHttpMessageHandler<AuthenticationDelegatingHandler>();

            services.AddTransient<MainForm>();
            services.AddTransient<LoginRegisterForm>();
            services.AddTransient<EditForm>();
            services.AddTransient<ShareTaskForm>();
            services.AddTransient<ChooseManagerForm>();
            services.AddSingleton<AuthenticationDelegatingHandler>();
        }


    }
}