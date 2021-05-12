using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaBox.Storing;
using Microsoft.EntityFrameworkCore;
//using NPG 

namespace PizzaBox.Client
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
      services.AddControllersWithViews();
      services.AddScoped<UnitOfWork>(); //scoped, transient, singleton
      services.AddDbContext<PizzaBoxContext>(options =>
      {
        if (!string.IsNullOrWhiteSpace(Configuration.GetConnectionString("mssql")))
        {
          options.UseSqlServer(Configuration.GetConnectionString("mssql"), opts =>
          {
            opts.EnableRetryOnFailure(3);
          });
        }
        /*         else
                {
                  options.UseNpgsql(Configuration.GetConnectionString("pgsql"), opts =>
                  {
                    opts.EnableRetryOnFailure(3);
                  });
                } */
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, PizzaBoxContext context)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }
      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllerRoute(
          name: "default",
          pattern: "{controller=Home}/{action=Index}/{id?}"
          );
        endpoints.MapControllerRoute(
          name: "order",
          pattern: "{controller=Order}/{action=order}/{id?}"
          );
      });
    }
  }
}
