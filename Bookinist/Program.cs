using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookinist
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }

        // если этого не сделать придется создавать отдельный класс
        // чтобы формировать контекст базы данных
        public static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(App.ConfigureServices);
    }
}
