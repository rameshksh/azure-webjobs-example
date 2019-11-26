using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace WebJobSdk
{
    class Program
    {
        public static void Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
            });
            var host = builder.Build();
            using (host)
            {
                host.Run();
            }
        }
    }
}
