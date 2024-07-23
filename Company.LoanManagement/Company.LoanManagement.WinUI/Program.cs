using Company.LoanManagement.Business.Interfaces;
using Company.LoanManagement.Business.Services;
using Company.LoanManagement.Data.Repositories;
using Company.LoanManagement.Domain.Interfaces;
using Company.LoanManagement.WinUI.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Company.LoanManagement.WinUI
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Configure services
            var serviceCollection = new ServiceCollection();
            ConfigureService(serviceCollection);

            //  Build the service provider
            ServiceProvider = serviceCollection.BuildServiceProvider();

            var customerForm = ServiceProvider.GetRequiredService<CustomerForm>();
            Application.Run(customerForm);
        }

        private static void ConfigureService(IServiceCollection services)
        {
            // Register application services
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();

            // Register the main form
            services.AddTransient<CustomerForm>();
        }
    }
}