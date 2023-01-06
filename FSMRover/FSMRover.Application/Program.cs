using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSMRover.Models.Fsm;
using FSMRover.Models.Rover;

namespace FSMRover
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            System.Windows.Forms.Application.Run(new MainWindow(new Rover(new Fsm())));
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IFsm, Fsm>();
            services.AddScoped<IRover, Rover>();

            services.BuildServiceProvider();
        }
    }
}