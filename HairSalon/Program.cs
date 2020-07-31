using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace HairSalon
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseKestrel()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}