using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CRUDelicious
{
    public class Startup
    {
        // public Startup(IWebHostEnvironment env) {            
        // // run this in the debugger, and inspect the "env" object! You can use this object to tell you 
        // // the root path of your application, for the purposes of reading from local files, and for            
        // // checking environment variables - such as if you are running in Development or Production 
        // Console.WriteLine(env.ContentRootPath);            
        // Console.WriteLine(env.IsDevelopment());
        // }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<MyContext>(options => options.UseMySql (Configuration["DBInfo:ConnectionString"]));
            services.AddMvc(options => options.EnableEndpointRouting = false); 
            services.AddSession();

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthorization();
            app.UseMvc();
            
            
        }
    }
}
