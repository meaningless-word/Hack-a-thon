using FluentValidation.AspNetCore;
using Mappers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Repositories;
using Repositories.Abstract;
using Services;
using Services.Abstract;
using System.Reflection;
using Validators;

namespace Hack_a_thon
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
			services.AddAutoMapper(Assembly.GetAssembly(typeof(PerevalMapper))
				, Assembly.GetAssembly(typeof(UserMapper))
				, Assembly.GetAssembly(typeof(CoordsMapper))
				, Assembly.GetAssembly(typeof(LevelMapper))
				, Assembly.GetAssembly(typeof(ImageMapper))
			);

			services.AddDbContext<AppDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
			services.AddScoped<IUnitOfWork, UnitOfWork>();

			services.AddScoped<IPerevalService, PerevalSerice>();

			services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AddPerevalRequestValidator>());

			services.AddControllers();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "Hack_a_thon", Version = "v1" });
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseSwagger();
			app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hack_a_thon v1"));

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
