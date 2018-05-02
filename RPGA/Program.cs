using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using RPGA.Data;

namespace RPGA
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			//BuildWebHost(args).Run();

			var host = BuildWebHost(args);

			using (var scope = host.Services.CreateScope())
			{
				var services = scope.ServiceProvider;
				try
				{
					var context = services.GetRequiredService<RPGAContext>();
					DbInitializer.Initialize(context);
				}
				catch
				{
					throw;
					//var logger = services.GetRequiredService<ILogger<Program>>();
					//logger.LogError(ex, "An error occurred while seeding the database.");
				}
			}

			host.Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			 WebHost.CreateDefaultBuilder(args)
				  .UseStartup<Startup>()
				  .Build();
	}
}
