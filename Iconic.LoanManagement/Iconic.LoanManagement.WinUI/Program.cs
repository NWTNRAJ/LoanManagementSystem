using Iconic.LoanManagement.Business.Interfaces;
using Iconic.LoanManagement.Business.Services;
using Iconic.LoanManagement.Data.Repositories;
using Iconic.LoanManagement.Domain.Interfaces;
using Iconic.LoanManagement.WinUI.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace Iconic.LoanManagement.WinUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureService(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<UserForm>());
        }

        private static void ConfigureService(IServiceCollection services)
        {
            // Register services and repositories
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            // Register forms
            services.AddTransient<UserForm>();
        }
    }
}
