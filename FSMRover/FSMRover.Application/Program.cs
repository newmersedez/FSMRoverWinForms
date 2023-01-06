using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models.Fsm;
using WindowsFormsApp1.Models.Rover;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            Application.Run(new MainWindow(new Rover(new Fsm())));
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IFsm, Fsm>();
            services.AddScoped<IRover, Rover>();

            services.BuildServiceProvider();
        }
    }
}