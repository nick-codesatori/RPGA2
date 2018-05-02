using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RPGA.Data;
using RPGA.Logic.Implementations;
using RPGA.Logic.Interfaces;
using RPGA.Relationships;
using System.Reflection;

namespace RPGA
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<RPGAContext>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
				.EnableSensitiveDataLogging(true)
				);
			services.AddMvc();
			services.AddTransient<ICharacterService, CharacterService>();
			services.AddTransient<IRaceService, RaceService>();
			services.AddTransient<IBackgroundService, BackgroundService>();
			services.AddTransient<IClassService, ClassService>();
			services.AddTransient<IFlatteningService, FlatteningService>();
			services.AddAutoMapper(Assembly.GetAssembly(typeof(MappingProfile)));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseBrowserLink();
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					 name: "default",
					 template: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
